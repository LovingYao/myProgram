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
    public class DictionaryItem
    {
        /// <summary>
        /// 主键
        /// </summary>
        public String Sysid { get; set; }
        /// <summary>
        /// 所属字典SYSID
        /// </summary>
        public String DictionaryCode { get; set; }
        /// <summary>
        /// 字典项代码
        /// </summary>
        public String Code { get; set; }
        /// <summary>
        /// 字典项名称
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// 字典项序号
        /// </summary>
        public int Sequence { get; set; }
        /// <summary>
        /// 车间
        /// </summary>
        public String Workshop { get; set; }
        /// <summary>
        /// 工序
        /// </summary>
        public String Step { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public String Remark { get; set; }
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
        /// <summary>
        /// 预留字段
        /// </summary>
        public String Resv01 { get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        public String Resv02 { get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        public String Resv03 { get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        public String Resv04 { get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        public String Resv05 { get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        public String Resv06 { get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        public String Resv07 { get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        public String Resv08 { get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        public String Resv09 { get; set; }
        /// <summary>
        /// 预留字段
        /// </summary>
        public String Resv10 { get; set; }

        public string DictionaryName { get; set; }

        public string StepName { get; set; }
    }
}
