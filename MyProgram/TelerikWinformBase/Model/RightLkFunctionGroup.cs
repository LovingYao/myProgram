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
    public class RightLkFunctionGroup
    {
        /// <summary>
        /// 组SYSID
        /// </summary>
        public String GroupSysid { get; set; }
        /// <summary>
        /// 功能SYSID
        /// </summary>
        public String FunctionSysid { get; set; }
        public int Sequence { get; set; }

    }
}
