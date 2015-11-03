namespace RFIDProgram
{
    partial class FrmBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBase));
            this.cmdBtnDelete = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarMain = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElementMain = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElementMain = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cmdBtnAdd = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdBtnEdit = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdBtnSubmit = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdBtnSave = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdBtnCancel = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdBtnPrint = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdBtnRefresh = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdBtnQuery = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdBtnImport = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdBtnExport = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdBtnHelp = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdBtnClose = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.commandBarMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdBtnDelete
            // 
            this.cmdBtnDelete.AccessibleDescription = "删除";
            this.cmdBtnDelete.AccessibleName = "删除";
            this.cmdBtnDelete.AutoSize = false;
            this.cmdBtnDelete.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.cmdBtnDelete.BorderLeftShadowColor = System.Drawing.Color.Empty;
            this.cmdBtnDelete.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnDelete.DisplayName = "删除";
            this.cmdBtnDelete.DrawText = true;
            this.cmdBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnDelete.Image")));
            this.cmdBtnDelete.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBtnDelete.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnDelete.Name = "cmdBtnDelete";
            this.cmdBtnDelete.Text = "删除";
            this.cmdBtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnDelete.ToolTipText = "删除";
            this.cmdBtnDelete.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnDelete.Click += new System.EventHandler(this.cmdBtnDelete_Click);
            // 
            // commandBarMain
            // 
            this.commandBarMain.AutoSize = true;
            this.commandBarMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.commandBarMain.Location = new System.Drawing.Point(0, 0);
            this.commandBarMain.Name = "commandBarMain";
            this.commandBarMain.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElementMain});
            this.commandBarMain.Size = new System.Drawing.Size(878, 68);
            this.commandBarMain.TabIndex = 4;
            // 
            // commandBarRowElementMain
            // 
            this.commandBarRowElementMain.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.commandBarRowElementMain.BorderLeftShadowColor = System.Drawing.Color.Empty;
            this.commandBarRowElementMain.DisplayName = "commandBarRowElementMain";
            this.commandBarRowElementMain.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElementMain.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElementMain});
            this.commandBarRowElementMain.Text = "";
            // 
            // commandBarStripElementMain
            // 
            this.commandBarStripElementMain.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.commandBarStripElementMain.BorderLeftShadowColor = System.Drawing.Color.Empty;
            this.commandBarStripElementMain.DisplayName = "commandBarStripElementMain";
            this.commandBarStripElementMain.FloatingForm = null;
            this.commandBarStripElementMain.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.cmdBtnAdd,
            this.cmdBtnEdit,
            this.cmdBtnSubmit,
            this.cmdBtnSave,
            this.cmdBtnCancel,
            this.cmdBtnPrint,
            this.cmdBtnDelete,
            this.cmdBtnRefresh,
            this.cmdBtnQuery,
            this.cmdBtnImport,
            this.cmdBtnExport,
            this.cmdBtnHelp,
            this.cmdBtnClose});
            this.commandBarStripElementMain.Name = "commandBarStripElementMain";
            this.commandBarStripElementMain.StretchHorizontally = true;
            this.commandBarStripElementMain.Text = "";
            this.commandBarStripElementMain.OverflowMenuOpening += new System.ComponentModel.CancelEventHandler(this.commandBarStripElementMain_OverflowMenuOpening);
            // 
            // cmdBtnAdd
            // 
            this.cmdBtnAdd.AccessibleDescription = "新增";
            this.cmdBtnAdd.AccessibleName = "新增";
            this.cmdBtnAdd.AutoSize = false;
            this.cmdBtnAdd.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.cmdBtnAdd.BorderLeftShadowColor = System.Drawing.Color.Empty;
            this.cmdBtnAdd.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnAdd.ClickMode = Telerik.WinControls.ClickMode.Release;
            this.cmdBtnAdd.DisplayName = "新增";
            this.cmdBtnAdd.DrawText = true;
            this.cmdBtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnAdd.Image")));
            this.cmdBtnAdd.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBtnAdd.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnAdd.Name = "cmdBtnAdd";
            this.cmdBtnAdd.Text = "新增";
            this.cmdBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnAdd.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnAdd.Click += new System.EventHandler(this.cmdBtnAdd_Click);
            // 
            // cmdBtnEdit
            // 
            this.cmdBtnEdit.AccessibleDescription = "编辑";
            this.cmdBtnEdit.AccessibleName = "编辑";
            this.cmdBtnEdit.AutoSize = false;
            this.cmdBtnEdit.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.cmdBtnEdit.BorderLeftShadowColor = System.Drawing.Color.Empty;
            this.cmdBtnEdit.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnEdit.DisplayName = "编辑";
            this.cmdBtnEdit.DrawText = true;
            this.cmdBtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnEdit.Image")));
            this.cmdBtnEdit.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBtnEdit.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnEdit.Name = "cmdBtnEdit";
            this.cmdBtnEdit.Text = "编辑";
            this.cmdBtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnEdit.ToolTipText = "编辑";
            this.cmdBtnEdit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnEdit.Click += new System.EventHandler(this.cmdBtnEdit_Click);
            // 
            // cmdBtnSubmit
            // 
            this.cmdBtnSubmit.AccessibleDescription = "提交";
            this.cmdBtnSubmit.AccessibleName = "提交";
            this.cmdBtnSubmit.AutoSize = false;
            this.cmdBtnSubmit.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnSubmit.DisplayName = "提交";
            this.cmdBtnSubmit.DrawText = true;
            this.cmdBtnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnSubmit.Image")));
            this.cmdBtnSubmit.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBtnSubmit.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnSubmit.Name = "cmdBtnSubmit";
            this.cmdBtnSubmit.Text = "提交";
            this.cmdBtnSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnSubmit.ToolTipText = "确定";
            this.cmdBtnSubmit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnSubmit.Click += new System.EventHandler(this.cmdBtnSubmit_Click);
            // 
            // cmdBtnSave
            // 
            this.cmdBtnSave.AccessibleDescription = "保存";
            this.cmdBtnSave.AccessibleName = "保存";
            this.cmdBtnSave.AutoSize = false;
            this.cmdBtnSave.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.cmdBtnSave.BorderLeftShadowColor = System.Drawing.Color.Empty;
            this.cmdBtnSave.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnSave.DisplayName = "保存";
            this.cmdBtnSave.DrawText = true;
            this.cmdBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnSave.Image")));
            this.cmdBtnSave.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBtnSave.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnSave.Name = "cmdBtnSave";
            this.cmdBtnSave.Text = "保存";
            this.cmdBtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnSave.ToolTipText = "保存";
            this.cmdBtnSave.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnSave.Click += new System.EventHandler(this.cmdBtnSave_Click);
            // 
            // cmdBtnCancel
            // 
            this.cmdBtnCancel.AccessibleDescription = "取消";
            this.cmdBtnCancel.AccessibleName = "取消";
            this.cmdBtnCancel.AutoSize = false;
            this.cmdBtnCancel.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.cmdBtnCancel.BorderLeftShadowColor = System.Drawing.Color.Empty;
            this.cmdBtnCancel.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnCancel.DisplayName = "取消";
            this.cmdBtnCancel.DrawText = true;
            this.cmdBtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnCancel.Image")));
            this.cmdBtnCancel.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBtnCancel.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnCancel.Name = "cmdBtnCancel";
            this.cmdBtnCancel.Text = "取消";
            this.cmdBtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnCancel.ToolTipText = "取消";
            this.cmdBtnCancel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnCancel.Click += new System.EventHandler(this.cmdBtnCancel_Click);
            // 
            // cmdBtnPrint
            // 
            this.cmdBtnPrint.AccessibleDescription = "打印";
            this.cmdBtnPrint.AccessibleName = "打印";
            this.cmdBtnPrint.AutoSize = false;
            this.cmdBtnPrint.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.cmdBtnPrint.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnPrint.DisplayName = "打印";
            this.cmdBtnPrint.DrawText = true;
            this.cmdBtnPrint.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnPrint.Image")));
            this.cmdBtnPrint.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnPrint.Name = "cmdBtnPrint";
            this.cmdBtnPrint.Text = "打印";
            this.cmdBtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnPrint.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnPrint.Click += new System.EventHandler(this.cmdBtnPrint_Click);
            // 
            // cmdBtnRefresh
            // 
            this.cmdBtnRefresh.AccessibleDescription = "刷新";
            this.cmdBtnRefresh.AccessibleName = "刷新";
            this.cmdBtnRefresh.AutoSize = false;
            this.cmdBtnRefresh.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.cmdBtnRefresh.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnRefresh.DisplayName = "刷新";
            this.cmdBtnRefresh.DrawText = true;
            this.cmdBtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnRefresh.Image")));
            this.cmdBtnRefresh.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnRefresh.Name = "cmdBtnRefresh";
            this.cmdBtnRefresh.Text = "刷新";
            this.cmdBtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnRefresh.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnRefresh.Click += new System.EventHandler(this.cmdBtnRefresh_Click);
            // 
            // cmdBtnQuery
            // 
            this.cmdBtnQuery.AccessibleDescription = "查询";
            this.cmdBtnQuery.AccessibleName = "查询";
            this.cmdBtnQuery.AutoSize = false;
            this.cmdBtnQuery.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.cmdBtnQuery.BorderLeftShadowColor = System.Drawing.Color.Empty;
            this.cmdBtnQuery.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnQuery.DisplayName = "查询";
            this.cmdBtnQuery.DrawText = true;
            this.cmdBtnQuery.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnQuery.Image")));
            this.cmdBtnQuery.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBtnQuery.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnQuery.Name = "cmdBtnQuery";
            this.cmdBtnQuery.Text = "查询";
            this.cmdBtnQuery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnQuery.ToolTipText = "查询";
            this.cmdBtnQuery.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnQuery.Click += new System.EventHandler(this.cmdBtnQuery_Click);
            // 
            // cmdBtnImport
            // 
            this.cmdBtnImport.AccessibleDescription = "导入";
            this.cmdBtnImport.AccessibleName = "导入";
            this.cmdBtnImport.AutoSize = false;
            this.cmdBtnImport.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.cmdBtnImport.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnImport.DisplayName = "导入";
            this.cmdBtnImport.DrawText = true;
            this.cmdBtnImport.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnImport.Image")));
            this.cmdBtnImport.ImageAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdBtnImport.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnImport.Name = "cmdBtnImport";
            this.cmdBtnImport.Text = "导入";
            this.cmdBtnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnImport.ToolTipText = "导入";
            this.cmdBtnImport.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnImport.Click += new System.EventHandler(this.cmdBtnImport_Click);
            // 
            // cmdBtnExport
            // 
            this.cmdBtnExport.AccessibleDescription = "导出";
            this.cmdBtnExport.AccessibleName = "导出";
            this.cmdBtnExport.AutoSize = false;
            this.cmdBtnExport.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.cmdBtnExport.BorderLeftShadowColor = System.Drawing.Color.Empty;
            this.cmdBtnExport.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnExport.DisplayName = "导出";
            this.cmdBtnExport.DrawText = true;
            this.cmdBtnExport.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnExport.Image")));
            this.cmdBtnExport.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.cmdBtnExport.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnExport.Name = "cmdBtnExport";
            this.cmdBtnExport.Text = "导出";
            this.cmdBtnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnExport.ToolTipText = "导出";
            this.cmdBtnExport.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnExport.Click += new System.EventHandler(this.cmdBtnExport_Click);
            // 
            // cmdBtnHelp
            // 
            this.cmdBtnHelp.AccessibleDescription = "帮助";
            this.cmdBtnHelp.AccessibleName = "帮助";
            this.cmdBtnHelp.AutoSize = false;
            this.cmdBtnHelp.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnHelp.DisplayName = "帮助";
            this.cmdBtnHelp.DrawText = true;
            this.cmdBtnHelp.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnHelp.Image")));
            this.cmdBtnHelp.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnHelp.Name = "cmdBtnHelp";
            this.cmdBtnHelp.Text = "帮助";
            this.cmdBtnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnHelp.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnHelp.Click += new System.EventHandler(this.cmdBtnHelp_Click);
            // 
            // cmdBtnClose
            // 
            this.cmdBtnClose.AccessibleDescription = "关闭";
            this.cmdBtnClose.AccessibleName = "关闭";
            this.cmdBtnClose.AutoSize = false;
            this.cmdBtnClose.BorderDrawMode = Telerik.WinControls.BorderDrawModes.HorizontalOverVertical;
            this.cmdBtnClose.BorderLeftShadowColor = System.Drawing.Color.Empty;
            this.cmdBtnClose.Bounds = new System.Drawing.Rectangle(0, 0, 48, 64);
            this.cmdBtnClose.DisplayName = "关闭";
            this.cmdBtnClose.DrawText = true;
            this.cmdBtnClose.Image = ((System.Drawing.Image)(resources.GetObject("cmdBtnClose.Image")));
            this.cmdBtnClose.ImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.cmdBtnClose.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cmdBtnClose.Name = "cmdBtnClose";
            this.cmdBtnClose.Text = "关闭";
            this.cmdBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdBtnClose.ToolTipText = "关闭";
            this.cmdBtnClose.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.cmdBtnClose.Click += new System.EventHandler(this.cmdBtnClose_Click);
            // 
            // FrmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 543);
            this.Controls.Add(this.commandBarMain);
            this.Name = "FrmBase";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "FrmBase";
            this.ThemeName = "ControlDefault";
            this.Load += new System.EventHandler(this.FrmBase_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBase_FormClosing);
            this.SizeChanged += new System.EventHandler(this.FrmBase_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.commandBarMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElementMain;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElementMain;
        private Telerik.WinControls.UI.CommandBarButton cmdBtnAdd;
        internal Telerik.WinControls.UI.RadCommandBar commandBarMain;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnEdit;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnSave;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnSubmit;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnDelete;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnCancel;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnQuery;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnExport;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnClose;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnPrint;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnRefresh;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnHelp;
        internal Telerik.WinControls.UI.CommandBarButton cmdBtnImport;

    }
}
