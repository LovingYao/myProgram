using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikWinformBase
{
    //权限用户信息
    /// <summary>
    /// 权限用户信息
    /// </summary>
    [Serializable]
    public class RightUser
    {
        /// <summary>
        /// 主键
        /// </summary>
        public String Sysid { get; set; }
        /// <summary>
        /// 工号
        /// </summary>
        public String UserId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public String UserName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public String UserPwd { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
        public String Department { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public String Email { get; set; }
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


        public string DepartmentName { get; set; }
        public string StepName { get; set; }
    }
}
