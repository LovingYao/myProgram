using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikWinformBase
{
    //
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class DictionaryInfo
    {
        /// <summary>
        /// 字典代码
        /// </summary>
        public String Code { get; set; }
        /// <summary>
        /// 字典名称
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 字典所有者：S/U
        /// </summary>
        public String Owner { get; set; }
        /// <summary>
        /// 字典类别：Dictionary（字典）/ReasonCode（原因代码）
        /// </summary>
        public String Category { get; set; }

    }
}
