namespace RFIDProgram
{
    partial class FrmSystemFunc
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.pageViewMain = new Telerik.WinControls.UI.RadPageView();
            this.pageQueryData = new Telerik.WinControls.UI.RadPageViewPage();
            this.gbQueryResult = new Telerik.WinControls.UI.RadGroupBox();
            this.grdQueryResult = new RFIDProgram.FastGridView();
            this.panelMainTop = new Telerik.WinControls.UI.RadPanel();
            this.lblViewFuncCode = new Telerik.WinControls.UI.RadLabel();
            this.txtViewFuncName = new Telerik.WinControls.UI.RadTextBox();
            this.txtViewFuncCode = new Telerik.WinControls.UI.RadTextBox();
            this.lblViewFuncName = new Telerik.WinControls.UI.RadLabel();
            this.pageEditData = new Telerik.WinControls.UI.RadPageViewPage();
            this.lblFuncParam = new Telerik.WinControls.UI.RadLabel();
            this.txtFuncParam = new Telerik.WinControls.UI.RadTextBox();
            this.chkIsEnable = new Telerik.WinControls.UI.RadCheckBox();
            this.lblFuncName = new Telerik.WinControls.UI.RadLabel();
            this.lblFuncCode = new Telerik.WinControls.UI.RadLabel();
            this.txtFuncName = new Telerik.WinControls.UI.RadTextBox();
            this.txtFuncCode = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).BeginInit();
            this.pageViewMain.SuspendLayout();
            this.pageQueryData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbQueryResult)).BeginInit();
            this.gbQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMainTop)).BeginInit();
            this.panelMainTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewFuncCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViewFuncName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViewFuncCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewFuncName)).BeginInit();
            this.pageEditData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFuncParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFuncName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFuncCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncCode)).BeginInit();
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
            gridViewTextBoxColumn1.FieldName = "FuncCode";
            gridViewTextBoxColumn1.HeaderText = "编号";
            gridViewTextBoxColumn1.Name = "colFuncCode";
            gridViewTextBoxColumn1.Width = 151;
            gridViewTextBoxColumn2.FieldName = "FuncName";
            gridViewTextBoxColumn2.HeaderText = "名称";
            gridViewTextBoxColumn2.Name = "colFuncName";
            gridViewTextBoxColumn2.Width = 86;
            gridViewTextBoxColumn3.FieldName = "FuncParam";
            gridViewTextBoxColumn3.HeaderText = "参数";
            gridViewTextBoxColumn3.Name = "colFuncParam";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Width = 86;
            gridViewTextBoxColumn4.FieldName = "CreatedOn";
            gridViewTextBoxColumn4.HeaderText = "创建时间";
            gridViewTextBoxColumn4.Name = "colCreatedOn";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn4.Width = 151;
            gridViewTextBoxColumn5.FieldName = "CreatedBy";
            gridViewTextBoxColumn5.HeaderText = "创建者";
            gridViewTextBoxColumn5.Name = "colCreatedBy";
            gridViewTextBoxColumn5.Width = 120;
            gridViewTextBoxColumn6.FieldName = "ModifiedOn";
            gridViewTextBoxColumn6.HeaderText = "修改时间";
            gridViewTextBoxColumn6.Name = "colModifiedOn";
            gridViewTextBoxColumn6.Width = 151;
            gridViewTextBoxColumn7.FieldName = "ModifiedBy";
            gridViewTextBoxColumn7.HeaderText = "修改者";
            gridViewTextBoxColumn7.Name = "colModifiedBy";
            gridViewTextBoxColumn7.Width = 120;
            gridViewTextBoxColumn8.FieldName = "RecordStatus";
            gridViewTextBoxColumn8.HeaderText = "状态";
            gridViewTextBoxColumn8.Name = "colRecordStatus";
            gridViewTextBoxColumn8.Width = 83;
            this.grdQueryResult.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.grdQueryResult.Name = "grdQueryResult";
            this.grdQueryResult.ReadOnly = true;
            this.grdQueryResult.Size = new System.Drawing.Size(962, 379);
            this.grdQueryResult.TabIndex = 0;
            // 
            // panelMainTop
            // 
            this.panelMainTop.Controls.Add(this.lblViewFuncCode);
            this.panelMainTop.Controls.Add(this.txtViewFuncName);
            this.panelMainTop.Controls.Add(this.txtViewFuncCode);
            this.panelMainTop.Controls.Add(this.lblViewFuncName);
            this.panelMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTop.Location = new System.Drawing.Point(0, 0);
            this.panelMainTop.Name = "panelMainTop";
            this.panelMainTop.Size = new System.Drawing.Size(966, 83);
            this.panelMainTop.TabIndex = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panelMainTop.GetChildAt(0).GetChildAt(1))).Width = 0F;
            // 
            // lblViewFuncCode
            // 
            this.lblViewFuncCode.Location = new System.Drawing.Point(30, 16);
            this.lblViewFuncCode.Name = "lblViewFuncCode";
            this.lblViewFuncCode.Size = new System.Drawing.Size(29, 18);
            this.lblViewFuncCode.TabIndex = 16;
            this.lblViewFuncCode.Text = "编号";
            // 
            // txtViewFuncName
            // 
            this.txtViewFuncName.Location = new System.Drawing.Point(300, 46);
            this.txtViewFuncName.Name = "txtViewFuncName";
            this.txtViewFuncName.Size = new System.Drawing.Size(180, 20);
            this.txtViewFuncName.TabIndex = 2;
            this.txtViewFuncName.TabStop = false;
            // 
            // txtViewFuncCode
            // 
            this.txtViewFuncCode.Location = new System.Drawing.Point(30, 46);
            this.txtViewFuncCode.Name = "txtViewFuncCode";
            this.txtViewFuncCode.Size = new System.Drawing.Size(180, 20);
            this.txtViewFuncCode.TabIndex = 1;
            this.txtViewFuncCode.TabStop = false;
            // 
            // lblViewFuncName
            // 
            this.lblViewFuncName.Location = new System.Drawing.Point(300, 16);
            this.lblViewFuncName.Name = "lblViewFuncName";
            this.lblViewFuncName.Size = new System.Drawing.Size(29, 18);
            this.lblViewFuncName.TabIndex = 12;
            this.lblViewFuncName.Text = "名称";
            // 
            // pageEditData
            // 
            this.pageEditData.Controls.Add(this.lblFuncParam);
            this.pageEditData.Controls.Add(this.txtFuncParam);
            this.pageEditData.Controls.Add(this.chkIsEnable);
            this.pageEditData.Controls.Add(this.lblFuncName);
            this.pageEditData.Controls.Add(this.lblFuncCode);
            this.pageEditData.Controls.Add(this.txtFuncName);
            this.pageEditData.Controls.Add(this.txtFuncCode);
            this.pageEditData.Location = new System.Drawing.Point(10, 37);
            this.pageEditData.Name = "pageEditData";
            this.pageEditData.Size = new System.Drawing.Size(966, 481);
            this.pageEditData.Text = "数据编辑";
            // 
            // lblFuncParam
            // 
            this.lblFuncParam.Location = new System.Drawing.Point(568, 15);
            this.lblFuncParam.Name = "lblFuncParam";
            this.lblFuncParam.Size = new System.Drawing.Size(29, 18);
            this.lblFuncParam.TabIndex = 29;
            this.lblFuncParam.Text = "参数";
            // 
            // txtFuncParam
            // 
            this.txtFuncParam.Location = new System.Drawing.Point(568, 39);
            this.txtFuncParam.MaxLength = 50;
            this.txtFuncParam.Name = "txtFuncParam";
            this.txtFuncParam.Size = new System.Drawing.Size(180, 20);
            this.txtFuncParam.TabIndex = 28;
            this.txtFuncParam.TabStop = false;
            // 
            // chkIsEnable
            // 
            this.chkIsEnable.Location = new System.Drawing.Point(30, 95);
            this.chkIsEnable.Name = "chkIsEnable";
            this.chkIsEnable.Size = new System.Drawing.Size(66, 18);
            this.chkIsEnable.TabIndex = 27;
            this.chkIsEnable.Text = "是否可用";
            this.chkIsEnable.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // lblFuncName
            // 
            this.lblFuncName.Location = new System.Drawing.Point(300, 15);
            this.lblFuncName.Name = "lblFuncName";
            this.lblFuncName.Size = new System.Drawing.Size(29, 18);
            this.lblFuncName.TabIndex = 26;
            this.lblFuncName.Text = "名称";
            // 
            // lblFuncCode
            // 
            this.lblFuncCode.Location = new System.Drawing.Point(30, 15);
            this.lblFuncCode.Name = "lblFuncCode";
            this.lblFuncCode.Size = new System.Drawing.Size(29, 18);
            this.lblFuncCode.TabIndex = 25;
            this.lblFuncCode.Text = "编号";
            // 
            // txtFuncName
            // 
            this.txtFuncName.Location = new System.Drawing.Point(300, 39);
            this.txtFuncName.MaxLength = 50;
            this.txtFuncName.Name = "txtFuncName";
            this.txtFuncName.Size = new System.Drawing.Size(180, 20);
            this.txtFuncName.TabIndex = 3;
            this.txtFuncName.TabStop = false;
            // 
            // txtFuncCode
            // 
            this.txtFuncCode.Location = new System.Drawing.Point(30, 39);
            this.txtFuncCode.MaxLength = 50;
            this.txtFuncCode.Name = "txtFuncCode";
            this.txtFuncCode.Size = new System.Drawing.Size(180, 20);
            this.txtFuncCode.TabIndex = 2;
            this.txtFuncCode.TabStop = false;
            // 
            // FrmSystemFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 598);
            this.Controls.Add(this.pageViewMain);
            this.Name = "FrmSystemFunc";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "功能维护";
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
            ((System.ComponentModel.ISupportInitialize)(this.lblViewFuncCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViewFuncName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtViewFuncCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewFuncName)).EndInit();
            this.pageEditData.ResumeLayout(false);
            this.pageEditData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblFuncParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIsEnable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFuncName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFuncCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFuncCode)).EndInit();
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
        private Telerik.WinControls.UI.RadLabel lblViewFuncCode;
        private Telerik.WinControls.UI.RadTextBox txtViewFuncName;
        private Telerik.WinControls.UI.RadTextBox txtViewFuncCode;
        private Telerik.WinControls.UI.RadLabel lblViewFuncName;
        private Telerik.WinControls.UI.RadPageViewPage pageEditData;
        private Telerik.WinControls.UI.RadTextBox txtFuncName;
        private Telerik.WinControls.UI.RadTextBox txtFuncCode;
        private Telerik.WinControls.UI.RadCheckBox chkIsEnable;
        private Telerik.WinControls.UI.RadLabel lblFuncName;
        private Telerik.WinControls.UI.RadLabel lblFuncCode;
        private Telerik.WinControls.UI.RadLabel lblFuncParam;
        private Telerik.WinControls.UI.RadTextBox txtFuncParam;

    }
}