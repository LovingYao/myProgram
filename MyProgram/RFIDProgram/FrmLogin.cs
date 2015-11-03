using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using TelerikWinformBase;


namespace RFIDProgram
{
    public partial class FrmLogin : RadForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (UI.EmptyText(txtUserId, "工号"))
            {
                this.txtUserId.Focus();
                return;
            }

            if (UI.EmptyText(txtUserPwd, "密码"))
            {
                this.txtUserPwd.Focus();
                return;
            }

            var userId = UI.GetValue(txtUserId);
            var userPwd = UI.GetValue(txtUserPwd);

            var user = RightUserBll.QueryRightUserByUserId(userId);

            if (user == null)
            {
                UI.MsgBox("工号在系统中不存在");
                txtUserId.SelectAll();
                txtUserId.Focus();
                return;
            }

            if (CryptoHelper.ToMd5(userPwd) != user.UserPwd)
            {
                UI.MsgBox("密码不正确");
                txtUserPwd.SelectAll();
                txtUserPwd.Focus();
                return;
            }

           


            GloableData.Instance.UserId = user.UserId;
           // GloableData.Instance.IsAdmin = RightUserBll.IsAdmin(new QueryCondition { UserId = user.UserId });

            DialogResult = DialogResult.OK;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtUserPwd_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode != Keys.Enter)
                return;

            btnSubmit_Click(sender, e);
        }

        private void txtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (UI.EmptyText(txtUserId, ""))
                return;

            txtUserPwd.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            gbForm.Focus();
            txtUserId.Focus();
        }
    }
}