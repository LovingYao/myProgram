using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.ComponentModel;

namespace RFIDProgram
{
    //扩展表格控件 当列RecordStatus=0的时候，前景色改为红色
    /// <summary>
    /// 扩展表格控件 当列RecordStatus=0的时候，前景色改为红色
    /// </summary>
    public class FastGridView : RadGridView
    {
        //是否自动更改ReadOnly列的背景颜色
        /// <summary>
        /// 是否自动更改ReadOnly列的背景颜色
        /// </summary>
        private bool _changeReadOnlyBackColor = true;
        //是否自动更改ReadOnly列的背景颜色
        /// <summary>
        /// 是否自动更改ReadOnly列的背景颜色
        /// </summary>
        [Category("Custom")]
        [Description("是否自动更改ReadOnly列的背景颜色")]
        [DefaultValue(true)]
        public bool ChangeReadOnlyBackColor
        {
            get
            {
                return _changeReadOnlyBackColor;
            }
            set
            {
                _changeReadOnlyBackColor = value;
            }
        }

        //当表格数据绑定完成的时候处理
        /// <summary>
        /// 当表格数据绑定完成的时候处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected override void OnDataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
        {
            //调用基类的处理方法
            base.OnDataBindingComplete(sender, e);

            //遍历所有行
            foreach (var row in Rows)
            {
                if (row == null)
                    continue;
                //记录当前行是否需要更改前景色
                var isDisabledRow = false;
                foreach (GridViewCellInfo cell in row.Cells)
                {
                    //列绑定的字段为RecordStatus
                    if (!cell.ColumnInfo.FieldName.Equals("RecordStatus"))
                        continue;
                    //列绑定的字段为RecordStatus
                    if (cell.Value == null || !cell.Value.ToString().Equals("0"))
                        continue;

                    isDisabledRow = true;
                    break;
                }
                if (!isDisabledRow)
                    continue;

                foreach (GridViewCellInfo cell in row.Cells)
                {
                    cell.Style.ForeColor = Color.Red;
                }
            }
        }

        //将ReadOnly的列背景色置灰
        /// <summary>
        /// 将ReadOnly的列背景色置灰
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FastGridView_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (!ChangeReadOnlyBackColor)
                return;

            var readOnlyColumnIndexs = new List<int>();

            for (var i = 0; i < ColumnCount; i++)
            {
                if (Columns[i].ReadOnly)
                    readOnlyColumnIndexs.Add(i);
            }

            if (!readOnlyColumnIndexs.Contains(e.ColumnIndex))
                return;

            e.CellElement.DrawFill = true;
            e.CellElement.NumberOfColors = 1;
            e.CellElement.BackColor = Color.LightGray;
        }

        //绑定单元格事件
        /// <summary>
        /// 绑定单元格事件
        /// </summary>
        /// <param name="desiredSize"></param>
        protected override void OnLoad(Size desiredSize)
        {
            base.OnLoad(desiredSize);

            CellFormatting -= FastGridView_CellFormatting;
            CellFormatting += FastGridView_CellFormatting;
        }

        //禁用系统自带的上下文菜单
        /// <summary>
        /// 禁用系统自带的上下文菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        protected override void OnContextMenuOpening(object sender, ContextMenuOpeningEventArgs args)
        {
            base.OnContextMenuOpening(sender, args);

            args.Cancel = true;
        }

        //处理Control + C事件
        /// <summary>
        /// 处理Control + C事件
        /// </summary>
        /// <param name="e"></param>
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (!e.Control || e.Shift || e.Alt || e.KeyCode != Keys.C)
                return;

            if (RowCount <= 0)
                return;

            if (CurrentCell == null)
                return;

            if (CurrentCell.Value == null)
                return;

            Clipboard.SetText(CurrentCell.Value.ToString());
        }
    }
}