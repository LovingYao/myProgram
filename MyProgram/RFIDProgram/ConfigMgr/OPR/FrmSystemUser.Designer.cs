using TelerikWinformBase;
namespace RFIDProgram
{
    partial class FrmSystemUser
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.pageViewMain = new Telerik.WinControls.UI.RadPageView();
            this.pageSel = new Telerik.WinControls.UI.RadPageViewPage();
            this.gbQueryResult = new Telerik.WinControls.UI.RadGroupBox();
            this.grdQueryResult = new RFIDProgram.FastGridView();
            this.panelMainTop = new Telerik.WinControls.UI.RadPanel();
            this.txtViewUserId = new Telerik.WinControls.UI.RadTextBox();
            this.lblViewUserId = new Telerik.WinControls.UI.RadLabel();
            this.ddlViewDepName = new RFIDProgram.FastDropDownList();
            this.ddlDepName = new RFIDProgram.FastDropDownList();
            this.lblViewDepName = new Telerik.WinControls.UI.RadLabel();
            this.pageEdit = new Telerik.WinControls.UI.RadPageViewPage();
            this.chkIsChangePassword = new Telerik.WinControls.UI.RadCheckBox();
            this.chkIsEnable = new Telerik.WinControls.UI.RadCheckBox();
            this.txtEmail = new Telerik.WinControls.UI.RadTextBox();
            this.lblDepName = new Telerik.WinControls.UI.RadLabel();
            this.lblEmail = new Telerik.WinControls.UI.RadLabel();
            this.txtUserName = new Telerik.WinControls.UI.RadTextBox();
            this.lblUserId = new Telerik.WinControls.UI.RadLabel();
            this.lblUserName = new Telerik.WinControls.UI.RadLabel();
            this.txtUserId = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).BeginInit();
            this.pageViewMain.SuspendLayout();
            this.pageSel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbQueryResult)).BeginInit();
            this.gbQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMainTop)).BeginInit();
            this.panelMainTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtViewUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlViewDepName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDepName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewDepName)).BeginInit();
            this.pageEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsChangePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDepName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pageViewMain
            // 
            this.pageViewMain.Controls.Add(this.pageSel);
            this.pageViewMain.Controls.Add(this.pageEdit);
            this.pageViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageViewMain.Location = new System.Drawing.Point(0, 68);
            this.pageViewMain.Name = "pageViewMain";
            this.pageViewMain.SelectedPage = this.pageSel;
            this.pageViewMain.Size = new System.Drawing.Size(987, 530);
            this.pageViewMain.TabIndex = 3;
            this.pageViewMain.Text = "radPageView1";
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.pageViewMain.GetChildAt(0).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // pageSel
            // 
            this.pageSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.pageSel.Controls.Add(this.gbQueryResult);
            this.pageSel.Controls.Add(this.panelMainTop);
            this.pageSel.Location = new System.Drawing.Point(10, 37);
            this.pageSel.Name = "pageSel";
            this.pageSel.Size = new System.Drawing.Size(966, 482);
            this.pageSel.Text = "数据查看";
            // 
            // gbQueryResult
            // 
            this.gbQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbQueryResult.Controls.Add(this.grdQueryResult);
            this.gbQueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbQueryResult.FooterImageIndex = -1;
            this.gbQueryResult.FooterImageKey = "";
            this.gbQueryResult.HeaderImageIndex = -1;
            this.gbQueryResult.HeaderImageKey = "";
            this.gbQueryResult.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbQueryResult.HeaderText = "查询结果";
            this.gbQueryResult.Location = new System.Drawing.Point(0, 83);
            this.gbQueryResult.Name = "gbQueryResult";
            this.gbQueryResult.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbQueryResult.Size = new System.Drawing.Size(966, 399);
            this.gbQueryResult.TabIndex = 3;
            this.gbQueryResult.Text = "查询结果";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.gbQueryResult.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.gbQueryResult.GetChildAt(0).GetChildAt(1).GetChildAt(0))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // grdQueryResult
            // 
            this.grdQueryResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdQueryResult.Location = new System.Drawing.Point(2, 18);
            // 
            // grdQueryResult
            // 
            this.grdQueryResult.MasterTemplate.AllowAddNewRow = false;
            this.grdQueryResult.MasterTemplate.AllowDeleteRow = false;
            this.grdQueryResult.MasterTemplate.AllowEditRow = false;
            this.grdQueryResult.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn19.FieldName = "UserId";
            gridViewTextBoxColumn19.HeaderText = "工号";
            gridViewTextBoxColumn19.Name = "colUserId";
            gridViewTextBoxColumn19.Width = 83;
            gridViewTextBoxColumn20.FieldName = "UserName";
            gridViewTextBoxColumn20.HeaderText = "姓名";
            gridViewTextBoxColumn20.Name = "colUserName";
            gridViewTextBoxColumn20.Width = 82;
            gridViewTextBoxColumn21.FieldName = "DepartmentName";
            gridViewTextBoxColumn21.HeaderText = "部门";
            gridViewTextBoxColumn21.Name = "colDepartmentName";
            gridViewTextBoxColumn21.Width = 128;
            gridViewTextBoxColumn22.FieldName = "Email";
            gridViewTextBoxColumn22.HeaderText = "邮箱";
            gridViewTextBoxColumn22.Name = "colEmail";
            gridViewTextBoxColumn22.Width = 188;
            gridViewTextBoxColumn23.FieldName = "CreatedOn";
            gridViewTextBoxColumn23.HeaderText = "创建时间";
            gridViewTextBoxColumn23.Name = "colCreatedOn";
            gridViewTextBoxColumn23.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn23.Width = 126;
            gridViewTextBoxColumn24.FieldName = "CreatedBy";
            gridViewTextBoxColumn24.HeaderText = "创建者";
            gridViewTextBoxColumn24.Name = "colCreatedBy";
            gridViewTextBoxColumn24.Width = 98;
            gridViewTextBoxColumn25.FieldName = "ModifiedOn";
            gridViewTextBoxColumn25.HeaderText = "修改时间";
            gridViewTextBoxColumn25.Name = "colModifiedOn";
            gridViewTextBoxColumn25.Width = 126;
            gridViewTextBoxColumn26.FieldName = "ModifiedBy";
            gridViewTextBoxColumn26.HeaderText = "修改者";
            gridViewTextBoxColumn26.Name = "colModifiedBy";
            gridViewTextBoxColumn26.Width = 98;
            gridViewTextBoxColumn27.FieldName = "RecordStatus";
            gridViewTextBoxColumn27.HeaderText = "状态";
            gridViewTextBoxColumn27.Name = "colRecordStatus";
            gridViewTextBoxColumn27.Width = 20;
            this.grdQueryResult.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21,
            gridViewTextBoxColumn22,
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26,
            gridViewTextBoxColumn27});
            this.grdQueryResult.Name = "grdQueryResult";
            this.grdQueryResult.ReadOnly = true;
            this.grdQueryResult.Size = new System.Drawing.Size(962, 379);
            this.grdQueryResult.TabIndex = 0;
            // 
            // panelMainTop
            // 
            this.panelMainTop.Controls.Add(this.txtViewUserId);
            this.panelMainTop.Controls.Add(this.lblViewUserId);
            this.panelMainTop.Controls.Add(this.ddlViewDepName);
            this.panelMainTop.Controls.Add(this.lblViewDepName);
            this.panelMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTop.Location = new System.Drawing.Point(0, 0);
            this.panelMainTop.Name = "panelMainTop";
            this.panelMainTop.Size = new System.Drawing.Size(966, 83);
            this.panelMainTop.TabIndex = 2;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panelMainTop.GetChildAt(0).GetChildAt(1))).Width = 0F;
            // 
            // txtViewUserId
            // 
            this.txtViewUserId.Location = new System.Drawing.Point(255, 38);
            this.txtViewUserId.Name = "txtViewUserId";
            this.txtViewUserId.Size = new System.Drawing.Size(161, 20);
            this.txtViewUserId.TabIndex = 51;
            this.txtViewUserId.TabStop = false;
            // 
            // lblViewUserId
            // 
            this.lblViewUserId.Location = new System.Drawing.Point(255, 17);
            this.lblViewUserId.Name = "lblViewUserId";
            this.lblViewUserId.Size = new System.Drawing.Size(29, 18);
            this.lblViewUserId.TabIndex = 50;
            this.lblViewUserId.Text = "工号";
            // 
            // ddlViewDepName
            // 
            this.ddlViewDepName.ContainEmptyItem = true;
            this.ddlViewDepName.DictionaryCode = TelerikWinformBase.DataDictionary.Workshop;
            this.ddlViewDepName.DropDownAnimationEnabled = true;
            this.ddlViewDepName.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlViewDepName.Location = new System.Drawing.Point(26, 39);
            this.ddlViewDepName.MaxDropDownItems = 0;
            this.ddlViewDepName.Name = "ddlViewDepName";
            this.ddlViewDepName.QueryCondition = null;
            this.ddlViewDepName.ReferenceDropDownList = this.ddlDepName;
            this.ddlViewDepName.ShowImageInEditorArea = true;
            this.ddlViewDepName.Size = new System.Drawing.Size(180, 20);
            this.ddlViewDepName.TabIndex = 44;
            this.ddlViewDepName.UsageFor = TelerikWinformBase.FastDropDownListUsageFor.DictionaryItem;
            // 
            // ddlDepName
            // 
            this.ddlDepName.ContainEmptyItem = true;
            this.ddlDepName.DictionaryCode = TelerikWinformBase.DataDictionary.Workshop;
            this.ddlDepName.DropDownAnimationEnabled = true;
            this.ddlDepName.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlDepName.Location = new System.Drawing.Point(463, 50);
            this.ddlDepName.MaxDropDownItems = 0;
            this.ddlDepName.Name = "ddlDepName";
            this.ddlDepName.QueryCondition = null;
            this.ddlDepName.ReferenceDropDownList = null;
            this.ddlDepName.ShowImageInEditorArea = true;
            this.ddlDepName.Size = new System.Drawing.Size(194, 20);
            this.ddlDepName.TabIndex = 12;
            this.ddlDepName.UsageFor = TelerikWinformBase.FastDropDownListUsageFor.DictionaryItem;
            // 
            // lblViewDepName
            // 
            this.lblViewDepName.Location = new System.Drawing.Point(26, 17);
            this.lblViewDepName.Name = "lblViewDepName";
            this.lblViewDepName.Size = new System.Drawing.Size(29, 18);
            this.lblViewDepName.TabIndex = 45;
            this.lblViewDepName.Text = "车间";
            // 
            // pageEdit
            // 
            this.pageEdit.Controls.Add(this.chkIsChangePassword);
            this.pageEdit.Controls.Add(this.chkIsEnable);
            this.pageEdit.Controls.Add(this.ddlDepName);
            this.pageEdit.Controls.Add(this.txtEmail);
            this.pageEdit.Controls.Add(this.lblDepName);
            this.pageEdit.Controls.Add(this.lblEmail);
            this.pageEdit.Controls.Add(this.txtUserName);
            this.pageEdit.Controls.Add(this.lblUserId);
            this.pageEdit.Controls.Add(this.lblUserName);
            this.pageEdit.Controls.Add(this.txtUserId);
            this.pageEdit.Location = new System.Drawing.Point(10, 37);
            this.pageEdit.Name = "pageEdit";
            this.pageEdit.Size = new System.Drawing.Size(966, 482);
            this.pageEdit.Text = "数据编辑";
            // 
            // chkIsChangePassword
            // 
            this.chkIsChangePassword.Location = new System.Drawing.Point(557, 127);
            this.chkIsChangePassword.Name = "chkIsChangePassword";
            this.chkIsChangePassword.Size = new System.Drawing.Size(100, 18);
            this.chkIsChangePassword.TabIndex = 16;
            this.chkIsChangePassword.Text = "是否初始化密码";
            // 
            // chkIsEnable
            // 
            this.chkIsEnable.Location = new System.Drawing.Point(461, 127);
            this.chkIsEnable.Name = "chkIsEnable";
            this.chkIsEnable.Size = new System.Drawing.Size(66, 18);
            this.chkIsEnable.TabIndex = 15;
            this.chkIsEnable.Text = "是否可用";
            this.chkIsEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(26, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(409, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TabStop = false;
            // 
            // lblDepName
            // 
            this.lblDepName.Location = new System.Drawing.Point(463, 26);
            this.lblDepName.Name = "lblDepName";
            this.lblDepName.Size = new System.Drawing.Size(29, 18);
            this.lblDepName.TabIndex = 9;
            this.lblDepName.Text = "部门";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(26, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(108, 18);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "邮箱（@之前部分）";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(241, 50);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(194, 20);
            this.txtUserName.TabIndex = 6;
            this.txtUserName.TabStop = false;
            // 
            // lblUserId
            // 
            this.lblUserId.Location = new System.Drawing.Point(29, 26);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(29, 18);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "工号";
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(241, 26);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(29, 18);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "姓名";
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(29, 50);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(194, 20);
            this.txtUserId.TabIndex = 7;
            this.txtUserId.TabStop = false;
            // 
            // FrmSystemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 598);
            this.Controls.Add(this.pageViewMain);
            this.Name = "FrmSystemUser";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.FrmSystemUser_Load);
            this.Controls.SetChildIndex(this.pageViewMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).EndInit();
            this.pageViewMain.ResumeLayout(false);
            this.pageSel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbQueryResult)).EndInit();
            this.gbQueryResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMainTop)).EndInit();
            this.panelMainTop.ResumeLayout(false);
            this.panelMainTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtViewUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlViewDepName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDepName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewDepName)).EndInit();
            this.pageEdit.ResumeLayout(false);
            this.pageEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsChangePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDepName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView pageViewMain;
        private Telerik.WinControls.UI.RadPageViewPage pageSel;
        private Telerik.WinControls.UI.RadPageViewPage pageEdit;
        private Telerik.WinControls.UI.RadTextBox txtUserName;
        private Telerik.WinControls.UI.RadLabel lblUserId;
        private Telerik.WinControls.UI.RadLabel lblUserName;
        private Telerik.WinControls.UI.RadTextBox txtUserId;
        private RFIDProgram.FastDropDownList ddlDepName;
        private Telerik.WinControls.UI.RadTextBox txtEmail;
        private Telerik.WinControls.UI.RadLabel lblDepName;
        private Telerik.WinControls.UI.RadLabel lblEmail;
        private Telerik.WinControls.UI.RadGroupBox gbQueryResult;
        private RFIDProgram.FastGridView grdQueryResult;
        private Telerik.WinControls.UI.RadPanel panelMainTop;
        private Telerik.WinControls.UI.RadTextBox txtViewUserId;
        private Telerik.WinControls.UI.RadLabel lblViewUserId;
        private RFIDProgram.FastDropDownList ddlViewDepName;
        private Telerik.WinControls.UI.RadLabel lblViewDepName;
        private Telerik.WinControls.UI.RadCheckBox chkIsEnable;
        private Telerik.WinControls.UI.RadCheckBox chkIsChangePassword;
    }
}