using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SapBatchTool
{
    public class DataUtils
    {
        #region 私有方法

        /// <summary>
        /// 转换DB类型为实体类型
        /// </summary>
        /// <param name="value"></param>
        /// <param name="conversionType"></param>
        /// <returns></returns>
        private static object HackType(object value, Type conversionType)
        {
            if (conversionType.IsGenericType && conversionType.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                    return null;

                var nullableConverter = new NullableConverter(conversionType);
                conversionType = nullableConverter.UnderlyingType;
            }

            return Convert.ChangeType(value, conversionType);
        }

        /// <summary>
        /// 判断是否为空
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static bool IsNullOrDbNull(object obj)
        {
            return ((obj is DBNull) || string.IsNullOrEmpty(obj.ToString())) ? true : false;
        }

        /// <summary>
        /// 判断实体是否由自定义特性来确定表和字段
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static bool IsConvertByAttribute<T>(T obj)
        {
            var type = obj.GetType();
            foreach (var attr in type.GetCustomAttributes(false))
            {
                var table = attr as TableAttribute;
                if (table == null)
                    continue;

                return true;
            }

            return false;
        }

        /// <summary>
        /// 获取字段名
        /// </summary>
        /// <param name="prs"></param>
        /// <returns></returns>
        private static string GetFieldNameFromAttribute(ICustomAttributeProvider prs)
        {
            var attu = prs.GetCustomAttributes(false);
            foreach (Attribute abute in attu)
            {
                var field = abute as FieldAttribute;
                if (field == null)
                    continue;

                return field.Fields;
            }

            return null;
        }

        #endregion

        #region 公共方法

        //类型转换：decimal --> long 向上取整
        /// <summary>
        /// 类型转换：decimal --> long 向上取整
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public static long ParseLongCeiling(decimal quantity)
        {
            return long.Parse(Math.Ceiling(quantity).ToString());
        }

        /// <summary>
        /// 将DataReader转为实体
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="dr">DataReader</param>
        /// <returns></returns>
        public static T ReaderToModel<T>(IDataReader dr)
        {
            using (dr)
            {
                if (dr.Read())
                {
                    var list = new List<string>(dr.FieldCount);
                    for (var i = 0; i < dr.FieldCount; i++)
                    {
                        list.Add(dr.GetName(i).ToLower());
                    }

                    var model = Activator.CreateInstance<T>();
                    var properties = model.GetType().GetProperties(BindingFlags.GetProperty |
                                                                              BindingFlags.Public |
                                                                              BindingFlags.Instance);
                    var isAttr = IsConvertByAttribute(model);
                    foreach (var pi in properties)
                    {
                        var fieldName = isAttr ? GetFieldNameFromAttribute(pi) : pi.Name;

                        if (!list.Contains(fieldName.ToLower()))
                            continue;

                        if (IsNullOrDbNull(dr[fieldName]))
                            continue;

                        pi.SetValue(model, HackType(dr[fieldName], pi.PropertyType), null);
                    }
                    return model;
                }
            }

            return default(T);
        }

        /// <summary>
        /// 将DataReader转为实体列表
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="dr">DataReader</param>
        /// <returns></returns>
        public static List<T> ReaderToList<T>(IDataReader dr)
        {
            using (dr)
            {
                var field = new List<string>(dr.FieldCount);
                for (var i = 0; i < dr.FieldCount; i++)
                {
                    field.Add(dr.GetName(i).ToLower());
                }
                var list = new List<T>();
                while (dr.Read())
                {
                    var model = Activator.CreateInstance<T>();
                    var properties = model.GetType().GetProperties(BindingFlags.GetProperty |
                                                                              BindingFlags.Public |
                                                                              BindingFlags.Instance);
                    var isAttr = IsConvertByAttribute(model);
                    foreach (var pi in properties)
                    {
                        var fieldName = isAttr ? GetFieldNameFromAttribute(pi) : pi.Name;

                        if (!field.Contains(fieldName.ToLower()))
                            continue;

                        if (IsNullOrDbNull(dr[fieldName]))
                            continue;

                        pi.SetValue(model, HackType(dr[fieldName], pi.PropertyType), null);
                    }
                    list.Add(model);
                }
                return list;
            }
        }


        #endregion
    }
}
