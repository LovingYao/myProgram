using System;
using System.ComponentModel;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using TelerikWinformBase;

namespace RFIDProgram
{
    public partial class FrmBase : RadForm
    {
        public FrmBase()
        {
            InitializeComponent();
        }

        #region* 按钮事件 *

        //新增
        internal void cmdBtnAdd_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (!Add())
                return;

            CurrentOperationStatus = OperationStatus.New;
            ResetButtonStatus();
        }

        //编辑
        internal void cmdBtnEdit_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (!Edit())
                return;

            CurrentOperationStatus = OperationStatus.Edit;
            ResetButtonStatus();
        }

        //提交
        internal void cmdBtnSubmit_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (!CanSubmit())
                return;

            if (!Submit())
                return;

            SetDefaultStatus();
        }

        //保存
        internal void cmdBtnSave_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (!CanSubmit())
                return;

            if (!Save())
                return;

            SetDefaultStatus();
        }

        //取消
        internal void cmdBtnCancel_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (!Cancel())
                return;

            SetDefaultStatus();
        }

        //打印
        internal void cmdBtnPrint_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (!CanSubmit())
                return;

            if (!Print())
                return;
            SetDefaultStatus();
        }

        //删除
        internal void cmdBtnDelete_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (!CanSubmit())
                return;

            if (!Delete())
                return;

            cmdBtnQuery_Click(null, null);

            SetDefaultStatus();
        }

        //刷新
        internal void cmdBtnRefresh_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (!RefreshData())
                return;
            SetDefaultStatus();
        }

        //查询
        internal void cmdBtnQuery_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (!Query())
                return;
            SetDefaultStatus();
        }

        //导入
        internal void cmdBtnImport_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (!CanSubmit())
                return;

            if (!Import())
                return;
            SetDefaultStatus();
        }

        //导出
        internal void cmdBtnExport_Click(object sender, EventArgs e)
        {
            ClearMessage();

            if (!Export())
                return;
            SetDefaultStatus();
        }

        //帮助
        internal void cmdBtnHelp_Click(object sender, EventArgs e)
        {
            ClearMessage();

            //TODO:
        }

        //关闭
        internal void cmdBtnClose_Click(object sender, EventArgs e)
        {
            ClearMessage();

            Close();
        }

        #endregion

        #region* 权限控制 *

        #endregion

        #region* 功能方法 *
        internal virtual bool Add()
        {
            return true;
        }
        internal virtual bool Edit()
        {
            return true;
        }
        internal virtual bool Submit()
        {
            return true;
        }
        internal virtual bool Save()
        {
            return true;
        }
        internal virtual bool Cancel()
        {
            return true;
        }
        internal virtual bool Delete()
        {
            return true;
        }
        internal virtual bool Print()
        {
            return true;
        }
        internal virtual bool RefreshData()
        {
            return true;
        }
        internal virtual bool Query()
        {
            return true;
        }
        internal virtual bool Import()
        {
            return true;
        }
        internal virtual bool Export()
        {
            return true;
        }
        internal virtual bool Help()
        {
            return true;
        }
        #endregion

        #region* 设置按钮 *

        //当CommandBar中有命令没显示的时候，显示OverflowButton
        /// <summary>
        /// 当CommandBar中有命令没显示的时候，显示OverflowButton
        /// </summary>
        private void ChangeOverflowButtonVisibility()
        {
            var overFlowCount = commandBarStripElementMain.OverflowButton.OverflowPanel.Children[0].Children.Count;
            commandBarStripElementMain.OverflowButton.Visibility = overFlowCount > 0
                                                                       ? ElementVisibility.Visible
                                                                       : ElementVisibility.Collapsed;
        }

        //改变按钮可用状态
        /// <summary>
        /// 改变按钮可用状态
        /// </summary>
        private void ResetButtonStatus()
        {
            var bDefault = CurrentOperationStatus == OperationStatus.Default;

            for (var i = 0; i < commandBarStripElementMain.Items.Count; i++)
            {
                if (commandBarStripElementMain.Items[i].Name == "cmdBtnSave" ||
                    commandBarStripElementMain.Items[i].Name == "cmdBtnCancel")
                {
                    commandBarStripElementMain.Items[i].Enabled = !bDefault;
                    continue;
                }
                commandBarStripElementMain.Items[i].Enabled = bDefault;
            }
        }

        private void SetDefaultStatus()
        {
            CurrentOperationStatus = OperationStatus.Default;
            ResetButtonStatus();
        }

        internal OperationStatus CurrentOperationStatus = OperationStatus.Default;

        private void RemoveCommandButtons()
        {
            commandBarStripElementMain.Items.Clear();
        }

        internal void ResetButtons(CommandButton[] buttons)
        {
            RemoveCommandButtons();
            for (var i = 0; i < buttons.Length; i++)
            {
                SetButton(buttons[i], i);
            }

            ResetButtonStatus();
        }

        private void SetButton(CommandButton button, int index)
        {
            switch (button)
            {
                case CommandButton.Add:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnAdd);
                    break;
                case CommandButton.Cancel:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnCancel);
                    break;
                case CommandButton.Close:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnClose);
                    break;
                case CommandButton.Submit:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnSubmit);
                    break;
                case CommandButton.Delete:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnDelete);
                    break;
                case CommandButton.Edit:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnEdit);
                    break;
                case CommandButton.Export:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnExport);
                    break;
                case CommandButton.Help:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnHelp);
                    break;
                case CommandButton.Import:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnImport);
                    break;
                case CommandButton.Print:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnPrint);
                    break;
                case CommandButton.Query:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnQuery);
                    break;
                case CommandButton.RefreshData:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnRefresh);
                    break;
                case CommandButton.Save:
                    commandBarStripElementMain.Items.Insert(index, cmdBtnSave);
                    break;
            }
        }

        #endregion

        #region* 窗体事件 *

        private void FrmBase_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            ClearMessage();

            RemoveCommandButtons();

            ChangeOverflowButtonVisibility();

            commandBarMain.CustomizeContextMenu.DropDownOpening += CustomizeContextMenu_DropDownOpening;

            _closed = false;
        }

        private bool _closed;

        private void FrmBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CurrentOperationStatus == OperationStatus.Default)
                return;

            if (!_closed && !UI.Confirm("窗体处于编辑状态，确定要关闭吗？"))
            {
                e.Cancel = true;
                return;
            }
            _closed = true;
        }

        private void FrmBase_SizeChanged(object sender, EventArgs e)
        {
            ChangeOverflowButtonVisibility();
        }

        //禁用CommandBar上的右键菜单
        /// <summary>
        /// 禁用CommandBar上的右键菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void CustomizeContextMenu_DropDownOpening(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        //禁用OverflowMenu中的"Add or Remove Buttons"和"Customize..." 
        /// <summary>
        /// 禁用OverflowMenu中的"Add or Remove Buttons"和"Customize..." 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commandBarStripElementMain_OverflowMenuOpening(object sender, CancelEventArgs e)
        {
            foreach (var item in commandBarStripElementMain.OverflowButton.DropDownMenu.Items)
            {
                if (item is RadCommandBarOverflowPanelElement)
                    continue;
                item.Visibility = ElementVisibility.Collapsed;
            }
        }

        #endregion

        #region* 提交前检查 *

        //是否可以提交
        /// <summary>
        /// 是否可以提交
        /// </summary>
        /// <returns></returns>
        private bool CanSubmit()
        {
            if (CheckClientVersion())
                return false;

            return true;
        }

        //检查客户端版本
        /// <summary>
        /// 检查客户端版本
        /// </summary>
        /// <returns></returns>
        private static bool CheckClientVersion()
        {
            //var b = new ClientVersionControl().HasNewVersion();

            //if (b)
            //{
            //    UI.MsgBox("有新版本，需要退出系统并重新登录才能继续作业");
            //}

            return false;
        }

        #endregion

        //事件开始处理前，清空MESSAGE
        /// <summary>
        /// 事件开始处理前，清空MESSAGE
        /// </summary>
        internal void ClearMessage()
        {
            try
            {
                UI.ClearMessage();
            }
            catch (Exception ex)
            {
                Logger.LogDebug("FrmBase ClearMessage", ex);
            }
        }
    }
}