

namespace RFIDProgram
{
    partial class FrmShowHistoryMessage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.gbResult = new Telerik.WinControls.UI.RadGroupBox();
            this.grdData = new RFIDProgram.FastGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gbResult)).BeginInit();
            this.gbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbResult
            // 
            this.gbResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.gbResult.Controls.Add(this.grdData);
            this.gbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbResult.FooterImageIndex = -1;
            this.gbResult.FooterImageKey = "";
            this.gbResult.HeaderImageIndex = -1;
            this.gbResult.HeaderImageKey = "";
            this.gbResult.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbResult.HeaderText = "";
            this.gbResult.Location = new System.Drawing.Point(0, 68);
            this.gbResult.Name = "gbResult";
            this.gbResult.Padding = new System.Windows.Forms.Padding(2);
            // 
            // 
            // 
            this.gbResult.RootElement.Padding = new System.Windows.Forms.Padding(2);
            this.gbResult.Size = new System.Drawing.Size(802, 437);
            this.gbResult.TabIndex = 1;
            // 
            // grdData
            // 
            this.grdData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdData.Location = new System.Drawing.Point(2, 2);
            // 
            // grdData
            // 
            this.grdData.MasterTemplate.AllowAddNewRow = false;
            this.grdData.MasterTemplate.AllowDeleteRow = false;
            this.grdData.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn1.HeaderText = "消息类型";
            gridViewTextBoxColumn1.Name = "colCnType";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 80;
            gridViewTextBoxColumn2.FieldName = "Message";
            gridViewTextBoxColumn2.HeaderText = "消息内容";
            gridViewTextBoxColumn2.Name = "colMessage";
            gridViewTextBoxColumn2.Width = 500;
            this.grdData.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.Size = new System.Drawing.Size(798, 433);
            this.grdData.TabIndex = 1;
            this.grdData.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.grdData_CellFormatting);
            // 
            // FrmShowHistoryMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(802, 505);
            this.Controls.Add(this.gbResult);
            this.Name = "FrmShowHistoryMessage";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "历史消息显示";
            this.Load += new System.EventHandler(this.FrmShowHistoryMessage_Load);
            this.Shown += new System.EventHandler(this.FrmShowHistoryMessage_Shown);
            this.Controls.SetChildIndex(this.gbResult, 0);
            ((System.ComponentModel.ISupportInitialize)(this.gbResult)).EndInit();
            this.gbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gbResult;
        private FastGridView grdData;
    }
}
