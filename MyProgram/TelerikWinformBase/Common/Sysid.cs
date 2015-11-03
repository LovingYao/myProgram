using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RFIDProgram
{
    //SYSID获取
    /// <summary>
    /// SYSID获取
    /// </summary>
    public class Sysid
    {
        //返回一个唯一标识符（最大长度为50）
        /// <summary>
        /// 返回一个唯一标识符（最大长度为50）
        /// </summary>
        /// <param name="suffix">后缀，超过10位的时候只取前10位</param>
        /// <returns></returns>
        public static string NewId(string suffix)
        {
            var id1 = Guid.NewGuid().ToString().ToLower().Replace("-", "");
            var id2 = Guid.NewGuid().ToString().ToLower().Split('-')[0];
            var retValue = id1 + id2;
            if (!string.IsNullOrEmpty(suffix))
                retValue += suffix.ToLower().Trim();
            return retValue.Length <= 50 ? retValue : retValue.Substring(0, 50);
        }
    }
}
