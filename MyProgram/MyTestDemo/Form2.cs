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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = @"http://restapi.amap.com/v3/geocode/geo?key=aa4a48297242d22d2b3fd6eddfe62217&s=rsv3&address=上海市浦东区新源小区";
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

               

            string ret = string.Empty;
            Stream s;
            string StrDate = "";
            string strValue = "";
            if (response.StatusCode == HttpStatusCode.OK)
            {
                //用stream流读
                s = response.GetResponseStream();

                StreamReader Reader = new StreamReader(s, Encoding.UTF8);//Encoding.Default乱码
                while ((StrDate = Reader.ReadLine()) != null)
                {
                    strValue += StrDate + "\r\n";
                }
            }
            label1.Text = strValue;
        }
    }
}
