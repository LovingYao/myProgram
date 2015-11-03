using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TelerikWinformBase
{
    public class RightFunctionBll
    {
        public static List<RightFunction> QueryRightFunction(QueryCondition queryCondition)
        {
            return RightFunctionDal.QueryRightFunction(queryCondition);
        }

        public static List<RightFunction> QueryAll()
        {
            return RightFunctionDal.QueryAll();
        }

        public static RightFunction QuerySingle(string sysid)
        {
            return RightFunctionDal.QuerySingle(sysid);
        }

        public static bool InsertRightFunction(RightFunction rightFunction, out string msg)
        {
            var rightFunctions = RightFunctionDal.QueryMutileFunction(rightFunction);
            if (rightFunctions != null && rightFunctions.Count > 0)
            {
                msg = string.Format("功能编号{0}、功能参数{1}的记录已经存在", rightFunction.FuncCode, rightFunction.FuncParam);
                return false;
            }
            if (!RightFunctionDal.Insert(rightFunction))
            {
                msg = "新增失败";
                return false;
            }
            msg = "新增成功";
            return true;
        }

        public static bool UpdateRightFunction(RightFunction rightFunction, out string msg)
        {
            var rightFunctions = RightFunctionDal.QueryMutileFunction(rightFunction);
            if (rightFunctions != null && rightFunctions.Count > 0)
            {
                if (rightFunctions.FindAll(p => p.Sysid != rightFunction.Sysid).Count > 0)
                {
                    msg = string.Format("功能编号{0}、功能参数{1}的记录已经存在", rightFunction.FuncCode, rightFunction.FuncParam);
                    return false;
                }
            }
            if (!RightFunctionDal.Update(rightFunction))
            {
                msg = "修改失败";
                return false;
            }
            msg = "修改成功";
            return true;
        }

        public static bool DeleteRightFunction(RightFunction rightFunction)
        {
            return RightFunctionDal.Delete(rightFunction);
        }
    }
}
