using System;
using System.Collections.Generic;
using Telerik.WinControls.UI;
using TelerikWinformBase;

namespace RFIDProgram
{
    //历史消息显示
    /// <summary>
    /// 历史消息显示
    /// </summary>
    internal partial class FrmShowHistoryMessage : FrmBaseSelect
    {
        //构造函数
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="messages"></param>
        internal FrmShowHistoryMessage(List<CustomMessage> messages)
        {
            InitializeComponent();

            grdData.DataSource = messages;
        }

        //窗体第一次显示
        /// <summary>
        /// 窗体第一次显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmShowHistoryMessage_Shown(object sender, EventArgs e)
        {
            Text = "历史消息显示";
        }

        private void FrmShowHistoryMessage_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            ResetButtons(new[]
                             {
                                 CommandButton.Close
                             });
        }

        private void grdData_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.ColumnIndex != 0)
                return;

            var customMessage = e.Row.DataBoundItem as CustomMessage;
            if (customMessage == null)
                return;

            switch (customMessage.Type.ToString())
            {
                case "Info":
                    e.CellElement.Value = "提示";
                    break;
                case "Error":
                    e.CellElement.Value = "错误";
                    break;
                case "Warn":
                    e.CellElement.Value = "警告";
                    break;
            }
        }
    }
}