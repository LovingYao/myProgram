using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TelerikWinformBase
{
    public class RightLkUserGroupBll
    {
        public static List<RightUser> QuerySelectedUserByGroupSysid(string groupSysid)
        {
            return RightLkUserGroupDal.QuerySelectedUserByGroupSysid(groupSysid);
        }

        public static List<RightUser> QueryNotSelectedUserByGroupSysid(string groupSysid)
        {
            return RightLkUserGroupDal.QueryNotSelectedUserByGroupSysid(groupSysid);
        }

        public static bool Save(List<RightLkUserGroup> insertRightLkUserGroup, List<RightLkUserGroup> deleteRightLkUserGroup)
        {
            return RightLkUserGroupDal.Save(insertRightLkUserGroup, deleteRightLkUserGroup);
        }
    }
}
