using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace MyTools
{
    public class SiemensPlcHelper
    {
        private string sServiceIP;
        private string sServicePort;

        private TcpListener tcp_Listener = null;
        private TcpClient tcp_client = null;
        private Stream plc_Streanm = null;

        public SiemensPlcHelper(string serviceIP,string servicePort)
        {
            this.sServiceIP = serviceIP;
            this.sServicePort = servicePort;
        }

        public bool OpenConnect()
        {
            try
            {
                IPAddress addrs = IPAddress.Parse(sServiceIP);
                IPEndPoint endpoint = new IPEndPoint(addrs, Int32.Parse(sServicePort));
                tcp_Listener = new TcpListener(endpoint);
                tcp_Listener.Start();

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool ReadBarcode(ref string barcode)
        {
            try
            {
                if (tcp_client == null || tcp_client.Connected == false)
                {
                    tcp_client = tcp_Listener.AcceptTcpClient(); //连接网络会停在这里
                }
                plc_Streanm = tcp_client.GetStream();

                int scancount;

                byte[] _Data = new byte[56];
                Int32 R = plc_Streanm.Read(_Data, 0, 56); //读码会停在这里

                string ResultHexstr = "";
                foreach (byte obj in _Data)
                {
                    if (Convert.ToString(obj, 16).Length == 1)
                    {
                        ResultHexstr += "0" + Convert.ToString(obj, 16) + ",";
                    }
                    else
                    {
                        ResultHexstr += Convert.ToString(obj, 16) + ",";
                    }
                }
                ResultHexstr = ResultHexstr.Substring(0, ResultHexstr.Length - 1); //把最后的‘,’去掉
                string[] StrArray = ResultHexstr.Split(',');

                int _Length = Convert.ToInt32(StrArray[14] + StrArray[15], 16);   //得到扫描枪读码有效长度,十六进制 转十进制

                //plc数据是否变化
                int strtest = Convert.ToInt32(StrArray[10] + StrArray[11] + StrArray[12] + StrArray[13], 16); //读码次数
                scancount = strtest;

                string Result = "";
                for (int i = 0; i < _Length; i++)
                {
                    string M_Value = TypeConversionHelper.HexStrToASCII(StrArray[16 + i]).ToString().Replace("\0\0\0", "").Replace("\0\0", "").Replace("\0", "");
                    Result = Result.ToString().Trim() + M_Value.ToString().Trim();
                }

                barcode = Result;
                plc_Streanm.Flush();
                plc_Streanm.Close();
                return true;


            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                tcp_client.Close();
            }
        }
    }
}
