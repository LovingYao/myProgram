namespace RFIDProgram
{
    partial class FrmSystemUserGroup
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.pageViewMain = new Telerik.WinControls.UI.RadPageView();
            this.pageQueryData = new Telerik.WinControls.UI.RadPageViewPage();
            this.gbQueryResult = new Telerik.WinControls.UI.RadGroupBox();
            this.grdQueryResult = new RFIDProgram.FastGridView();
            this.panelMainTop = new Telerik.WinControls.UI.RadPanel();
            this.lblViewGroupName = new Telerik.WinControls.UI.RadLabel();
            this.txtViewGroupName = new Telerik.WinControls.UI.RadTextBox();
            this.pageEditData = new Telerik.WinControls.UI.RadPageViewPage();
            this.chkRecordStatus = new Telerik.WinControls.UI.RadCheckBox();
            this.lblGroupName = new Telerik.WinControls.UI.RadLabel();
            this.txtGroupName = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).BeginInit();
            this.pageViewMain.SuspendLayout();
            this.pageQueryData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbQueryResult)).BeginInit();
            this.gbQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMainTop)).BeginInit();
            this.panelMainTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViewGroupName)).BeginInit();
            this.pageEditData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkRecordStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pageViewMain
            // 
            this.pageViewMain.Controls.Add(this.pageQueryData);
            this.pageViewMain.Controls.Add(this.pageEditData);
            this.pageViewMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageViewMain.Location = new System.Drawing.Point(0, 68);
            this.pageViewMain.Name = "pageViewMain";
            this.pageViewMain.SelectedPage = this.pageEditData;
            this.pageViewMain.Size = new System.Drawing.Size(987, 529);
            this.pageViewMain.TabIndex = 8;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageViewMain.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // pageQueryData
            // 
            this.pageQueryData.Controls.Add(this.gbQueryResult);
            this.pageQueryData.Controls.Add(this.panelMainTop);
            this.pageQueryData.Location = new System.Drawing.Point(10, 37);
            this.pageQueryData.Name = "pageQueryData";
            this.pageQueryData.Size = new System.Drawing.Size(966, 481);
            this.pageQueryData.Text = "数据查看";
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
            // 
            // 
            // 
            this.gbQueryResult.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbQueryResult.Size = new System.Drawing.Size(966, 398);
            this.gbQueryResult.TabIndex = 1;
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
            gridViewTextBoxColumn1.FieldName = "GroupName";
            gridViewTextBoxColumn1.HeaderText = "名称";
            gridViewTextBoxColumn1.Name = "colGroupName";
            gridViewTextBoxColumn1.Width = 114;
            gridViewTextBoxColumn2.FieldName = "CreatedOn";
            gridViewTextBoxColumn2.HeaderText = "创建时间";
            gridViewTextBoxColumn2.Name = "colCreatedOn";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.FieldName = "CreatedBy";
            gridViewTextBoxColumn3.HeaderText = "创建者";
            gridViewTextBoxColumn3.Name = "colCreatedBy";
            gridViewTextBoxColumn3.Width = 160;
            gridViewTextBoxColumn4.FieldName = "ModifiedOn";
            gridViewTextBoxColumn4.HeaderText = "修改时间";
            gridViewTextBoxColumn4.Name = "colModifiedOn";
            gridViewTextBoxColumn4.Width = 200;
            gridViewTextBoxColumn5.FieldName = "ModifiedBy";
            gridViewTextBoxColumn5.HeaderText = "修改者";
            gridViewTextBoxColumn5.Name = "colModifiedBy";
            gridViewTextBoxColumn5.Width = 160;
            gridViewTextBoxColumn6.FieldName = "RecordStatus";
            gridViewTextBoxColumn6.HeaderText = "状态";
            gridViewTextBoxColumn6.Name = "colRecordStatus";
            gridViewTextBoxColumn6.Width = 113;
            this.grdQueryResult.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.grdQueryResult.Name = "grdQueryResult";
            this.grdQueryResult.ReadOnly = true;
            this.grdQueryResult.Size = new System.Drawing.Size(962, 378);
            this.grdQueryResult.TabIndex = 0;
            // 
            // panelMainTop
            // 
            this.panelMainTop.Controls.Add(this.lblViewGroupName);
            this.panelMainTop.Controls.Add(this.txtViewGroupName);
            this.panelMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTop.Location = new System.Drawing.Point(0, 0);
            this.panelMainTop.Name = "panelMainTop";
            this.panelMainTop.Size = new System.Drawing.Size(966, 83);
            this.panelMainTop.TabIndex = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panelMainTop.GetChildAt(0).GetChildAt(1))).Width = 0F;
            // 
            // lblViewGroupName
            // 
            this.lblViewGroupName.Location = new System.Drawing.Point(30, 16);
            this.lblViewGroupName.Name = "lblViewGroupName";
            this.lblViewGroupName.Size = new System.Drawing.Size(29, 18);
            this.lblViewGroupName.TabIndex = 16;
            this.lblViewGroupName.Text = "名称";
            // 
            // txtViewGroupName
            // 
            this.txtViewGroupName.Location = new System.Drawing.Point(30, 39);
            this.txtViewGroupName.Name = "txtViewGroupName";
            this.txtViewGroupName.Size = new System.Drawing.Size(180, 20);
            this.txtViewGroupName.TabIndex = 1;
            this.txtViewGroupName.TabStop = false;
            // 
            // pageEditData
            // 
            this.pageEditData.Controls.Add(this.chkRecordStatus);
            this.pageEditData.Controls.Add(this.lblGroupName);
            this.pageEditData.Controls.Add(this.txtGroupName);
            this.pageEditData.Location = new System.Drawing.Point(10, 37);
            this.pageEditData.Name = "pageEditData";
            this.pageEditData.Size = new System.Drawing.Size(966, 481);
            this.pageEditData.Text = "数据编辑";
            // 
            // chkRecordStatus
            // 
            this.chkRecordStatus.Location = new System.Drawing.Point(295, 38);
            this.chkRecordStatus.Name = "chkRecordStatus";
            this.chkRecordStatus.Size = new System.Drawing.Size(66, 18);
            this.chkRecordStatus.TabIndex = 32;
            this.chkRecordStatus.Text = "是否可用";
            // 
            // lblGroupName
            // 
            this.lblGroupName.Location = new System.Drawing.Point(25, 14);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(29, 18);
            this.lblGroupName.TabIndex = 30;
            this.lblGroupName.Text = "名称";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(25, 38);
            this.txtGroupName.MaxLength = 50;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(180, 20);
            this.txtGroupName.TabIndex = 28;
            this.txtGroupName.TabStop = false;
            // 
            // FrmSystemUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 597);
            this.Controls.Add(this.pageViewMain);
            this.Name = "FrmSystemUserGroup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "用户组维护";
            this.Controls.SetChildIndex(this.pageViewMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).EndInit();
            this.pageViewMain.ResumeLayout(false);
            this.pageQueryData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbQueryResult)).EndInit();
            this.gbQueryResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMainTop)).EndInit();
            this.panelMainTop.ResumeLayout(false);
            this.panelMainTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViewGroupName)).EndInit();
            this.pageEditData.ResumeLayout(false);
            this.pageEditData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkRecordStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView pageViewMain;
        private Telerik.WinControls.UI.RadPageViewPage pageQueryData;
        private Telerik.WinControls.UI.RadGroupBox gbQueryResult;
        private RFIDProgram.FastGridView grdQueryResult;
        private Telerik.WinControls.UI.RadPanel panelMainTop;
        private Telerik.WinControls.UI.RadLabel lblViewGroupName;
        private Telerik.WinControls.UI.RadTextBox txtViewGroupName;
        private Telerik.WinControls.UI.RadPageViewPage pageEditData;
        private Telerik.WinControls.UI.RadCheckBox chkRecordStatus;
        private Telerik.WinControls.UI.RadLabel lblGroupName;
        private Telerik.WinControls.UI.RadTextBox txtGroupName;

    }
}