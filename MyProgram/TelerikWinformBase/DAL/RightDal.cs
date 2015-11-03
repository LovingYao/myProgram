using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TelerikWinformBase
{
    public class RightDal
    {
        #region 自动生成部分

        public static List<Right> QueryAll()
        {
            const string sql = @"
SELECT A.SYSID AS Sysid,A.USER_GROUP_SYSID AS UserGroupSysid,A.FUNCTION_GROUP_SYSID AS FunctionGroupSysid,A.FUNCTION_SYSID AS FunctionSysid,A.COMMAND_SYSID AS CommandSysid,A.CREATED_ON AS CreatedOn,A.CREATED_BY AS CreatedBy
FROM T_RIGHT AS A WITH(NOLOCK) 
WHERE 1=1 

";

            return Dapper.Query<Right>(sql, null);
        }

        public static Right QuerySingle(String sysid)
        {
            const string sql = @"
SELECT SYSID AS Sysid,USER_GROUP_SYSID AS UserGroupSysid,FUNCTION_GROUP_SYSID AS FunctionGroupSysid,FUNCTION_SYSID AS FunctionSysid,COMMAND_SYSID AS CommandSysid,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy
FROM T_RIGHT WITH(NOLOCK) 
WHERE SYSID=@Sysid

";

            return Dapper.QuerySingle<Right>(sql, new { Sysid = sysid });
        }

        public static bool Insert(Right right)
        {
            const string sql = @"
INSERT INTO T_RIGHT(SYSID,USER_GROUP_SYSID,FUNCTION_GROUP_SYSID,FUNCTION_SYSID,COMMAND_SYSID,CREATED_ON,CREATED_BY)
VALUES(@Sysid,@UserGroupSysid,@FunctionGroupSysid,@FunctionSysid,@CommandSysid,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy)

";

            return Dapper.Save(right, sql);
        }

        public static bool Insert(Right right, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
INSERT INTO T_RIGHT(SYSID,USER_GROUP_SYSID,FUNCTION_GROUP_SYSID,FUNCTION_SYSID,COMMAND_SYSID,CREATED_ON,CREATED_BY)
VALUES(@Sysid,@UserGroupSysid,@FunctionGroupSysid,@FunctionSysid,@CommandSysid,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy)

";

            return Dapper.Save(right, sql, conn, trans);
        }

        public static bool Update(Right right)
        {
            const string sql = @"
UPDATE T_RIGHT
SET USER_GROUP_SYSID=@UserGroupSysid,FUNCTION_GROUP_SYSID=@FunctionGroupSysid,FUNCTION_SYSID=@FunctionSysid,COMMAND_SYSID=@CommandSysid,CREATED_BY=@CreatedBy
WHERE SYSID=@Sysid

";

            return Dapper.Save(right, sql);
        }

        public static bool Update(Right right, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
UPDATE T_RIGHT
SET USER_GROUP_SYSID=@UserGroupSysid,FUNCTION_GROUP_SYSID=@FunctionGroupSysid,FUNCTION_SYSID=@FunctionSysid,COMMAND_SYSID=@CommandSysid,CREATED_BY=@CreatedBy
WHERE SYSID=@Sysid

";

            return Dapper.Save(right, sql, conn, trans);
        }

        public static bool Delete(Right right)
        {
            const string sql = @"
DELETE FROM T_RIGHT
WHERE SYSID=@Sysid

";

            return Dapper.Save(right, sql);
        }

        public static bool Delete(Right right, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT
WHERE SYSID=@Sysid

";

            return Dapper.Save(right, sql, conn, trans);
        }

        public static bool BatchInsert(List<Right> rights)
        {
            const string sql = @"
INSERT INTO T_RIGHT(SYSID,USER_GROUP_SYSID,FUNCTION_GROUP_SYSID,FUNCTION_SYSID,COMMAND_SYSID,CREATED_ON,CREATED_BY)
VALUES(@Sysid,@UserGroupSysid,@FunctionGroupSysid,@FunctionSysid,@CommandSysid,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy)

";

            return Dapper.Save(rights, sql);
        }

        #endregion

        public static bool DeleteByFunctionGroupSysid(Right right, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT
WHERE FUNCTION_GROUP_SYSID=@FunctionGroupSysid

";

            return Dapper.Save(right, sql, conn, trans);
        }

        public static bool DeleteByFunctionSysid(Right right, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT
WHERE FUNCTION_SYSID=@FunctionSysid

";

            return Dapper.Save(right, sql, conn, trans);
        }

        public static bool DeleteByUserGroupSysid(Right right, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT
WHERE USER_GROUP_SYSID=@UserGroupSysid

";

            return Dapper.Save(right, sql, conn, trans);
        }

        public static bool Delete(RightLkFunctionCommand rightLKFunctionCommand, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT
WHERE FUNCTION_SYSID=@FunctionSysid
    AND COMMAND_SYSID=@CommandSysid ";

            return Dapper.Save(rightLKFunctionCommand, sql, conn, trans);
        }

        public static bool Delete(RightLkFunctionGroup rightLKFunctionGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT
WHERE FUNCTION_SYSID=@FunctionSysid
    AND FUNCTION_GROUP_SYSID=@GroupSysid ";

            return Dapper.Save(rightLKFunctionGroup, sql, conn, trans);
        }

        public static List<RightMenu> QueryAllRightMenu()
        {
            const string sql = @"
SELECT RFG.SYSID GroupSysid,RFG.GROUP_NAME GroupName
	,RF.SYSID FunctionSysid,RF.FUNC_NAME FunctionName
	,DI.SYSID CommandSysid,DI.NAME CommandName
FROM T_RIGHT_FUNCTION_GROUP RFG WITH(NOLOCK)
	INNER JOIN T_RIGHT_LK_FUNCTION_GROUP RLKFG WITH(NOLOCK) ON
		RFG.SYSID = RLKFG.GROUP_SYSID
	INNER JOIN T_RIGHT_FUNCTION RF WITH(NOLOCK) ON
		RLKFG.FUNCTION_SYSID = RF.SYSID
	INNER JOIN T_RIGHT_LK_FUNCTION_COMMAND RLKFC WITH(NOLOCK) ON
		RF.SYSID = RLKFC.FUNCTION_SYSID
	INNER JOIN T_DICTIONARY_ITEM DI WITH(NOLOCK) ON
		RLKFC.COMMAND_SYSID = DI.SYSID
		AND DI.DICTIONARY_CODE = 'FunctionCommand'
ORDER BY RFG.SEQUENCE,RLKFG.SEQUENCE,DI.SYSID ";

            return Dapper.Query<RightMenu>(sql, null);
        }

        public static List<Right> QueryByUserGroupSysid(string userGroupSysid)
        {
            const string sql = @"
SELECT SYSID AS Sysid,USER_GROUP_SYSID AS UserGroupSysid,FUNCTION_GROUP_SYSID AS FunctionGroupSysid,FUNCTION_SYSID AS FunctionSysid,COMMAND_SYSID AS CommandSysid,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy
FROM T_RIGHT WITH(NOLOCK) 
WHERE 1 = 1 
    AND USER_GROUP_SYSID = @UserGroupSysid
";

            return Dapper.Query<Right>(sql, new { UserGroupSysid = userGroupSysid });
        }

        public static bool Save(string userGroupSysid, List<Right> rights)
        {
            using (var conn = new SqlConnection(Conn.getConn()))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    DeleteByUserGroupSysid(new Right { UserGroupSysid = userGroupSysid }, conn, trans);

                    foreach (var item in rights)
                    {
                        var result = Insert(item, conn, trans);
                        if (result)
                            continue;

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

        public static List<Right> QueryByCommandSysid(string commandSysid)
        {
            const string sql = @"
SELECT SYSID AS Sysid,USER_GROUP_SYSID AS UserGroupSysid,FUNCTION_GROUP_SYSID AS FunctionGroupSysid,FUNCTION_SYSID AS FunctionSysid,COMMAND_SYSID AS CommandSysid,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy
FROM T_RIGHT WITH(NOLOCK) 
WHERE COMMAND_SYSID=@CommandSysid ";

            return Dapper.Query<Right>(sql, new { CommandSysid = commandSysid });
        }
    }
}
