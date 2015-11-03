using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikWinformBase
{
    //查询参数
    /// <summary>
    /// 查询参数
    /// </summary>
    public class QueryCondition
    {
        public string CATEGORY { get; set; }

        public string WORKSHOP { get; set; }

        public string PROTOCOL { get; set; }

        public string EQUIPMENT { get; set; }

        public string EQUIPMENTIP { get; set; }

        public string UserId { get; set; }

        public string Code { get; set; }

        public string ReasonCategory { get; set; }

        public string GroupName { get; set; }

        public string Resv01 { get; set; }

        public string DepartmentCode { get; set; }



        //SQL in 参数 例如：“status in ('a','b','c')”，其中“'a','b','c'”为InCondition的值
        /// <summary>
        /// SQL in 参数 例如：“status in ('a','b','c')”，其中“'a','b','c'”为InCondition的值
        /// </summary>
        public string InCondition { get; set; }

        //SQL not in 参数 例如：“status not in ('a','b','c')”，其中“'a','b','c'”为NotInCondition的值
        /// <summary>
        /// SQL not in 参数 例如：“status not in ('a','b','c')”，其中“'a','b','c'”为NotInCondition的值
        /// </summary>
        public string NotInCondition { get; set; }


    }
}
