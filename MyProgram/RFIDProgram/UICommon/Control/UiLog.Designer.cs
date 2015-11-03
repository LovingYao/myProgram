namespace RFIDProgram
{
    partial class UiLog
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlImg = new Telerik.WinControls.UI.RadPanel();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.pnlFill = new Telerik.WinControls.UI.RadPanel();
            this.lblMsg = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pnlImg)).BeginInit();
            this.pnlImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).BeginInit();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImg
            // 
            this.pnlImg.Controls.Add(this.picBox);
            this.pnlImg.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImg.Location = new System.Drawing.Point(0, 0);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(51, 89);
            this.pnlImg.TabIndex = 0;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.pnlImg.GetChildAt(0).GetChildAt(1))).Width = 0F;
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(3, 18);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(46, 50);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            this.picBox.DoubleClick += new System.EventHandler(this.picBox_DoubleClick);
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.lblMsg);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(51, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(493, 89);
            this.pnlFill.TabIndex = 1;
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.pnlFill.GetChildAt(0).GetChildAt(1))).Width = 0F;
            // 
            // lblMsg
            // 
            this.lblMsg.Location = new System.Drawing.Point(4, 31);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(2, 2);
            this.lblMsg.TabIndex = 0;
            // 
            // UiLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlFill);
            this.Controls.Add(this.pnlImg);
            this.Name = "UiLog";
            this.Size = new System.Drawing.Size(544, 89);
            this.SizeChanged += new System.EventHandler(this.UiLog_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pnlImg)).EndInit();
            this.pnlImg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFill)).EndInit();
            this.pnlFill.ResumeLayout(false);
            this.pnlFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblMsg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel pnlImg;
        private Telerik.WinControls.UI.RadPanel pnlFill;
        private System.Windows.Forms.PictureBox picBox;
        private Telerik.WinControls.UI.RadLabel lblMsg;
    }
}
