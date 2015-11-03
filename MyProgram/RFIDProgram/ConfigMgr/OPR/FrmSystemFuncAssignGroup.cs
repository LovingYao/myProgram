using AutoMapper;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.UI.Data;
using TelerikWinformBase;

namespace RFIDProgram
{
    //功能分组
    /// <summary>
    /// 功能分组
    /// </summary>
    public partial class FrmSystemFuncAssignGroup : FrmSimpleBaseData
    {
        //构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        private FrmSystemFuncAssignGroup()
        {
            InitializeComponent();
            RegistEvents();
        }

        #region 窗体单例
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        private static FrmSystemFuncAssignGroup _window;
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        public static FrmSystemFuncAssignGroup Window
        {
            get
            {
                if (_window == null)
                {
                    _window = new FrmSystemFuncAssignGroup();
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
            FormClosed += FrmSystemFunctionAssignGroup_FormClosed;
            Shown += FrmSystemFunctionAssignGroup_Shown;
        }

        //加载查询数据
        /// <summary>
        /// 加载查询数据
        /// </summary
        private void QueryData()
        {
            var selectedGroupSysid = UI.GetValue(ddlFunctionGroup);
            SelectedFunctions = RightLkFunctionGroupBll.QuerySelectedFunctionByGroupSysid(selectedGroupSysid);
            _selectedFunctionsInDb = Mapper.Map<List<RightFunction>, List<RightFunction>>(SelectedFunctions);
            NotSelectedFunctions = RightLkFunctionGroupBll.QueryNotSelectedFunctionByGroupSysid(selectedGroupSysid);

            BindingGridView();
        }

        //绑定下拉框
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        private void BindingDropDownList()
        {
            ddlFunctionGroup.SelectedIndexChanged -= ddlFunctionGroup_SelectedIndexChanged;
            ddlFunctionGroup.RefreshDataSource();
            ddlFunctionGroup.SelectedIndexChanged += ddlFunctionGroup_SelectedIndexChanged;
        }

        //绑定表格
        /// <summary>
        /// 绑定表格
        /// </summary>
        private void BindingGridView()
        {
            gridViewSel.DataSource = null;

            gridViewUnSel.DataSource = null;

            gridViewSel.DataSource = SelectedFunctions;

            ResetSequence();

            gridViewUnSel.DataSource = NotSelectedFunctions;
        }

        //构造新增的数据
        /// <summary>
        /// 构造新增的数据
        /// </summary>
        private List<RightLkFunctionGroup> BuildInsertEntity()
        {
            var insertList = new List<RightLkFunctionGroup>();
            var groupSysid = UI.GetValue(ddlFunctionGroup);
            for (var i = 0; i < SelectedFunctions.Count; i++)
            {
                var rightFunction = SelectedFunctions[i];
                var findInDb = _selectedFunctionsInDb.FindAll(p => p.Sysid == rightFunction.Sysid);
                if (findInDb.Count > 0)
                    continue;

                var rightLKFunctionGroup = new RightLkFunctionGroup
                                               {
                                                   GroupSysid = groupSysid,
                                                   FunctionSysid = rightFunction.Sysid,
                                                   Sequence = rightFunction.Sequence
                                               };
                insertList.Add(rightLKFunctionGroup);
            }
            return insertList;
        }

        //构造删除的数据
        /// <summary>
        /// 构造删除的数据
        /// </summary>
        private List<RightLkFunctionGroup> BuildDeleteEntity()
        {
            var deleteList = new List<RightLkFunctionGroup>();
            var groupSysid = UI.GetValue(ddlFunctionGroup);
            for (var i = 0; i < _selectedFunctionsInDb.Count; i++)
            {
                var rightFunction = _selectedFunctionsInDb[i];
                var findInDb = SelectedFunctions.FindAll(p => p.Sysid == rightFunction.Sysid);
                if (findInDb.Count > 0)
                    continue;

                var rightLKFunctionGroup = new RightLkFunctionGroup
                                               {
                                                   GroupSysid = groupSysid,
                                                   FunctionSysid = rightFunction.Sysid,
                                                   Sequence = rightFunction.Sequence
                                               };
                deleteList.Add(rightLKFunctionGroup);
            }
            return deleteList;
        }

        //构造更新的数据
        /// <summary>
        /// 构造更新的数据
        /// </summary>
        private List<RightLkFunctionGroup> BuildUpdateEntity()
        {
            var updateList = new List<RightLkFunctionGroup>();
            var groupSysid = UI.GetValue(ddlFunctionGroup);
            for (var i = 0; i < gridViewSel.Rows.Count; i++)
            {
                var rightFunction = gridViewSel.Rows[i].DataBoundItem as RightFunction;
                if (rightFunction == null)
                    continue;

                var findInDb = _selectedFunctionsInDb.FindAll(p => p.Sysid == rightFunction.Sysid);
                if (findInDb.Count <= 0)
                    continue;

                var rightLKFunctionGroup = new RightLkFunctionGroup
                                               {
                                                   GroupSysid = groupSysid,
                                                   FunctionSysid = rightFunction.Sysid,
                                                   Sequence = rightFunction.Sequence
                                               };
                updateList.Add(rightLKFunctionGroup);
            }
            return updateList;
        }

        //排序
        /// <summary>
        /// 排序
        /// </summary>
        private void ResetSequence()
        {
            if (gridViewSel.RowCount <= 0)
                return;

            for (var i = 0; i < gridViewSel.Rows.Count; i++)
            {
                var rightFunction = gridViewSel.Rows[i].DataBoundItem as RightFunction;
                if (rightFunction == null)
                    continue;

                rightFunction.Sequence = i;
            }
        }

        #endregion

        #region 属性

        //已经选择的功能
        /// <summary>
        /// 已经选择的功能
        /// </summary>
        private List<RightFunction> SelectedFunctions { get; set; }

        //未选择的功能
        /// <summary>
        /// 未选择的功能
        /// </summary>
        private List<RightFunction> NotSelectedFunctions { get; set; }

        private List<RightFunction> _selectedFunctionsInDb;

        #endregion

        #region 窗体事件

        //窗体加载完成
        /// <summary>
        /// 窗体加载完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemFuncAssignGroup_Load(object sender, EventArgs e)
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
        private void FrmSystemFunctionAssignGroup_Shown(object sender, EventArgs e)
        {
            Text = "功能分组";
            BindingDropDownList();
        }

        //窗体关闭完成
        /// <summary>
        /// 窗体关闭完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemFunctionAssignGroup_FormClosed(object sender, FormClosedEventArgs e)
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

            var rightFunction = gridViewSel.SelectedRows[0].DataBoundItem as RightFunction;
            if (rightFunction == null)
                return;

            SelectedFunctions.Remove(rightFunction);
            NotSelectedFunctions.Add(rightFunction);
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

            var rightFunction = gridViewUnSel.SelectedRows[0].DataBoundItem as RightFunction;
            if (rightFunction == null)
                return;

            NotSelectedFunctions.Remove(rightFunction);
            SelectedFunctions.Add(rightFunction);
            BindingGridView();
            CurrentOperationStatus = OperationStatus.Edit;
        }

        //用户组选择更改
        /// <summary>
        /// 用户组选择更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ddlFunctionGroup_SelectedIndexChanged(object sender, PositionChangedEventArgs e)
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

            var insertList = BuildInsertEntity();
            var deleteList = BuildDeleteEntity();
            var updateList = BuildUpdateEntity();
            var result = RightLkFunctionGroupBll.Save(insertList, deleteList, updateList);

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

        private void gridViewSel_KeyDown(object sender, KeyEventArgs e)
        {
            if (gridViewSel.RowCount <= 0)
                return;

            if (gridViewSel.SelectedRows.Count <= 0)
                return;

            var rightFunction = gridViewSel.SelectedRows[0].DataBoundItem as RightFunction;
            if (rightFunction == null)
                return;

            CurrentOperationStatus = OperationStatus.Edit;
            var rowIndex = gridViewSel.SelectedRows[0].Index;
            if (e.KeyCode == Keys.F5)
            {
                if (rowIndex <= 0)
                    return;
                SelectedFunctions.Remove(rightFunction);
                SelectedFunctions.Insert(rowIndex - 1, rightFunction);
            }
            if (e.KeyCode == Keys.F6)
            {
                if (rowIndex >= gridViewSel.RowCount - 1)
                    return;
                SelectedFunctions.Remove(rightFunction);
                SelectedFunctions.Insert(rowIndex + 1, rightFunction);
            }
            BindingGridView();
        }
    }
}