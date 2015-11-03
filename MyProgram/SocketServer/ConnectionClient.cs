using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketServer
{
    public delegate void DGShowMsg(string strMsg);

    public class ConnectionClient
    {
        Socket sokMsg;
        DGShowMsg dgShowMsg;//负责 向主窗体文本框显示消息的方法委托
        DGShowMsg dgRemoveConnection;// 负责 从主窗体 中移除 当前连接
        Thread threadMsg;

        #region 构造函数
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sokMsg">通信套接字</param>
        /// <param name="dgShowMsg">向主窗体文本框显示消息的方法委托</param>
        public ConnectionClient(Socket sokMsg, DGShowMsg dgShowMsg, DGShowMsg dgRemoveConnection)
        {
            this.sokMsg = sokMsg;
            this.dgShowMsg = dgShowMsg;
            this.dgRemoveConnection = dgRemoveConnection;

            this.threadMsg = new Thread(RecMsg);
            this.threadMsg.IsBackground = true;
            this.threadMsg.Start();
        }
        #endregion

        bool isRec = true;
        #region 02负责监听客户端发送来的消息
        void RecMsg()
        {
            while (isRec)
            {
                try
                {
                    byte[] arrMsg = new byte[1024 * 1024 * 1];
                    //接收 对应 客户端发来的消息
                    int length = sokMsg.Receive(arrMsg);
                    // string abc = Encoding.Default.GetString(arrMsg);
                    // MessageBox.Show(abc);
                    //将接收到的消息数组里真实消息转成字符串                                        
                    if (arrMsg[0] == 1)
                    {
                        //string abc = Encoding.Default.GetString(arrMsg);
                        //MessageBox.Show(abc);
                        //发送来的是文件
                        //MessageBox.Show("00000s");
                        //SaveFileDialog sfd = new SaveFileDialog();
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "文本文件(.txt)|*.txt|所有文件(*.*)|*.*";
                        // MessageBox.Show(sfd.Filter);

                        //sfd.ShowDialog(); 
                        //弹出文件保存选择框
                        if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            //MessageBox.Show("111110");
                            //创建文件流
                            using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate))
                            {
                                fs.Write(arrMsg, 1, length - 1);
                                MessageBox.Show("文件保存成功！");
                            }
                        }
                    }
                    /*else if(arrMsg[0] == 2)
                    {

                        //  MemoryStream ms = new MemoryStream(arrMsg, 0, length-1);
                        MemoryStream ms = new MemoryStream(arrMsg);
                        Image returnImage = Image.FromStream(ms);//??????????
                        PictureBox district = (PictureBox)Application.OpenForms["Form1"].Controls["pictureBox1"].Controls["pictureBox1"];
                        district.Image  =  returnImage;
                       // this.saveFileDialog1.FileName = "";//清空名称栏

                        /*  
                         SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "图像文件(.jpg)|*.jpg|所有文件(*.*)|*.*";
                        MessageBox.Show(sfd.Filter);
                        if (DialogResult.OK == sfd.ShowDialog())
                        {
                            string strFileName = sfd.FileName;
                            //Image img = (Image)this.pictureBox1.Image;
                            returnImage.Save(strFileName);
                        }

                    }*/
                    else//发送来的是消息
                    {
                        //MessageBox.Show("2222");
                        string strMsg = sokMsg.RemoteEndPoint.ToString() + "说：" + "rn" + System.Text.Encoding.UTF8.GetString(arrMsg, 0, length); //// 我在这里  Request.ServerVariables.Get("Remote_Addr").ToString()+
                        //通过委托 显示消息到 窗体的文本框
                        dgShowMsg(strMsg);
                    }

                    //MessageBox.Show("11111");
                }
                catch (Exception ex)
                {
                    isRec = false;
                    //从主窗体中 移除 下拉框中对应的客户端选择项，同时 移除 集合中对应的 ConnectionClient对象
                    dgRemoveConnection(sokMsg.RemoteEndPoint.ToString());
                }
            }
        }
        #endregion

        #region 03向客户端发送消息
        /// <summary>
        /// 向客户端发送消息
        /// </summary>
        /// <param name="strMsg"></param>
        public void Send(string strMsg)
        {
            byte[] arrMsg = System.Text.Encoding.UTF8.GetBytes(strMsg);
            byte[] arrMsgFinal = new byte[arrMsg.Length + 1];

            arrMsgFinal[0] = 0;//设置 数据标识位等于0，代表 发送的是 文字
            arrMsg.CopyTo(arrMsgFinal, 1);

            sokMsg.Send(arrMsgFinal);
        }
        #endregion

        #region 04向客户端发送文件数据 +void SendFile(string strPath)
        /// <summary>
        /// 04向客户端发送文件数据
        /// </summary>
        /// <param name="strPath">文件路径</param>
        public void SendFile(string strPath)
        {
            //通过文件流 读取文件内容
            //MessageBox.Show("12540");
            using (FileStream fs = new FileStream(strPath, FileMode.OpenOrCreate))
            {
                byte[] arrFile = new byte[1024 * 1024 * 2];
                //读取文件内容到字节数组，并 获得 实际文件大小
                int length = fs.Read(arrFile, 0, arrFile.Length);
                //定义一个 新数组，长度为文件实际长度 +1
                byte[] arrFileFina = new byte[length + 1];
                arrFileFina[0] = 1;//设置 数据标识位等于1，代表 发送的是文件
                //将 文件数据数组 复制到 新数组中，下标从1开始
                //arrFile.CopyTo(arrFileFina, 1);
                Buffer.BlockCopy(arrFile, 0, arrFileFina, 1, length);
                // MessageBox.Show("120");
                //发送文件数据
                sokMsg.Send(arrFileFina);//, 0, length + 1, SocketFlags.None);
            }
        }
        #endregion

        #region 05向客户端发送闪屏
        /// <summary>
        /// 向客户端发送闪屏
        /// </summary>
        /// <param name="strMsg"></param>
        public void SendShake()
        {
            byte[] arrMsgFinal = new byte[1];
            arrMsgFinal[0] = 2;
            sokMsg.Send(arrMsgFinal);
        }
        #endregion

        #region 06关闭与客户端连接
        /// <summary>
        /// 关闭与客户端连接
        /// </summary>
        public void CloseConnection()
        {
            isRec = false;
        }
        #endregion

        #region 07向客户端发送连接成功提示
        /// <summary>
        /// 向客户端发送连接成功提示
        /// </summary>
        /// <param name="strMsg"></param>
        public void SendTrue()
        {
            byte[] arrMsgFinal = new byte[1];
            arrMsgFinal[0] = 3;
            sokMsg.Send(arrMsgFinal);
        }
        #endregion

        #region 08向客户端发送关机命令
        /// <summary>
        /// 向客户端发送关机命令
        /// </summary>
        /// <param name="strMsg"></param>
        public void guanji()
        {
            byte[] arrMsgFinal = new byte[1];
            arrMsgFinal[0] = 4;
            sokMsg.Send(arrMsgFinal);
        }
        #endregion

        #region 09向客户端发送重启命令
        /// <summary>
        /// 向客户端发送关机命令
        /// </summary>
        /// <param name="strMsg"></param>
        public void chongqi()
        {
            byte[] arrMsgFinal = new byte[1];
            arrMsgFinal[0] = 5;
            sokMsg.Send(arrMsgFinal);
        }
        #endregion

        #region 10向客户端发送待机命令
        /// <summary>
        /// 向客户端发送关机命令
        /// </summary>
        /// <param name="strMsg"></param>
        public void zhuxiao()
        {
            byte[] arrMsgFinal = new byte[1];
            arrMsgFinal[0] = 6;
            sokMsg.Send(arrMsgFinal);
        }
        #endregion

        #region 11向客户端发送截屏命令
        /// <summary>
        /// 向客户端发送截屏命令
        /// </summary>
        /// <param name="strMsg"></param>
        public void jieping()
        {
            byte[] arrMsgFinal = new byte[1];
            arrMsgFinal[0] = 7;
            sokMsg.Send(arrMsgFinal);
        }
        #endregion
    }
}
