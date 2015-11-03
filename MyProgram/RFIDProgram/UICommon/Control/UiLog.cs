using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TelerikWinformBase;

namespace RFIDProgram
{
    public partial class UiLog : UserControl
    {
        public UiLog()
        {
            InitializeComponent();

            _msgHistory = new List<CustomMessage>();
            _timer = new Timer
                         {
                             Enabled = true,
                             Interval = 1000,
                             Tag = 0
                         };
            _timer.Tick += timer_Tick;
        }

        private readonly Timer _timer;

        private void timer_Tick(object sender, EventArgs e)
        {
            var cnt = (int)_timer.Tag;
            cnt++;
            if (cnt >= MessageRemainTime)
            {
                _timer.Stop();
                cnt = 0;
                if (IsAutoClearMessage)
                    ClearCurrentMessage();
            }
            _timer.Tag = cnt;
        }

        private readonly List<CustomMessage> _msgHistory;
        public List<CustomMessage> Messages
        {
            get
            {
                return _msgHistory;
            }
        }

        private int _maxHistoryMsgCount = 200;
        [Description("最大历史消息数，默认值200")]
        [DefaultValue(200)]
        [Category("Custom")]
        public int MaxHistoryMsgCount
        {
            get
            {
                if (_maxHistoryMsgCount <= 0)
                    _maxHistoryMsgCount = 200;
                return _maxHistoryMsgCount;
            }
            set
            {
                if (value <= 0)
                    value = 200;
                _maxHistoryMsgCount = value;
            }
        }

        [Description("消息显示的字体")]
        [Category("Custom")]
        public Font MessageFont
        {
            get
            {
                return lblMsg.Font;
            }
            set
            {
                lblMsg.Font = value;
                ResetMessagePosition();
            }
        }

        [Description("消息显示的字体颜色")]
        [Category("Custom")]
        public Color MessageForeColor
        {
            get
            {
                return lblMsg.ForeColor;
            }
            set
            {
                lblMsg.ForeColor = value;
            }
        }

        private bool _isAutoClearMessage;
        [Description("是否自动清除超时消息")]
        [Category("Custom")]
        [DefaultValue(false)]
        public bool IsAutoClearMessage
        {
            get
            {
                return _isAutoClearMessage;
            }
            set
            {
                if (!value)
                {
                    if (_timer != null)
                        _timer.Stop();
                }
                _isAutoClearMessage = value;
            }
        }

        private int _messageRemainTime = 10;
        [Description("同一消息的界面停留时间（单位：秒），默认值10")]
        [DefaultValue(10)]
        [Category("Custom")]
        public int MessageRemainTime
        {
            get
            {
                if (_messageRemainTime <= 0)
                    _messageRemainTime = 10;
                return _messageRemainTime;
            }
            set
            {
                if (value <= 0)
                    value = 10;
                _messageRemainTime = value;
            }
        }

        private delegate void ShowMessageHandler(CustomMessage message);
        internal void ShowMessage(CustomMessage message)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ShowMessageHandler(ShowMessage), message);
            }
            else
            {
                lblMsg.Text = message.Message;
                ResetMessageType(message.Type);
                ResetMessagePosition();
                _timer.Tag = 0;
                _timer.Start();
                _msgHistory.Add(message);
            }
        }

        private delegate void ClearCurrentMessageHandler();
        internal void ClearCurrentMessage()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new ClearCurrentMessageHandler(ClearCurrentMessage));
            }
            else
            {
                lblMsg.Text = "";
                picBox.Image = null;
                ResetMessagePosition();
            }
        }

        private void UiLog_SizeChanged(object sender, EventArgs e)
        {
            ResetPictureBoxPosition();

            ResetMessagePosition();
        }

        private void picBox_DoubleClick(object sender, EventArgs e)
        {
            if (lblMsg.Text.Trim().Length <= 0)
                return;

            Clipboard.SetText(lblMsg.Text);
        }

        private void ResetPictureBoxPosition()
        {
            const int picBoxX = 0;
            var picBoxY = (pnlImg.Height - picBox.Height) / 2;
            picBox.Width = pnlImg.Width;
            picBox.Location = new Point(picBoxX, picBoxY);
        }

        private void ResetMessagePosition()
        {
            var msgSize = TextRenderer.MeasureText(lblMsg.Text, lblMsg.Font);
            const int labelX = 0;
            var labelY = (pnlFill.Height - msgSize.Height) / 2;
            lblMsg.Location = new Point(labelX, labelY);
        }

        private void ResetMessageType(MessageType messageType)
        {
            switch (messageType)
            {
                case MessageType.Info:
                    picBox.Image = Properties.Resources.Info;
                    break;
                case MessageType.Warn:
                    picBox.Image = Properties.Resources.Warn;
                    break;
                case MessageType.Error:
                    picBox.Image = Properties.Resources.Error;
                    break;
            }
        }
    }
}