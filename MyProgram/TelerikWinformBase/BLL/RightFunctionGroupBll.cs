using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TelerikWinformBase
{
    public class RightFunctionGroupBll
    {
        public static List<RightFunctionGroup> QueryRightFunctionGroup(QueryCondition queryCondition)
        {
            return RightFunctionGroupDal.QueryRightFunctionGroup(queryCondition);
        }

        public static List<RightFunctionGroup> QueryAll()
        {
            return RightFunctionGroupDal.QueryAll();
        }

        public static RightFunctionGroup QuerySingle(string sysid)
        {
            return RightFunctionGroupDal.QuerySingle(sysid);
        }

        public static bool InsertRightFunctionGroup(RightFunctionGroup rightFunctionGroup, out string msg)
        {
            var rightFunctionGroups = RightFunctionGroupDal.QueryMutileRightFunctionGroup(rightFunctionGroup);
            if (rightFunctionGroups != null && rightFunctionGroups.Count > 0)
            {
                msg = string.Format("名称{0}的记录已经存在", rightFunctionGroup.GroupName);
                return false;
            }
            if (!RightFunctionGroupDal.Insert(rightFunctionGroup))
            {
                msg = "新增失败";
                return false;
            }
            msg = "新增成功";
            return true;
        }

        public static bool UpdateRightFunctionGroup(RightFunctionGroup rightFunctionGroup, out string msg)
        {
            var rightFunctionGroups = RightFunctionGroupDal.QueryMutileRightFunctionGroup(rightFunctionGroup);
            if (rightFunctionGroups != null && rightFunctionGroups.Count > 0)
            {
                if (rightFunctionGroups.FindAll(p => p.Sysid != rightFunctionGroup.Sysid).Count > 0)
                {
                    msg = string.Format("名称{0}的记录已经存在", rightFunctionGroup.GroupName);
                    return false;
                }
            }
            if (!RightFunctionGroupDal.Update(rightFunctionGroup))
            {
                msg = "修改失败";
                return false;
            }
            msg = "修改成功";
            return true;
        }

        public static bool DeleteRightFunctionGroup(RightFunctionGroup rightFunctionGroup)
        {
            return RightFunctionGroupDal.Delete(rightFunctionGroup);
        }
    }
}
