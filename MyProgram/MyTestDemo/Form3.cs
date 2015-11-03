using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace MyTestDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var url = "http://localhost:8081/jaytest";
            var req = WebRequest.Create(url);
            req.Method = "GET";
            try
            {
                //返回 HttpWebResponse
                var hwRes = req.GetResponse() as HttpWebResponse;
                string result;
                if (hwRes == null)
                {
                    
                    return;
                }
                if (hwRes.StatusCode == HttpStatusCode.OK)
                {
                    //是否返回成功
                    var rStream = hwRes.GetResponseStream();
                    //流读取
                    var sr = new StreamReader(rStream, Encoding.UTF8);
                    result = sr.ReadToEnd();
                    sr.Close();
                    rStream.Close();
                }
                else
                {
                    result = "连接错误";
                }
                //关闭
                hwRes.Close();
                result = result.ToUpper();
                label1.Text = result;
               
            }
            catch (WebException ex)
            {
                var responseFromServer = ex.Message + " ";
                if (ex.Response != null)
                {
                    using (var response = ex.Response)
                    {
                        var data = response.GetResponseStream();
                        using (var reader = new StreamReader(data))
                        {
                            responseFromServer += reader.ReadToEnd();
                        }
                    }
                }
                label1.Text = ex.Message;
                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlertWindows asd=new AlertWindows();
            asd.Show("我成功了");
        }
    }
}
