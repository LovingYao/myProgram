using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsiProgram.Entity;

namespace CsiProgram.DAL
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
                case QueryConditionField.user_name:

                    if (string.IsNullOrEmpty(_queryCondition.user_name))
                        return "";
                    break;

                case QueryConditionField.role_id:

                    if (string.IsNullOrEmpty(_queryCondition.role_id))
                        return "";
                    break;
               
                case QueryConditionField.status_id:

                    if (string.IsNullOrEmpty(_queryCondition.status_id))
                       return "";
                    break;
                case QueryConditionField.type_name:

                    if (string.IsNullOrEmpty(_queryCondition.type_name))
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
