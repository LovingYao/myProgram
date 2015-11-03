using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikWinformBase
{
    public class QueryConditionBuilder
    {
        private readonly QueryCondition _queryCondition;

        private readonly Dictionary<QueryConditionField, string> _dictCondition;

        public QueryConditionBuilder(QueryCondition queryCondition, Dictionary<QueryConditionField, string> dictCondition)
        {
            _queryCondition = queryCondition;

            _dictCondition = dictCondition;
        }

        public string Build()
        {
            var code = new StringBuilder();
            foreach (var pair in _dictCondition)
                code.Append(BuildSqlPart(pair.Value, pair.Key));

            return code.ToString();
        }

        private string BuildSqlPart(string sql, QueryConditionField queryConditionField)
        {
            switch (queryConditionField)
            {
                case QueryConditionField.UserId:
                    if (string.IsNullOrEmpty(_queryCondition.UserId))
                        return "";
                    break;
                case QueryConditionField.CATEGORY:
                    if (string.IsNullOrEmpty(_queryCondition.CATEGORY))
                        return "";
                    break;
                case QueryConditionField.WORKSHOP:
                    if (string.IsNullOrEmpty(_queryCondition.WORKSHOP))
                        return "";
                    break;
                case QueryConditionField.Name:
                    if (string.IsNullOrEmpty(_queryCondition.GroupName))
                        return "";
                    break;
                case QueryConditionField.Code:
                    if (string.IsNullOrEmpty(_queryCondition.Code))
                        return "";
                    break;
                case QueryConditionField.DepartmentCode:
                    if (string.IsNullOrEmpty(_queryCondition.DepartmentCode))
                        return "";
                    break;
                case QueryConditionField.EQUIPMENT:
                    if (string.IsNullOrEmpty(_queryCondition.EQUIPMENT))
                        return "";
                    break;
                case QueryConditionField.PROTOCOL:
                    if (string.IsNullOrEmpty(_queryCondition.PROTOCOL))
                        return "";
                    break;
                case QueryConditionField.ReasonCategory:
                    if (string.IsNullOrEmpty(_queryCondition.ReasonCategory))
                        return "";
                    break;
                case QueryConditionField.Resv01:
                    if (string.IsNullOrEmpty(_queryCondition.Resv01))
                        return "";
                    break;
                case QueryConditionField.InCondition:
                    return string.IsNullOrEmpty(_queryCondition.InCondition)
                               ? ""
                               : string.Format(sql, _queryCondition.InCondition);

                case QueryConditionField.NotInCondition:
                    return string.IsNullOrEmpty(_queryCondition.NotInCondition)
                               ? ""
                               : string.Format(sql, _queryCondition.NotInCondition);
              
            }

            return sql + "@" + queryConditionField;
        }
    }
}
