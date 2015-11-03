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
    public class RightUserGroup
    {
        /// <summary>
        /// 主键
        /// </summary>
        public String Sysid { get; set; }
        /// <summary>
        /// 组名称
        /// </summary>
        public String GroupName { get; set; }
        /// <summary>
        /// 车间
        /// </summary>
        public String Workshop { get; set; }
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
    }
}
