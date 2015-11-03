using TelerikWinformBase;
namespace RFIDProgram
{
    partial class FrmAssignRight
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
            this.gbTop = new Telerik.WinControls.UI.RadGroupBox();
            this.ddlUserGroup = new RFIDProgram.FastDropDownList();
            this.lblUserGroup = new Telerik.WinControls.UI.RadLabel();
            this.gbMain = new Telerik.WinControls.UI.RadGroupBox();
            this.treeRight = new Telerik.WinControls.UI.RadTreeView();
            ((System.ComponentModel.ISupportInitialize)(this.gbTop)).BeginInit();
            this.gbTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUserGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).BeginInit();
            this.gbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTop
            // 
            this.gbTop.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbTop.Controls.Add(this.ddlUserGroup);
            this.gbTop.Controls.Add(this.lblUserGroup);
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
            this.gbTop.Size = new System.Drawing.Size(867, 85);
            this.gbTop.TabIndex = 5;
            // 
            // ddlUserGroup
            // 
            this.ddlUserGroup.ContainEmptyItem = true;
            this.ddlUserGroup.DictionaryCode = DataDictionary.Workshop;
            this.ddlUserGroup.DropDownAnimationEnabled = true;
            this.ddlUserGroup.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.ddlUserGroup.Location = new System.Drawing.Point(28, 47);
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
            // gbMain
            // 
            this.gbMain.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbMain.Controls.Add(this.treeRight);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.FooterImageIndex = -1;
            this.gbMain.FooterImageKey = "";
            this.gbMain.HeaderImageIndex = -1;
            this.gbMain.HeaderImageKey = "";
            this.gbMain.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbMain.HeaderText = "功能";
            this.gbMain.Location = new System.Drawing.Point(0, 153);
            this.gbMain.Name = "gbMain";
            this.gbMain.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            // 
            // 
            // 
            this.gbMain.RootElement.Padding = new System.Windows.Forms.Padding(2, 18, 2, 2);
            this.gbMain.Size = new System.Drawing.Size(867, 444);
            this.gbMain.TabIndex = 6;
            this.gbMain.Text = "功能";
            // 
            // treeRight
            // 
            this.treeRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.treeRight.CheckBoxes = true;
            this.treeRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeRight.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.treeRight.ForeColor = System.Drawing.Color.Black;
            this.treeRight.Location = new System.Drawing.Point(2, 18);
            this.treeRight.Name = "treeRight";
            this.treeRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // 
            // 
            this.treeRight.RootElement.ForeColor = System.Drawing.Color.Black;
            this.treeRight.Size = new System.Drawing.Size(863, 424);
            this.treeRight.SpacingBetweenNodes = -1;
            this.treeRight.TabIndex = 0;
            this.treeRight.Text = "radTreeView1";
            this.treeRight.TriStateMode = true;
            this.treeRight.NodeCheckedChanged += new Telerik.WinControls.UI.RadTreeView.TreeViewEventHandler(this.treeRight_NodeCheckedChanged);
            // 
            // FrmAssignRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 597);
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.gbTop);
            this.Name = "FrmAssignRight";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "权限分配";
            this.Load += new System.EventHandler(this.FrmAssignRight_Load);
            this.Controls.SetChildIndex(this.gbTop, 0);
            this.Controls.SetChildIndex(this.gbMain, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gbTop)).EndInit();
            this.gbTop.ResumeLayout(false);
            this.gbTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlUserGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblUserGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbMain)).EndInit();
            this.gbMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gbTop;
        private RFIDProgram.FastDropDownList ddlUserGroup;
        private Telerik.WinControls.UI.RadLabel lblUserGroup;
        private Telerik.WinControls.UI.RadGroupBox gbMain;
        private Telerik.WinControls.UI.RadTreeView treeRight;


    }
}