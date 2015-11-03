using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Collections.Generic;
using TelerikWinformBase;

namespace RFIDProgram
{
    //权限分配
    /// <summary>
    /// 权限分配
    /// </summary>
    public partial class FrmAssignRight : FrmSimpleBaseData
    {
        //构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        private FrmAssignRight()
        {
            InitializeComponent();
            RegistEvents();
        }

        #region 窗体单例
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        private static FrmAssignRight _window;
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        public static FrmAssignRight Window
        {
            get
            {
                if (_window == null)
                {
                    _window = new FrmAssignRight();
                }
                return _window;
            }
        }
        #endregion

        #region 私有方法

        //注册事件
        /// <summary>
        /// 注册事件
        /// </summary>
        private void RegistEvents()
        {
            FormClosed += FrmAssignRight_FormClosed;
            Shown += FrmAssignRight_Shown;
        }

        //加载查询数据
        /// <summary>
        /// 加载查询数据
        /// </summary>
        private void QueryData()
        {
            Rights = RightBll.QueryByUserGroupSysid(UI.GetValue(ddlUserGroup));
            foreach (var groupNode in treeRight.Nodes)
            {
                foreach (var functionNode in groupNode.Nodes)
                {
                    foreach (var commandNode in functionNode.Nodes)
                    {
                        var commandData = commandNode.Tag as RightMenu;
                        if (commandData == null)
                            continue;

                        commandNode.Checked =
                            Rights.FindAll(
                                p =>
                                p.FunctionGroupSysid == commandData.GroupSysid &&
                                p.FunctionSysid == commandData.FunctionSysid &&
                                p.CommandSysid == commandData.CommandSysid).Count > 0;
                    }
                }
            }
        }

        //绑定下拉框
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        private void BindingDropDownList()
        {
            ddlUserGroup.SelectedIndexChanged -= ddlUserGroup_SelectedIndexChanged;
            ddlUserGroup.RefreshDataSource();
            ddlUserGroup.SelectedIndexChanged += ddlUserGroup_SelectedIndexChanged;
        }

        //绑定树 功能组节点
        /// <summary>
        /// 绑定树 功能组节点
        /// </summary>
        private void BindingTreeView()
        {
            treeRight.Nodes.Clear();
            RightMenus = RightBll.QueryAllRightMenu();
            if (RightMenus == null || RightMenus.Count <= 0)
                return;
            //1、绑定Group
            var lstGroupData = new List<RightMenu>();
            for (var i = 0; i < RightMenus.Count; i++)
            {
                var rightMenu = RightMenus[i];
                if (lstGroupData.FindAll(p => p.GroupSysid == rightMenu.GroupSysid).Count > 0)
                    continue;

                lstGroupData.Add(rightMenu);
                var node = new RadTreeNode
                               {
                                   Text = rightMenu.GroupName,
                                   CheckType = CheckType.CheckBox,
                                   Tag = rightMenu
                               };
                BindingTreeFunction(node);
                treeRight.Nodes.Add(node);
                treeRight.ExpandAll();
            }
        }

        //绑定树 功能节点
        /// <summary>
        /// 绑定树 功能节点
        /// </summary>
        /// <param name="groupNode"></param>
        private void BindingTreeFunction(RadTreeNode groupNode)
        {
            var rightMenu = groupNode.Tag as RightMenu;
            if (rightMenu == null)
                return;

            var lstFunctionData = RightMenus.FindAll(p => p.GroupSysid == rightMenu.GroupSysid);
            var lstAddedFunctions = new List<RightMenu>();
            for (var i = 0; i < lstFunctionData.Count; i++)
            {
                var functionData = lstFunctionData[i];
                if (lstAddedFunctions.FindAll(p => p.FunctionSysid == functionData.FunctionSysid).Count > 0)
                    continue;

                lstAddedFunctions.Add(functionData);
                var node = new RadTreeNode
                               {
                                   Text = functionData.FunctionName,
                                   CheckType = CheckType.CheckBox,
                                   Tag = functionData
                               };
                BindingTreeCommand(node);
                groupNode.Nodes.Add(node);
            }
        }

        //绑定树 命令节点
        /// <summary>
        /// 绑定树 命令节点
        /// </summary>
        /// <param name="functionNode"></param>
        /// <returns>CheckBox选中的个数</returns>
        private void BindingTreeCommand(RadTreeNode functionNode)
        {
            var rightMenu = functionNode.Tag as RightMenu;
            if (rightMenu == null)
                return;

            var lstCommandData = RightMenus.FindAll(p => p.GroupSysid == rightMenu.GroupSysid && p.FunctionSysid == rightMenu.FunctionSysid);
            var lstAddedCommands = new List<RightMenu>();
            for (var i = 0; i < lstCommandData.Count; i++)
            {
                var commandData = lstCommandData[i];
                if (lstAddedCommands.FindAll(p => p.CommandSysid == commandData.CommandSysid).Count > 0)
                    continue;

                lstAddedCommands.Add(commandData);
                var node = new RadTreeNode
                               {
                                   Text = commandData.CommandName,
                                   CheckType = CheckType.CheckBox,
                                   Tag = commandData
                               };
                functionNode.Nodes.Add(node);
            }
        }

        //用编辑框数据填充实体
        /// <summary>
        /// 用编辑框数据填充实体
        /// </summary>
        private List<Right> BuildEntity()
        {
            var rights = new List<Right>();

            var userGroupSysid = UI.GetValue(ddlUserGroup);
            foreach (var groupNode in treeRight.Nodes)
            {
                foreach (var functionNode in groupNode.Nodes)
                {
                    foreach (var commandNode in functionNode.Nodes)
                    {
                        if (!commandNode.Checked)
                            continue;
                        var rightMenu = commandNode.Tag as RightMenu;
                        if (rightMenu == null)
                            continue;
                        var right = new Right
                                        {
                                            Sysid = Sysid.NewId(""),
                                            UserGroupSysid = userGroupSysid,
                                            FunctionGroupSysid = rightMenu.GroupSysid,
                                            FunctionSysid = rightMenu.FunctionSysid,
                                            CommandSysid = rightMenu.CommandSysid,
                                            CreatedBy = GloableData.Instance.UserId
                                        };
                        rights.Add(right);
                    }
                }
            }

            return rights;
        }

        #endregion

        #region 属性

        //上一次选中的用户组的索引
        /// <summary>
        /// 上一次选中的用户组的索引
        /// </summary>
        private int LastSelectedUserGroupIndex { get; set; }

        //所有权限菜单
        /// <summary>
        /// 所有权限菜单
        /// </summary>
        private List<RightMenu> RightMenus { get; set; }

        //权限列表
        /// <summary>
        /// 权限列表
        /// </summary>
        private List<Right> Rights { get; set; }

        #endregion

        #region 窗体事件

        //窗体加载完成
        /// <summary>
        /// 窗体加载完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAssignRight_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            ResetButtons(new[]
                             {
                                 CommandButton.Submit,
                                 CommandButton.Close
                             });
        }

        //窗体第一次显示
        /// <summary>
        /// 窗体第一次显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAssignRight_Shown(object sender, EventArgs e)
        {
            Text = "权限分配";
            LastSelectedUserGroupIndex = -1;
            BindingDropDownList();
            BindingTreeView();
        }

        //窗体关闭完成
        /// <summary>
        /// 窗体关闭完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAssignRight_FormClosed(object sender, FormClosedEventArgs e)
        {
            _window = null;
        }

        #endregion

        #region 其他事件

        //用户组选择更改
        /// <summary>
        /// 用户组选择更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddlUserGroup_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (LastSelectedUserGroupIndex == -1)
                LastSelectedUserGroupIndex = ddlUserGroup.SelectedIndex;

            if (CurrentOperationStatus != OperationStatus.Default &&
                !UI.Confirm("有数据未保存，继续将丢失，是否继续？"))
            {
                ddlUserGroup.SelectedIndexChanged -= ddlUserGroup_SelectedIndexChanged;
                ddlUserGroup.Items[LastSelectedUserGroupIndex].Selected = true;
                ddlUserGroup.SelectedIndexChanged += ddlUserGroup_SelectedIndexChanged;
                return;
            }

            QueryData();

            CurrentOperationStatus = OperationStatus.Default;
        }

        //节点选择更改
        /// <summary>
        /// 节点选择更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeRight_NodeCheckedChanged(object sender, RadTreeViewEventArgs e)
        {
            CurrentOperationStatus = OperationStatus.Edit;
        }

        #endregion

        #region CommandBar 事件

        //保存数据
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        internal override bool Submit()
        {
            if (CurrentOperationStatus == OperationStatus.Default)
                return false;
            if (UI.EmptyText(ddlUserGroup, "用户组"))
                return false;
            var list = BuildEntity();
            var userGroupSysid = UI.GetValue(ddlUserGroup);

            var result = RightBll.Save(userGroupSysid, list);

            string msg;
            if (result)
            {
                msg = "保存成功";
                CurrentOperationStatus = OperationStatus.Default;
            }
            else
            {
                msg = "保存失败";
                CurrentOperationStatus = OperationStatus.Edit;
            }
            UI.ShowInfo(msg);
            return result;
        }

        #endregion
    }
}