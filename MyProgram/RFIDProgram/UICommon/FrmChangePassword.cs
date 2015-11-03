using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using TelerikWinformBase;

namespace RFIDProgram
{
    //修改密码
    /// <summary>
    /// 修改密码
    /// </summary>
    internal partial class FrmChangePassword : RadForm
    {
        //构造方法
        /// <summary>
        /// 构造方法
        /// </summary>
        private FrmChangePassword()
        {
            InitializeComponent();
        }

        #region 单例

        private static readonly object LockObject = new object();
        private static FrmChangePassword _form;
        public static FrmChangePassword Form
        {
            get
            {
                if (_form == null)
                {
                    lock (LockObject)
                    {
                        if (_form == null)
                        {
                            _form = new FrmChangePassword();
                        }
                    }
                }

                return _form;
            }
        }

        #endregion

        //窗体第一次显示
        /// <summary>
        /// 窗体第一次显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmChangePassword_Shown(object sender, EventArgs e)
        {
            Text = "修改密码";
            txtCurrentUser.Text = GloableData.Instance.UserId;
        }

        //窗体关闭
        /// <summary>
        /// 窗体关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form = null;
        }

        //确定
        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            var currentUser = txtCurrentUser.Text.Trim();
            var currentPwd = txtCurrentPwd.Text.Trim();
            var pwdNew = txtPwdNew.Text.Trim();
            var pwdConfirmNew = txtConfirmPwdNew.Text.Trim();
            if (currentUser.Trim().Length <= 0)
            {
                UI.MsgBox("获取当前用户信息失败");
                return;
            }
            if (currentPwd.Trim().Length <= 0)
            {
                UI.MsgBox("当前密码不能为空");
                return;
            }
            if (pwdNew.Trim().Length <= 0)
            {
                UI.MsgBox("新密码不能为空");
                return;
            }
            if (pwdConfirmNew.Trim().Length <= 0)
            {
                UI.MsgBox("确认新密码不能为空");
                return;
            }
            if (pwdNew != pwdConfirmNew)
            {
                UI.MsgBox("新密码和确认新密码必须相同");
                return;
            }
            string msg;
            if (!RightUserBll.ChangeSelfPassword(currentUser, currentPwd, pwdNew, out msg))
            {
                UI.MsgBox(msg);
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        //取消
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}