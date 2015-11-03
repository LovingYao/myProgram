using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SapBatchTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string Password = ConfigurationManager.AppSettings["Password"].Trim();//获取默认操作密码

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void clearControl()
        {
            txtBatch.Text = "";
            txtJobno.Text = "";
            txtStdpower.Text = "";

        }

        /// <summary>
        /// 执行操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //判断密码
                if (txtPassword.Text == "")
                {
                    Log("请输入操作口令", "ABNORMAL", lstView);
                    return;
                }
                if (!txtPassword.Text.Equals(Password))
                {
                    Log("输入的口令不正确，无法进行操作", "ABNORMAL", lstView);
                    return;
                }

                if (radioButton1.Checked)
                {

                    if (txtBatch.Text.Trim() == "")
                    {
                        Log("SapBatch不能为空", "ABNORMAL", lstView);
                        return;
                    }
                    if (txtJobno.Text.Trim() == "")
                    {
                        Log("JobNo不能为空", "ABNORMAL", lstView);
                        return;
                    }
                    if (txtStdpower.Text.Trim() == "")
                    {
                        Log("标称功率不能为空", "ABNORMAL", lstView);
                        return;
                    }


                }

                if (radioButton3.Checked)
                {
                    if (txtBatch.Text.Trim() == "" && txtJobno.Text.Trim() == "")
                    {
                        Log("Sapbatch和Jobno不能同时为空", "ABNORMAL", lstView);
                        return;
                    }
                }

                //检查是否存在此jobno
                var batchNo = BatchDAL.getBatchInfo(txtJobno.Text.Trim(), txtBatch.Text.Trim());
                if (batchNo != null && radioButton1.Checked)
                {

                    Log(string.Format("此记录已经存在 BatchNo:{0} JobNo:{1} StdPower:{2}", batchNo.SAP_BATCH, batchNo.JOB_NO, batchNo.STDPOWER), "ABNORMAL", lstView);
                    return;

                }
                if (batchNo == null && radioButton3.Checked)
                {
                    Log("数据库中没有满足条件的数据，无法进行删除", "ABNORMAL", lstView);
                    return;
                }

                BatchModel bm = new BatchModel();
                bm.JOB_NO = txtJobno.Text.Trim();
                bm.SAP_BATCH = txtBatch.Text.Trim();
                bm.STDPOWER = txtStdpower.Text.Trim();
                bm.CREATED_BY = System.Net.Dns.GetHostName();
                bm.CREATED_ON = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                if (radioButton1.Checked)
                {
                    if (BatchDAL.Insert(bm))
                    {
                        Log(string.Format("插入成功! BatchNo:{0} JobNo:{1} StdPower:{2}", bm.SAP_BATCH, bm.JOB_NO, bm.STDPOWER), "NORMAL", lstView);
                        return;
                    }
                    else
                    {
                        Log("插入失败!", "ABNORMAL", lstView);
                        return;
                    }
                }
                if (radioButton3.Checked)
                {
                    if (BatchDAL.Delete(bm))
                    {
                        Log(string.Format("删除成功! BatchNo:{0} JobNo:{1}", batchNo.SAP_BATCH, batchNo.JOB_NO), "NORMAL", lstView);
                        return;
                    }
                    else
                    {
                        Log("删除失败！", "ABNORMAL", lstView);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Log(string.Format("操作异常！ {0}", ex.Message), "ABNORMAL", lstView);
                return;
            }
            finally
            {
                clearControl();
            }



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
    }
}
