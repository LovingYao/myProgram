using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using TelerikWinformBase;

namespace RFIDProgram
{
    internal class RightMenuUI
    {
        #region 加载菜单

        //加载菜单
        /// <summary>
        /// 加载菜单
        /// </summary>
        /// <param name="treeView"></param>
        internal static void LoadMenus(RadTreeView treeView)
        {
            treeView.Nodes.Clear();
            var lstData = ViewBll.QueryViewRight(new QueryCondition
                                                     {
                                                         UserId = GloableData.Instance.UserId
                                                     });
            if (lstData == null || lstData.Count <= 0)
                return;

            //第一级菜单
            var groupData = QueryMenuGroups(lstData);
            if (groupData == null || groupData.Count <= 0)
                return;

            foreach (var group in groupData)
            {
                //第二级菜单
                var groupNode = new RadTreeNode(group);
                var funcData = QueryMenuFunctions(lstData, group);
                if (funcData == null || funcData.Count <= 0)
                    continue;
                foreach (var entity in funcData)
                {
                    //第三级菜单 功能菜单
                    var funcNode = new RadTreeNode
                                       {
                                           Text = entity.FunctionName,
                                           Tag = entity
                                       };
                    groupNode.Nodes.Add(funcNode);
                }
                treeView.Nodes.Add(groupNode);
            }
        }

        //获取组信息
        /// <summary>
        /// 获取组信息
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private static List<string> QueryMenuGroups(IEnumerable<ViewRight> list)
        {
            var query = (from entity in list select entity.FunctionGroupName).Distinct();
            var lstData = new List<string>();
            foreach (var functionGroupName in query)
            {
                lstData.Add(functionGroupName);
            }

            return lstData;
        }

        //获取功能信息
        /// <summary>
        /// 获取功能信息
        /// </summary>
        /// <param name="list"></param>
        /// <param name="groupName"></param>
        /// <returns></returns>
        private static List<ViewRight> QueryMenuFunctions(IEnumerable<ViewRight> list, string groupName)
        {
            var query = (from entity in list where entity.FunctionGroupName == groupName select entity).Distinct();
            var lstData = new List<ViewRight>();
            foreach (var entity in query)
            {
                var info = entity;
                var findEntity = lstData.Find(p => p.FunctionCode == info.FunctionCode);
                if (findEntity != null)
                    continue;
                lstData.Add(entity);
            }

            return lstData;
        }

        #endregion

        #region 根据Code获取指定窗体

        //根据菜单代码获取子窗体
        /// <summary>
        /// 根据菜单代码获取子窗体
        /// </summary>
        /// <param name="viewRight"></param>
        /// <returns></returns>
        internal static Form GetMenuForm(ViewRight viewRight)
        {
            switch (viewRight.FunctionCode.ToUpper())
            {
                case "FRMSYSTEMUSER": return FrmSystemUser.Window;
                case "FRMSYSTEMUSERGROUP": return FrmSystemUserGroup.Window;
                case "FRMSYSTEMFUNC": return FrmSystemFunc.Window;
                case "FRMSYSTEMFUNCGROUP": return FrmSystemFuncGroup.Window;
                case "FRMSYSTEMUSERASSIGNGROUP": return FrmSystemUserAssignGroup.Window;
                case "FRMSYSTEMFUNCASSIGNGROUP": return FrmSystemFuncAssignGroup.Window;
                case "FRMSYSTEMFUNCCOMMAND": return FrmSystemFuncCommand.Window;
                case "FRMASSIGNRIGHT": return FrmAssignRight.Window;
                case "FRMDICTIONARYITEM": return FrmDictionaryItem.Window;

              //  case "FRMAUTOMATIONMAIN": return FrmAutomationMain.Window;
               // case "FRMAUTOMATIONM03": return FrmAutomationM03.Window;
            
            }
            return null;
        }

        #endregion
    }
}