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
    public class Right
    {
        /// <summary>
        /// 
        /// </summary>
        public String Sysid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String UserGroupSysid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String FunctionGroupSysid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String FunctionSysid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String CommandSysid { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public String CreatedOn { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        public String CreatedBy { get; set; }
    }
}
