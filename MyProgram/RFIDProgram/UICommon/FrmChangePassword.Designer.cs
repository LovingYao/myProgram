namespace RFIDProgram
{
    partial class FrmChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCurrentUser = new Telerik.WinControls.UI.RadLabel();
            this.lblCurrentPwd = new Telerik.WinControls.UI.RadLabel();
            this.lblNewPwd = new Telerik.WinControls.UI.RadLabel();
            this.lblConfirmNewPwd = new Telerik.WinControls.UI.RadLabel();
            this.txtCurrentUser = new Telerik.WinControls.UI.RadTextBox();
            this.txtCurrentPwd = new Telerik.WinControls.UI.RadTextBox();
            this.txtPwdNew = new Telerik.WinControls.UI.RadTextBox();
            this.txtConfirmPwdNew = new Telerik.WinControls.UI.RadTextBox();
            this.btnOk = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.lblCurrentUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCurrentPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNewPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConfirmNewPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwdNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPwdNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Location = new System.Drawing.Point(50, 21);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(68, 16);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "当前用户：";
            // 
            // lblCurrentPwd
            // 
            this.lblCurrentPwd.Location = new System.Drawing.Point(50, 58);
            this.lblCurrentPwd.Name = "lblCurrentPwd";
            this.lblCurrentPwd.Size = new System.Drawing.Size(68, 16);
            this.lblCurrentPwd.TabIndex = 1;
            this.lblCurrentPwd.Text = "当前密码：";
            // 
            // lblNewPwd
            // 
            this.lblNewPwd.Location = new System.Drawing.Point(62, 95);
            this.lblNewPwd.Name = "lblNewPwd";
            this.lblNewPwd.Size = new System.Drawing.Size(56, 16);
            this.lblNewPwd.TabIndex = 2;
            this.lblNewPwd.Text = "新密码：";
            // 
            // lblConfirmNewPwd
            // 
            this.lblConfirmNewPwd.Location = new System.Drawing.Point(37, 132);
            this.lblConfirmNewPwd.Name = "lblConfirmNewPwd";
            this.lblConfirmNewPwd.Size = new System.Drawing.Size(81, 16);
            this.lblConfirmNewPwd.TabIndex = 3;
            this.lblConfirmNewPwd.Text = "确认新密码：";
            // 
            // txtCurrentUser
            // 
            this.txtCurrentUser.Enabled = false;
            this.txtCurrentUser.Location = new System.Drawing.Point(125, 20);
            this.txtCurrentUser.Name = "txtCurrentUser";
            this.txtCurrentUser.Size = new System.Drawing.Size(146, 18);
            this.txtCurrentUser.TabIndex = 1;
            this.txtCurrentUser.TabStop = false;
            // 
            // txtCurrentPwd
            // 
            this.txtCurrentPwd.Location = new System.Drawing.Point(125, 57);
            this.txtCurrentPwd.Name = "txtCurrentPwd";
            this.txtCurrentPwd.PasswordChar = '*';
            this.txtCurrentPwd.Size = new System.Drawing.Size(146, 18);
            this.txtCurrentPwd.TabIndex = 0;
            this.txtCurrentPwd.TabStop = false;
            // 
            // txtPwdNew
            // 
            this.txtPwdNew.Location = new System.Drawing.Point(125, 94);
            this.txtPwdNew.Name = "txtPwdNew";
            this.txtPwdNew.PasswordChar = '*';
            this.txtPwdNew.Size = new System.Drawing.Size(146, 18);
            this.txtPwdNew.TabIndex = 1;
            this.txtPwdNew.TabStop = false;
            // 
            // txtConfirmPwdNew
            // 
            this.txtConfirmPwdNew.Location = new System.Drawing.Point(125, 131);
            this.txtConfirmPwdNew.Name = "txtConfirmPwdNew";
            this.txtConfirmPwdNew.PasswordChar = '*';
            this.txtConfirmPwdNew.Size = new System.Drawing.Size(146, 18);
            this.txtConfirmPwdNew.TabIndex = 2;
            this.txtConfirmPwdNew.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(37, 175);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(108, 33);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "确  定";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(163, 175);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 33);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取  消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(329, 220);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtConfirmPwdNew);
            this.Controls.Add(this.txtPwdNew);
            this.Controls.Add(this.txtCurrentPwd);
            this.Controls.Add(this.txtCurrentUser);
            this.Controls.Add(this.lblConfirmNewPwd);
            this.Controls.Add(this.lblNewPwd);
            this.Controls.Add(this.lblCurrentPwd);
            this.Controls.Add(this.lblCurrentUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmChangePassword";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "修改密码";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmChangePassword_FormClosed);
            this.Shown += new System.EventHandler(this.FrmChangePassword_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.lblCurrentUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCurrentPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNewPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblConfirmNewPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCurrentPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPwdNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPwdNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel lblCurrentUser;
        private Telerik.WinControls.UI.RadLabel lblCurrentPwd;
        private Telerik.WinControls.UI.RadLabel lblNewPwd;
        private Telerik.WinControls.UI.RadLabel lblConfirmNewPwd;
        private Telerik.WinControls.UI.RadTextBox txtCurrentUser;
        private Telerik.WinControls.UI.RadTextBox txtCurrentPwd;
        private Telerik.WinControls.UI.RadTextBox txtPwdNew;
        private Telerik.WinControls.UI.RadTextBox txtConfirmPwdNew;
        private Telerik.WinControls.UI.RadButton btnOk;
        private Telerik.WinControls.UI.RadButton btnCancel;
    }
}