using System;
using System.Drawing;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;

namespace RFIDProgram
{
    public class FastGridViewCheckBoxColumn : GridViewCheckBoxColumn
    {
        public override Type GetCellType(GridViewRowInfo row)
        {
            if (row is GridViewTableHeaderRowInfo)
            {
                return typeof(FastGridViewCheckBoxHeaderCell);
            }

            return base.GetCellType(row);
        }
    }

    public class FastGridViewCheckBoxHeaderCell : GridHeaderCellElement
    {
        RadCheckBoxElement _checkbox;

        protected override Type ThemeEffectiveType
        {
            get
            {
                return typeof(GridHeaderCellElement);
            }
        }

        public FastGridViewCheckBoxHeaderCell(GridViewColumn column, GridRowElement row)
            : base(column, row)
        {

        }

        public override void Initialize(GridViewColumn column, GridRowElement row)
        {
            base.Initialize(column, row);
            column.AllowSort = false;
        }

        public override void SetContent()
        {

        }

        protected override void DisposeManagedResources()
        {
            _checkbox.ToggleStateChanged -= checkbox_ToggleStateChanged;
            base.DisposeManagedResources();
        }

        protected override void CreateChildElements()
        {
            base.CreateChildElements();
            _checkbox = new RadCheckBoxElement();
            _checkbox.ToggleStateChanged += checkbox_ToggleStateChanged;
            Children.Add(_checkbox);
        }

        protected override SizeF ArrangeOverride(SizeF finalSize)
        {
            var size = base.ArrangeOverride(finalSize);

            var rect = GetClientRectangle(finalSize);
            _checkbox.Arrange(new RectangleF((finalSize.Width - _checkbox.DesiredSize.Width) / 2, (rect.Height - 20) / 2, 20, 20));

            return size;
        }

        public override bool IsCompatible(GridViewColumn data, object context)
        {
            return data.Name == "Select" &&
                context is GridTableHeaderRowElement &&
                base.IsCompatible(data, context);
        }

        private void checkbox_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (_suspendProcessingToggleStateChanged)
                return;

            var valueState = false;

            if (args.ToggleState == ToggleState.On)
            {
                valueState = true;
            }
            GridViewElement.EditorManager.EndEdit();
            TableElement.BeginUpdate();
            for (var i = 0; i < ViewInfo.Rows.Count; i++)
            {
                ViewInfo.Rows[i].Cells[ColumnIndex].Value = valueState;
            }

            TableElement.EndUpdate(false);

            TableElement.Update(GridUINotifyAction.DataChanged);
        }

        private bool _suspendProcessingToggleStateChanged;

        public void SetCheckBoxState(ToggleState state)
        {
            _suspendProcessingToggleStateChanged = true;
            _checkbox.ToggleState = state;
            _suspendProcessingToggleStateChanged = false;
        }

        public override void Attach(GridViewColumn data, object context)
        {
            base.Attach(data, context);
            GridControl.DataBindingComplete += GridControl_DataBindingComplete;
            GridControl.ValueChanged += GridControl_ValueChanged;
        }

        public override void Detach()
        {
            if (GridControl != null)
            {
                GridControl.DataBindingComplete -= GridControl_DataBindingComplete;
                GridControl.ValueChanged -= GridControl_ValueChanged;
            }

            base.Detach();
        }

        void GridControl_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
        {
            var grid = sender as RadGridView;
            if (grid == null)
                return;
            if (grid.Rows == null || grid.Rows.Count <= 0)
                return;

            var found = false;
            foreach (var row in grid.Rows)
            {
                var checkBoxColumn = row.Cells["Select"];
                if (checkBoxColumn == null || checkBoxColumn.Value == null ||
                    (bool)checkBoxColumn.Value)
                    continue;

                found = true;
                break;
            }
            if (found)
                return;

            SetCheckBoxState(ToggleState.On);
        }

        void GridControl_ValueChanged(object sender, EventArgs e)
        {
            var editor = sender as RadCheckBoxEditor;
            if (editor == null)
                return;

            if (GridControl == null)
                return;

            GridViewElement.EditorManager.EndEdit();
            switch ((ToggleState)editor.Value)
            {
                case ToggleState.Off:
                    SetCheckBoxState(ToggleState.Off);
                    break;
                case ToggleState.On:
                    {
                        var found = false;
                        foreach (var row in ViewInfo.Rows)
                        {
                            if ((row == RowInfo || row.Cells[ColumnIndex].Value != null) &&
                                (bool)row.Cells[ColumnIndex].Value)
                                continue;

                            found = true;
                            break;
                        }
                        if (!found)
                        {
                            SetCheckBoxState(ToggleState.On);
                        }
                    }
                    break;
            }
        }
    }
}