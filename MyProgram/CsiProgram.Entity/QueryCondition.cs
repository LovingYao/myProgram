using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsiProgram.Entity
{
    //查询参数
    /// <summary>
    /// 查询参数
    /// </summary>
    public class QueryCondition
    {
        public string user_name { get; set; }

        public string status_id { get; set; }

        public string type_name { get; set; }

        public string role_id { get; set; }

        public int total { get; set; }

        public int pageSize{ get; set; }

        public int pageIndex { get; set; }

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
