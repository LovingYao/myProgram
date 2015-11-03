
using System;
using System.Windows.Forms;
using TelerikWinformBase;



namespace RFIDProgram
{
    //功能管理
    /// <summary>
    /// 功能管理
    /// </summary>
    public partial class FrmSystemFunc : FrmBaseData
    {
        //构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        private FrmSystemFunc()
        {
            InitializeComponent();
            RegistEvents();
        }

        #region 窗体单例
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        private static FrmSystemFunc _window;
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        public static FrmSystemFunc Window
        {
            get
            {
                if (_window == null)
                {
                    _window = new FrmSystemFunc();
                }
                return _window;
            }
        }
        #endregion

        #region 私有方法

        private void RegistEvents()
        {
            grdQueryResult.SelectionChanged += grdQueryResult_SelectionChanged;
            FormClosed += FrmSystemFunc_FormClosed;
            Shown += FrmSystemFunc_Shown;
        }

        //加载查询数据
        /// <summary>
        /// 加载查询数据
        /// </summary
        private void QueryData()
        {
            var condition = new QueryCondition
                                {
                                    Code = UI.GetValue(txtViewFuncCode),
                                    GroupName = UI.GetValue(txtViewFuncName)
                                };
            var lstData = RightFunctionBll.QueryRightFunction(condition);
            grdQueryResult.DataSource = lstData;
        }

        //编辑框验证
        /// <summary>
        /// 编辑框验证
        /// </summary>
        /// <returns></returns>
        private bool ValidateEditForm()
        {
            if (UI.EmptyText(txtFuncCode, "编号"))
                return false;

            if (UI.EmptyText(txtFuncName, "名称"))
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

            UI.SetValue(txtFuncCode, EditEntity.FuncCode);
            UI.SetValue(txtFuncName, EditEntity.FuncName);
            UI.SetValue(txtFuncParam, EditEntity.FuncParam);
            UI.SetValue(chkIsEnable, EditEntity.RecordStatus);
        }

        //用编辑框数据填充实体
        /// <summary>
        /// 用编辑框数据填充实体
        /// </summary>
        private void BuildEntity()
        {

            if (CurrentOperationStatus == OperationStatus.New)
                EditEntity = new RightFunction
                    {
                        Sysid = Sysid.NewId(""),
                        CreatedBy = GloableData.Instance.UserId
                    };

            EditEntity.ModifiedBy = GloableData.Instance.UserId;

            EditEntity.FuncCode = UI.GetValue(txtFuncCode);
            EditEntity.FuncName = UI.GetValue(txtFuncName);
            EditEntity.FuncParam = UI.GetValue(txtFuncParam);
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

            EditEntity = grdQueryResult.SelectedRows[0].DataBoundItem as RightFunction;

            InitEditForm();
        }

        #endregion

        #region 属性

        //当前编辑的实体
        /// <summary>
        /// 当前编辑的实体
        /// </summary>
        private RightFunction EditEntity { get; set; }

        #endregion

        #region 窗体事件

        //窗体第一次显示
        /// <summary>
        /// 窗体第一次显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemFunc_Shown(object sender, EventArgs e)
        {
            pageViewMain.SelectedPage = pageQueryData;
            UI.ReadOnlyUi(pageEditData, true);
        }

        //窗体关闭完成
        /// <summary>
        /// 窗体关闭完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemFunc_FormClosed(object sender, FormClosedEventArgs e)
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
                             ? RightFunctionBll.InsertRightFunction(EditEntity, out msg)
                             : RightFunctionBll.UpdateRightFunction(EditEntity, out msg);

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
            if (!RightFunctionBll.DeleteRightFunction(EditEntity))
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
            //UI.ExportToExcel(grdQueryResult, "系统功能");

            return true;
        }

        #endregion
    }
}