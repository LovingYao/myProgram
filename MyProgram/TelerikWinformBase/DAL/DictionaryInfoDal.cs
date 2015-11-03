using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace TelerikWinformBase
{
    public class DictionaryInfoDal
    {
        #region 自动生成部分

        public static DictionaryInfo QuerySingle(String code)
        {
            const string sql = @"
SELECT CODE AS Code,NAME AS Name,OWNER AS Owner,CATEGORY AS Category
FROM T_DICTIONARY_INFO WITH(NOLOCK) 
WHERE CODE=@Code

";

            return Dapper.QuerySingle<DictionaryInfo>(sql, new { Code = code });
        }

        public static bool Insert(DictionaryInfo dictionaryInfo)
        {
            const string sql = @"
INSERT INTO T_DICTIONARY_INFO(CODE,NAME,OWNER,CATEGORY)
VALUES(@Code,@Name,@Owner,@Category)

";

            return Dapper.Save(dictionaryInfo, sql);
        }

        public static bool Insert(DictionaryInfo dictionaryInfo, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
INSERT INTO T_DICTIONARY_INFO(CODE,NAME,OWNER,CATEGORY)
VALUES(@Code,@Name,@Owner,@Category)

";

            return Dapper.Save(dictionaryInfo, sql, conn, trans);
        }

        public static bool Update(DictionaryInfo dictionaryInfo)
        {
            const string sql = @"
UPDATE T_DICTIONARY_INFO
SET NAME=@Name,OWNER=@Owner,CATEGORY=@Category
WHERE CODE=@Code

";

            return Dapper.Save(dictionaryInfo, sql);
        }

        public static bool Update(DictionaryInfo dictionaryInfo, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
UPDATE T_DICTIONARY_INFO
SET NAME=@Name,OWNER=@Owner,CATEGORY=@Category
WHERE CODE=@Code

";

            return Dapper.Save(dictionaryInfo, sql, conn, trans);
        }

        public static bool Delete(DictionaryInfo dictionaryInfo)
        {
            const string sql = @"
DELETE FROM T_DICTIONARY_INFO
WHERE CODE=@Code

";

            return Dapper.Save(dictionaryInfo, sql);
        }

        public static bool Delete(DictionaryInfo dictionaryInfo, SqlConnection conn, SqlTransaction trans)
        {
            const string sql = @"
DELETE FROM T_DICTIONARY_INFO
WHERE CODE=@Code

";

            return Dapper.Save(dictionaryInfo, sql, conn, trans);
        }

        public static bool BatchInsert(List<DictionaryInfo> dictionaryInfos)
        {
            const string sql = @"
INSERT INTO T_DICTIONARY_INFO(CODE,NAME,OWNER,CATEGORY)
VALUES(@Code,@Name,@Owner,@Category)

";

            return Dapper.Save(dictionaryInfos, sql);
        }

        #endregion

        public static List<DictionaryInfo> QueryAll(DictionaryCategory category)
        {
            const string sql = @"
SELECT A.CODE AS Code,A.NAME AS Name,A.OWNER AS Owner,A.CATEGORY AS Category
FROM T_DICTIONARY_INFO AS A WITH(NOLOCK) 
WHERE 1 = 1 
    AND A.CATEGORY = @Category 
ORDER BY A.CODE
";

            return Dapper.Query<DictionaryInfo>(sql, new { Category = category.ToString() });
        }

        public static List<DictionaryInfo> QueryAll(DictionaryCategory category, string owner)
        {
            const string sql = @"
SELECT A.CODE AS Code,A.NAME AS Name,A.OWNER AS Owner,A.CATEGORY AS Category
FROM T_DICTIONARY_INFO AS A WITH(NOLOCK) 
WHERE 1 = 1 
    AND A.CATEGORY = @Category
    AND Owner = @Owner
ORDER BY A.CODE
";

            return Dapper.Query<DictionaryInfo>(sql, new { Category = category.ToString(), Owner = owner });
        }
    }
}
