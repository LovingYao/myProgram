using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;

namespace RFIDProgram
{
    public  class CSICSV
    {
        public CSICSV(string cSVFile)
        {
            _csvFile = cSVFile;
        }

        /// <summary>
        /// CSV文件
        /// </summary>
        private  string _csvFile;

        #region 读CSV文件

        /// <summary>
        /// 读1
        /// </summary>
        /// <returns></returns>
        public DataTable Read(out string msg)
        {
            try
            {
                msg = "";
                FileInfo fi = new FileInfo(this._csvFile);
                if (fi == null || !fi.Exists)
                {
                    msg = _csvFile+" 文件不存在或为空";
                    return null;
                }

                using (StreamReader reader = new StreamReader(this._csvFile))
                {
                    string line = string.Empty; 
                    int lineNumber = 0;
                    DataTable dt = new DataTable();
                    while ((line = reader.ReadLine()) != null)
                    {
                        //第一行属于标题列
                        if (lineNumber == 0)
                        {
                            dt = CreateDataTable(line);
                            if (dt.Columns.Count == 0)
                            {
                                msg = "文件中的列不能为空";
                                return null;
                            }
                        }
                        else
                        {
                            bool isSuccess = CreateDataRow(ref dt, line,out msg);
                            {
                                if (!isSuccess) return null;
                            }
                        }

                        lineNumber++;
                    }
                    return dt;
                }
            }
            catch(Exception ex)
            {
                msg = "读取数据发生异常:"+ex.Message+"";
                return null;
            }
        }


        /// <summary>
        /// 读2
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private DataTable CreateDataTable(string line)
        {
            try
            {
              
                DataTable dt = new DataTable();
               // foreach (string field in line.Split(FormatSplitString, StringSplitOptions.None))
                foreach (string field in line.Split(','))
                {
                    string vfield = field.Substring(0).Trim();
                    if (vfield.Contains("\""))
                        vfield = vfield.Substring(0, vfield.Length - 1);

                    if (vfield.Trim().Equals("Flag"))
                        dt.Columns.Add("Flag");
                    else if (vfield.Trim().Equals("Customer Name"))
                        dt.Columns.Add("CustomerName");
                    else if (vfield.Trim().Equals("Ordered Item/SKU"))
                        dt.Columns.Add("ItemName");
                    else if (vfield.Trim().Equals("Serial No."))
                        dt.Columns.Add("SerialNo");
                   else if (vfield.Trim().Equals("Retail Panel Price(USD)"))
                        dt.Columns.Add("Price");
                    else if (vfield.Trim().Equals("Invoice Date"))
                        dt.Columns.Add("InvoiceDate");
                    else if (vfield.Trim().Equals("Ship Address"))
                        dt.Columns.Add("Address");
                    else if (vfield.Trim().Equals("Country"))
                        dt.Columns.Add("Country");
                    else if (vfield.Trim().Equals("Job NO."))
                        dt.Columns.Add("JobNo");
                    else if (vfield.Trim().Equals("Qty"))
                        dt.Columns.Add("Qty");
                    else if (vfield.Trim().Equals("FYMonth"))
                        dt.Columns.Add("Month");
                }
                return dt;
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 读3
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        private bool CreateDataRow(ref DataTable dt, string line,out string msg)
        {
            try
            {
                msg = "";
                DataRow dr = dt.NewRow();
                //string[] fileds = line.Split(FormatSplitString, StringSplitOptions.None);
                string[] fileds = line.Split(',');
                for (int i = 0; i < fileds.Length; i++)
                {
                    string vfield = fileds[i].Substring(0).Trim();
                   // if (vfield.Contains("\""))
                   //     vfield = vfield.Substring(0, vfield.Length - 1);
                    if (vfield.Contains("*"))
                        vfield = vfield.Replace("*",",");
                    dr[i] = vfield.Trim();
                }
                dt.Rows.Add(dr);
                return true;
            }
            catch(Exception ex)
            {
                msg = ex.Message;
                return false;
            }
        }


        #endregion

        #region 写CSV文件

        /// <summary>
        /// 写1
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public bool Write(DataTable dt)
        {
            FileInfo fi = new FileInfo(this._csvFile);
            if (fi == null || !fi.Exists) return false;

            if (dt == null || dt.Columns.Count == 0 || dt.Rows.Count == 0) return false;

            StreamWriter writer = new StreamWriter(this._csvFile);
            //writer.AutoFlush = true;  

            string line = string.Empty;

            line = CreateTitle(dt);
            writer.WriteLine(line);

            foreach (DataRow dr in dt.Rows)
            {
                line = CretreLine(dr);
                writer.WriteLine(line);
            }

            writer.Flush();

            return true;
        }

        /// <summary>
        /// 写2
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private string CreateTitle(DataTable dt)
        {
            string line = string.Empty;

            for (int i = 0; i < dt.Columns.Count; i++)
            {
                line += string.Format("{0}{1}", dt.Columns[i].ColumnName, FormatSplit[0].ToString());
            }

            line.TrimEnd(FormatSplit[0]);

            return line;
        }

        /// <summary>
        /// 写2
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        private string CretreLine(DataRow dr)
        {
            string line = string.Empty;

            for (int i = 0; i < dr.ItemArray.Length; i++)
            {
                line += string.Format("{0}{1}", dr[i], FormatSplit[0].ToString());
            }

            line.TrimEnd(FormatSplit[0]);

            return line;
        }

        private char[] FormatSplit
        {
            get { return new char[] { ',' }; }
        }

        private string[] FormatSplitString
        {
            get { return new string[] { "\"," }; }
        }
        #endregion
    }
}
