using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsiProgram.Entity
{
    //
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class BaseStatus
    {
        /// <summary>
        /// 
        /// </summary>
        public Int32 ID { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String StatusId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String StatusName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String GroupName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String CreatedOn { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String CreatedBy { get; set; }

        //构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        public BaseStatus()
        {
            StatusId = string.Empty;
            StatusName = string.Empty;
            GroupName = string.Empty;
            CreatedOn = string.Empty;
            CreatedBy = string.Empty;
        }
    }
}
