using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TelerikWinformBase
{
    public class RightLkFunctionCommandBll
    {
        public static bool Save(List<RightLkFunctionCommand> insertList, List<RightLkFunctionCommand> deleteList)
        {
            return RightLkFunctionCommandDal.Save(insertList, deleteList);
        }

        public static List<RightLkFunctionCommand> QueryRightLkFunctionCommand(QueryCondition queryCondition)
        {
            return RightLkFunctionCommandDal.QueryRightLkFunctionCommand(queryCondition);
        }
    }
}
