using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TelerikWinformBase
{
    public class DictionaryItemBll
    {
        public static List<DictionaryItem> QueryDictionaryItem(QueryCondition queryCondition)
        {
            return DictionaryItemDal.QueryDictionaryItem(queryCondition);
        }

        public static List<DictionaryItem> QueryAll()
        {
            return DictionaryItemDal.QueryAll();
        }

        public static DictionaryItem QuerySingle(string sysid)
        {
            return DictionaryItemDal.QuerySingle(sysid);
        }

        public static bool InsertDictionaryItem(DictionaryItem dictionaryItem, out string msg)
        {
            var dictionaryItems = DictionaryItemDal.QueryMutileCodeInDictionary(dictionaryItem);
            if (dictionaryItems != null && dictionaryItems.Count > 0)
            {
                msg = string.Format("字典编号{0}、字典项编号{1}的记录已经存在", dictionaryItem.DictionaryCode, dictionaryItem.Code);
                return false;
            }
            if (!DictionaryItemDal.Insert(dictionaryItem))
            {
                msg = "新增失败";
                return false;
            }
            msg = "新增成功";
            return true;
        }

        public static bool UpdateDictionaryItem(DictionaryItem dictionaryItem, out string msg)
        {
            var dictionaryItems = DictionaryItemDal.QueryMutileCodeInDictionary(dictionaryItem);
            if (dictionaryItems != null && dictionaryItems.Count > 0)
            {
                if (dictionaryItems.FindAll(p => p.Sysid != dictionaryItem.Sysid).Count > 0)
                {
                    msg = string.Format("字典编号{0}、字典项编号{1}的记录已经存在", dictionaryItem.DictionaryCode, dictionaryItem.Code);
                    return false;
                }
            }
            if (!DictionaryItemDal.Update(dictionaryItem))
            {
                msg = "修改失败";
                return false;
            }
            msg = "修改成功";
            return true;
        }

        public static bool DeleteDictionaryItem(DictionaryItem dictionaryItem, out string msg)
        {
            if (dictionaryItem.DictionaryCode == DataDictionary.FunctionCommand.ToString())
            {
                var commandsInRight = RightBll.QueryByCommandSysid(dictionaryItem.Sysid);
                if (commandsInRight != null && commandsInRight.Count > 0)
                {
                    msg = "当前字典项被功能命令设置使用，不可进行删除操作";
                    return false;
                }
            }
            if (DictionaryItemDal.Delete(dictionaryItem))
            {
                msg = "删除成功";
                return true;
            }
            msg = "删除失败";
            return false;
        }
    }
}
