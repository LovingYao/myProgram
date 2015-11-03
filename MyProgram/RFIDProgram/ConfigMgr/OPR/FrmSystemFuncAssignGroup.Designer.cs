using TelerikWinformBase;
namespace RFIDProgram
{
    partial class FrmSystemFuncAssignGroup
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
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.gbSel = new Telerik.WinControls.UI.RadGroupBox();
            this.gridViewSel = new RFIDProgram.FastGridView();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.gbNotSel = new Telerik.WinControls.UI.RadGroupBox();
            this.gridViewUnSel = new RFIDProgram.FastGridView();
            this.gbButton = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSelect = new Telerik.WinControls.UI.RadButton();
            this.btnUnSelect = new Telerik.WinControls.UI.RadButton();
            this.gbTop = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlFunctionGroup = new RFIDProgram.FastDropDownList();
            this.lblFunctionGroup = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbSel)).BeginInit();
            this.gbSel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSel.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbNotSel)).BeginInit();
            this.gbNotSel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnSel.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbButton)).BeginInit();
            this.gbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbTop)).BeginInit();
            this.gbTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlFunctionGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFunctionGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 153);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(987, 444);
            this.radSplitContainer1.TabIndex = 4;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.Text = "radSplitContainer1";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.gbSel);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(481, 444);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.01117885F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-11, 0);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            // 
            // gbSel
            // 
            this.gbSel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbSel.Controls.Add(this.gridViewSel);
            this.gbSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSel.FooterImageIndex = -1;
            this.gbSel.FooterImageKey = "";
            this.gbSel.HeaderImageIndex = -1;
            this.gbSel.HeaderImageKey = "";
            this.gbSel.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbSel.HeaderText = "已选功能列表";
            this.gbSel.Location = new System.Drawing.Point(0, 0);
            this.gbSel.Name = "gbSel";
            this.gbSel.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.gbSel.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbSel.Size = new System.Drawing.Size(481, 444);
            this.gbSel.TabIndex = 0;
            this.gbSel.Text = "已选功能列表";
            // 
            // gridViewSel
            // 
            this.gridViewSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewSel.Location = new System.Drawing.Point(2, 18);
            // 
            // gridViewSel
            // 
            this.gridViewSel.MasterTemplate.AllowAddNewRow = false;
            this.gridViewSel.MasterTemplate.AllowColumnReorder = false;
            this.gridViewSel.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "FuncCode";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "功能编号";
            gridViewTextBoxColumn1.Name = "colFuncCode";
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn2.FieldName = "FuncName";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "功能名称";
            gridViewTextBoxColumn2.Name = "colFuncName";
            gridViewTextBoxColumn2.Width = 150;
            this.gridViewSel.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gridViewSel.Name = "gridViewSel";
            this.gridViewSel.ReadOnly = true;
            this.gridViewSel.Size = new System.Drawing.Size(477, 424);
            this.gridViewSel.TabIndex = 2;
            this.gridViewSel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridViewSel_KeyDown);
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.gbNotSel);
            this.splitPanel2.Controls.Add(this.gbButton);
            this.splitPanel2.Location = new System.Drawing.Point(484, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(503, 444);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.01117885F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(11, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // gbNotSel
            // 
            this.gbNotSel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbNotSel.Controls.Add(this.gridViewUnSel);
            this.gbNotSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbNotSel.FooterImageIndex = -1;
            this.gbNotSel.FooterImageKey = "";
            this.gbNotSel.HeaderImageIndex = -1;
            this.gbNotSel.HeaderImageKey = "";
            this.gbNotSel.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbNotSel.HeaderText = "可选功能列表";
            this.gbNotSel.Location = new System.Drawing.Point(127, 0);
            this.gbNotSel.Name = "gbNotSel";
            this.gbNotSel.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.gbNotSel.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbNotSel.Size = new System.Drawing.Size(376, 444);
            this.gbNotSel.TabIndex = 1;
            this.gbNotSel.Text = "可选功能列表";
            // 
            // gridViewUnSel
            // 
            this.gridViewUnSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewUnSel.Location = new System.Drawing.Point(2, 18);
            // 
            // gridViewUnSel
            // 
            this.gridViewUnSel.MasterTemplate.AllowAddNewRow = false;
            this.gridViewUnSel.MasterTemplate.AllowColumnReorder = false;
            this.gridViewUnSel.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn3.FieldName = "FuncCode";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "功能编号";
            gridViewTextBoxColumn3.Name = "colFuncCode";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.FieldName = "FuncName";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "功能名称";
            gridViewTextBoxColumn4.Name = "colFuncName";
            gridViewTextBoxColumn4.Width = 150;
            this.gridViewUnSel.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.gridViewUnSel.Name = "gridViewUnSel";
            this.gridViewUnSel.ReadOnly = true;
            this.gridViewUnSel.Size = new System.Drawing.Size(372, 424);
            this.gridViewUnSel.TabIndex = 1;
            // 
            // gbButton
            // 
            this.gbButton.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbButton.Controls.Add(this.btnSelect);
            this.gbButton.Controls.Add(this.btnUnSelect);
            this.gbButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbButton.FooterImageIndex = -1;
            this.gbButton.FooterImageKey = "";
            this.gbButton.HeaderImageIndex = -1;
            this.gbButton.HeaderImageKey = "";
            this.gbButton.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbButton.HeaderText = "";
            this.gbButton.Location = new System.Drawing.Point(0, 0);
            this.gbButton.Name = "gbButton";
            this.gbButton.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.gbButton.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbButton.Size = new System.Drawing.Size(127, 444);
            this.gbButton.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(23, 217);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(81, 24);
            this.btnSelect.TabIndex = 1;
            this.btnSelect.Text = "<==";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.Location = new System.Drawing.Point(23, 136);
            this.btnUnSelect.Name = "btnUnSelect";
            this.btnUnSelect.Size = new System.Drawing.Size(81, 24);
            this.btnUnSelect.TabIndex = 0;
            this.btnUnSelect.Text = "==>";
            this.btnUnSelect.Click += new System.EventHandler(this.btnUnSelect_Click);
            // 
            // gbTop
            // 
            this.gbTop.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbTop.Controls.Add(this.ddlFunctionGroup);
            this.gbTop.Controls.Add(this.lblFunctionGroup);
            this.gbTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbTop.FooterImageIndex = -1;
            this.gbTop.FooterImageKey = "";
            this.gbTop.HeaderImageIndex = -1;
            this.gbTop.HeaderImageKey = "";
            this.gbTop.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbTop.HeaderText = "";
            this.gbTop.Location = new System.Drawing.Point(0, 68);
            this.gbTop.Name = "gbTop";
            this.gbTop.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.gbTop.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbTop.Size = new System.Drawing.Size(987, 85);
            this.gbTop.TabIndex = 5;
            // 
            // ddlFunctionGroup
            // 
            this.ddlFunctionGroup.ContainEmptyItem = true;
            this.ddlFunctionGroup.DictionaryCode = DataDictionary.Workshop;
            this.ddlFunctionGroup.DropDownAnimationEnabled = true;
            this.ddlFunctionGroup.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlFunctionGroup.Location = new System.Drawing.Point(28, 47);
            this.ddlFunctionGroup.Name = "ddlFunctionGroup";
            this.ddlFunctionGroup.QueryCondition = null;
            this.ddlFunctionGroup.ReferenceDropDownList = null;
            this.ddlFunctionGroup.ShowImageInEditorArea = true;
            this.ddlFunctionGroup.Size = new System.Drawing.Size(181, 20);
            this.ddlFunctionGroup.TabIndex = 1;
            this.ddlFunctionGroup.UsageFor = FastDropDownListUsageFor.FunctionGroup;
            this.ddlFunctionGroup.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlFunctionGroup_SelectedIndexChanged);
            // 
            // lblFunctionGroup
            // 
            this.lblFunctionGroup.Location = new System.Drawing.Point(28, 22);
            this.lblFunctionGroup.Name = "lblFunctionGroup";
            this.lblFunctionGroup.Size = new System.Drawing.Size(40, 18);
            this.lblFunctionGroup.TabIndex = 0;
            this.lblFunctionGroup.Text = "功能组";
            // 
            // FrmSystemFuncAssignGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 597);
            this.Controls.Add(this.radSplitContainer1);
            this.Controls.Add(this.gbTop);
            this.Name = "FrmSystemFuncAssignGroup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "功能分组";
            this.Load += new System.EventHandler(this.FrmSystemFuncAssignGroup_Load);
            this.Controls.SetChildIndex(this.gbTop, 0);
            this.Controls.SetChildIndex(this.radSplitContainer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbSel)).EndInit();
            this.gbSel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSel.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gbNotSel)).EndInit();
            this.gbNotSel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnSel.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbButton)).EndInit();
            this.gbButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbTop)).EndInit();
            this.gbTop.ResumeLayout(false);
            this.gbTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlFunctionGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFunctionGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadGroupBox gbSel;
        private Telerik.WinControls.UI.RadGroupBox gbNotSel;
        private Telerik.WinControls.UI.RadGroupBox gbTop;
        private RFIDProgram.FastDropDownList ddlFunctionGroup;
        private Telerik.WinControls.UI.RadLabel lblFunctionGroup;
        private Telerik.WinControls.UI.RadGroupBox gbButton;
        private Telerik.WinControls.UI.RadButton btnSelect;
        private Telerik.WinControls.UI.RadButton btnUnSelect;
        private RFIDProgram.FastGridView gridViewSel;
        private RFIDProgram.FastGridView gridViewUnSel;


    }
}