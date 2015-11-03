using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TelerikWinformBase
{
    //菜单实体信息
    /// <summary>
    /// 菜单实体信息
    /// </summary>
    [Serializable]
    public class ViewRight
    {
        public string FunctionGroupName { get; set; }
        public string FunctionCode { get; set; }
        public string FunctionName { get; set; }
        public string FunctionParam { get; set; }
        public string CommandCode { get; set; }
        public string CommandName { get; set; }
    }
}
