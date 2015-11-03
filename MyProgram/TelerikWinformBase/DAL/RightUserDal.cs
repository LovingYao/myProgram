using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace TelerikWinformBase
{
    public class RightUserDal
    {
        #region 自动生成部分

        public static List<RightUser> QueryAll()
        {
            const string sql = @"
SELECT A.SYSID AS Sysid,A.USER_ID AS UserId,A.USER_NAME AS UserName,A.USER_PWD AS UserPwd,A.DEPARTMENT AS Department,A.EMAIL AS Email,A.CREATED_ON AS CreatedOn,A.CREATED_BY AS CreatedBy,A.MODIFIED_ON AS ModifiedOn,A.MODIFIED_BY AS ModifiedBy,A.RECORD_STATUS AS RecordStatus,A.RESV01 AS Resv01,A.RESV02 AS Resv02,A.RESV03 AS Resv03,A.RESV04 AS Resv04,A.RESV05 AS Resv05,A.RESV06 AS Resv06,A.RESV07 AS Resv07,A.RESV08 AS Resv08,A.RESV09 AS Resv09,A.RESV10 AS Resv10
FROM T_RIGHT_USER AS A WITH(NOLOCK) 
WHERE 1=1 

";

            return Dapper.Query<RightUser>(sql, null);
        }

        public static RightUser QuerySingle(String sysid)
        {
            const string sql = @"
SELECT SYSID AS Sysid,USER_ID AS UserId,USER_NAME AS UserName,USER_PWD AS UserPwd,DEPARTMENT AS Department,EMAIL AS Email,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy,MODIFIED_ON AS ModifiedOn,MODIFIED_BY AS ModifiedBy,RECORD_STATUS AS RecordStatus,RESV01 AS Resv01,RESV02 AS Resv02,RESV03 AS Resv03,RESV04 AS Resv04,RESV05 AS Resv05,RESV06 AS Resv06,RESV07 AS Resv07,RESV08 AS Resv08,RESV09 AS Resv09,RESV10 AS Resv10
FROM T_RIGHT_USER WITH(NOLOCK) 
WHERE SYSID=@Sysid

";

            return Dapper.QuerySingle<RightUser>(sql, new { Sysid = sysid });
        }

        public static bool Insert(RightUser rightUser)
        {
            const string sql = @"
INSERT INTO T_RIGHT_USER(SYSID,USER_ID,USER_NAME,USER_PWD,DEPARTMENT,EMAIL,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS,RESV01,RESV02,RESV03,RESV04,RESV05,RESV06,RESV07,RESV08,RESV09,RESV10)
VALUES(@Sysid,@UserId,@UserName,@UserPwd,@Department,@Email,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus,@Resv01,@Resv02,@Resv03,@Resv04,@Resv05,@Resv06,@Resv07,@Resv08,@Resv09,@Resv10)

";

            return Dapper.Save(rightUser, sql);
        }

        public static bool Insert(RightUser rightUser, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
INSERT INTO T_RIGHT_USER(SYSID,USER_ID,USER_NAME,USER_PWD,DEPARTMENT,EMAIL,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS,RESV01,RESV02,RESV03,RESV04,RESV05,RESV06,RESV07,RESV08,RESV09,RESV10)
VALUES(@Sysid,@UserId,@UserName,@UserPwd,@Department,@Email,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus,@Resv01,@Resv02,@Resv03,@Resv04,@Resv05,@Resv06,@Resv07,@Resv08,@Resv09,@Resv10)

";

            return Dapper.Save(rightUser, sql, conn, trans);
        }

        public static bool Update(RightUser rightUser)
        {
            const string sql = @"
UPDATE T_RIGHT_USER
SET USER_ID=@UserId,USER_NAME=@UserName,USER_PWD=@UserPwd,DEPARTMENT=@Department,EMAIL=@Email,CREATED_BY=@CreatedBy,MODIFIED_ON=CONVERT(NVARCHAR(50),GETDATE(),121),MODIFIED_BY=@ModifiedBy,RECORD_STATUS=@RecordStatus,RESV01=@Resv01,RESV02=@Resv02,RESV03=@Resv03,RESV04=@Resv04,RESV05=@Resv05,RESV06=@Resv06,RESV07=@Resv07,RESV08=@Resv08,RESV09=@Resv09,RESV10=@Resv10
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightUser, sql);
        }

        public static bool Update(RightUser rightUser, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
UPDATE T_RIGHT_USER
SET USER_ID=@UserId,USER_NAME=@UserName,USER_PWD=@UserPwd,DEPARTMENT=@Department,,EMAIL=@Email,CREATED_BY=@CreatedBy,MODIFIED_ON=CONVERT(NVARCHAR(50),GETDATE(),121),MODIFIED_BY=@ModifiedBy,RECORD_STATUS=@RecordStatus,RESV01=@Resv01,RESV02=@Resv02,RESV03=@Resv03,RESV04=@Resv04,RESV05=@Resv05,RESV06=@Resv06,RESV07=@Resv07,RESV08=@Resv08,RESV09=@Resv09,RESV10=@Resv10
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightUser, sql, conn, trans);
        }

        public static bool Delete(RightUser rightUser, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_USER
WHERE SYSID=@Sysid

";

            return Dapper.Save(rightUser, sql, conn, trans);
        }

        public static bool BatchInsert(List<RightUser> rightUsers)
        {
            const string sql = @"
INSERT INTO T_RIGHT_USER(SYSID,USER_ID,USER_NAME,USER_PWD,DEPARTMENT,EMAIL,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS,RESV01,RESV02,RESV03,RESV04,RESV05,RESV06,RESV07,RESV08,RESV09,RESV10)
VALUES(@Sysid,@UserId,@UserName,@UserPwd,@Department,@Email,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus,@Resv01,@Resv02,@Resv03,@Resv04,@Resv05,@Resv06,@Resv07,@Resv08,@Resv09,@Resv10)

";

            return Dapper.Save(rightUsers, sql);
        }

        #endregion

        public static bool Delete(RightUser rightUser)
        {
            using (var conn = new SqlConnection(Conn.getConn()))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    //1、删除用户信息
                    var result = Delete(rightUser, conn, trans);
                    if (!result)
                    {
                        trans.Rollback();
                        return false;
                    }
                    //2、删除当前用户对应的用户分组信息
                    RightLkUserGroupDal.DeleteByUserSysid(new RightLkUserGroup { UserSysid = rightUser.Sysid }, conn, trans);

                    trans.Commit();
                }

                if (conn.State != ConnectionState.Closed)
                    conn.Close();
            }

            return true;
        }

        public static List<RightUser> QueryRightUser(QueryCondition queryCondition)
        {
            var sql = @"
SELECT T_RIGHT_USER.SYSID AS Sysid,T_RIGHT_USER.USER_ID AS UserId,
T_RIGHT_USER.USER_NAME AS UserName,T_RIGHT_USER.USER_PWD AS UserPwd,
T_RIGHT_USER.DEPARTMENT AS Department,T_RIGHT_USER.EMAIL AS Email,
T_RIGHT_USER.CREATED_ON AS CreatedOn,T_RIGHT_USER.CREATED_BY AS CreatedBy,
T_RIGHT_USER.MODIFIED_ON AS ModifiedOn,T_RIGHT_USER.MODIFIED_BY AS ModifiedBy,
T_RIGHT_USER.RECORD_STATUS AS RecordStatus,
T_RIGHT_USER.RESV01 AS Resv01,T_RIGHT_USER.RESV02 AS Resv02,T_RIGHT_USER.RESV03 AS Resv03,T_RIGHT_USER.RESV04 AS Resv04,
T_RIGHT_USER.RESV05 AS Resv05,T_RIGHT_USER.RESV06 AS Resv06,T_RIGHT_USER.RESV07 AS Resv07,
T_RIGHT_USER.RESV08 AS Resv08,T_RIGHT_USER.RESV09 AS Resv09,T_RIGHT_USER.RESV10 AS Resv10,
T_DICTIONARY_ITEM.NAME DepartmentName
FROM T_RIGHT_USER WITH(NOLOCK) 
	LEFT JOIN T_DICTIONARY_ITEM WITH(NOLOCK) ON
		T_RIGHT_USER.DEPARTMENT=T_DICTIONARY_ITEM.CODE
		AND T_DICTIONARY_ITEM.DICTIONARY_CODE = 'Department'
WHERE 1 = 1 ";

            var dict = new Dictionary<QueryConditionField, string>
                           {
                               {QueryConditionField.DepartmentCode, " AND T_RIGHT_USER.DEPARTMENT = "},
                               {QueryConditionField.UserId, " AND T_RIGHT_USER.USER_ID = "}
                           };
            var builder = new QueryConditionBuilder(queryCondition, dict);
            sql += builder.Build();

            sql += " ORDER BY T_RIGHT_USER.RECORD_STATUS DESC,T_RIGHT_USER.MODIFIED_ON DESC ";

            return Dapper.Query<RightUser>(sql, queryCondition);
        }

        public static List<RightUser> QueryRightUserByUserId(String userId)
        {
            const string sql = @"
SELECT SYSID AS Sysid,USER_ID AS UserId,USER_NAME AS UserName,USER_PWD AS UserPwd,DEPARTMENT AS Department,EMAIL AS Email,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy,MODIFIED_ON AS ModifiedOn,MODIFIED_BY AS ModifiedBy,RECORD_STATUS AS RecordStatus,RESV01 AS Resv01,RESV02 AS Resv02,RESV03 AS Resv03,RESV04 AS Resv04,RESV05 AS Resv05,RESV06 AS Resv06,RESV07 AS Resv07,RESV08 AS Resv08,RESV09 AS Resv09,RESV10 AS Resv10
FROM T_RIGHT_USER WITH(NOLOCK) 
WHERE USER_ID=@UserId

";

            return Dapper.Query<RightUser>(sql, new { UserId = userId });
        }

        public static bool IsAdmin(QueryCondition queryCondition)
        {
            var isAdmin = false;

            var sql = @"
 SELECT A.SYSID AS Sysid,A.USER_ID AS UserId,A.USER_NAME AS UserName,A.USER_PWD AS UserPwd,A.DEPARTMENT AS Department,A.EMAIL AS Email,A.CREATED_ON AS CreatedOn,A.CREATED_BY AS CreatedBy,A.MODIFIED_ON AS ModifiedOn,A.MODIFIED_BY AS ModifiedBy,A.RECORD_STATUS AS RecordStatus,A.RESV01 AS Resv01,A.RESV02 AS Resv02,A.RESV03 AS Resv03,A.RESV04 AS Resv04,A.RESV05 AS Resv05,A.RESV06 AS Resv06,A.RESV07 AS Resv07,A.RESV08 AS Resv08,A.RESV09 AS Resv09,A.RESV10 AS Resv10 
  FROM T_RIGHT_USER A WITH(NOLOCK)
  INNER JOIN  T_RIGHT_LK_USER_GROUP B WITH(NOLOCK) ON A.SYSID = B.USER_SYSID
  INNER JOIN T_RIGHT_USER_GROUP C WITH(NOLOCK) ON B.GROUP_SYSID = C.SYSID
  WHERE C.GROUP_NAME = '系统管理员'
";

            var dict = new Dictionary<QueryConditionField, string>
                           {
                               {QueryConditionField.UserId, " AND A.USER_ID = "}
                           };
            var builder = new QueryConditionBuilder(queryCondition, dict);
            sql += builder.Build();

            var userlist = Dapper.Query<RightUser>(sql, queryCondition);
            if (userlist.Count > 0)
                isAdmin = true;

            return isAdmin;
        }
    }

    
}
