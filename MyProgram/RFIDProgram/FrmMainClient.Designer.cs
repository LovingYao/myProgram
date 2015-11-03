namespace RFIDProgram
{
    partial class FrmMainClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainClient));
            this.dockMain = new Telerik.WinControls.UI.Docking.RadDock();
            this.toolWindow = new Telerik.WinControls.UI.Docking.ToolWindow();
            this.treeMenu = new Telerik.WinControls.UI.RadTreeView();
            this.toolTabStrip = new Telerik.WinControls.UI.Docking.ToolTabStrip();
            this.documentContainerMain = new Telerik.WinControls.UI.Docking.DocumentContainer();
            this.mnuSystem = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuChangePwd = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuSysSp1 = new Telerik.WinControls.UI.RadMenuSeparatorItem();
            this.mnuExit = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuView = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuShow = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuTopPanel = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuLeftSysMenu = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuShowHistoryLog = new Telerik.WinControls.UI.RadMenuItem();
            this.mnuAbout = new Telerik.WinControls.UI.RadMenuItem();
            this.mainStatus = new Telerik.WinControls.UI.RadStatusStrip();
            this.lblStatusCurrentUser = new Telerik.WinControls.UI.RadLabelElement();
            this.lblStatusCurrentUserValue = new Telerik.WinControls.UI.RadLabelElement();
            this.lblStatusCurrentDateTime = new Telerik.WinControls.UI.RadLabelElement();
            this.lblStatusCurrentDateTimeValue = new Telerik.WinControls.UI.RadLabelElement();
            this.statusBarTimer = new System.Windows.Forms.Timer(this.components);
            this.mainMenu = new Telerik.WinControls.UI.RadMenu();
            this.pnlTop = new Telerik.WinControls.UI.RadPanel();
            this.panelTopLeft = new Telerik.WinControls.UI.RadPanel();
            this.uiLog = new RFIDProgram.UiLog();
            ((System.ComponentModel.ISupportInitialize)(this.dockMain)).BeginInit();
            this.dockMain.SuspendLayout();
            this.toolWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip)).BeginInit();
            this.toolTabStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentContainerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).BeginInit();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTopLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dockMain
            // 
            this.dockMain.ActiveWindow = this.toolWindow;
            this.dockMain.AutoDetectMdiChildren = true;
            this.dockMain.Controls.Add(this.toolTabStrip);
            this.dockMain.Controls.Add(this.documentContainerMain);
            this.dockMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dockMain.DocumentManager.DocumentInsertOrder = Telerik.WinControls.UI.Docking.DockWindowInsertOrder.InFront;
            this.dockMain.IsCleanUpTarget = true;
            this.dockMain.Location = new System.Drawing.Point(0, 83);
            this.dockMain.MainDocumentContainer = this.documentContainerMain;
            this.dockMain.Name = "dockMain";
            this.dockMain.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.dockMain.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.dockMain.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.dockMain.Size = new System.Drawing.Size(927, 262);
            this.dockMain.SplitterWidth = 4;
            this.dockMain.TabIndex = 0;
            this.dockMain.TabStop = false;
            // 
            // toolWindow
            // 
            this.toolWindow.Caption = null;
            this.toolWindow.Controls.Add(this.treeMenu);
            this.toolWindow.DocumentButtons = Telerik.WinControls.UI.Docking.DocumentStripButtons.None;
            this.toolWindow.Location = new System.Drawing.Point(1, 24);
            this.toolWindow.Name = "toolWindow";
            this.toolWindow.PreviousDockState = Telerik.WinControls.UI.Docking.DockState.Docked;
            this.toolWindow.Size = new System.Drawing.Size(223, 226);
            this.toolWindow.Text = "系统菜单";
            this.toolWindow.ToolCaptionButtons = Telerik.WinControls.UI.Docking.ToolStripCaptionButtons.AutoHide;
            // 
            // treeMenu
            // 
            this.treeMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMenu.Location = new System.Drawing.Point(0, 0);
            this.treeMenu.Name = "treeMenu";
            this.treeMenu.Size = new System.Drawing.Size(223, 226);
            this.treeMenu.SpacingBetweenNodes = -1;
            this.treeMenu.TabIndex = 0;
            this.treeMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeMenu_KeyPress);
            this.treeMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeMenu_MouseDoubleClick);
            // 
            // toolTabStrip
            // 
            this.toolTabStrip.CanUpdateChildIndex = true;
            this.toolTabStrip.Controls.Add(this.toolWindow);
            this.toolTabStrip.Location = new System.Drawing.Point(5, 5);
            this.toolTabStrip.Name = "toolTabStrip";
            // 
            // 
            // 
            this.toolTabStrip.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.toolTabStrip.SelectedIndex = 0;
            this.toolTabStrip.ShowItemToolTips = false;
            this.toolTabStrip.Size = new System.Drawing.Size(225, 252);
            this.toolTabStrip.SizeInfo.AbsoluteSize = new System.Drawing.Size(225, 200);
            this.toolTabStrip.SizeInfo.SplitterCorrection = new System.Drawing.Size(25, 0);
            this.toolTabStrip.TabIndex = 1;
            this.toolTabStrip.TabStop = false;
            // 
            // documentContainerMain
            // 
            this.documentContainerMain.Location = new System.Drawing.Point(234, 5);
            this.documentContainerMain.Name = "documentContainerMain";
            this.documentContainerMain.Padding = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.documentContainerMain.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.documentContainerMain.RootElement.Padding = new System.Windows.Forms.Padding(5);
            this.documentContainerMain.Size = new System.Drawing.Size(688, 252);
            this.documentContainerMain.SizeInfo.AbsoluteSize = new System.Drawing.Size(811, 200);
            this.documentContainerMain.SizeInfo.SizeMode = Telerik.WinControls.UI.Docking.SplitPanelSizeMode.Fill;
            this.documentContainerMain.SizeInfo.SplitterCorrection = new System.Drawing.Size(-25, 0);
            this.documentContainerMain.SplitterWidth = 4;
            this.documentContainerMain.TabIndex = 0;
            this.documentContainerMain.TabStop = false;
            // 
            // mnuSystem
            // 
            this.mnuSystem.AccessibleDescription = "&S系统";
            this.mnuSystem.AccessibleName = "&S系统";
            this.mnuSystem.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuChangePwd,
            this.mnuSysSp1,
            this.mnuExit});
            this.mnuSystem.Name = "mnuSystem";
            this.mnuSystem.Text = "&S系统";
            this.mnuSystem.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // mnuChangePwd
            // 
            this.mnuChangePwd.AccessibleDescription = "&C修改密码";
            this.mnuChangePwd.AccessibleName = "&C修改密码";
            this.mnuChangePwd.Name = "mnuChangePwd";
            this.mnuChangePwd.Text = "&C修改密码";
            this.mnuChangePwd.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.mnuChangePwd.Click += new System.EventHandler(this.mnuChangePwd_Click);
            // 
            // mnuSysSp1
            // 
            this.mnuSysSp1.Name = "mnuSysSp1";
            this.mnuSysSp1.Text = "";
            this.mnuSysSp1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // mnuExit
            // 
            this.mnuExit.AccessibleDescription = "&E退出系统";
            this.mnuExit.AccessibleName = "&E退出系统";
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Text = "&E退出系统";
            this.mnuExit.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuView
            // 
            this.mnuView.AccessibleDescription = "&V视图";
            this.mnuView.AccessibleName = "&V视图";
            this.mnuView.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuShow,
            this.mnuShowHistoryLog});
            this.mnuView.Name = "mnuView";
            this.mnuView.ShowArrow = false;
            this.mnuView.Text = "&V视图";
            this.mnuView.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // mnuShow
            // 
            this.mnuShow.AccessibleDescription = "&S显示";
            this.mnuShow.AccessibleName = "&S显示";
            this.mnuShow.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuTopPanel,
            this.mnuLeftSysMenu});
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.Text = "&S显示";
            this.mnuShow.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // mnuTopPanel
            // 
            this.mnuTopPanel.AccessibleDescription = "顶部图片";
            this.mnuTopPanel.AccessibleName = "顶部图片";
            this.mnuTopPanel.CheckOnClick = true;
            this.mnuTopPanel.IsChecked = true;
            this.mnuTopPanel.Name = "mnuTopPanel";
            this.mnuTopPanel.Text = "顶部图片";
            this.mnuTopPanel.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.mnuTopPanel.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.mnuTopPanel.Click += new System.EventHandler(this.mnuTopPanel_Click);
            // 
            // mnuLeftSysMenu
            // 
            this.mnuLeftSysMenu.AccessibleDescription = "左侧系统菜单";
            this.mnuLeftSysMenu.AccessibleName = "左侧系统菜单";
            this.mnuLeftSysMenu.CheckOnClick = true;
            this.mnuLeftSysMenu.IsChecked = true;
            this.mnuLeftSysMenu.Name = "mnuLeftSysMenu";
            this.mnuLeftSysMenu.Text = "左侧系统菜单";
            this.mnuLeftSysMenu.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.mnuLeftSysMenu.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.mnuLeftSysMenu.Click += new System.EventHandler(this.mnuLeftSysMenu_Click);
            // 
            // mnuShowHistoryLog
            // 
            this.mnuShowHistoryLog.AccessibleDescription = "显示历史消息";
            this.mnuShowHistoryLog.AccessibleName = "显示历史消息";
            this.mnuShowHistoryLog.Name = "mnuShowHistoryLog";
            this.mnuShowHistoryLog.Text = "显示历史消息";
            this.mnuShowHistoryLog.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.mnuShowHistoryLog.Click += new System.EventHandler(this.mnuShowHistoryLog_Click);
            // 
            // mnuAbout
            // 
            this.mnuAbout.AccessibleDescription = "关于";
            this.mnuAbout.AccessibleName = "关于";
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Text = "关于";
            this.mnuAbout.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mainStatus
            // 
            this.mainStatus.AutoSize = true;
            this.mainStatus.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lblStatusCurrentUser,
            this.lblStatusCurrentUserValue,
            this.lblStatusCurrentDateTime,
            this.lblStatusCurrentDateTimeValue});
            this.mainStatus.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.mainStatus.Location = new System.Drawing.Point(0, 345);
            this.mainStatus.Name = "mainStatus";
            this.mainStatus.Size = new System.Drawing.Size(927, 26);
            this.mainStatus.TabIndex = 4;
            // 
            // lblStatusCurrentUser
            // 
            this.lblStatusCurrentUser.AccessibleDescription = "当前用户：";
            this.lblStatusCurrentUser.AccessibleName = "当前用户：";
            this.lblStatusCurrentUser.Margin = new System.Windows.Forms.Padding(1);
            this.lblStatusCurrentUser.Name = "lblStatusCurrentUser";
            this.mainStatus.SetSpring(this.lblStatusCurrentUser, false);
            this.lblStatusCurrentUser.Text = "当前用户：";
            this.lblStatusCurrentUser.TextWrap = true;
            this.lblStatusCurrentUser.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // lblStatusCurrentUserValue
            // 
            this.lblStatusCurrentUserValue.Margin = new System.Windows.Forms.Padding(1);
            this.lblStatusCurrentUserValue.Name = "lblStatusCurrentUserValue";
            this.mainStatus.SetSpring(this.lblStatusCurrentUserValue, false);
            this.lblStatusCurrentUserValue.Text = "";
            this.lblStatusCurrentUserValue.TextWrap = true;
            this.lblStatusCurrentUserValue.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // lblStatusCurrentDateTime
            // 
            this.lblStatusCurrentDateTime.AccessibleDescription = "当前时间：";
            this.lblStatusCurrentDateTime.AccessibleName = "当前时间：";
            this.lblStatusCurrentDateTime.Margin = new System.Windows.Forms.Padding(1);
            this.lblStatusCurrentDateTime.Name = "lblStatusCurrentDateTime";
            this.mainStatus.SetSpring(this.lblStatusCurrentDateTime, false);
            this.lblStatusCurrentDateTime.Text = "当前时间：";
            this.lblStatusCurrentDateTime.TextWrap = true;
            this.lblStatusCurrentDateTime.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // lblStatusCurrentDateTimeValue
            // 
            this.lblStatusCurrentDateTimeValue.Margin = new System.Windows.Forms.Padding(1);
            this.lblStatusCurrentDateTimeValue.Name = "lblStatusCurrentDateTimeValue";
            this.mainStatus.SetSpring(this.lblStatusCurrentDateTimeValue, false);
            this.lblStatusCurrentDateTimeValue.Text = "";
            this.lblStatusCurrentDateTimeValue.TextWrap = true;
            this.lblStatusCurrentDateTimeValue.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // statusBarTimer
            // 
            this.statusBarTimer.Enabled = true;
            this.statusBarTimer.Interval = 1000;
            this.statusBarTimer.Tick += new System.EventHandler(this.statusBarTimer_Tick);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.mnuSystem,
            this.mnuView,
            this.mnuAbout});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(927, 20);
            this.mainMenu.TabIndex = 3;
            this.mainMenu.Text = "radMenu1";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BackgroundImage = global::RFIDProgram.Properties.Resources.Top;
            this.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTop.Controls.Add(this.uiLog);
            this.pnlTop.Controls.Add(this.panelTopLeft);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 20);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(927, 63);
            this.pnlTop.TabIndex = 8;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.pnlTop.GetChildAt(0).GetChildAt(1))).Width = 0F;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.BackColor = System.Drawing.Color.Transparent;
            this.panelTopLeft.BackgroundImage = global::RFIDProgram.Properties.Resources.Logo;
            this.panelTopLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(229, 63);
            this.panelTopLeft.TabIndex = 3;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.panelTopLeft.GetChildAt(0).GetChildAt(1))).Width = 0F;
            // 
            // uiLog
            // 
            this.uiLog.BackColor = System.Drawing.Color.Transparent;
            this.uiLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLog.Location = new System.Drawing.Point(229, 0);
            this.uiLog.MaxHistoryMsgCount = 600;
            this.uiLog.MessageFont = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiLog.MessageForeColor = System.Drawing.Color.White;
            this.uiLog.Name = "uiLog";
            this.uiLog.Size = new System.Drawing.Size(698, 63);
            this.uiLog.TabIndex = 4;
            // 
            // FrmMainClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 371);
            this.Controls.Add(this.dockMain);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.mainStatus);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMainClient";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFID System";
            this.ThemeName = "ControlDefault";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMainClient_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMainClient_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainClient_Load);
            this.Shown += new System.EventHandler(this.FrmMainClient_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dockMain)).EndInit();
            this.dockMain.ResumeLayout(false);
            this.toolWindow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolTabStrip)).EndInit();
            this.toolTabStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentContainerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTop)).EndInit();
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelTopLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.Docking.DocumentContainer documentContainerMain;
        private Telerik.WinControls.UI.Docking.ToolWindow toolWindow;
        private Telerik.WinControls.UI.Docking.ToolTabStrip toolTabStrip;
        private Telerik.WinControls.UI.RadMenuItem mnuSystem;
        private Telerik.WinControls.UI.RadStatusStrip mainStatus;
        private Telerik.WinControls.UI.RadMenuItem mnuChangePwd;
        private Telerik.WinControls.UI.RadMenuSeparatorItem mnuSysSp1;
        private Telerik.WinControls.UI.RadMenuItem mnuExit;
        private Telerik.WinControls.UI.RadMenuItem mnuView;
        private Telerik.WinControls.UI.RadMenuItem mnuShow;
        private Telerik.WinControls.UI.RadMenuItem mnuTopPanel;
        private Telerik.WinControls.UI.RadMenuItem mnuLeftSysMenu;
        //private Telerik.WinControls.UI.RadToolStripSeparatorItem toolStripSp6;
        private System.Windows.Forms.Timer statusBarTimer;
        private Telerik.WinControls.UI.RadPanel pnlTop;
        private Telerik.WinControls.UI.RadMenuItem mnuShowHistoryLog;
        private Telerik.WinControls.UI.RadMenuItem mnuAbout;
        private RFIDProgram.UiLog uiLog;
        private Telerik.WinControls.UI.RadPanel panelTopLeft;
        private Telerik.WinControls.UI.RadTreeView treeMenu;
        private Telerik.WinControls.UI.RadLabelElement lblStatusCurrentUser;
        private Telerik.WinControls.UI.RadLabelElement lblStatusCurrentUserValue;
        private Telerik.WinControls.UI.RadLabelElement lblStatusCurrentDateTime;
        private Telerik.WinControls.UI.RadLabelElement lblStatusCurrentDateTimeValue;
        private Telerik.WinControls.UI.RadMenu mainMenu;
        private Telerik.WinControls.UI.Docking.RadDock dockMain;
    }
}

