namespace RFIDProgram
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.gbForm = new Telerik.WinControls.UI.RadGroupBox();
            this.txtUserPwd = new Telerik.WinControls.UI.RadTextBox();
            this.lblUserPwd = new Telerik.WinControls.UI.RadLabel();
            this.txtUserId = new Telerik.WinControls.UI.RadTextBox();
            this.lblUserId = new Telerik.WinControls.UI.RadLabel();
            this.btnExit = new Telerik.WinControls.UI.RadButton();
            this.btnSubmit = new Telerik.WinControls.UI.RadButton();
            this.gbButton = new Telerik.WinControls.UI.RadGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gbForm)).BeginInit();
            this.gbForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbButton)).BeginInit();
            this.gbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbForm
            // 
            this.gbForm.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbForm.Controls.Add(this.txtUserPwd);
            this.gbForm.Controls.Add(this.lblUserPwd);
            this.gbForm.Controls.Add(this.txtUserId);
            this.gbForm.Controls.Add(this.lblUserId);
            this.gbForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbForm.FooterImageIndex = -1;
            this.gbForm.FooterImageKey = "";
            this.gbForm.HeaderImageIndex = -1;
            this.gbForm.HeaderImageKey = "";
            this.gbForm.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbForm.HeaderText = "";
            this.gbForm.Location = new System.Drawing.Point(0, 0);
            this.gbForm.Name = "gbForm";
            this.gbForm.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.gbForm.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbForm.Size = new System.Drawing.Size(300, 154);
            this.gbForm.TabIndex = 3;
            // 
            // txtUserPwd
            // 
            this.txtUserPwd.Location = new System.Drawing.Point(33, 107);
            this.txtUserPwd.Name = "txtUserPwd";
            this.txtUserPwd.PasswordChar = '*';
            this.txtUserPwd.Size = new System.Drawing.Size(211, 20);
            this.txtUserPwd.TabIndex = 4;
            this.txtUserPwd.TabStop = false;
            this.txtUserPwd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserPwd_KeyDown);
            // 
            // lblUserPwd
            // 
            this.lblUserPwd.Location = new System.Drawing.Point(33, 83);
            this.lblUserPwd.Name = "lblUserPwd";
            this.lblUserPwd.Size = new System.Drawing.Size(29, 18);
            this.lblUserPwd.TabIndex = 2;
            this.lblUserPwd.Text = "密码";
            // 
            // txtUserId
            // 
            this.txtUserId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserId.Location = new System.Drawing.Point(33, 45);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(211, 20);
            this.txtUserId.TabIndex = 3;
            this.txtUserId.TabStop = false;
            this.txtUserId.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserId_KeyDown);
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(33, 21);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(40, 18);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "用户名";
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(164, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 24);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "退 出";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(33, 10);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 24);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "登 录";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbButton
            // 
            this.gbButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbButton.Controls.Add(this.btnExit);
            this.gbButton.Controls.Add(this.btnSubmit);
            this.gbButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbButton.FooterImageIndex = -1;
            this.gbButton.FooterImageKey = "";
            this.gbButton.HeaderImageIndex = -1;
            this.gbButton.HeaderImageKey = "";
            this.gbButton.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbButton.HeaderText = "";
            this.gbButton.Location = new System.Drawing.Point(0, 154);
            this.gbButton.Name = "gbButton";
            this.gbButton.Padding = new System.Windows.Forms.Padding(2);
            // 
            // 
            // 
            this.gbButton.RootElement.Padding = new System.Windows.Forms.Padding(2);
            this.gbButton.Size = new System.Drawing.Size(300, 60);
            this.gbButton.TabIndex = 6;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 214);
            this.Controls.Add(this.gbButton);
            this.Controls.Add(this.gbForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID System";
            this.ThemeName = "ControlDefault";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbForm)).EndInit();
            this.gbForm.ResumeLayout(false);
            this.gbForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbButton)).EndInit();
            this.gbButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gbForm;
        private Telerik.WinControls.UI.RadTextBox txtUserPwd;
        private Telerik.WinControls.UI.RadLabel lblUserPwd;
        private Telerik.WinControls.UI.RadTextBox txtUserId;
        private Telerik.WinControls.UI.RadLabel lblUserId;
        private Telerik.WinControls.UI.RadButton btnExit;
        private Telerik.WinControls.UI.RadButton btnSubmit;
        private Telerik.WinControls.UI.RadGroupBox gbButton;
    }
}
