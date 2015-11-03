using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TelerikWinformBase
{
    public class RightFunctionGroupDal
    {
        #region 自动生成部分

        public static List<RightFunctionGroup> QueryAll()
        {
            const string sql = @"
SELECT A.SYSID AS Sysid,A.GROUP_NAME AS GroupName,A.SEQUENCE AS Sequence,A.GROUP_NAME_CN AS GroupNameCn,A.GROUP_NAME_US AS GroupNameUs,A.GROUP_NAME_TW AS GroupNameTw,A.GROUP_NAME_EN AS GroupNameEn,A.GROUP_NAME_GE AS GroupNameGe,A.GROUP_NAME_VI AS GroupNameVi,A.GROUP_NAME_JP AS GroupNameJp,A.GROUP_NAME_KO AS GroupNameKo,A.GROUP_NAME_FR AS GroupNameFr,A.CREATED_ON AS CreatedOn,A.CREATED_BY AS CreatedBy,A.MODIFIED_ON AS ModifiedOn,A.MODIFIED_BY AS ModifiedBy,A.RECORD_STATUS AS RecordStatus
FROM T_RIGHT_FUNCTION_GROUP AS A WITH(NOLOCK) 
WHERE 1=1 

";

            return Dapper.Query<RightFunctionGroup>(sql, null);
        }

        public static RightFunctionGroup QuerySingle(String sysid)
        {
            const string sql = @"
SELECT SYSID AS Sysid,GROUP_NAME AS GroupName,SEQUENCE AS Sequence,GROUP_NAME_CN AS GroupNameCn,GROUP_NAME_US AS GroupNameUs,GROUP_NAME_TW AS GroupNameTw,GROUP_NAME_EN AS GroupNameEn,GROUP_NAME_GE AS GroupNameGe,GROUP_NAME_VI AS GroupNameVi,GROUP_NAME_JP AS GroupNameJp,GROUP_NAME_KO AS GroupNameKo,GROUP_NAME_FR AS GroupNameFr,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy,MODIFIED_ON AS ModifiedOn,MODIFIED_BY AS ModifiedBy,RECORD_STATUS AS RecordStatus
FROM T_RIGHT_FUNCTION_GROUP WITH(NOLOCK) 
WHERE SYSID=@Sysid

";

            return Dapper.QuerySingle<RightFunctionGroup>(sql, new { Sysid = sysid });
        }

        public static bool Insert(RightFunctionGroup rightFunctionGroup)
        {
            const string sql = @"
INSERT INTO T_RIGHT_FUNCTION_GROUP(SYSID,GROUP_NAME,SEQUENCE,GROUP_NAME_CN,GROUP_NAME_US,GROUP_NAME_TW,GROUP_NAME_EN,GROUP_NAME_GE,GROUP_NAME_VI,GROUP_NAME_JP,GROUP_NAME_KO,GROUP_NAME_FR,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS)
VALUES(@Sysid,@GroupName,@Sequence,@GroupNameCn,@GroupNameUs,@GroupNameTw,@GroupNameEn,@GroupNameGe,@GroupNameVi,@GroupNameJp,@GroupNameKo,@GroupNameFr,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus)

";

            return Dapper.Save(rightFunctionGroup, sql);
        }

        public static bool Insert(RightFunctionGroup rightFunctionGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
INSERT INTO T_RIGHT_FUNCTION_GROUP(SYSID,GROUP_NAME,SEQUENCE,GROUP_NAME_CN,GROUP_NAME_US,GROUP_NAME_TW,GROUP_NAME_EN,GROUP_NAME_GE,GROUP_NAME_VI,GROUP_NAME_JP,GROUP_NAME_KO,GROUP_NAME_FR,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS)
VALUES(@Sysid,@GroupName,@Sequence,@GroupNameCn,@GroupNameUs,@GroupNameTw,@GroupNameEn,@GroupNameGe,@GroupNameVi,@GroupNameJp,@GroupNameKo,@GroupNameFr,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus)

";

            return Dapper.Save(rightFunctionGroup, sql, conn, trans);
        }

        public static bool Update(RightFunctionGroup rightFunctionGroup)
        {
            const string sql = @"
UPDATE T_RIGHT_FUNCTION_GROUP
SET GROUP_NAME=@GroupName,SEQUENCE=@Sequence,GROUP_NAME_CN=@GroupNameCn,GROUP_NAME_US=@GroupNameUs,GROUP_NAME_TW=@GroupNameTw,GROUP_NAME_EN=@GroupNameEn,GROUP_NAME_GE=@GroupNameGe,GROUP_NAME_VI=@GroupNameVi,GROUP_NAME_JP=@GroupNameJp,GROUP_NAME_KO=@GroupNameKo,GROUP_NAME_FR=@GroupNameFr,CREATED_BY=@CreatedBy,MODIFIED_ON=CONVERT(NVARCHAR(50),GETDATE(),121),MODIFIED_BY=@ModifiedBy,RECORD_STATUS=@RecordStatus
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightFunctionGroup, sql);
        }

        public static bool Update(RightFunctionGroup rightFunctionGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
UPDATE T_RIGHT_FUNCTION_GROUP
SET GROUP_NAME=@GroupName,SEQUENCE=@Sequence,GROUP_NAME_CN=@GroupNameCn,GROUP_NAME_US=@GroupNameUs,GROUP_NAME_TW=@GroupNameTw,GROUP_NAME_EN=@GroupNameEn,GROUP_NAME_GE=@GroupNameGe,GROUP_NAME_VI=@GroupNameVi,GROUP_NAME_JP=@GroupNameJp,GROUP_NAME_KO=@GroupNameKo,GROUP_NAME_FR=@GroupNameFr,CREATED_BY=@CreatedBy,MODIFIED_ON=CONVERT(NVARCHAR(50),GETDATE(),121),MODIFIED_BY=@ModifiedBy,RECORD_STATUS=@RecordStatus
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightFunctionGroup, sql, conn, trans);
        }

        public static bool Delete(RightFunctionGroup rightFunctionGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_FUNCTION_GROUP
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightFunctionGroup, sql, conn, trans);
        }

        public static bool BatchInsert(List<RightFunctionGroup> rightFunctionGroups)
        {
            const string sql = @"
INSERT INTO T_RIGHT_FUNCTION_GROUP(SYSID,GROUP_NAME,SEQUENCE,GROUP_NAME_CN,GROUP_NAME_US,GROUP_NAME_TW,GROUP_NAME_EN,GROUP_NAME_GE,GROUP_NAME_VI,GROUP_NAME_JP,GROUP_NAME_KO,GROUP_NAME_FR,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS)
VALUES(@Sysid,@GroupName,@Sequence,@GroupNameCn,@GroupNameUs,@GroupNameTw,@GroupNameEn,@GroupNameGe,@GroupNameVi,@GroupNameJp,@GroupNameKo,@GroupNameFr,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus)

";

            return Dapper.Save(rightFunctionGroups, sql);
        }

        #endregion

        public static bool Delete(RightFunctionGroup rightFunctionGroup)
        {
            using (var conn = new SqlConnection(Conn.getConn()))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    //1、删除功能组
                    var result = Delete(rightFunctionGroup, conn, trans);
                    if (!result)
                    {
                        trans.Rollback();
                        return false;
                    }
                    //2、删除当前组对应的功能分组信息
                    RightLkFunctionGroupDal.DeleteByGroupSysid(new RightLkFunctionGroup { GroupSysid = rightFunctionGroup.Sysid }, conn, trans);

                    //3、删除当前组对应的权限分配信息
                    RightDal.DeleteByFunctionGroupSysid(new Right { FunctionGroupSysid = rightFunctionGroup.Sysid }, conn, trans);

                    trans.Commit();
                }

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return true;
        }

        public static List<RightFunctionGroup> QueryRightFunctionGroup(QueryCondition queryCondition)
        {
            var sql = @"
SELECT SYSID AS Sysid,GROUP_NAME AS GroupName,SEQUENCE AS Sequence,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy,MODIFIED_ON AS ModifiedOn,MODIFIED_BY AS ModifiedBy,RECORD_STATUS AS RecordStatus
FROM T_RIGHT_FUNCTION_GROUP WITH(NOLOCK) 
WHERE 1=1 

";

            var dict = new Dictionary<QueryConditionField, string>
                           {
                               {QueryConditionField.Name, " AND GROUP_NAME = "}
                           };
            var builder = new QueryConditionBuilder(queryCondition, dict);
            sql += builder.Build();

            sql += " ORDER BY RECORD_STATUS DESC,MODIFIED_ON DESC ";

            return Dapper.Query<RightFunctionGroup>(sql, queryCondition);
        }

        public static List<RightFunctionGroup> QueryMutileRightFunctionGroup(RightFunctionGroup rightFunctionGroup)
        {
            const string sql = @"
SELECT SYSID AS Sysid,GROUP_NAME AS GroupName,SEQUENCE AS Sequence,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy,MODIFIED_ON AS ModifiedOn,MODIFIED_BY AS ModifiedBy,RECORD_STATUS AS RecordStatus
FROM T_RIGHT_FUNCTION_GROUP WITH(NOLOCK) 
WHERE 1 = 1
	AND GROUP_NAME = @GroupName ";

            return Dapper.Query<RightFunctionGroup>(sql, rightFunctionGroup);
        }
    }
}
