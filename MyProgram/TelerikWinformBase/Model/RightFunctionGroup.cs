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
    public class RightFunctionGroup
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
        /// 排序
        /// </summary>
        public Int32 Sequence { get; set; }
        /// <summary>
        /// 中文简体
        /// </summary>
        public String GroupNameCn { get; set; }
        /// <summary>
        /// 美语
        /// </summary>
        public String GroupNameUs { get; set; }
        /// <summary>
        /// 中文繁体
        /// </summary>
        public String GroupNameTw { get; set; }
        /// <summary>
        /// 英语
        /// </summary>
        public String GroupNameEn { get; set; }
        /// <summary>
        /// 德语
        /// </summary>
        public String GroupNameGe { get; set; }
        /// <summary>
        /// 越南语
        /// </summary>
        public String GroupNameVi { get; set; }
        /// <summary>
        /// 日本语
        /// </summary>
        public String GroupNameJp { get; set; }
        /// <summary>
        /// 韩语
        /// </summary>
        public String GroupNameKo { get; set; }
        /// <summary>
        /// 法语
        /// </summary>
        public String GroupNameFr { get; set; }
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
