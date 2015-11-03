using System.Collections.Generic;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI.Data;
using TelerikWinformBase;
using AutoMapper;

namespace RFIDProgram
{
    //用户分组
    /// <summary>
    /// 用户分组
    /// </summary>
    public partial class FrmSystemUserAssignGroup : FrmSimpleBaseData
    {
        //构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        private FrmSystemUserAssignGroup()
        {
            InitializeComponent();
            RegistEvents();
        }

        #region 窗体单例
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        private static FrmSystemUserAssignGroup _window;
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        public static FrmSystemUserAssignGroup Window
        {
            get
            {
                if (_window == null)
                {
                    _window = new FrmSystemUserAssignGroup();
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
            FormClosed += FrmSystemUserAssignGroup_FormClosed;
            Shown += FrmSystemUserAssignGroup_Shown;
        }

        //加载查询数据
        /// <summary>
        /// 加载查询数据
        /// </summary
        private void QueryData()
        {
            var selectedGroupSysid = UI.GetValue(ddlUserGroup);
            SelectedUsers = RightLkUserGroupBll.QuerySelectedUserByGroupSysid(selectedGroupSysid);
            _selectedUsersInDb = Mapper.Map<List<RightUser>, List<RightUser>>(SelectedUsers);
            NotSelectedUsers = RightLkUserGroupBll.QueryNotSelectedUserByGroupSysid(selectedGroupSysid);

            BindingGridView();
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

        //绑定表格
        /// <summary>
        /// 绑定表格
        /// </summary>
        private void BindingGridView()
        {
            gridViewSel.DataSource = null;

            gridViewUnSel.DataSource = null;

            gridViewSel.DataSource = SelectedUsers;

            gridViewUnSel.DataSource = NotSelectedUsers;
        }

        //构造新增的数据
        /// <summary>
        /// 构造新增的数据
        /// </summary>
        private List<RightLkUserGroup> BuildInsertEntity()
        {
            var lstRightLkUserGroup = new List<RightLkUserGroup>();
            var groupSysid = UI.GetValue(ddlUserGroup);
            for (var i = 0; i < SelectedUsers.Count; i++)
            {
                var rightUser = SelectedUsers[i];
                var findInDb = _selectedUsersInDb.FindAll(p => p.Sysid == rightUser.Sysid);
                if (findInDb.Count > 0)
                    continue;

                var rightLkUserGroup = new RightLkUserGroup
                                           {
                                               GroupSysid = groupSysid,
                                               UserSysid = rightUser.Sysid
                                           };
                lstRightLkUserGroup.Add(rightLkUserGroup);
            }
            return lstRightLkUserGroup;
        }

        //构造删除的数据
        /// <summary>
        /// 构造删除的数据
        /// </summary>
        private List<RightLkUserGroup> BuildDeleteEntity()
        {
            var lstRightLkUserGroup = new List<RightLkUserGroup>();
            var groupSysid = UI.GetValue(ddlUserGroup);
            for (var i = 0; i < _selectedUsersInDb.Count; i++)
            {
                var rightUser = _selectedUsersInDb[i];
                var findInDb = SelectedUsers.FindAll(p => p.Sysid == rightUser.Sysid);
                if (findInDb.Count > 0)
                    continue;

                var rightLkUserGroup = new RightLkUserGroup
                                           {
                                               GroupSysid = groupSysid,
                                               UserSysid = rightUser.Sysid
                                           };
                lstRightLkUserGroup.Add(rightLkUserGroup);
            }
            return lstRightLkUserGroup;
        }

        #endregion

        #region 属性

        //已经选择的用户
        /// <summary>
        /// 已经选择的用户
        /// </summary>
        private List<RightUser> SelectedUsers { get; set; }

        //未选择的用户
        /// <summary>
        /// 未选择的用户
        /// </summary>
        private List<RightUser> NotSelectedUsers { get; set; }

        private List<RightUser> _selectedUsersInDb;

        #endregion

        #region 窗体事件

        //窗体加载事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemUserAssignGroup_Load(object sender, EventArgs e)
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
        private void FrmSystemUserAssignGroup_Shown(object sender, EventArgs e)
        {
            Text = "用户分组";
            BindingDropDownList();
        }

        //窗体关闭完成
        /// <summary>
        /// 窗体关闭完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemUserAssignGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            _window = null;
        }

        #endregion

        #region 其他事件

        //取消选中
        /// <summary>
        /// 取消选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            if (gridViewSel.RowCount <= 0 || gridViewSel.SelectedRows.Count <= 0)
                return;

            var rightUser = gridViewSel.SelectedRows[0].DataBoundItem as RightUser;
            if (rightUser == null)
                return;

            SelectedUsers.Remove(rightUser);
            NotSelectedUsers.Add(rightUser);
            BindingGridView();
            CurrentOperationStatus = OperationStatus.Edit;
        }

        //选中
        /// <summary>
        /// 选中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (gridViewUnSel.RowCount <= 0 || gridViewUnSel.SelectedRows.Count <= 0)
                return;

            var rightUser = gridViewUnSel.SelectedRows[0].DataBoundItem as RightUser;
            if (rightUser == null)
                return;

            NotSelectedUsers.Remove(rightUser);
            SelectedUsers.Add(rightUser);
            BindingGridView();
            CurrentOperationStatus = OperationStatus.Edit;
        }

        //用户组选择更改
        /// <summary>
        /// 用户组选择更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddlUserGroup_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
        {
            CurrentOperationStatus = OperationStatus.Default;

            QueryData();
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
            var insertRightLkUserGroup = BuildInsertEntity();
            var deleteRightLkUserGroup = BuildDeleteEntity();
            var result = RightLkUserGroupBll.Save(insertRightLkUserGroup, deleteRightLkUserGroup);

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