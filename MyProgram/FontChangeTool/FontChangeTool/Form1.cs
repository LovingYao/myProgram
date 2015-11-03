using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word=Microsoft.Office.Interop.Word;
using Microsoft.VisualBasic;

namespace FontChangeTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string strUrl = "";
        private string strOperateStatus = "";
        private string strChangeType = "";
        private string tempTotal = "";
        private string temp = "";
        private int iCount = 0;
        private delegate void CallBackDelegate(string message);
        private Word.Application app;
        private Word.Document doc;
        private object missing=System.Reflection.Missing.Value; 



        private void button2_Click(object sender, EventArgs e)
        {
            strOperateStatus = "2";
            strUrl = this.txtAddress.Text.Trim();
            if (this.strUrl == "")
            {
                MessageBox.Show("请选择文件夹路径!");
            }
            else
            {
                if (rbSimplified.Checked)
                {
                    this.strChangeType = "SimplifiedChinese";
                }
                else if (this.rbTraditional.Checked)
                {
                    this.strChangeType = "TraditionalChinese";
                }
                else
                {
                    MessageBox.Show("请选择转换类型!");
                    return;
                }
                CallBackDelegate cbd = new CallBackDelegate(this.CallBack);
                new Thread(new ParameterizedThreadStart(this.ThreadFun)).Start(cbd);
            }

        }

        private void CallBack(string message)
        {


            this.Invoke(
                            (EventHandler)
                            (delegate
                            {
                                this.txtLog.AppendText(message + "\r\n");

                            }));

        }

        private void ThreadFun(object o)
        {
            CallBackDelegate cbd = o as CallBackDelegate;
            
            try
            {
                FileInfo[] ArrUnPostil = new DirectoryInfo(this.strUrl).GetFiles();
                this.SortAsFileNameX(ref ArrUnPostil);
                foreach (FileInfo FileName in ArrUnPostil)
                {
                    iCount += 1;
                    if (FileName.Name.Contains(".doc") || FileName.Name.Contains(".docx"))
                    {
                        cbd(string.Concat(new object[] { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), " ", FileName, ":", this.OpenDocument(this.strUrl + @"\" + FileName, FileName.Name.ToString()) }));
                    }
                    else
                    {
                        cbd(string.Concat(new object[] { DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), " ", FileName, "不是有效的word文档" }));
                    }
                }
                if (this.strOperateStatus == "2")
                {
                    cbd(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + this.SaveDocument(this.strUrl + @"\Total.docx"));
                }
                cbd(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " " + this.strUrl + "中所有word文档操作完成");
            }
            catch (Exception ex)
            {
                cbd("执行异常：" + ex.Message);
            }
        }

        private string OpenDocument(string parFilePath, string FileName)
        {
            try
            {
                object filePath = parFilePath;
                object savePath = null;
                app = new Word.Application();
                this.doc = this.app.Documents.Open(ref filePath, ref missing, ref missing, ref missing, ref missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing);
                this.doc.Activate();
                this.temp = this.doc.Content.Text.Trim();
                if (this.strChangeType == "TraditionalChinese")
                {
                    this.temp = Strings.StrConv(this.temp, VbStrConv.TraditionalChinese, 0);
                }
                if (this.strChangeType == "SimplifiedChinese")
                {
                    this.temp = Strings.StrConv(this.temp, VbStrConv.SimplifiedChinese, 0);
                }
                if (this.strOperateStatus == "1")
                {
                    this.doc.Content.Text = this.temp;
                    savePath = parFilePath;
                    this.doc.SaveAs(ref savePath, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing);
                }
                if (this.strOperateStatus == "2")
                {
                    this.tempTotal = this.tempTotal + "\r\n" + "\r\n" + "********" + iCount + "***" + FileName.Split('.')[0] + "************************************************" + "\r\n" + "\r\n" + this.temp;
                }
                object saveChanges = this.app.Options.BackgroundSave;
                this.doc.Close(ref saveChanges, ref this.missing, ref this.missing);
                this.app.Quit(ref this.missing, ref this.missing, ref this.missing);
                return "转换成功";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



        private void SortAsFileNameX(ref FileInfo[] arrFi)
        {
            Array.Sort<FileInfo>(arrFi, delegate(FileInfo x, FileInfo y)
            {
                return x.Name.CompareTo(y.Name);
            });
        }

        private string SaveDocument(string parFilePath)
        {
            try
            {
                app = new Word.Application();
                this.doc = this.app.Documents.Add(ref this.missing, ref this.missing, ref this.missing, ref this.missing);
                this.doc.Activate();
                this.doc.Content.Text = this.tempTotal;
                object savePath = parFilePath;
                object saveChanges = this.app.Options.BackgroundSave;
                this.doc.SaveAs(ref savePath, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing, ref this.missing);
                this.doc.Close(ref saveChanges, ref this.missing, ref this.missing);
                this.app.Quit(ref this.missing, ref this.missing, ref this.missing);
                return "文件另存为成功";
            }
            catch (Exception ex)
            {
                return ("Total.docx保存失败" + ex.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

 

    }
}
