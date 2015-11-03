using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTools
{
    public class TypeConversionHelper
    {
        /// <summary>
        /// 十六进制转ascii
        /// </summary>
        /// <param name="HexStr"></param>
        /// <returns></returns>
        public static string HexStrToASCII(string HexStr)
        {
            try
            {
                int iValue;
                byte[] bs;
                string sValue;
                iValue = Convert.ToInt32(HexStr, 16); // 16进制->10进制
                bs = System.BitConverter.GetBytes(iValue); //int->byte[]
                sValue = System.Text.Encoding.ASCII.GetString(bs);   //byte[]-> ASCII
                return sValue;
            }
            catch
            {
                return "error";
            }
        }
    }
}
