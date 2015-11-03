using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QueryStepInfor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string strMsg = "";
        private string strStartTime = "";
        private string strEndTime = "";
        private string strEquip = "";
        private List<DataModel> dModel;

        private delegate void CallBackDelegate(string message);

        private void Form1_Load(object sender, EventArgs e)
        {
            txtStartTime.Text="2015-05-21 12:06:12.280";
            txtEndTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            txtEquip.Text = ConfigurationManager.AppSettings["Equipment"].Trim();
        }

        /// <summary>
        /// 显示信息
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="msgtype"></param>
        /// <param name="lstV"></param>
        public static void Log(string msg, string msgtype = "", ListView lstV = null)
        {
            if (lstV != null)
            {

                if (msgtype.Equals("NORMAL"))
                {

                    ListViewItem Item = new ListViewItem();
                    Item.SubItems.Clear();
                    Item.SubItems[0].Text = System.DateTime.Now.ToString() + "   " + msg;// i.ToString();
                    Item.SubItems[0].ForeColor = System.Drawing.Color.Blue;
                    lstV.Items.Add(Item);
                }
                else if (msgtype.Equals("ABNORMAL"))
                {

                    ListViewItem Item = new ListViewItem();
                    Item.SubItems.Clear();
                    Item.SubItems[0].Text = System.DateTime.Now.ToString() + "   " + msg;// i.ToString();
                    Item.SubItems[0].ForeColor = System.Drawing.Color.Red;
                    lstV.Items.Add(Item);
                }
                lstV.Items[lstV.Items.Count - 1].EnsureVisible();
                if (lstV.Items.Count > 2000)
                    lstV.Items.Clear();
            }
        }

        private bool checkType()
        {
            if (txtStartTime.Text.Trim() == "" || txtEndTime.Text.Trim() == "")
            {
                strMsg = "时间不能为空";
                return false;
            }

            if (txtStartTime.Text.Trim().Length != 23)
            {
                strMsg = "起始时间格式不对";
                return false;
            }
            if (txtEndTime.Text.Trim().Length != 23)
            {
                strMsg = "结束时间格式不对";
                return false;
            }
            if (txtEquip.Text.Trim() == "")
            {
                strMsg = "设备名称不能为空";
                return false;
            }

            DateTime dt1 = DateTime.Parse(txtStartTime.Text.Trim());
            DateTime dt2 = DateTime.Parse(txtEndTime.Text.Trim());

            TimeSpan ts = dt2 - dt1;
            if (ts.Days > 6)
            {
                strMsg = "时间区间过大，影响MES系统";
                return false;
            }

            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkType())
            {
                Log(strMsg, "ABNORMAL", lstView);
                return;
            }

            strStartTime = txtStartTime.Text.Trim();
            strEndTime = txtEndTime.Text.Trim();
            strEquip = txtEquip.Text;

            button1.Text = "正在执行...";
            button1.Enabled = false;

            CallBackDelegate cbd = new CallBackDelegate(this.CallBack);
            new Thread(new ParameterizedThreadStart(this.ThreadFun)).Start(cbd);

        }

        private void CallBack(string message)
        {


            this.Invoke(
                            (EventHandler)
                            (delegate
                            {
                                string Msg;
                                DataToExcel.ToExcel(dModel, out Msg);
                                Log(message, "ABNORMAL", lstView);
                                button1.Text = "生成Excel";
                                button1.Enabled = true;
                                Log(Msg, "ABNORMAL", lstView);
                            }));

        }

        private void ThreadFun(object o)
        {
            CallBackDelegate cbd = o as CallBackDelegate;
            try
            {
                dModel = DataAccess.getData(strStartTime, strEndTime, strEquip);
                cbd("数据获取成功!");
            }
            catch (Exception ex)
            {
                cbd("执行异常：" + ex.Message);
            }

        }
    }
}
