using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace TelerikWinformBase
{
    public class RightLkUserGroupDal
    {
        #region 自动生成部分

        public static bool Insert(RightLkUserGroup rightLkUserGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
INSERT INTO T_RIGHT_LK_USER_GROUP(GROUP_SYSID,USER_SYSID)
VALUES(@GroupSysid,@UserSysid)

";

            return Dapper.Save(rightLkUserGroup, sql, conn, trans);
        }

        public static bool Delete(RightLkUserGroup rightLkUserGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_LK_USER_GROUP
WHERE GROUP_SYSID=@GroupSysid AND USER_SYSID=@UserSysid

";

            return Dapper.Save(rightLkUserGroup, sql, conn, trans);
        }

        public static bool BatchInsert(List<RightLkUserGroup> rightLkUserGroups)
        {
            const string sql = @"
INSERT INTO T_RIGHT_LK_USER_GROUP(GROUP_SYSID,USER_SYSID)
VALUES(@GroupSysid,@UserSysid)

";

            return Dapper.Save(rightLkUserGroups, sql);
        }

        #endregion

        public static bool DeleteByUserSysid(RightLkUserGroup rightLkUserGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_LK_USER_GROUP
WHERE USER_SYSID=@UserSysid

";

            return Dapper.Save(rightLkUserGroup, sql, conn, trans);
        }

        public static bool DeleteByGroupSysid(RightLkUserGroup rightLkUserGroup, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_RIGHT_LK_USER_GROUP
WHERE GROUP_SYSID=@GroupSysid

";

            return Dapper.Save(rightLkUserGroup, sql, conn, trans);
        }

        public static List<RightUser> QuerySelectedUserByGroupSysid(string groupSysid)
        {
            const string sql = @"
SELECT B.SYSID AS Sysid,B.USER_ID AS UserId,B.USER_NAME AS UserName,B.USER_PWD AS UserPwd
    ,B.DEPARTMENT AS Department
    ,B.EMAIL AS Email,B.CREATED_ON AS CreatedOn,B.CREATED_BY AS CreatedBy
    ,B.MODIFIED_ON AS ModifiedOn,B.MODIFIED_BY AS ModifiedBy,B.RECORD_STATUS AS RecordStatus
    ,B.RESV01 AS Resv01,B.RESV02 AS Resv02,B.RESV03 AS Resv03,B.RESV04 AS Resv04,B.RESV05 AS Resv05
    ,B.RESV06 AS Resv06,B.RESV07 AS Resv07,B.RESV08 AS Resv08,B.RESV09 AS Resv09,B.RESV10 AS Resv10
FROM T_RIGHT_USER B WITH(NOLOCK)
	INNER JOIN T_RIGHT_LK_USER_GROUP A WITH(NOLOCK) ON
		A.USER_SYSID = B.SYSID
        AND A.GROUP_SYSID = @GroupSysid
";

            return Dapper.Query<RightUser>(sql, new { GroupSysid = groupSysid });
        }

        public static List<RightUser> QueryNotSelectedUserByGroupSysid(string groupSysid)
        {
            const string sql = @"
SELECT B.SYSID AS Sysid,B.USER_ID AS UserId,B.USER_NAME AS UserName,B.USER_PWD AS UserPwd
    ,B.DEPARTMENT AS Department
    ,B.EMAIL AS Email,B.CREATED_ON AS CreatedOn,B.CREATED_BY AS CreatedBy
    ,B.MODIFIED_ON AS ModifiedOn,B.MODIFIED_BY AS ModifiedBy,B.RECORD_STATUS AS RecordStatus
    ,B.RESV01 AS Resv01,B.RESV02 AS Resv02,B.RESV03 AS Resv03,B.RESV04 AS Resv04,B.RESV05 AS Resv05
    ,B.RESV06 AS Resv06,B.RESV07 AS Resv07,B.RESV08 AS Resv08,B.RESV09 AS Resv09,B.RESV10 AS Resv10
FROM T_RIGHT_USER B WITH(NOLOCK)
	LEFT JOIN T_RIGHT_LK_USER_GROUP A WITH(NOLOCK) ON
		A.USER_SYSID = B.SYSID
        AND A.GROUP_SYSID = @GroupSysid
WHERE A.USER_SYSID IS NULL
";

            return Dapper.Query<RightUser>(sql, new { GroupSysid = groupSysid });
        }

        public static bool Save(List<RightLkUserGroup> insertRightLkUserGroup, List<RightLkUserGroup> deleteRightLkUserGroup)
        {
            using (var conn = new SqlConnection(Conn.getConn()))
            {
                if (conn.State != ConnectionState.Open)
                    conn.Open();

                using (var trans = conn.BeginTransaction())
                {
                    foreach (var item in insertRightLkUserGroup)
                    {
                        var result = Insert(item, conn, trans);
                        if (result)
                            continue;

                        trans.Rollback();
                        return false;
                    }

                    foreach (var item in deleteRightLkUserGroup)
                    {
                        var result = Delete(item, conn, trans);
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
    }
}
