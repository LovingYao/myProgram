using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

namespace SocketClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TextBox.CheckForIllegalCrossThreadCalls = false;
        }

        #region[成员函数]

        private delegate void CallBackDelegate(string message);

        ///<summary>
        ///图像函数
        ///</summary>
        private Image _img;
        #endregion

        [StructLayout(LayoutKind.Sequential, Pack = 1)]

        internal struct TokPriv1Luid
        {

            public int Count;

            public long Luid;

            public int Attr;

        }

        [DllImport("kernel32.dll", ExactSpelling = true)]

        internal static extern IntPtr GetCurrentProcess();

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]

        internal static extern bool OpenProcessToken(IntPtr h, int acc, ref IntPtr phtok);

        [DllImport("advapi32.dll", SetLastError = true)]

        internal static extern bool LookupPrivilegeValue(string host, string name, ref long pluid);

        [DllImport("advapi32.dll", ExactSpelling = true, SetLastError = true)]

        internal static extern bool AdjustTokenPrivileges(IntPtr htok, bool disall,

        ref TokPriv1Luid newst, int len, IntPtr prev, IntPtr relen);

        [DllImport("user32.dll", ExactSpelling = true, SetLastError = true)]

        internal static extern bool ExitWindowsEx(int flg, int rea);

        internal const int SE_PRIVILEGE_ENABLED = 0x00000002;

        internal const int TOKEN_QUERY = 0x00000008;

        internal const int TOKEN_ADJUST_PRIVILEGES = 0x00000020;

        internal const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

        internal const int EWX_LOGOFF = 0x00000000;  //注销

        internal const int EWX_SHUTDOWN = 0x00000001;   //关机

        internal const int EWX_REBOOT = 0x00000002;     //重启

        internal const int EWX_FORCE = 0x00000004;

        internal const int EWX_POWEROFF = 0x00000008;    //断开电源

        internal const int EWX_FORCEIFHUNG = 0x00000010;  //强制终止未响应的程序

       // internal const int WM_POWERBROADCAST

        private static void DoExitWin(int flg)
        {

            bool ok;

            TokPriv1Luid tp;

            IntPtr hproc = GetCurrentProcess();

            IntPtr htok = IntPtr.Zero;

            ok = OpenProcessToken(hproc, TOKEN_ADJUST_PRIVILEGES | TOKEN_QUERY, ref htok);

            tp.Count = 1;

            tp.Luid = 0;

            tp.Attr = SE_PRIVILEGE_ENABLED;

            ok = LookupPrivilegeValue(null, SE_SHUTDOWN_NAME, ref tp.Luid);

            ok = AdjustTokenPrivileges(htok, false, ref tp, 0, IntPtr.Zero, IntPtr.Zero);

            ok = ExitWindowsEx(flg, 0);

        }

        Socket sokClient = null;//负责与服务端通信的套接字
        Thread threadClient = null;//负责 监听 服务端发送来的消息的线程
        bool isRec = true; //是否循环接收服务端数据
       // Dictionary<string, ConnectionClient> dictConn = new Dictionary<string, ConnectionClient>();
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //实例化 套接字
            sokClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //创建 ip对象
            IPAddress address = IPAddress.Parse(txtIP.Text.Trim());
            //MessageBox.Show("address");
            //创建网络节点对象 包含 ip和port
            IPEndPoint endpoint = new IPEndPoint(address, int.Parse(txtPort.Text.Trim()));
            //连接 服务端监听套接字
            sokClient.Connect(endpoint);

            //创建负责接收 服务端发送来数据的 线程

            CallBackDelegate cbd = new CallBackDelegate(this.CallBack);
            new Thread(new ParameterizedThreadStart(this.ReceiveMsg)).Start(cbd);

            //threadClient = new Thread(ReceiveMsg);
            //threadClient.IsBackground = true;
            ////如果在win7下要通过 某个线程 来调用 文件选择框的代码，就需要设置如下
            //threadClient.SetApartmentState(ApartmentState.STA);
            //threadClient.Start();
        }

        private void CallBack(string message)
        {


            this.Invoke(
                            (EventHandler)
                            (delegate
                            {
                                AlertWindows asd = new AlertWindows();
                                asd.Show(message);

                            }));

        }

        /// <summary>
        /// 接收服务端发送来的消息数据
        /// </summary>
        void ReceiveMsg(object o)
        {

            CallBackDelegate cbd = o as CallBackDelegate;

            while (isRec)
            {
             
                byte[] msgArr = new byte[1024 * 1024 * 1];//接收到的消息的缓冲区
                int length = 0;
                //接收服务端发送来的消息数据
                length = sokClient.Receive(msgArr);//Receive会阻断线程
                if (msgArr[0] == 0)//发送来的是文字
                {
                    string strMsg = System.Text.Encoding.UTF8.GetString(msgArr, 1, length - 1);
                    txtShow.AppendText(strMsg + "rn");

                    cbd(strMsg);

                }
                else if (msgArr[0] == 1)
                {
                    //发送来的是文件
                    //string abc = Encoding.Default.GetString(msgArr);
                    //MessageBox.Show(abc);
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "文本文件(.txt)|*.txt|所有文件(*.*)|*.*";
                    //弹出文件保存选择框
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        //创建文件流
                        using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                        {
                            fs.Write(msgArr, 1, length - 1);
                            MessageBox.Show("文件保存成功！");
                        }
                    }
                }
                else if (msgArr[0] == 2)
                {
                    //ShakeWindow();
                }
                else if (msgArr[0] == 3)
                {
                    MessageBox.Show("连接成功");
                }
                else if (msgArr[0] == 4)
                {
                    DoExitWin(EWX_SHUTDOWN);
                }
                else if (msgArr[0] == 5)
                {
                    DoExitWin(EWX_REBOOT);
                }
                else if (msgArr[0] == 6)
                {
                    DoExitWin(EWX_LOGOFF);
                }
                else if (msgArr[0] == 7)
                {

                    PrintScreen();
                }

            }
        }

        #region[方法]
        ///<summary>
        ///截屏
        ///</summary>
        private void PrintScreen()
        {

            string Opath = @"C:/Picture";
            if (Opath.Substring(Opath.Length - 1, 1) != @"/")
               Opath = Opath + @"/";
            string photoname = DateTime.Now.Ticks.ToString();
            string path1 = Opath + DateTime.Now.ToShortDateString();
            if (!Directory.Exists(path1))
                Directory.CreateDirectory(path1);
            try
            {

                Screen scr = Screen.PrimaryScreen;
                Rectangle rc = scr.Bounds;
                int iWidth = rc.Width;
                int iHeight = rc.Height;
                Bitmap myImage = new Bitmap(iWidth, iHeight);
                Graphics gl = Graphics.FromImage(myImage);
                gl.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
                _img = myImage;
                //pictureBox1.Image = _img;
                // IntPtr dc1 = gl.GetHdc();
                //gl.ReleaseHdc(dc1);
                MessageBox.Show(path1);
                MessageBox.Show(photoname);
                _img.Save(path1 + "//" + photoname + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);  
               // _img.Save("D:\1.jpeg");
              //  SendFile(path1+"//"+photoname+".jpg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("截屏失败！n" + ex.Message.ToString() + "n" + ex.StackTrace.ToString());
            }

           // MessageBox.Show("12322222");
            /////////////////////////////////////////////////////////
            ///////////////////发送图片流///////////////////////////
           /*
            MemoryStream ms = new MemoryStream();
            byte[] imagedata = null;
            _img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            imagedata = ms.GetBuffer();

            byte[] arrFile = new byte[1024 * 1024 * 2];
            //读取文件内容到字节数组，并 获得 实际文件大小
            int length = ms.Read(arrFile, 0, arrFile.Length);
            // int length = ms.Read(arrFile, 0, arrFile.Length);
            //定义一个 新数组，长度为文件实际长度 +1
            byte[] arrFileFina = new byte[length + 1];
            arrFileFina[0] = 2;//设置 数据标识位等于1，代表 发送的是文件
            //将 图片流数据数组 复制到 新数组中，下标从1开始
            //arrFile.CopyTo(arrFileFina, 1);
            Buffer.BlockCopy(arrFile, 0, arrFileFina, 1, length);
            //发送文件数据  
            sokClient.Send(arrFileFina);//, 0, length + 1, SocketFlags.None);
            //MessageBox.Show("我在这里！！！");
            // byte[] arrMsg = System.Text.Encoding.UTF8.GetBytes(_img);
            MessageBox.Show("2222");
            */
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            AlertWindows asd = new AlertWindows();
            asd.Show("test");
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            // this.WindowState = FormWindowState.Minimized;
            PrintScreen();
            if (_img != null)
            {
                this.pictureBox1.Image = _img;
            }
            this.WindowState = FormWindowState.Normal;
        }
*/
        ///// <summary>
        ///// 闪屏
        ///// </summary>
        //private void ShakeWindow()
        //{
        //    Random ran = new Random();
        //    //保存 窗体原坐标
        //    System.Drawing.Point point = this.Location;
        //    for (int i = 0; i < 30; i++)
        //    {
        //        //随机 坐标
        //        this.Location = new System.Drawing.Point(point.X + ran.Next(8), point.Y + ran.Next(8));
        //        System.Threading.Thread.Sleep(15);//休息15毫秒
        //        this.Location = point;//还原 原坐标(窗体回到原坐标)
        //        System.Threading.Thread.Sleep(15);//休息15毫秒
        //    }
        //}
        ////发送消息
        //private void btnSend_Click(object sender, EventArgs e)
        //{
        //    byte[] arrMsg = System.Text.Encoding.UTF8.GetBytes(txtInput.Text.Trim());
        //    sokClient.Send(arrMsg);
        //    richTextBox1.AppendText(txtInput.Text.Trim()+"rn");
        //    txtInput.Text = "";
        //}

        //private void btnChooseFile_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog ofd = new OpenFileDialog();
        //    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        txtFilePath.Text = ofd.FileName;
        //    }
        //}
        ////发送文件
        //private void btnSendFile_Click(object sender, EventArgs e)
        //{
        //    string key = txtIP.Text + ":" + comboBox1.Text.Trim();
        //    //MessageBox.Show(key);
        //    if (!string.IsNullOrEmpty(key))
        //    {
        //        SendFile(txtFilePath.Text.Trim());
        //       // MessageBox.Show("1230");
        //        // txtFilePath.Text = "";
        //    }
        //}
        //private void SendFile(string strPath)
        //{
        //    //通过文件流 读取文件内容

        //    using (FileStream fs = new FileStream(strPath, FileMode.OpenOrCreate))
        //    {
        //        byte[] arrFile = new byte[1024 * 1024 * 2];
        //        //读取文件内容到字节数组，并 获得 实际文件大小
        //        int length = fs.Read(arrFile, 0, arrFile.Length);
        //        //定义一个 新数组，长度为文件实际长度 +1
        //        byte[] arrFileFina = new byte[length + 1];
        //        arrFileFina[0] = 1;//设置 数据标识位等于1，代表 发送的是文件
        //        //将 文件数据数组 复制到 新数组中，下标从1开始
        //        //arrFile.CopyTo(arrFileFina, 1);
        //        Buffer.BlockCopy(arrFile, 0, arrFileFina, 1, length);
        //        //发送文件数据  
        //        sokClient.Send(arrFileFina);//, 0, length + 1, SocketFlags.None);
        //        //MessageBox.Show("我在这里！！！");
        //    }
        //}
    }
}
