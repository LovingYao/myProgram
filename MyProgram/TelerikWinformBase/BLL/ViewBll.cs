using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TelerikWinformBase
{
    public class ViewBll
    {
        public static List<ViewRight> QueryViewRight(QueryCondition queryCondition)
        {
            return ViewDal.QueryViewRight(queryCondition);
        }
    }
}
