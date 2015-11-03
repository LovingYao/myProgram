using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyTools.LanguageHelper
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class FieldAttribute : Attribute
    {
        private readonly string _fields;
        /// <summary>
        /// 字段名称
        /// </summary>
        public string Fields
        {
            get { return _fields; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="fields">字段在表中的名称</param>
        public FieldAttribute(string fields)
        {
            _fields = fields;
        }
    }
}
