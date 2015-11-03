using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTools.LanguageHelper
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class TableAttribute : Attribute
    {
        private readonly string _tableName;
        /// <summary>
        /// 映射的表名
        /// </summary>
        public string TableName
        {
            get { return _tableName; }
        }

        /// <summary>
        /// 定位函数映射表名
        /// </summary>
        /// <param name="table">实体对应的表名称</param>
        public TableAttribute(string table)
        {
            _tableName = table;
        }
    }
}
