using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace TelerikWinformBase
{
    public class RightFunctionDal
    {
        #region 自动生成部分

        public static List<RightFunction> QueryAll()
        {
            const string sql = @"
SELECT A.SYSID AS Sysid,A.FUNC_CODE AS FuncCode,A.FUNC_NAME AS FuncName,A.FUNC_PARAM AS FuncParam,A.CREATED_ON AS CreatedOn,A.CREATED_BY AS CreatedBy,A.MODIFIED_ON AS ModifiedOn,A.MODIFIED_BY AS ModifiedBy,A.RECORD_STATUS AS RecordStatus
FROM T_RIGHT_FUNCTION AS A WITH(NOLOCK) 
WHERE 1=1 

";

            return Dapper.Query<RightFunction>(sql, null);
        }

        public static RightFunction QuerySingle(String sysid)
        {
            const string sql = @"
SELECT SYSID AS Sysid,FUNC_CODE AS FuncCode,FUNC_NAME AS FuncName,FUNC_PARAM AS FuncParam,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy,MODIFIED_ON AS ModifiedOn,MODIFIED_BY AS ModifiedBy,RECORD_STATUS AS RecordStatus
FROM T_RIGHT_FUNCTION WITH(NOLOCK) 
WHERE SYSID=@Sysid

";

            return Dapper.QuerySingle<RightFunction>(sql, new { Sysid = sysid });
        }

        public static bool Insert(RightFunction rightFunction)
        {
            const string sql = @"
INSERT INTO T_RIGHT_FUNCTION(SYSID,FUNC_CODE,FUNC_NAME,FUNC_PARAM,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS)
VALUES(@Sysid,@FuncCode,@FuncName,@FuncParam,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus)

";

            return Dapper.Save(rightFunction, sql);
        }

        public static bool Insert(RightFunction rightFunction, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
INSERT INTO T_RIGHT_FUNCTION(SYSID,FUNC_CODE,FUNC_NAME,FUNC_PARAM,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS)
VALUES(@Sysid,@FuncCode,@FuncName,@FuncParam,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus)

";

            return Dapper.Save(rightFunction, sql, conn, trans);
        }

        public static bool Update(RightFunction rightFunction)
        {
            const string sql = @"
UPDATE T_RIGHT_FUNCTION
SET FUNC_CODE=@FuncCode,FUNC_NAME=@FuncName,FUNC_PARAM=@FuncParam,CREATED_BY=@CreatedBy,MODIFIED_ON=CONVERT(NVARCHAR(50),GETDATE(),121),MODIFIED_BY=@ModifiedBy,RECORD_STATUS=@RecordStatus
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightFunction, sql);
        }

        public static bool Update(RightFunction rightFunction, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
UPDATE T_RIGHT_FUNCTION
SET FUNC_CODE=@FuncCode,FUNC_NAME=@FuncName,FUNC_PARAM=@FuncParam,CREATED_BY=@CreatedBy,MODIFIED_ON=CONVERT(NVARCHAR(50),GETDATE(),121),MODIFIED_BY=@ModifiedBy,RECORD_STATUS=@RecordStatus
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightFunction, sql, conn, trans);
        }

        public static bool Delete(RightFunction rightFunction, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_FUNCTION
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightFunction, sql, conn, trans);
        }

        public static bool BatchInsert(List<RightFunction> rightFunctions)
        {
            const string sql = @"
INSERT INTO T_RIGHT_FUNCTION(SYSID,FUNC_CODE,FUNC_NAME,FUNC_PARAM,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS)
VALUES(@Sysid,@FuncCode,@FuncName,@FuncParam,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus)

";

            return Dapper.Save(rightFunctions, sql);
        }

        #endregion

        public static bool Delete(RightFunction rightFunction)
        {
            using (var conn = new SqlConnection(Conn.getConn()))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    //1、删除功能信息
                    var result = Delete(rightFunction, conn, trans);
                    if (!result)
                    {
                        trans.Rollback();
                        return false;
                    }
                    //2、删除当前功能对应的功能分组信息
                    RightLkFunctionGroupDal.DeleteByFunctionSysid(new RightLkFunctionGroup { FunctionSysid = rightFunction.Sysid }, conn, trans);

                    //3、删除当前功能对应的功能命令信息
                    RightLkFunctionCommandDal.DeleteByFunctionSysid(new RightLkFunctionCommand { FunctionSysid = rightFunction.Sysid }, conn, trans);

                    //4、删除当前功能对应的权限分配信息
                    RightDal.DeleteByFunctionSysid(new Right { FunctionSysid = rightFunction.Sysid }, conn, trans);

                    trans.Commit();
                }

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return true;
        }

        public static List<RightFunction> QueryRightFunction(QueryCondition queryCondition)
        {
            var sql = @"
SELECT SYSID AS Sysid,FUNC_CODE AS FuncCode,FUNC_NAME AS FuncName,FUNC_PARAM AS FuncParam
    ,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy,MODIFIED_ON AS ModifiedOn
    ,MODIFIED_BY AS ModifiedBy,RECORD_STATUS AS RecordStatus
FROM T_RIGHT_FUNCTION WITH(NOLOCK) 
WHERE 1=1 

";

            var dict = new Dictionary<QueryConditionField, string>
                           {
                               {QueryConditionField.Code, " AND FUNC_CODE = "},
                               {QueryConditionField.Name, " AND FUNC_NAME = "}
                           };
            var builder = new QueryConditionBuilder(queryCondition, dict);
            sql += builder.Build();

            sql += " ORDER BY RECORD_STATUS DESC,MODIFIED_ON DESC ";

            return Dapper.Query<RightFunction>(sql, queryCondition);
        }

        public static List<RightFunction> QueryMutileFunction(RightFunction rightFunction)
        {
            const string sql = @"
SELECT SYSID AS Sysid,FUNC_CODE AS FuncCode,FUNC_NAME AS FuncName,FUNC_PARAM AS FuncParam
    ,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy,MODIFIED_ON AS ModifiedOn
    ,MODIFIED_BY AS ModifiedBy,RECORD_STATUS AS RecordStatus
FROM T_RIGHT_FUNCTION WITH(NOLOCK) 
WHERE 1 = 1
	AND FUNC_CODE = @FuncCode 
    AND FUNC_PARAM = @FuncParam ";

            return Dapper.Query<RightFunction>(sql, rightFunction);
        }
    }
}
