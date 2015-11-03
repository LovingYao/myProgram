using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikWinformBase
{
    public class RightUserGroupBll
    {
        public static List<RightUserGroup> QueryRightUserGroup(QueryCondition queryCondition)
        {
            return RightUserGroupDal.QueryRightUserGroup(queryCondition);
        }

        public static List<RightUserGroup> QueryAll()
        {
            return RightUserGroupDal.QueryAll();
        }

        public static RightUserGroup QuerySingle(string sysid)
        {
            return RightUserGroupDal.QuerySingle(sysid);
        }

        public static bool InsertRightUserGroup(RightUserGroup rightUserGroup, out string msg)
        {
            if (!RightUserGroupDal.Insert(rightUserGroup))
            {
                msg = "新增失败";
                return false;
            }
            msg = "新增成功";
            return true;
        }

        public static bool UpdateRightUserGroup(RightUserGroup rightUserGroup, out string msg)
        {
            if (!RightUserGroupDal.Update(rightUserGroup))
            {
                msg = "修改失败";
                return false;
            }
            msg = "修改成功";
            return true;
        }

        public static bool DeleteRightUserGroup(RightUserGroup rightUserGroup)
        {
            return RightUserGroupDal.Delete(rightUserGroup);
        }
    }
}
