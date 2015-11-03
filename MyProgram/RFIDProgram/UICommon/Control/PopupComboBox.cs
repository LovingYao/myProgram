using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace RFIDProgram
{
    [ToolboxItem(false)]
    public partial class PopupComboBox : ComboBox
    {
        /// <summary>
        /// 当显示<see cref="glControl.ComboBoxTree" />的下拉部分时发生
        /// </summary>
        [CategoryAttribute("行为"), Description("显示组合框的下拉树部分时发生。")]
        public new event EventHandler DropDown;
        /// <summary>
        /// 在<see cref="glControl.ComboBoxTree" />的下拉部分不再可见时发生。
        /// </summary>
        [CategoryAttribute("行为"), Description("指示组合框的下拉树部分已关闭。")]
        public new event EventHandler DropDownClosed;

        private const int WM_LBUTTONDOWN = 0x201, WM_LBUTTONDBLCLK = 0x203;

        PopupToolStripDropDown dropDownHost;
        public PopupToolStripDropDown DropDownHost
        {
            get { return dropDownHost; }
        }

        bool IsdropDown = false;

        public void dropDown(object sender, EventArgs e)
        {
            if (DropDown != null)
            {
                DropDown(sender, e);
            }
            IsdropDown = true;
        }

        public void dropDownClosed(object sender, EventArgs e)
        {
            if (DropDownClosed != null)
            {
                DropDownClosed(this, EventArgs.Empty);
            }
            IsdropDown = false;
        }

        public PopupComboBox()
        {
            InitializeComponent();

            dropDownHost = new PopupToolStripDropDown(this);

            dropDownHost.AutoClose = true;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDBLCLK || m.Msg == WM_LBUTTONDOWN)
            {
                if (IsdropDown)
                {
                    //关闭下拉框
                    dropDownHost.Close();
                    //下拉框关闭后，控件获得焦点
                    this.Focus();
                }
                else
                {
                    //在指定位置显示下拉框
                    dropDownHost.Show(this, 0, this.Height);
                    //显示下拉框之后，直接将焦点设置到下拉框上 
                    dropDownHost.Focus();
                }
                return;
            }
            base.WndProc(ref m);
        }
    }

    [ToolboxItem(false)]
    public partial class PopupToolStripDropDown : ToolStripDropDown
    {
        PopupComboBox owner;

        public PopupToolStripDropDown(PopupComboBox owner)
            : base()
        {
            this.owner = owner;
            this.owner.FlatStyle = FlatStyle.Popup;
            this.owner.DrawMode = DrawMode.OwnerDrawFixed;
            this.owner.BackColor = Color.FromArgb(191, 219, 255); 
        }

        /// <summary>
        /// 关闭<see cref="glControl.PopupToolStripDropDown"/>控件
        /// </summary>
        public new void Close()
        {
            base.Close();
            owner.dropDownClosed(this, EventArgs.Empty);
        }

        /// <summary>
        /// 相对于指定控件的水平和垂直屏幕坐标定位<see cref="glControl.PopupToolStripDropDown"/>
        /// </summary>
        /// <param name="control"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public new void Show(System.Windows.Forms.Control control, int x, int y)
        {
            base.Show(control, x, y);
            owner.dropDown(this, EventArgs.Empty);
        }
    }
}
