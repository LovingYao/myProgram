using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Telerik.WinControls.UI.Docking;
using Telerik.WinControls;
using TelerikWinformBase;

namespace RFIDProgram
{
    //主窗体
    /// <summary>
    /// 主窗体
    /// </summary>
    internal partial class FrmMainClient : RadForm
    {
        #region 构造方法

        //构造方法
        /// <summary>
        /// 构造方法
        /// </summary>
        private FrmMainClient()
        {
            InitializeComponent();
        }

        #endregion

        #region 主窗体单例
        private static readonly object LockObject = new object();
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        private static FrmMainClient _form;
        //窗体单例
        /// <summary>
        /// 窗体单例
        /// </summary>
        public static FrmMainClient Form
        {
            get
            {
                if (_form == null)
                {
                    lock (LockObject)
                    {
                        if (_form == null)
                        {
                            _form = new FrmMainClient();
                        }
                    }
                }

                return _form;
            }
        }
        #endregion

        #region 私有方法

        //显示子窗体
        /// <summary>
        /// 显示子窗体
        /// </summary>
        private void ShowChildForm()
        {
            var selectedNode = treeMenu.SelectedNode;
            if (selectedNode == null || selectedNode.Level != 1 || (selectedNode.Tag as ViewRight) == null)
                return;

            var tagEngity = selectedNode.Tag as ViewRight;
            var frmChild = RightMenuUI.GetMenuForm(tagEngity);
            if (frmChild == null)
                return;

            frmChild.MdiParent = this;
            frmChild.Show();
        }

        #endregion

        #region 窗体事件

        //窗体加载
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainClient_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;
            //禁止菜单ToolWindow ToolTabStrip的上下文菜单
            var menuService = dockMain.GetService<ContextMenuService>();
            menuService.ContextMenuDisplaying += MenuServiceContextMenuDisplaying;
            //屏蔽ToolWindow title双击事件，默认双击的时候会浮动
            toolWindow.AllowedDockState = AllowedDockState.Docked | AllowedDockState.AutoHide;

            RightMenuUI.LoadMenus(treeMenu);
        }

        //禁止菜单ToolWindow ToolTabStrip的上下文菜单 隐藏Mdi窗体标题部分右键菜单
        /// <summary>
        /// 禁止菜单ToolWindow ToolTabStrip的上下文菜单 隐藏Mdi窗体标题部分右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void MenuServiceContextMenuDisplaying(object sender, ContextMenuDisplayingEventArgs e)
        {
            //判断是不是DockWindow
            if (e.MenuType != ContextMenuType.DockWindow)
                return;
            //判断是不是DockWindow的ToolTabStrip
            if (e.DockWindow.DockTabStrip is ToolTabStrip)
            {
                //移除所有菜单
                e.Cancel = true;
                return;
            }
            //判断是不是DockWindow的DocumentTabStrip
            if (!(e.DockWindow.DockTabStrip is DocumentTabStrip))
                return;
            //移除“新建水平选项卡组”“新建垂直选项卡组”
            for (var i = 0; i < e.MenuItems.Count; i++)
            {
                var menuItem = e.MenuItems[i];
                if (menuItem.Name != "CloseWindow" &&
                    menuItem.Name != "CloseAllButThis" &&
                    menuItem.Name != "CloseAll")
                {
                    menuItem.Visibility = ElementVisibility.Collapsed;
                }
            }
        }

        //窗体第一次显示
        /// <summary>
        /// 窗体第一次显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainClient_Shown(object sender, EventArgs e)
        {
            Text += " Version : " + ProductVersion;

            lblStatusCurrentUserValue.Text = GloableData.Instance.UserId;
            lblStatusCurrentDateTimeValue.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //主窗体正在关闭，可取消
        /// <summary>
        /// 主窗体正在关闭，可取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UI.Confirm("确定要退出吗？")) 
                return;

            e.Cancel = true;
        }

        //主窗体已关闭
        /// <summary>
        /// 主窗体已关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMainClient_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form = null;
        }

        #endregion

        #region* 控件事件 *

        //Timer事件 更新状态栏时间
        /// <summary>
        /// Timer事件 更新状态栏时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statusBarTimer_Tick(object sender, EventArgs e)
        {
            lblStatusCurrentDateTimeValue.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        #endregion

        #region 树事件

        //树菜单双击事件
        /// <summary>
        /// 树菜单双击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeMenu_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            UI.ClearMessage();
            ShowChildForm();
        }

        //树菜单回车事件
        /// <summary>
        /// 树菜单回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            //按下的不是回车
            if (e.KeyChar != 13)
                return;

            UI.ClearMessage();
            ShowChildForm();
        }

        #endregion

        #region 菜单事件

        //顶部图片显示事件
        /// <summary>
        /// 顶部图片显示事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuTopPanel_Click(object sender, EventArgs e)
        {
            UI.ClearMessage();
            pnlTop.Visible = mnuTopPanel.IsChecked;
        }

        //左侧系统菜单显示事件
        /// <summary>
        /// 左侧系统菜单显示事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuLeftSysMenu_Click(object sender, EventArgs e)
        {
            toolWindow.DockState = mnuLeftSysMenu.IsChecked ? DockState.Docked : DockState.AutoHide;
        }

        //修改个人密码
        /// <summary>
        /// 修改个人密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuChangePwd_Click(object sender, EventArgs e)
        {
            var frm = FrmChangePassword.Form;
            frm.ShowDialog();
        }

        //退出系统
        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        internal void ShowMessage(CustomMessage message)
        {
            uiLog.ShowMessage(message);
        }

        internal void ClearMessage()
        {
            uiLog.ClearCurrentMessage();
        }

        private void mnuShowHistoryLog_Click(object sender, EventArgs e)
        {
            if (uiLog.Messages.Count <= 0)
            {
                UI.MsgBox("暂无历史消息");
                return;
            }
            var frm = new FrmShowHistoryMessage(uiLog.Messages);
            frm.ShowDialog();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            //var appServiceHost = GloableData.Instance.ClientUpdateService.Endpoint.Address.Uri.Host;
            //var conn = new System.Data.SqlClient.SqlConnection(GloableData.Instance.ConfigDbConn);
            //var dbHost = conn.DataSource;
            //var msg = string.Format("当前连接的服务器信息\r\n\r\nAp服务器：{0}\r\nDb服务器：{1}", appServiceHost, dbHost);
            //UI.MsgBox(msg);
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}