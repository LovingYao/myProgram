using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikWinformBase
{
    [Serializable]
    public class RightMenu
    {
        public string GroupSysid { get; set; }
        public string GroupName { get; set; }
        public string FunctionSysid { get; set; }
        public string FunctionName { get; set; }
        public string CommandSysid { get; set; }
        public string CommandName { get; set; }
    }
}
