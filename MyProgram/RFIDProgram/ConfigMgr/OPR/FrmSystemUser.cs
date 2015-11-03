using System;
using System.Windows.Forms;
using TelerikWinformBase;

namespace RFIDProgram
{
    //用户管理
    /// <summary>
    /// 用户管理
    /// </summary>
    public partial class FrmSystemUser : FrmBaseData
    {
        //构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        private FrmSystemUser()
        {
            InitializeComponent();
            RegistEvents();
        }

        #region 窗体单例
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        private static FrmSystemUser _window;
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        public static FrmSystemUser Window
        {
            get
            {
                if (_window == null)
                {
                    _window = new FrmSystemUser();
                }
                return _window;
            }
        }
        #endregion

        #region 私有方法

        private void RegistEvents()
        {
            grdQueryResult.SelectionChanged += grdQueryResult_SelectionChanged;
            FormClosed += FrmSystemUser_FormClosed;
            Shown += FrmSystemUser_Shown;
        }

        //加载查询数据
        /// <summary>
        /// 加载查询数据
        /// </summary>
        private void QueryData()
        {
            var condition = new QueryCondition
                    {
                        DepartmentCode = UI.GetValue(ddlViewDepName),
                        UserId = UI.GetValue(txtViewUserId)
                    };
            var lstData = RightUserBll.QueryRightUser(condition);
            grdQueryResult.DataSource = lstData;
        }

        //绑定下拉框
        /// <summary>
        /// 绑定下拉框
        /// </summary>
        private void BindingDropDownList()
        {
            ddlDepName.RefreshDataSource();
            ddlViewDepName.RefreshDataSource();
        }

        //编辑框验证
        /// <summary>
        /// 编辑框验证
        /// </summary>
        /// <returns></returns>
        private bool ValidateEditForm()
        {
            if (UI.EmptyText(txtUserId, "工号"))
                return false;

            if (UI.EmptyText(txtUserName, "姓名"))
                return false;

            if (UI.EmptyText(ddlDepName, "车间"))
                return false;

            if (UI.EmptyText(txtEmail, "邮箱"))
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

            UI.SetValue(ddlDepName, EditEntity.Department);
            UI.SetValue(txtUserId, EditEntity.UserId);
            UI.SetValue(txtUserName, EditEntity.UserName);
            UI.SetValue(txtEmail, EditEntity.Email);
            UI.SetValue(chkIsEnable, EditEntity.RecordStatus);
        }

        //用编辑框数据填充实体
        /// <summary>
        /// 用编辑框数据填充实体
        /// </summary>
        private void BuildEntity()
        {
            if (CurrentOperationStatus == OperationStatus.New)
            {
                EditEntity = new RightUser
                                {
                                    Sysid = Sysid.NewId(""),
                                    UserPwd = CryptoHelper.ToMd5("123456"),
                                    CreatedBy = GloableData.Instance.UserId
                                };
            }
            else if (CurrentOperationStatus == OperationStatus.Edit)
            {
                if (UI.GetValue(chkIsChangePassword) == "1")
                {
                    EditEntity.UserPwd = CryptoHelper.ToMd5("123456");
                }
            }

            EditEntity.ModifiedBy = GloableData.Instance.UserId;
            EditEntity.Department = UI.GetValue(ddlDepName);
            EditEntity.UserId = UI.GetUpperValue(txtUserId);
            EditEntity.UserName = UI.GetValue(txtUserName);
            EditEntity.Email = UI.GetValue(txtEmail);
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

            EditEntity = grdQueryResult.SelectedRows[0].DataBoundItem as RightUser;

            InitEditForm();
        }

        #endregion

        #region 属性

        //当前编辑的实体
        /// <summary>
        /// 当前编辑的实体
        /// </summary>
        private RightUser EditEntity { get; set; }

        #endregion

        #region 窗体事件

        //窗体第一次显示
        /// <summary>
        /// 窗体第一次显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemUser_Shown(object sender, EventArgs e)
        {
            Text = "用户信息维护";
            pageViewMain.SelectedPage = pageSel;
            txtViewUserId.Text = "";

            BindingDropDownList();
            
            UI.ReadOnlyUi(pageEdit, true);
        }

        //窗体关闭完成
        /// <summary>
        /// 窗体关闭完成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmSystemUser_FormClosed(object sender, FormClosedEventArgs e)
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
            pageViewMain.SelectedPage = pageEdit;
            UI.ClearUi(pageEdit);
            UI.ReadOnlyUi(pageEdit, false);

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

            UI.ReadOnlyUi(pageEdit, false);

            pageViewMain.SelectedPage = pageEdit;

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
                             ? RightUserBll.InsertRightUser(EditEntity, out msg)
                             : RightUserBll.UpdateRightUser(EditEntity, out msg);

            UI.ShowInfo(msg);

            if (result)
            {
                UI.ReadOnlyUi(pageEdit, true);
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
            UI.ClearUi(pageEdit);
            SetSelectedEntity();
            UI.ReadOnlyUi(pageEdit, true);

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
            if (!RightUserBll.DeleteRightUser(EditEntity))
            {
                UI.ShowError("删除失败");
                return false;
            }
            EditEntity = null;
            UI.ClearUi(pageEdit);
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
           // UI.ExportToExcel(grdQueryResult, "System User");

            return true;
        }

        #endregion

        private void FrmSystemUser_Load(object sender, EventArgs e)
        {

        }
    }
}