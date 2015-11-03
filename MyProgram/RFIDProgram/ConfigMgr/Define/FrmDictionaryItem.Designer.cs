using TelerikWinformBase;
namespace RFIDProgram
{
    partial class FrmDictionaryItem
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
            this.ddlViewDictionaryCode = new RFIDProgram.FastDropDownList();
            this.ddlDictionaryCode = new RFIDProgram.FastDropDownList();
            this.lblViewDictionaryCode = new Telerik.WinControls.UI.RadLabel();
            this.pageEditData = new Telerik.WinControls.UI.RadPageViewPage();
            this.txtSequence = new Telerik.WinControls.UI.RadMaskedEditBox();
            this.lblSequence = new Telerik.WinControls.UI.RadLabel();
            this.txtRemark = new Telerik.WinControls.UI.RadTextBox();
            this.lblRemark = new Telerik.WinControls.UI.RadLabel();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.lblName = new Telerik.WinControls.UI.RadLabel();
            this.txtCode = new Telerik.WinControls.UI.RadTextBox();
            this.lblCode = new Telerik.WinControls.UI.RadLabel();
            this.lblDictionaryCode = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pageViewMain)).BeginInit();
            this.pageViewMain.SuspendLayout();
            this.pageQueryData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbQueryResult)).BeginInit();
            this.gbQueryResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdQueryResult.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMainTop)).BeginInit();
            this.panelMainTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlViewDictionaryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDictionaryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewDictionaryCode)).BeginInit();
            this.pageEditData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSequence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRemark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDictionaryCode)).BeginInit();
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
            this.pageViewMain.Size = new System.Drawing.Size(970, 528);
            this.pageViewMain.TabIndex = 4;
            this.pageViewMain.Text = "radPageView1";
            ((Telerik.WinControls.UI.StripViewButtonsPanel)(this.pageViewMain.GetChildAt(0).GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            // 
            // pageQueryData
            // 
            this.pageQueryData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(240)))), ((int)(((byte)(249)))));
            this.pageQueryData.Controls.Add(this.gbQueryResult);
            this.pageQueryData.Controls.Add(this.panelMainTop);
            this.pageQueryData.Location = new System.Drawing.Point(10, 37);
            this.pageQueryData.Name = "pageQueryData";
            this.pageQueryData.Size = new System.Drawing.Size(949, 480);
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
            this.gbQueryResult.Size = new System.Drawing.Size(949, 397);
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
            gridViewTextBoxColumn1.FieldName = "DictionaryCode";
            gridViewTextBoxColumn1.HeaderText = "字典编号";
            gridViewTextBoxColumn1.Name = "colDictionaryCode";
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn2.FieldName = "DictionaryName";
            gridViewTextBoxColumn2.HeaderText = "字典名称";
            gridViewTextBoxColumn2.Name = "colDictionaryName";
            gridViewTextBoxColumn2.Width = 150;
            gridViewTextBoxColumn3.FieldName = "Code";
            gridViewTextBoxColumn3.HeaderText = "项目编号";
            gridViewTextBoxColumn3.Name = "colCode";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.FieldName = "Name";
            gridViewTextBoxColumn4.HeaderText = "项目名称";
            gridViewTextBoxColumn4.Name = "colName";
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.FieldName = "Sequence";
            gridViewTextBoxColumn5.HeaderText = "项目序号";
            gridViewTextBoxColumn5.Name = "colSequence";
            gridViewTextBoxColumn5.Width = 150;
            gridViewTextBoxColumn6.FieldName = "Remark";
            gridViewTextBoxColumn6.HeaderText = "备注";
            gridViewTextBoxColumn6.Name = "colRemark";
            gridViewTextBoxColumn6.Width = 150;
            this.grdQueryResult.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6});
            this.grdQueryResult.Name = "grdQueryResult";
            this.grdQueryResult.ReadOnly = true;
            this.grdQueryResult.Size = new System.Drawing.Size(945, 377);
            this.grdQueryResult.TabIndex = 0;
            // 
            // panelMainTop
            // 
            this.panelMainTop.Controls.Add(this.ddlViewDictionaryCode);
            this.panelMainTop.Controls.Add(this.lblViewDictionaryCode);
            this.panelMainTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainTop.Location = new System.Drawing.Point(0, 0);
            this.panelMainTop.Name = "panelMainTop";
            this.panelMainTop.Size = new System.Drawing.Size(949, 83);
            this.panelMainTop.TabIndex = 2;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panelMainTop.GetChildAt(0).GetChildAt(1))).Width = 0F;
            // 
            // ddlViewDictionaryCode
            // 
            this.ddlViewDictionaryCode.ContainEmptyItem = true;
            this.ddlViewDictionaryCode.DictionaryCode = DataDictionary.Workshop;
            this.ddlViewDictionaryCode.DropDownAnimationEnabled = true;
            this.ddlViewDictionaryCode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlViewDictionaryCode.Location = new System.Drawing.Point(63, 40);
            this.ddlViewDictionaryCode.Name = "ddlViewDictionaryCode";
            this.ddlViewDictionaryCode.QueryCondition = null;
            this.ddlViewDictionaryCode.ReferenceDropDownList = this.ddlDictionaryCode;
            this.ddlViewDictionaryCode.ShowImageInEditorArea = true;
            this.ddlViewDictionaryCode.Size = new System.Drawing.Size(165, 20);
            this.ddlViewDictionaryCode.TabIndex = 49;
            this.ddlViewDictionaryCode.UsageFor = FastDropDownListUsageFor.Dictionary;
            // 
            // ddlDictionaryCode
            // 
            this.ddlDictionaryCode.ContainEmptyItem = false;
            this.ddlDictionaryCode.DictionaryCode = DataDictionary.Workshop;
            this.ddlDictionaryCode.DropDownAnimationEnabled = true;
            this.ddlDictionaryCode.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlDictionaryCode.Location = new System.Drawing.Point(42, 38);
            this.ddlDictionaryCode.Name = "ddlDictionaryCode";
            this.ddlDictionaryCode.QueryCondition = null;
            this.ddlDictionaryCode.ReferenceDropDownList = null;
            this.ddlDictionaryCode.ShowImageInEditorArea = true;
            this.ddlDictionaryCode.Size = new System.Drawing.Size(165, 20);
            this.ddlDictionaryCode.TabIndex = 53;
            this.ddlDictionaryCode.UsageFor = FastDropDownListUsageFor.Dictionary;
            // 
            // lblViewDictionaryCode
            // 
            this.lblViewDictionaryCode.Location = new System.Drawing.Point(63, 18);
            this.lblViewDictionaryCode.Name = "lblViewDictionaryCode";
            this.lblViewDictionaryCode.Size = new System.Drawing.Size(52, 18);
            this.lblViewDictionaryCode.TabIndex = 48;
            this.lblViewDictionaryCode.Text = "数据字典";
            // 
            // pageEditData
            // 
            this.pageEditData.Controls.Add(this.txtSequence);
            this.pageEditData.Controls.Add(this.lblSequence);
            this.pageEditData.Controls.Add(this.txtRemark);
            this.pageEditData.Controls.Add(this.lblRemark);
            this.pageEditData.Controls.Add(this.txtName);
            this.pageEditData.Controls.Add(this.lblName);
            this.pageEditData.Controls.Add(this.txtCode);
            this.pageEditData.Controls.Add(this.lblCode);
            this.pageEditData.Controls.Add(this.ddlDictionaryCode);
            this.pageEditData.Controls.Add(this.lblDictionaryCode);
            this.pageEditData.Location = new System.Drawing.Point(10, 37);
            this.pageEditData.Name = "pageEditData";
            this.pageEditData.Size = new System.Drawing.Size(949, 480);
            this.pageEditData.Text = "数据编辑";
            // 
            // txtSequence
            // 
            this.txtSequence.Culture = null;
            this.txtSequence.Location = new System.Drawing.Point(42, 94);
            this.txtSequence.Mask = "n0";
            this.txtSequence.MaskType = Telerik.WinControls.UI.MaskType.Numeric;
            this.txtSequence.Name = "txtSequence";
            this.txtSequence.Size = new System.Drawing.Size(165, 20);
            this.txtSequence.TabIndex = 57;
            this.txtSequence.TabStop = false;
            this.txtSequence.Text = "0";
            this.txtSequence.Value = "0";
            // 
            // lblSequence
            // 
            this.lblSequence.Location = new System.Drawing.Point(42, 74);
            this.lblSequence.Name = "lblSequence";
            this.lblSequence.Size = new System.Drawing.Size(29, 18);
            this.lblSequence.TabIndex = 56;
            this.lblSequence.Text = "序号";
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(297, 95);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(441, 20);
            this.txtRemark.TabIndex = 55;
            this.txtRemark.TabStop = false;
            // 
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(297, 74);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(29, 18);
            this.lblRemark.TabIndex = 54;
            this.lblRemark.Text = "备注";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(562, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 55;
            this.txtName.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(562, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 54;
            this.lblName.Text = "项目名称";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(297, 37);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(180, 20);
            this.txtCode.TabIndex = 55;
            this.txtCode.TabStop = false;
            // 
            // lblCode
            // 
            this.lblCode.Location = new System.Drawing.Point(297, 16);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(52, 18);
            this.lblCode.TabIndex = 54;
            this.lblCode.Text = "项目编号";
            // 
            // lblDictionaryCode
            // 
            this.lblDictionaryCode.Location = new System.Drawing.Point(42, 16);
            this.lblDictionaryCode.Name = "lblDictionaryCode";
            this.lblDictionaryCode.Size = new System.Drawing.Size(52, 18);
            this.lblDictionaryCode.TabIndex = 52;
            this.lblDictionaryCode.Text = "字典名称";
            // 
            // FrmDictionaryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 596);
            this.Controls.Add(this.pageViewMain);
            this.Name = "FrmDictionaryItem";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "字典项目维护";
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
            ((System.ComponentModel.ISupportInitialize)(this.ddlViewDictionaryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlDictionaryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblViewDictionaryCode)).EndInit();
            this.pageEditData.ResumeLayout(false);
            this.pageEditData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSequence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblSequence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRemark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDictionaryCode)).EndInit();
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
        private RFIDProgram.FastDropDownList ddlViewDictionaryCode;
        private Telerik.WinControls.UI.RadLabel lblViewDictionaryCode;
        private Telerik.WinControls.UI.RadPageViewPage pageEditData;
        private RFIDProgram.FastDropDownList ddlDictionaryCode;
        private Telerik.WinControls.UI.RadLabel lblDictionaryCode;
        private Telerik.WinControls.UI.RadTextBox txtCode;
        private Telerik.WinControls.UI.RadLabel lblCode;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadLabel lblName;
        private Telerik.WinControls.UI.RadLabel lblSequence;
        private Telerik.WinControls.UI.RadMaskedEditBox txtSequence;
        private Telerik.WinControls.UI.RadLabel lblRemark;
        private Telerik.WinControls.UI.RadTextBox txtRemark;
    }
}
