using System;
using System.Windows.Forms;
using TelerikWinformBase;

namespace RFIDProgram
{
    //功能组
    /// <summary>
    /// 功能组
    /// </summary>
    public partial class FrmSystemFuncGroup : FrmBaseData
    {
        //构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        private FrmSystemFuncGroup()
        {
            InitializeComponent();
            RegistEvents();
        }

        #region 窗体单例
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        private static FrmSystemFuncGroup _window;
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        public static FrmSystemFuncGroup Window
        {
            get
            {
                if (_window == null)
                {
                    _window = new FrmSystemFuncGroup();
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
            grdQueryResult.SelectionChanged += grdQueryResult_SelectionChanged;
            FormClosed += FrmSystemFuncGroup_FormClosed;
            Shown += FrmSystemFuncGroup_Shown;
        }

        //加载查询数据
        /// <summary>
        /// 加载查询数据
        /// </summary
        private void QueryData()
        {
            var condition = new QueryCondition
                                {
                                    GroupName = txtViewFuncGroupName.Text.Trim()
                                };
            var lstData = RightFunctionGroupBll.QueryRightFunctionGroup(condition);
            grdQueryResult.DataSource = lstData;
        }

        //编辑框验证
        /// <summary>
        /// 编辑框验证
        /// </summary>
        /// <returns></returns>
        private bool ValidateEditForm()
        {
            if (UI.EmptyText(txtFuncGroupName, "名称"))
                return false;

            return true;
        }

        //初始化编辑框
        /// <summary>
        /// 初始化编辑框
        /// </summary>
        private void InitEditForm()
        {
            if (EditEntity == null)
                return;

            UI.SetValue(txtFuncGroupName, EditEntity.GroupName);
            UI.SetValue(txtSequence, EditEntity.Sequence.ToString());
            UI.SetValue(chkIsEnable, EditEntity.RecordStatus);
        }

        //用编辑框数据填充实体
        /// <summary>
        /// 用编辑框数据填充实体
        /// </summary>
        private void BuildEntity()
        {
            if (CurrentOperationStatus == OperationStatus.New)
                EditEntity = new RightFunctionGroup
                                 {
                                     Sysid = Sysid.NewId(""),
                                     CreatedBy = GloableData.Instance.UserId
                                 };

            EditEntity.ModifiedBy = GloableData.Instance.UserId;
            EditEntity.GroupName = UI.GetValue(txtFuncGroupName);
            EditEntity.Sequence = UI.GetInt(txtSequence);
            EditEntity.RecordStatus = UI.GetValue(chkIsEnable);
        }

        //设置选中的实体
        /// <summary>
        /// 设置选中的实体
        /// </summary>
        private void SetSelectedEntity()
        {
            if (grdQueryResult.SelectedRows == null ||
                grdQueryResult.SelectedRows.Count <= 0)
                return;

            EditEntity = grdQueryResult.SelectedRows[0].DataBoundItem as RightFunctionGroup;

            InitEditForm();
        }

        #endregion

        #region 属性

        //当前编辑的实体
        /// <summary>
        /// 当前编辑的实体
        /// </summary>
        private RightFunctionGroup EditEntity { get; set; }

        #endregion

        #region 窗体事件

        //窗体第一次显示
        /// <summary>
        /// 窗体第一次显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemFuncGroup_Shown(object sender, EventArgs e)
        {
            Text = "功能组维护";
            pageViewMain.SelectedPage = pageQueryData;
            UI.ReadOnlyUi(pageEditData, true);
        }

        //窗体关闭完成
        /// <summary>
        /// 窗体关闭完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemFuncGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
            _window = null;
        }

        #endregion

        #region 事件方法

        //表格选中行更改的时候，设置当前选中行
        /// <summary>
        /// 表格选中行更改的时候，设置当前选中行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdQueryResult_SelectionChanged(object sender, EventArgs e)
        {
            if (CurrentOperationStatus != OperationStatus.Default)
                return;

            SetSelectedEntity();
        }

        #endregion

        #region CommandBar 事件

        //新增数据
        /// <summary>
        /// 新增数据
        /// </summary>
        /// <returns></returns>
        internal override bool Add()
        {
            EditEntity = null;
            pageViewMain.SelectedPage = pageEditData;
            UI.ClearUi(pageEditData);
            UI.ReadOnlyUi(pageEditData, false);

            var rightFunctionGroups = RightFunctionGroupBll.QueryAll();
            if (rightFunctionGroups != null && rightFunctionGroups.Count > 0)
                UI.SetValue(txtSequence, rightFunctionGroups.Count.ToString());

            return true;
        }

        //编辑数据
        /// <summary>
        /// 编辑数据
        /// </summary>
        /// <returns></returns>
        internal override bool Edit()
        {
            if (EditEntity == null)
            {
                UI.ShowWarn("请选择待编辑数据");
                return false;
            }

            UI.ReadOnlyUi(pageEditData, false);

            pageViewMain.SelectedPage = pageEditData;

            return true;
        }

        //保存数据
        /// <summary>
        /// 保存数据
        /// </summary>
        /// <returns></returns>
        internal override bool Save()
        {
            if (!ValidateEditForm())
                return false;

            string msg;

            BuildEntity();

            var result = CurrentOperationStatus == OperationStatus.New
                             ? RightFunctionGroupBll.InsertRightFunctionGroup(EditEntity, out msg)
                             : RightFunctionGroupBll.UpdateRightFunctionGroup(EditEntity, out msg);

            UI.ShowInfo(msg);

            if (result)
            {
                UI.ReadOnlyUi(pageEditData, true);
                SetSelectedEntity();
            }

            return result;
        }

        //取消编辑数据
        /// <summary>
        /// 取消编辑数据
        /// </summary>
        /// <returns></returns>
        internal override bool Cancel()
        {
            UI.ClearUi(pageEditData);
            SetSelectedEntity();
            UI.ReadOnlyUi(pageEditData, true);

            return true;
        }

        //删除数据
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <returns></returns>
        internal override bool Delete()
        {
            if (EditEntity == null)
            {
                UI.ShowWarn("请选择待删除数据");
                return false;
            }
            if (!UI.Confirm("确定要删除吗？"))
                return false;
            if (!RightFunctionGroupBll.DeleteRightFunctionGroup(EditEntity))
            {
                UI.ShowError("删除失败");
                return false;
            }
            EditEntity = null;
            UI.ClearUi(pageEditData);
            return true;
        }

        //查询数据
        /// <summary>
        /// 查询数据
        /// </summary>
        internal override bool Query()
        {
            QueryData();

            return true;
        }

        //导出数据
        /// <summary>
        /// 导出数据
        /// </summary>
        internal override bool Export()
        {
            //UI.ExportToExcel(grdQueryResult, "功能组");

            return true;
        }

        #endregion
    }
}