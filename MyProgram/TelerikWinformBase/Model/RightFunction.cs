using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikWinformBase
{
    [Serializable]
    public class RightFunction
    {
        /// <summary>
        /// 主键
        /// </summary>
        public String Sysid { get; set; }
        /// <summary>
        /// 功能代码
        /// </summary>
        public String FuncCode { get; set; }
        /// <summary>
        /// 功能名称
        /// </summary>
        public String FuncName { get; set; }
        /// <summary>
        /// 功能参数
        /// </summary>
        public String FuncParam { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public String CreatedOn { get; set; }
        /// <summary>
        /// 创建者
        /// </summary>
        public String CreatedBy { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public String ModifiedOn { get; set; }
        /// <summary>
        /// 修改者
        /// </summary>
        public String ModifiedBy { get; set; }
        /// <summary>
        /// 记录状态
        /// </summary>
        public String RecordStatus { get; set; }

        public int Sequence { get; set; }
    }
}
