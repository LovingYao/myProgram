using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TelerikWinformBase
{
    public class RightLkFunctionGroupBll
    {
        public static List<RightFunction> QuerySelectedFunctionByGroupSysid(string groupSysid)
        {
            return RightLkFunctionGroupDal.QuerySelectedFunctionByGroupSysid(groupSysid);
        }

        public static List<RightFunction> QueryNotSelectedFunctionByGroupSysid(string groupSysid)
        {
            return RightLkFunctionGroupDal.QueryNotSelectedFunctionByGroupSysid(groupSysid);
        }

        public static bool Save(List<RightLkFunctionGroup> insertList, List<RightLkFunctionGroup> deleteList, List<RightLkFunctionGroup> updateList)
        {
            return RightLkFunctionGroupDal.Save(insertList, deleteList, updateList);
        }
    }
}
