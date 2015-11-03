using TelerikWinformBase;
namespace RFIDProgram
{
    partial class FrmSystemUserAssignGroup
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
            this.gbUnSel = new Telerik.WinControls.UI.RadGroupBox();
            this.gridViewUnSel = new RFIDProgram.FastGridView();
            this.gbButton = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSelect = new Telerik.WinControls.UI.RadButton();
            this.btnUnSelect = new Telerik.WinControls.UI.RadButton();
            this.gbDdl = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlUserGroup = new RFIDProgram.FastDropDownList();
            this.lblUserGroup = new Telerik.WinControls.UI.RadLabel();
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
            ((System.ComponentModel.ISupportInitialize)(this.gbUnSel)).BeginInit();
            this.gbUnSel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnSel.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbButton)).BeginInit();
            this.gbButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDdl)).BeginInit();
            this.gbDdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUserGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserGroup)).BeginInit();
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
            this.splitPanel1.Size = new System.Drawing.Size(401, 444);
            this.splitPanel1.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(-0.09247968F, 0F);
            this.splitPanel1.SizeInfo.SplitterCorrection = new System.Drawing.Size(-91, 0);
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
            this.gbSel.HeaderText = "已选用户列表";
            this.gbSel.Location = new System.Drawing.Point(0, 0);
            this.gbSel.Name = "gbSel";
            this.gbSel.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.gbSel.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbSel.Size = new System.Drawing.Size(401, 444);
            this.gbSel.TabIndex = 0;
            this.gbSel.Text = "已选用户列表";
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
            gridViewTextBoxColumn1.FieldName = "UserId";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "工号";
            gridViewTextBoxColumn1.Name = "colUserId";
            gridViewTextBoxColumn1.Width = 150;
            gridViewTextBoxColumn2.FieldName = "UserName";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "姓名";
            gridViewTextBoxColumn2.Name = "colUserName";
            gridViewTextBoxColumn2.Width = 150;
            this.gridViewSel.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.gridViewSel.Name = "gridViewSel";
            this.gridViewSel.ReadOnly = true;
            this.gridViewSel.Size = new System.Drawing.Size(397, 424);
            this.gridViewSel.TabIndex = 1;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.gbUnSel);
            this.splitPanel2.Controls.Add(this.gbButton);
            this.splitPanel2.Location = new System.Drawing.Point(404, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(583, 444);
            this.splitPanel2.SizeInfo.AutoSizeScale = new System.Drawing.SizeF(0.09247965F, 0F);
            this.splitPanel2.SizeInfo.SplitterCorrection = new System.Drawing.Size(91, 0);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            // 
            // gbUnSel
            // 
            this.gbUnSel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbUnSel.Controls.Add(this.gridViewUnSel);
            this.gbUnSel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUnSel.FooterImageIndex = -1;
            this.gbUnSel.FooterImageKey = "";
            this.gbUnSel.HeaderImageIndex = -1;
            this.gbUnSel.HeaderImageKey = "";
            this.gbUnSel.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbUnSel.HeaderText = "可选用户列表";
            this.gbUnSel.Location = new System.Drawing.Point(127, 0);
            this.gbUnSel.Name = "gbUnSel";
            this.gbUnSel.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.gbUnSel.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbUnSel.Size = new System.Drawing.Size(456, 444);
            this.gbUnSel.TabIndex = 1;
            this.gbUnSel.Text = "可选用户列表";
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
            gridViewTextBoxColumn3.FieldName = "UserId";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "工号";
            gridViewTextBoxColumn3.Name = "colUserId";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.FieldName = "UserName";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "姓名";
            gridViewTextBoxColumn4.Name = "colUserName";
            gridViewTextBoxColumn4.Width = 150;
            this.gridViewUnSel.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.gridViewUnSel.Name = "gridViewUnSel";
            this.gridViewUnSel.ReadOnly = true;
            this.gridViewUnSel.Size = new System.Drawing.Size(452, 424);
            this.gridViewUnSel.TabIndex = 0;
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
            // gbDdl
            // 
            this.gbDdl.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbDdl.Controls.Add(this.ddlUserGroup);
            this.gbDdl.Controls.Add(this.lblUserGroup);
            this.gbDdl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDdl.FooterImageIndex = -1;
            this.gbDdl.FooterImageKey = "";
            this.gbDdl.HeaderImageIndex = -1;
            this.gbDdl.HeaderImageKey = "";
            this.gbDdl.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbDdl.HeaderText = "";
            this.gbDdl.Location = new System.Drawing.Point(0, 68);
            this.gbDdl.Name = "gbDdl";
            this.gbDdl.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.gbDdl.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbDdl.Size = new System.Drawing.Size(987, 85);
            this.gbDdl.TabIndex = 5;
            // 
            // ddlUserGroup
            // 
            this.ddlUserGroup.ContainEmptyItem = true;
            this.ddlUserGroup.DictionaryCode = DataDictionary.Workshop;
            this.ddlUserGroup.DropDownAnimationEnabled = true;
            this.ddlUserGroup.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlUserGroup.Location = new System.Drawing.Point(28, 47);
            this.ddlUserGroup.MaxDropDownItems = 0;
            this.ddlUserGroup.Name = "ddlUserGroup";
            this.ddlUserGroup.QueryCondition = null;
            this.ddlUserGroup.ReferenceDropDownList = null;
            this.ddlUserGroup.ShowImageInEditorArea = true;
            this.ddlUserGroup.Size = new System.Drawing.Size(181, 20);
            this.ddlUserGroup.TabIndex = 1;
            this.ddlUserGroup.UsageFor = FastDropDownListUsageFor.UserGroup;
            this.ddlUserGroup.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.ddlUserGroup_SelectedIndexChanged);
            // 
            // lblUserGroup
            // 
            this.lblUserGroup.Location = new System.Drawing.Point(28, 22);
            this.lblUserGroup.Name = "lblUserGroup";
            this.lblUserGroup.Size = new System.Drawing.Size(40, 18);
            this.lblUserGroup.TabIndex = 0;
            this.lblUserGroup.Text = "用户组";
            // 
            // FrmSystemUserAssignGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 597);
            this.Controls.Add(this.radSplitContainer1);
            this.Controls.Add(this.gbDdl);
            this.Name = "FrmSystemUserAssignGroup";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "用户分组";
            this.Load += new System.EventHandler(this.FrmSystemUserAssignGroup_Load);
            this.Controls.SetChildIndex(this.gbDdl, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.gbUnSel)).EndInit();
            this.gbUnSel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnSel.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUnSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbButton)).EndInit();
            this.gbButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUnSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbDdl)).EndInit();
            this.gbDdl.ResumeLayout(false);
            this.gbDdl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUserGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.RadGroupBox gbDdl;
        private RFIDProgram.FastDropDownList ddlUserGroup;
        private Telerik.WinControls.UI.RadLabel lblUserGroup;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private Telerik.WinControls.UI.RadGroupBox gbButton;
        private Telerik.WinControls.UI.RadGroupBox gbSel;
        private RFIDProgram.FastGridView gridViewSel;
        private Telerik.WinControls.UI.RadGroupBox gbUnSel;
        private RFIDProgram.FastGridView gridViewUnSel;
        private Telerik.WinControls.UI.RadButton btnSelect;
        private Telerik.WinControls.UI.RadButton btnUnSelect;


    }
}