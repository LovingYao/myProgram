using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TelerikWinformBase
{
    public class RightLkFunctionGroupDal
    {
        #region 自动生成部分

        public static bool Insert(RightLkFunctionGroup rightLkFunctionGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
INSERT INTO T_RIGHT_LK_FUNCTION_GROUP(GROUP_SYSID,FUNCTION_SYSID,SEQUENCE)
VALUES(@GroupSysid,@FunctionSysid,@Sequence)

";

            return Dapper.Save(rightLkFunctionGroup, sql, conn, trans);
        }

        public static bool Update(RightLkFunctionGroup rightLkFunctionGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
UPDATE T_RIGHT_LK_FUNCTION_GROUP
SET SEQUENCE=@Sequence
WHERE GROUP_SYSID=@GroupSysid AND FUNCTION_SYSID=@FunctionSysid

";

            return Dapper.Save(rightLkFunctionGroup, sql, conn, trans);
        }

        public static bool Delete(RightLkFunctionGroup rightLkFunctionGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_LK_FUNCTION_GROUP
WHERE GROUP_SYSID=@GroupSysid AND FUNCTION_SYSID=@FunctionSysid

";

            return Dapper.Save(rightLkFunctionGroup, sql, conn, trans);
        }

        #endregion

        public static bool DeleteByFunctionSysid(RightLkFunctionGroup rightLkFunctionGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_LK_FUNCTION_GROUP
WHERE FUNCTION_SYSID=@FunctionSysid

";

            return Dapper.Save(rightLkFunctionGroup, sql, conn, trans);
        }

        public static bool DeleteByGroupSysid(RightLkFunctionGroup rightLkFunctionGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_LK_FUNCTION_GROUP
WHERE GROUP_SYSID=@GroupSysid

";

            return Dapper.Save(rightLkFunctionGroup, sql, conn, trans);
        }

        public static List<RightFunction> QuerySelectedFunctionByGroupSysid(string groupSysid)
        {
            const string sql = @"
SELECT B.SYSID AS Sysid,B.FUNC_CODE AS FuncCode,B.FUNC_NAME AS FuncName,B.FUNC_PARAM AS FuncParam
    ,B.CREATED_ON AS CreatedOn,B.CREATED_BY AS CreatedBy,B.MODIFIED_ON AS ModifiedOn
    ,B.MODIFIED_BY AS ModifiedBy,B.RECORD_STATUS AS RecordStatus,A.SEQUENCE AS Sequence
FROM T_RIGHT_FUNCTION B WITH(NOLOCK)
	INNER JOIN T_RIGHT_LK_FUNCTION_GROUP A WITH(NOLOCK) ON
		A.FUNCTION_SYSID = B.SYSID
        AND A.GROUP_SYSID = @GroupSysid 
ORDER BY A.SEQUENCE ";

            return Dapper.Query<RightFunction>(sql, new { GroupSysid = groupSysid });
        }

        public static List<RightFunction> QueryNotSelectedFunctionByGroupSysid(string groupSysid)
        {
            const string sql = @"
SELECT B.SYSID AS Sysid,B.FUNC_CODE AS FuncCode,B.FUNC_NAME AS FuncName,B.FUNC_PARAM AS FuncParam
    ,B.CREATED_ON AS CreatedOn,B.CREATED_BY AS CreatedBy,B.MODIFIED_ON AS ModifiedOn
    ,B.MODIFIED_BY AS ModifiedBy,B.RECORD_STATUS AS RecordStatus
FROM T_RIGHT_FUNCTION B WITH(NOLOCK)
	LEFT JOIN T_RIGHT_LK_FUNCTION_GROUP A WITH(NOLOCK) ON
		A.FUNCTION_SYSID = B.SYSID 
        AND A.GROUP_SYSID = @GroupSysid
WHERE A.FUNCTION_SYSID IS NULL
";

            return Dapper.Query<RightFunction>(sql, new { GroupSysid = groupSysid });
        }

        public static bool Save(List<RightLkFunctionGroup> insertList, List<RightLkFunctionGroup> deleteList, List<RightLkFunctionGroup> updateList)
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
                    foreach (var item in updateList)
                    {
                        var result = Update(item, conn, trans);
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
