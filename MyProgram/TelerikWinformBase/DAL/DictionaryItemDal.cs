using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;


namespace TelerikWinformBase
{
    public class DictionaryItemDal
    {
        #region 自动生成部分

        public static List<DictionaryItem> QueryAll()
        {
            const string sql = @"
SELECT A.SYSID AS Sysid,A.DICTIONARY_CODE AS DictionaryCode,A.CODE AS Code,A.NAME AS Name,A.SEQUENCE AS Sequence,A.WORKSHOP AS Workshop,A.STEP AS Step,A.REMARK AS Remark,A.CREATED_ON AS CreatedOn,A.CREATED_BY AS CreatedBy,A.MODIFIED_ON AS ModifiedOn,A.MODIFIED_BY AS ModifiedBy,A.RECORD_STATUS AS RecordStatus,A.RESV01 AS Resv01,A.RESV02 AS Resv02,A.RESV03 AS Resv03,A.RESV04 AS Resv04,A.RESV05 AS Resv05,A.RESV06 AS Resv06,A.RESV07 AS Resv07,A.RESV08 AS Resv08,A.RESV09 AS Resv09,A.RESV10 AS Resv10
FROM T_DICTIONARY_ITEM AS A WITH(NOLOCK) 
WHERE 1=1 

";

            return Dapper.Query<DictionaryItem>(sql, null);
        }

        public static DictionaryItem QuerySingle(String sysid)
        {
            const string sql = @"
SELECT SYSID AS Sysid,DICTIONARY_CODE AS DictionaryCode,CODE AS Code,NAME AS Name,SEQUENCE AS Sequence,WORKSHOP AS Workshop,STEP AS Step,REMARK AS Remark,CREATED_ON AS CreatedOn,CREATED_BY AS CreatedBy,MODIFIED_ON AS ModifiedOn,MODIFIED_BY AS ModifiedBy,RECORD_STATUS AS RecordStatus,RESV01 AS Resv01,RESV02 AS Resv02,RESV03 AS Resv03,RESV04 AS Resv04,RESV05 AS Resv05,RESV06 AS Resv06,RESV07 AS Resv07,RESV08 AS Resv08,RESV09 AS Resv09,RESV10 AS Resv10
FROM T_DICTIONARY_ITEM WITH(NOLOCK) 
WHERE SYSID=@Sysid

";

            return Dapper.QuerySingle<DictionaryItem>(sql, new { Sysid = sysid });
        }

        public static bool Insert(DictionaryItem dictionaryItem)
        {
            const string sql = @"
INSERT INTO T_DICTIONARY_ITEM(SYSID,DICTIONARY_CODE,CODE,NAME,SEQUENCE,WORKSHOP,STEP,REMARK,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS,RESV01,RESV02,RESV03,RESV04,RESV05,RESV06,RESV07,RESV08,RESV09,RESV10)
VALUES(@Sysid,@DictionaryCode,@Code,@Name,@Sequence,@Workshop,@Step,@Remark,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus,@Resv01,@Resv02,@Resv03,@Resv04,@Resv05,@Resv06,@Resv07,@Resv08,@Resv09,@Resv10)

";

            return Dapper.Save(dictionaryItem, sql);
        }

        public static bool Insert(DictionaryItem dictionaryItem, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
INSERT INTO T_DICTIONARY_ITEM(SYSID,DICTIONARY_CODE,CODE,NAME,SEQUENCE,WORKSHOP,STEP,REMARK,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS,RESV01,RESV02,RESV03,RESV04,RESV05,RESV06,RESV07,RESV08,RESV09,RESV10)
VALUES(@Sysid,@DictionaryCode,@Code,@Name,@Sequence,@Workshop,@Step,@Remark,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus,@Resv01,@Resv02,@Resv03,@Resv04,@Resv05,@Resv06,@Resv07,@Resv08,@Resv09,@Resv10)

";

            return Dapper.Save(dictionaryItem, sql, conn, trans);
        }

        public static bool Update(DictionaryItem dictionaryItem)
        {
            const string sql = @"
UPDATE T_DICTIONARY_ITEM
SET DICTIONARY_CODE=@DictionaryCode,CODE=@Code,NAME=@Name,SEQUENCE=@Sequence,WORKSHOP=@Workshop,STEP=@Step,REMARK=@Remark,CREATED_BY=@CreatedBy,MODIFIED_ON=CONVERT(NVARCHAR(50),GETDATE(),121),MODIFIED_BY=@ModifiedBy,RECORD_STATUS=@RecordStatus,RESV01=@Resv01,RESV02=@Resv02,RESV03=@Resv03,RESV04=@Resv04,RESV05=@Resv05,RESV06=@Resv06,RESV07=@Resv07,RESV08=@Resv08,RESV09=@Resv09,RESV10=@Resv10
WHERE SYSID=@Sysid

";

            return Dapper.Save(dictionaryItem, sql);
        }

        public static bool Update(DictionaryItem dictionaryItem, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
UPDATE T_DICTIONARY_ITEM
SET DICTIONARY_CODE=@DictionaryCode,CODE=@Code,NAME=@Name,SEQUENCE=@Sequence,WORKSHOP=@Workshop,STEP=@Step,REMARK=@Remark,CREATED_BY=@CreatedBy,MODIFIED_ON=CONVERT(NVARCHAR(50),GETDATE(),121),MODIFIED_BY=@ModifiedBy,RECORD_STATUS=@RecordStatus,RESV01=@Resv01,RESV02=@Resv02,RESV03=@Resv03,RESV04=@Resv04,RESV05=@Resv05,RESV06=@Resv06,RESV07=@Resv07,RESV08=@Resv08,RESV09=@Resv09,RESV10=@Resv10
WHERE SYSID=@Sysid

";

            return Dapper.Save(dictionaryItem, sql, conn, trans);
        }

        public static bool Delete(DictionaryItem dictionaryItem)
        {
            const string sql = @"
DELETE FROM T_DICTIONARY_ITEM
WHERE SYSID=@Sysid

";

            return Dapper.Save(dictionaryItem, sql);
        }

        public static bool Delete(DictionaryItem dictionaryItem, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_DICTIONARY_ITEM
WHERE SYSID=@Sysid

";

            return Dapper.Save(dictionaryItem, sql, conn, trans);
        }

        public static bool BatchInsert(List<DictionaryItem> dictionaryItems)
        {
            const string sql = @"
INSERT INTO T_DICTIONARY_ITEM(SYSID,DICTIONARY_CODE,CODE,NAME,SEQUENCE,WORKSHOP,STEP,REMARK,CREATED_ON,CREATED_BY,MODIFIED_ON,MODIFIED_BY,RECORD_STATUS,RESV01,RESV02,RESV03,RESV04,RESV05,RESV06,RESV07,RESV08,RESV09,RESV10)
VALUES(@Sysid,@DictionaryCode,@Code,@Name,@Sequence,@Workshop,@Step,@Remark,CONVERT(NVARCHAR(50),GETDATE(),121),@CreatedBy,CONVERT(NVARCHAR(50),GETDATE(),121),@ModifiedBy,@RecordStatus,@Resv01,@Resv02,@Resv03,@Resv04,@Resv05,@Resv06,@Resv07,@Resv08,@Resv09,@Resv10)

";

            return Dapper.Save(dictionaryItems, sql);
        }

        #endregion

        public static List<DictionaryItem> QueryDictionaryItem(QueryCondition queryCondition)
        {
            var sql = @"
SELECT A.SYSID AS Sysid,A.DICTIONARY_CODE AS DictionaryCode,A.CODE AS Code
	,A.NAME AS Name,A.SEQUENCE AS Sequence,A.WORKSHOP AS Workshop
	,A.STEP AS Step,A.REMARK AS Remark,A.CREATED_ON AS CreatedOn
	,A.CREATED_BY AS CreatedBy,A.MODIFIED_ON AS ModifiedOn
	,A.MODIFIED_BY AS ModifiedBy,A.RECORD_STATUS AS RecordStatus
	,A.RESV01 AS Resv01,A.RESV02 AS Resv02,A.RESV03 AS Resv03
	,A.RESV04 AS Resv04,A.RESV05 AS Resv05,A.RESV06 AS Resv06
	,A.RESV07 AS Resv07,A.RESV08 AS Resv08,A.RESV09 AS Resv09
	,A.RESV10 AS Resv10,B.NAME AS DictionaryName
FROM T_DICTIONARY_ITEM AS A WITH(NOLOCK) 
	INNER JOIN T_DICTIONARY_INFO AS B WITH(NOLOCK) ON
		A.DICTIONARY_CODE = B.CODE
WHERE 1 = 1
";

            var dict = new Dictionary<QueryConditionField, string>
                           {
                               {QueryConditionField.Code, " AND A.DICTIONARY_CODE = "},
                               {QueryConditionField.ReasonCategory, " AND B.CATEGORY = "}
                           };
            var builder = new QueryConditionBuilder(queryCondition, dict);
            sql += builder.Build();

            sql += " ORDER BY A.SEQUENCE ";

            return Dapper.Query<DictionaryItem>(sql, queryCondition);
        }

        public static List<DictionaryItem> QueryMutileCodeInDictionary(DictionaryItem dictionaryItem)
        {
            const string sql = @"
SELECT A.SYSID AS Sysid,A.DICTIONARY_CODE AS DictionaryCode,A.CODE AS Code
    ,A.NAME AS Name,A.SEQUENCE AS Sequence,A.WORKSHOP AS Workshop,A.STEP AS Step
    ,A.REMARK AS Remark,A.CREATED_ON AS CreatedOn,A.CREATED_BY AS CreatedBy
    ,A.MODIFIED_ON AS ModifiedOn,A.MODIFIED_BY AS ModifiedBy,A.RECORD_STATUS AS RecordStatus
    ,A.RESV01 AS Resv01,A.RESV02 AS Resv02,A.RESV03 AS Resv03,A.RESV04 AS Resv04
    ,A.RESV05 AS Resv05,A.RESV06 AS Resv06,A.RESV07 AS Resv07,A.RESV08 AS Resv08
    ,A.RESV09 AS Resv09,A.RESV10 AS Resv10
FROM T_DICTIONARY_ITEM AS A WITH(NOLOCK) 
WHERE 1 = 1
	AND A.DICTIONARY_CODE = @DictionaryCode 
	AND A.CODE = @Code 
";

            return Dapper.Query<DictionaryItem>(sql, dictionaryItem);
        }
    }
}
