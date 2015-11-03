using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace TelerikWinformBase
{
    public class RightUserGroupDal
    {
        #region 自动生成部分

        public static List<RightUserGroup> QueryAll()
        {
            const string sql = @"
SELECT A.SYSID AS Sysid,A.GROUP_NAME AS GroupName,A.WORKSHOP AS Workshop,A.CREATED_ON AS CreatedOn,A.CREATED_BY AS CreatedBy,A.MODIFIED_ON AS ModifiedOn,A.MODIFIED_BY AS ModifiedBy,A.RECORD_STATUS AS RecordStatus
FROM T_RIGHT_USER_GROUP AS A WITH(NOLOCK) 
WHERE 1=1 
ORDER BY A.GROUP_NAME
";

            return Dapper.Query<RightUserGroup>(sql, null);
        }

        public static RightUserGroup QuerySingle(String sysid)
        {
            const string sql = @"
SELECT SYSID AS Sysid,GROUP_NAME AS GroupName,WORKSHOP AS Workshop,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy,MODIFIED_ON AS ModifiedOn,MODIFIED_BY AS ModifiedBy,RECORD_STATUS AS RecordStatus
FROM T_RIGHT_USER_GROUP WITH(NOLOCK) 
WHERE SYSID=@Sysid

";

            return Dapper.QuerySingle<RightUserGroup>(sql, new { Sysid = sysid });
        }

        public static bool Insert(RightUserGroup rightUserGroup)
        {
            const string sql = @"
INSERT INTO T_RIGHT_USER_GROUP(SYSID,GROUP_NAME,WORKSHOP,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS)
VALUES(@Sysid,@GroupName,@Workshop,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus)

";

            return Dapper.Save(rightUserGroup, sql);
        }

        public static bool Insert(RightUserGroup rightUserGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
INSERT INTO T_RIGHT_USER_GROUP(SYSID,GROUP_NAME,WORKSHOP,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS)
VALUES(@Sysid,@GroupName,@Workshop,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus)

";

            return Dapper.Save(rightUserGroup, sql, conn, trans);
        }

        public static bool Update(RightUserGroup rightUserGroup)
        {
            const string sql = @"
UPDATE T_RIGHT_USER_GROUP
SET GROUP_NAME=@GroupName,WORKSHOP=@Workshop,CREATED_BY=@CreatedBy,MODIFIED_ON=CONVERT(NVARCHAR(50),GETDATE(),121),MODIFIED_BY=@ModifiedBy,RECORD_STATUS=@RecordStatus
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightUserGroup, sql);
        }

        public static bool Update(RightUserGroup rightUserGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
UPDATE T_RIGHT_USER_GROUP
SET GROUP_NAME=@GroupName,WORKSHOP=@Workshop,CREATED_BY=@CreatedBy,MODIFIED_ON=CONVERT(NVARCHAR(50),GETDATE(),121),MODIFIED_BY=@ModifiedBy,RECORD_STATUS=@RecordStatus
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightUserGroup, sql, conn, trans);
        }

        public static bool Delete(RightUserGroup rightUserGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_USER_GROUP
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightUserGroup, sql, conn, trans);
        }

        public static bool BatchInsert(List<RightUserGroup> rightUserGroups)
        {
            const string sql = @"
INSERT INTO T_RIGHT_USER_GROUP(SYSID,GROUP_NAME,WORKSHOP,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS)
VALUES(@Sysid,@GroupName,@Workshop,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus)

";

            return Dapper.Save(rightUserGroups, sql);
        }

        #endregion

        public static bool Delete(RightUserGroup rightUserGroup)
        {
            using (var conn = new SqlConnection(Conn.getConn()))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    //1、删除用户组
                    var result = Delete(rightUserGroup, conn, trans);
                    if (!result)
                    {
                        trans.Rollback();
                        return false;
                    }
                    //2、删除当前组对应的用户分组信息
                    RightLkUserGroupDal.DeleteByGroupSysid(new RightLkUserGroup { GroupSysid = rightUserGroup.Sysid }, conn, trans);

                    //3、删除当前组对应的权限分配信息
                    RightDal.DeleteByUserGroupSysid(new Right { UserGroupSysid = rightUserGroup.Sysid }, conn, trans);

                    trans.Commit();
                }

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return true;
        }

        public static List<RightUserGroup> QueryRightUserGroup(QueryCondition queryCondition)
        {
            var sql = @"
SELECT SYSID AS Sysid,GROUP_NAME AS GroupName,WORKSHOP AS Workshop,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy,MODIFIED_ON AS ModifiedOn,MODIFIED_BY AS ModifiedBy,RECORD_STATUS AS RecordStatus
FROM T_RIGHT_USER_GROUP WITH(NOLOCK) 
WHERE 1=1 

";

            var dict = new Dictionary<QueryConditionField, string>
                           {
                               {QueryConditionField.WORKSHOP, " AND WORKSHOP = "},
                               {QueryConditionField.Name, " AND GROUP_NAME = "}
                           };
            var builder = new QueryConditionBuilder(queryCondition, dict);
            sql += builder.Build();

            sql += " ORDER BY RECORD_STATUS DESC,MODIFIED_ON DESC ";

            return Dapper.Query<RightUserGroup>(sql, queryCondition);
        }
    }
}
