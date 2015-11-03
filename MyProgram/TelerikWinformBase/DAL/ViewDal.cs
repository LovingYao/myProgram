using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikWinformBase
{
    public class ViewDal
    {
        public static List<ViewRight> QueryViewRight(QueryCondition queryCondition)
        {
            var sql = @"
SELECT RFG.GROUP_NAME FunctionGroupName
	,RF.FUNC_CODE FunctionCode
	,RF.FUNC_NAME FunctionName
	,RF.FUNC_PARAM FunctionParam
	,DI.CODE CommandCode
	,DI.NAME CommandName
FROM T_RIGHT R WITH(NOLOCK)
	INNER JOIN T_RIGHT_LK_USER_GROUP LUG WITH(NOLOCK) ON
		R.USER_GROUP_SYSID = LUG.GROUP_SYSID
	INNER JOIN T_RIGHT_USER RU WITH(NOLOCK) ON
		LUG.USER_SYSID = RU.SYSID
	INNER JOIN T_RIGHT_FUNCTION_GROUP RFG WITH(NOLOCK) ON
		R.FUNCTION_GROUP_SYSID = RFG.SYSID
	INNER JOIN T_RIGHT_LK_FUNCTION_GROUP RLFG WITH(NOLOCK) ON
		RFG.SYSID = RLFG.GROUP_SYSID
	INNER JOIN T_RIGHT_FUNCTION RF WITH(NOLOCK) ON
		R.FUNCTION_SYSID = RF.SYSID
		AND RF.SYSID = RLFG.FUNCTION_SYSID
	INNER JOIN T_RIGHT_LK_FUNCTION_COMMAND RLFC WITH(NOLOCK) ON
		RF.SYSID = RLFC.FUNCTION_SYSID
	LEFT JOIN T_DICTIONARY_ITEM DI WITH(NOLOCK) ON
		R.COMMAND_SYSID = DI.SYSID
		AND DI.SYSID = RLFC.COMMAND_SYSID
        AND DI.DICTIONARY_CODE = 'FunctionCommand' 
WHERE 1 = 1 ";

            var dict = new Dictionary<QueryConditionField, string>
                           {
                               {QueryConditionField.UserId, " AND RU.USER_ID = "}
                           };
            var builder = new QueryConditionBuilder(queryCondition, dict);
            sql += builder.Build();

            sql += " ORDER BY RFG.SEQUENCE,RLFG.SEQUENCE ";

            return Dapper.Query<ViewRight>(sql, queryCondition);
        }
    }
}
