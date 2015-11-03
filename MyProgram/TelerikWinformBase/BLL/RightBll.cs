using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TelerikWinformBase
{
    public class RightBll
    {
        public static bool Save(string userGroupSysid, List<Right> rights)
        {
            return RightDal.Save(userGroupSysid, rights);
        }

        public static List<RightMenu> QueryAllRightMenu()
        {
            return RightDal.QueryAllRightMenu();
        }

        public static List<Right> QueryByUserGroupSysid(string userGroupSysid)
        {
            return RightDal.QueryByUserGroupSysid(userGroupSysid);
        }

        public static List<Right> QueryAll()
        {
            return RightDal.QueryAll();
        }

        public static Right QuerySingle(string sysid)
        {
            return RightDal.QuerySingle(sysid);
        }

        public static bool InsertRight(Right right, out string msg)
        {
            if (!RightDal.Insert(right))
            {
                msg = "新增失败";
                return false;
            }
            msg = "新增成功";
            return true;
        }

        public static bool UpdateRight(Right right, out string msg)
        {
            if (!RightDal.Update(right))
            {
                msg = "修改失败";
                return false;
            }
            msg = "修改成功";
            return true;
        }

        public static bool DeleteRight(Right right)
        {
            return RightDal.Delete(right);
        }

        public static List<Right> QueryByCommandSysid(string commandSysid)
        {
            return RightDal.QueryByCommandSysid(commandSysid);
        }
    }
}
