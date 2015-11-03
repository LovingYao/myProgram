using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace TelerikWinformBase
{
    public class CryptoHelper
    {
        //MD5加密字符串
        /// <summary>
        /// MD5加密字符串
        /// </summary>
        /// <param name="sourceStr"></param>
        /// <returns></returns>
        public static string ToMd5(string sourceStr)
        {
            var md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            var data = md5Hasher.ComputeHash(Encoding.Unicode.GetBytes(sourceStr));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            var sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (var i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
    }
}
