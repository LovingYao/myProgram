using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TelerikWinformBase
{
    public class RightLkFunctionCommandDal
    {
        #region 自动生成部分

        public static List<RightLkFunctionCommand> QueryRightLkFunctionCommand(QueryCondition queryCondition)
        {
            var sql = @"
SELECT FUNCTION_SYSID AS FunctionSysid,COMMAND_SYSID AS CommandSysid
FROM T_RIGHT_LK_FUNCTION_COMMAND WITH(NOLOCK) 
WHERE 1 = 1 ";

            var dict = new Dictionary<QueryConditionField, string>
                           {
                               {QueryConditionField.Resv01, " AND FUNCTION_SYSID = "}
                           };
            var builder = new QueryConditionBuilder(queryCondition, dict);
            sql += builder.Build();

            return Dapper.Query<RightLkFunctionCommand>(sql, queryCondition);
        }

        public static bool Insert(RightLkFunctionCommand rightLkFunctionCommand, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
INSERT INTO T_RIGHT_LK_FUNCTION_COMMAND(FUNCTION_SYSID,COMMAND_SYSID)
VALUES(@FunctionSysid,@CommandSysid)

";

            return Dapper.Save(rightLkFunctionCommand, sql, conn, trans);
        }

        public static bool Delete(RightLkFunctionCommand rightLkFunctionCommand, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_LK_FUNCTION_COMMAND
WHERE FUNCTION_SYSID=@FunctionSysid AND COMMAND_SYSID=@CommandSysid

";

            return Dapper.Save(rightLkFunctionCommand, sql, conn, trans);
        }

        public static bool BatchInsert(List<RightLkFunctionCommand> rightLkFunctionCommands)
        {
            const string sql = @"
INSERT INTO T_RIGHT_LK_FUNCTION_COMMAND(FUNCTION_SYSID,COMMAND_SYSID)
VALUES(@FunctionSysid,@CommandSysid)

";

            return Dapper.Save(rightLkFunctionCommands, sql);
        }

        #endregion

        public static bool DeleteByFunctionSysid(RightLkFunctionCommand rightLkFunctionCommand, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_LK_FUNCTION_COMMAND
WHERE FUNCTION_SYSID=@FunctionSysid

";

            return Dapper.Save(rightLkFunctionCommand, sql, conn, trans);
        }

        public static bool Save(List<RightLkFunctionCommand> insertList, List<RightLkFunctionCommand> deleteList)
        {
            using (var conn = new SqlConnection(Conn.getConn()))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    foreach (var item in insertList)
                    {
                        var result = Insert(item, conn, trans);
                        if (result)
                            continue;

                        trans.Rollback();
                        return false;
                    }
                    foreach (var item in deleteList)
                    {
                        var result = Delete(item, conn, trans);
                        if (result)
                            continue;

                        RightDal.Delete(item, conn, trans);

                        trans.Rollback();
                        return false;
                    }

                    trans.Commit();
                }

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return true;
        }
    }
}
