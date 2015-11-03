using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBFactory;
using System.IO;


namespace ImportDataTool
{
    public partial class ImportModuleTest : Form
    {
        private string iSysid;
        private bool isOperate;
        private int iID;
        private int iCount;
        private string strSQL1 = "";
        private string strSQL2 = "";
        private delegate void CallBackDelegate(string message);
        private string strUrl1 = "Server=10.245.40.81;Database=TRACKING_2014;Uid=root;Pwd=root;CharSet=utf8;";
        private string strUrl2 = "Server=10.245.40.85;Database=TRACKING;Uid=root;Pwd=root;CharSet=utf8;";
        DBOperate dbo1;
        DBOperate dbo2;
        StreamWriter sw;

        public ImportModuleTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbo1 = new DBOperate("Mysql", strUrl1, "TRACKING_TEST");
            dbo2 = new DBOperate("Mysql", strUrl2, "TRACKING");
            iID=int.Parse(tbBeginID.Text.Trim());
            iCount = int.Parse(tbCount.Text.Trim());
            isOperate = true;
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
                                if (message != "ok")
                                {
                                    this.txtLog.AppendText(message + "\r\n");
                                }
                                else
                                {
                                    this.button1.Enabled = true;
                                }

                            }));

        }

        private void writeLog(string Msg)
        {
            
            if (!File.Exists("templog.txt"))
            {
                sw = File.CreateText("templog.txt");
            }
            else
            {
                sw = File.AppendText("templog.txt");                
            }
            sw.WriteLine(Msg);
            sw.Close(); 
        }

        private void ThreadFun(object o)
        {
            CallBackDelegate cbd = o as CallBackDelegate;

            try
            {
                writeLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  导入开始");
                while (isOperate)
                {                 
                    strSQL2 = string.Format(@"select * from T_MODULE_TEST where id>={0} and id<{1}", iID, iID + iCount);
                    var list = dbo2.getModuleTest(strSQL2);
                    if (iID > int.Parse(textBox1.Text.Trim()))
                    {
                        isOperate = false;
                        cbd(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "导入全部完成(" + iID.ToString() + "-" + (iID + iCount).ToString() + ")");
                        return;
                    }
                    //if (list == null || list.Tables["dbTable"].Rows.Count <= 0)
                    //{
                    //    isOperate = false;
                    //    cbd(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "导入全部完成了(" + iID.ToString() + "-" + (iID + iCount).ToString() + ")");
                    //}
                    foreach (DataRow dr in list.Tables["dbTable"].Rows)
                    {
                        iSysid = dr[0].ToString();
                        strSQL1 = string.Format(@"select * from T_MODULE_TEST where module_sn='{0}' and factory='CSAS'", dr[2].ToString());
                        var list1 = dbo1.getModuleTest(strSQL1);
                        if (list1.Tables["dbTable"].Rows.Count > 0)
                        {
                            continue;
                        }

                        strSQL1 = string.Format(@"insert into T_MODULE_TEST
                                                        (SYSID,FACTORY,MODULE_SN,TEMP,ISC,VOC,IMP,VMP,PMAX,FF,EFF,TEST_DATE,CREATED_NO,CREATED_BY,MODIFIED_ON,MODIFIED_BY,CREATE_TIME,REMARK,FROMSYS)
                                                  values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}',now(),'{16}','{17}')",
                                                  dr[1].ToString(), "CSAS", dr[2].ToString(), dr[3].ToString(),
                                                  dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),
                                                  dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(),
                                                  dr[12].ToString(), dr[13].ToString(), dr[14].ToString(),
                                                  dr[15].ToString(), dr[16].ToString(),"Histroy");
                        if (!dbo1.insertModuleTest(strSQL1))
                        {
                            cbd(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "导入出现异常(" + iID.ToString() + "-" + (iID + iCount).ToString()+")");
                            writeLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") +" 导入出现异常");
                            writeLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + strSQL2);
                            writeLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + strSQL1);
                            isOperate = false;
                            return;
                        }
                       
                    }
                    cbd(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "导入完成(" + iID.ToString() + "-" + (iID + iCount).ToString() + ")");
                    writeLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "导入完成(" + iID.ToString() + "-" + (iID + iCount).ToString() + ")");
                    iID = iID + iCount;
                                    
                }

                writeLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "  导入结束");
                cbd("ok");
            }
            catch (Exception ex)
            {
                cbd("执行异常：" + ex.Message);
                cbd("ok");
                writeLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ex.Message + iSysid);
                writeLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + strSQL2);
                writeLog(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + strSQL1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isOperate = false;
            button1.Enabled = true;
        }

    }
}
