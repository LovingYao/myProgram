using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TelerikWinformBase
{
    public class DictionaryInfoBll
    {
        public static DictionaryInfo QuerySingle(string sysid)
        {
            return DictionaryInfoDal.QuerySingle(sysid);
        }

        public static bool InsertDictionaryInfo(DictionaryInfo dictionaryInfo, out string msg)
        {
            if (!DictionaryInfoDal.Insert(dictionaryInfo))
            {
                msg = "新增失败";
                return false;
            }
            msg = "新增成功";
            return true;
        }

        public static bool UpdateDictionaryInfo(DictionaryInfo dictionaryInfo, out string msg)
        {
            if (!DictionaryInfoDal.Update(dictionaryInfo))
            {
                msg = "修改失败";
                return false;
            }
            msg = "修改成功";
            return true;
        }

        public static bool DeleteDictionaryInfo(DictionaryInfo dictionaryInfo)
        {
            return DictionaryInfoDal.Delete(dictionaryInfo);
        }

        public static List<DictionaryInfo> QueryAll(DictionaryCategory category)
        {
            return DictionaryInfoDal.QueryAll(category);
        }

        public static List<DictionaryInfo> QueryAll(DictionaryCategory category, string owner)
        {
            return string.IsNullOrEmpty(owner)
                ? DictionaryInfoDal.QueryAll(category)
                : DictionaryInfoDal.QueryAll(category, owner);
        }
    }
}
