using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsiProgram.Entity;
using System.Data.SqlClient;

namespace CsiProgram.DAL
{
    public class BaseStatusDal
    {
        #region 自动生成部分


        public static List<BaseStatus> QueryAll()
        {
            const string sql = @"
SELECT A.ID AS ID,A.STATUS_ID AS StatusId,A.STATUS_NAME AS StatusName,A.GROUP_NAME AS GroupName,A.CREATED_ON AS CreatedOn,A.CREATED_BY AS CreatedBy
FROM T_BASE_STATUS AS A WITH(NOLOCK) 
WHERE 1=1 

";

            return Dapper.Query<BaseStatus>(sql, null);
        }

        public static List<BaseStatus> QueryBaseStatus(QueryCondition queryCondition)
        {
            string sql = @"
SELECT A.ID AS ID,A.STATUS_ID AS StatusId,A.STATUS_NAME AS StatusName,A.GROUP_NAME AS GroupName,A.CREATED_ON AS CreatedOn,A.CREATED_BY AS CreatedBy
FROM T_BASE_STATUS AS A WITH(NOLOCK) 
WHERE 1=1 

";

            var dict = new Dictionary<QueryConditionField, string>
            {
                //{QueryConditionField.Workshop, " AND WORKSHOP = "},
            };
            var builder = new QueryConditionBuilder(queryCondition, dict);
            sql += builder.Build();

            //sql += " ORDER BY RECORD_STATUS DESC,MODIFIED_ON DESC ";

            return Dapper.Query<BaseStatus>(sql, queryCondition);
        }
        public static BaseStatus QuerySingle(Int32 iD)
        {
            const string sql = @"
SELECT ID AS ID,STATUS_ID AS StatusId,STATUS_NAME AS StatusName,GROUP_NAME AS GroupName,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy
FROM T_BASE_STATUS WITH(NOLOCK) 
WHERE ID=@ID

";

            return Dapper.QuerySingle<BaseStatus>(sql, new { ID = iD });
        }

        public static bool Insert(BaseStatus baseStatus)
        {
            const string sql = @"
INSERT INTO T_BASE_STATUS(STATUS_ID,STATUS_NAME,GROUP_NAME,CREATED_ON,CREATED_BY)
VALUES(@StatusId,@StatusName,@GroupName,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy)

";

            return Dapper.Save(baseStatus, sql);
        }

        public static bool Insert(BaseStatus baseStatus, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
INSERT INTO T_BASE_STATUS(STATUS_ID,STATUS_NAME,GROUP_NAME,CREATED_ON,CREATED_BY)
VALUES(@StatusId,@StatusName,@GroupName,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy)

";

            return Dapper.Save(baseStatus, sql, conn, trans);
        }

        public static bool Update(BaseStatus baseStatus)
        {
            const string sql = @"
UPDATE T_BASE_STATUS
SET STATUS_ID=@StatusId,STATUS_NAME=@StatusName,GROUP_NAME=@GroupName,CREATED_BY=@CreatedBy
WHERE ID=@ID

";

            return Dapper.Save(baseStatus, sql);
        }

        public static bool Update(BaseStatus baseStatus, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
UPDATE T_BASE_STATUS
SET STATUS_ID=@StatusId,STATUS_NAME=@StatusName,GROUP_NAME=@GroupName,CREATED_BY=@CreatedBy
WHERE ID=@ID

";

            return Dapper.Save(baseStatus, sql, conn, trans);
        }

        public static bool Delete(BaseStatus baseStatus)
        {
            const string sql = @"
DELETE FROM T_BASE_STATUS
WHERE ID=@ID

";

            return Dapper.Save(baseStatus, sql);
        }

        public static bool Delete(BaseStatus baseStatus, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_BASE_STATUS
WHERE ID=@ID

";

            return Dapper.Save(baseStatus, sql, conn, trans);
        }

        public static bool BatchInsert(List<BaseStatus> baseStatuss)
        {
            const string sql = @"
INSERT INTO T_BASE_STATUS(STATUS_ID,STATUS_NAME,GROUP_NAME,CREATED_ON,CREATED_BY)
VALUES(@StatusId,@StatusName,@GroupName,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy)

";

            return Dapper.Save(baseStatuss, sql);
        }



        #endregion

    }
}
