namespace RFIDProgram
{
    partial class FrmSystemFuncGroup
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.pageViewMain = new Telerik.WinControls.UI.RadPageView();
            this.pageQueryData = new Telerik.WinControls.UI.RadPageViewPage();
            this.gbQueryResult = new Telerik.WinControls.UI.RadGroupBox();
            this.grdQueryResult = new RFIDProgram.FastGridView();
            this.panelMainTop = new Telerik.WinControls.UI.RadPanel();
            this.txtViewFuncGroupName = new Telerik.WinControls.UI.RadTextBox();
            this.lblViewFuncGroupName = new Telerik.WinControls.UI.RadLabel();
            this.pageEditData = new Telerik.WinControls.UI.RadPageViewPage();
            this.txtSequence = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.chkIsEnable = new Telerik.WinControls.UI.RadCheckBox();
            this.lblSequence = new Telerik.WinControls.UI.RadLabel();
            this.lblFuncGroupName = new Telerik.WinControls.UI.RadLabel();
            this.txtFuncGroupName = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).BeginInit();
            this.pageViewMain.SuspendLayout();
            this.pageQueryData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbQueryResult)).BeginInit();
            this.gbQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMainTop)).BeginInit();
            this.panelMainTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtViewFuncGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewFuncGroupName)).BeginInit();
            this.pageEditData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSequence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFuncGroupName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncGroupName)).BeginInit();
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
            this.pageViewMain.SelectedPage = this.pageQueryData;
            this.pageViewMain.Size = new System.Drawing.Size(987, 530);
            this.pageViewMain.TabIndex = 7;
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pageViewMain.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // pageQueryData
            // 
            this.pageQueryData.Controls.Add(this.gbQueryResult);
            this.pageQueryData.Controls.Add(this.panelMainTop);
            this.pageQueryData.Location = new System.Drawing.Point(10, 37);
            this.pageQueryData.Name = "pageQueryData";
            this.pageQueryData.Size = new System.Drawing.Size(966, 482);
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
            this.gbQueryResult.Size = new System.Drawing.Size(966, 399);
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
            gridViewTextBoxColumn1.Width = 108;
            gridViewTextBoxColumn2.FieldName = "Sequence";
            gridViewTextBoxColumn2.HeaderText = "排序";
            gridViewTextBoxColumn2.Name = "colSequence";
            gridViewTextBoxColumn2.Width = 48;
            gridViewTextBoxColumn3.FieldName = "CreatedOn";
            gridViewTextBoxColumn3.HeaderText = "创建时间";
            gridViewTextBoxColumn3.Name = "colCreatedOn";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn3.Width = 191;
            gridViewTextBoxColumn4.FieldName = "CreatedBy";
            gridViewTextBoxColumn4.HeaderText = "创建者";
            gridViewTextBoxColumn4.Name = "colCreatedBy";
            gridViewTextBoxColumn4.Width = 152;
            gridViewTextBoxColumn5.FieldName = "ModifiedOn";
            gridViewTextBoxColumn5.HeaderText = "修改时间";
            gridViewTextBoxColumn5.Name = "colModifiedOn";
            gridViewTextBoxColumn5.Width = 191;
            gridViewTextBoxColumn6.FieldName = "ModifiedBy";
            gridViewTextBoxColumn6.HeaderText = "修改者";
            gridViewTextBoxColumn6.Name = "colModifiedBy";
            gridViewTextBoxColumn6.Width = 152;
            gridViewTextBoxColumn7.FieldName = "RecordStatus";
            gridViewTextBoxColumn7.HeaderText = "状态";
            gridViewTextBoxColumn7.Name = "colRecordStatus";
            gridViewTextBoxColumn7.Width = 106;
            this.grdQueryResult.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.grdQueryResult.Name = "grdQueryResult";
            this.grdQueryResult.ReadOnly = true;
            this.grdQueryResult.Size = new System.Drawing.Size(962, 379);
            this.grdQueryResult.TabIndex = 0;
            // 
            // panelMainTop
            // 
            this.panelMainTop.Controls.Add(this.txtViewFuncGroupName);
            this.panelMainTop.Controls.Add(this.lblViewFuncGroupName);
            this.panelMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTop.Location = new System.Drawing.Point(0, 0);
            this.panelMainTop.Name = "panelMainTop";
            this.panelMainTop.Size = new System.Drawing.Size(966, 83);
            this.panelMainTop.TabIndex = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panelMainTop.GetChildAt(0).GetChildAt(1))).Width = 0F;
            // 
            // txtViewFuncGroupName
            // 
            this.txtViewFuncGroupName.Location = new System.Drawing.Point(37, 44);
            this.txtViewFuncGroupName.Name = "txtViewFuncGroupName";
            this.txtViewFuncGroupName.Size = new System.Drawing.Size(180, 20);
            this.txtViewFuncGroupName.TabIndex = 2;
            this.txtViewFuncGroupName.TabStop = false;
            // 
            // lblViewFuncGroupName
            // 
            this.lblViewFuncGroupName.Location = new System.Drawing.Point(37, 14);
            this.lblViewFuncGroupName.Name = "lblViewFuncGroupName";
            this.lblViewFuncGroupName.Size = new System.Drawing.Size(29, 18);
            this.lblViewFuncGroupName.TabIndex = 12;
            this.lblViewFuncGroupName.Text = "名称";
            // 
            // pageEditData
            // 
            this.pageEditData.Controls.Add(this.txtSequence);
            this.pageEditData.Controls.Add(this.chkIsEnable);
            this.pageEditData.Controls.Add(this.lblSequence);
            this.pageEditData.Controls.Add(this.lblFuncGroupName);
            this.pageEditData.Controls.Add(this.txtFuncGroupName);
            this.pageEditData.Location = new System.Drawing.Point(10, 37);
            this.pageEditData.Name = "pageEditData";
            this.pageEditData.Size = new System.Drawing.Size(966, 482);
            this.pageEditData.Text = "数据编辑";
            // 
            // txtSequence
            // 
            this.txtSequence.Culture = null;
            this.txtSequence.Location = new System.Drawing.Point(300, 46);
            this.txtSequence.Mask = "d";
            this.txtSequence.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(180, 20);
            this.txtSequence.TabIndex = 28;
            this.txtSequence.TabStop = false;
            this.txtSequence.Text = "0";
            this.txtSequence.Value = "0";
            // 
            // chkIsEnable
            // 
            this.chkIsEnable.Location = new System.Drawing.Point(570, 46);
            this.chkIsEnable.Name = "chkIsEnable";
            this.chkIsEnable.Size = new System.Drawing.Size(66, 18);
            this.chkIsEnable.TabIndex = 27;
            this.chkIsEnable.Text = "是否可用";
            this.chkIsEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // lblSequence
            // 
            this.lblSequence.Location = new System.Drawing.Point(300, 16);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Size = new System.Drawing.Size(29, 18);
            this.lblSequence.TabIndex = 26;
            this.lblSequence.Text = "排序";
            // 
            // lblFuncGroupName
            // 
            this.lblFuncGroupName.Location = new System.Drawing.Point(30, 16);
            this.lblFuncGroupName.Name = "lblFuncGroupName";
            this.lblFuncGroupName.Size = new System.Drawing.Size(29, 18);
            this.lblFuncGroupName.TabIndex = 26;
            this.lblFuncGroupName.Text = "名称";
            // 
            // txtFuncGroupName
            // 
            this.txtFuncGroupName.Location = new System.Drawing.Point(30, 46);
            this.txtFuncGroupName.MaxLength = 50;
            this.txtFuncGroupName.Name = "txtFuncGroupName";
            this.txtFuncGroupName.Size = new System.Drawing.Size(180, 20);
            this.txtFuncGroupName.TabIndex = 3;
            this.txtFuncGroupName.TabStop = false;
            // 
            // FrmSystemFuncGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 598);
            this.Controls.Add(this.pageViewMain);
            this.Name = "FrmSystemFuncGroup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "功能组维护";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtViewFuncGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewFuncGroupName)).EndInit();
            this.pageEditData.ResumeLayout(false);
            this.pageEditData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSequence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFuncGroupName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncGroupName)).EndInit();
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
        private Telerik.WinControls.UI.RadTextBox txtViewFuncGroupName;
        private Telerik.WinControls.UI.RadLabel lblViewFuncGroupName;
        private Telerik.WinControls.UI.RadPageViewPage pageEditData;
        private Telerik.WinControls.UI.RadTextBox txtFuncGroupName;
        private Telerik.WinControls.UI.RadCheckBox chkIsEnable;
        private Telerik.WinControls.UI.RadLabel lblFuncGroupName;
        private Telerik.WinControls.UI.RadLabel lblSequence;
        private Telerik.WinControls.UI.RadMaskedEditBox txtSequence;

    }
}