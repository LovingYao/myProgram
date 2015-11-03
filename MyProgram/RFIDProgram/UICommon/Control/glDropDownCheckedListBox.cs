using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RFIDProgram
{
    [ToolboxBitmap(typeof(ComboBox)), ToolboxItem(true), ToolboxItemFilter("glControl"), Description("下拉框为 CheckListBox 的组合框")]
    public partial class DropDownCheckedListBox : PopupComboBox
    {
        CheckedListBox checkedListBox;
        ToolStripControlHost controlHost;

        public DropDownCheckedListBox()
        {
            InitializeComponent();

            DoubleBuffered = true;

            base.KeyDown += new KeyEventHandler(ComboTreeBox_KeyDown);

            checkedListBox = new CheckedListBox();
            checkedListBox.MultiColumn = false;
            checkedListBox.CheckOnClick = true;
            checkedListBox.IntegralHeight = false;
            checkedListBox.BorderStyle = BorderStyle.None;
            checkedListBox.ItemCheck += new ItemCheckEventHandler(checkedListBox_ItemCheck);

            controlHost = new ToolStripControlHost(checkedListBox);
            controlHost.AutoSize = false;
            base.DropDownHost.Items.Add(controlHost);
        }

        void ComboTreeBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            e.Handled = true;
        }

        void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string text = "";
            int curIndex = e.Index;
            bool newState = e.NewValue == CheckState.Checked;
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (i == curIndex)
                {
                    if (newState)
                        text += checkedListBox.Items[i].ToString() + ",";
                }
                else
                {
                    if (checkedListBox.GetItemChecked(i))
                    {
                        text += checkedListBox.Items[i].ToString() + ",";
                    }
                }
            }
            this.Text = text.TrimEnd(',');
        }

        #region 属性

        /// <summary>
        /// 获取一个对象，该对象表示该<see cref="glControl.glDropDownCheckedListBox2" />中所包含项的集合
        /// </summary>
        [Browsable(true), CategoryAttribute("自定义属性"), Localizable(true), MergableProperty(false), Description("下拉列表框中的项")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(System.Drawing.Design.UITypeEditor))]
        public new CheckedListBox.ObjectCollection Items
        {
            get { return this.checkedListBox.Items; }
        }

        /// <summary>
        /// 获取或设置一个值，该值指示<see cref="glControl.glDropDownCheckedListBox2"/>中的项是否按字母顺序排列
        /// </summary>
        [Browsable(true), CategoryAttribute("自定义属性"), Description("指示是否对列进行排序")]
        public new bool Sorted
        {
            get { return this.checkedListBox.Sorted; }
            set { this.checkedListBox.Sorted = value; }
        }

        /// <summary>
        /// 获取或设置 <see cref="glControl.DropDownTreeView2"/> 下拉部分的高度（以像素为单位）。
        /// </summary>
        [Browsable(true), CategoryAttribute("自定义属性"), Description("组合框中下拉框的高度（以像素为单位）。")]
        public int DropDownTreeHeight
        {
            get { return this.controlHost.Height; }
            set { this.controlHost.Height = value; }
        }

        #endregion

        /// <summary>
        /// <see cref="glControl.DropDownTreeView2"/>中选中项的集合
        /// </summary>
        [Browsable(false)]
        public CheckedListBox.CheckedItemCollection CheckedItems
        {
            get { return checkedListBox.CheckedItems; }
        }

        private void glDropDownCheckedListBox2_SizeChanged(object sender, EventArgs e)
        {
            controlHost.Width = this.Width - 2;
        }
    }
}
