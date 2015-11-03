namespace ImportDataTool
{
    partial class ImportDataMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDBTable = new System.Windows.Forms.ComboBox();
            this.cbDBName = new System.Windows.Forms.ComboBox();
            this.cbDBType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbHistroyName = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbDBTableG = new System.Windows.Forms.ComboBox();
            this.cbDBNameG = new System.Windows.Forms.ComboBox();
            this.cbDBTypeG = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gvMacth = new System.Windows.Forms.DataGridView();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btSureMacth = new System.Windows.Forms.Button();
            this.btImportMacth = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBasis = new System.Windows.Forms.ComboBox();
            this.txtBegin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MacthName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MatchOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ckbColumn = new System.Windows.Forms.CheckBox();
            this.rdbDelete = new System.Windows.Forms.RadioButton();
            this.rdbContinue = new System.Windows.Forms.RadioButton();
            this.lstV = new System.Windows.Forms.ListView();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMacth)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDBTable);
            this.groupBox1.Controls.Add(this.cbDBName);
            this.groupBox1.Controls.Add(this.cbDBType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(363, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据源";
            // 
            // cbDBTable
            // 
            this.cbDBTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDBTable.FormattingEnabled = true;
            this.cbDBTable.Location = new System.Drawing.Point(83, 65);
            this.cbDBTable.MaxLength = 8;
            this.cbDBTable.Name = "cbDBTable";
            this.cbDBTable.Size = new System.Drawing.Size(217, 20);
            this.cbDBTable.TabIndex = 7;
            this.cbDBTable.SelectedValueChanged += new System.EventHandler(this.cbDBTable_SelectedValueChanged);
            // 
            // cbDBName
            // 
            this.cbDBName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDBName.FormattingEnabled = true;
            this.cbDBName.Location = new System.Drawing.Point(83, 40);
            this.cbDBName.MaxLength = 8;
            this.cbDBName.Name = "cbDBName";
            this.cbDBName.Size = new System.Drawing.Size(217, 20);
            this.cbDBName.TabIndex = 6;
            this.cbDBName.SelectedValueChanged += new System.EventHandler(this.cbDBName_SelectedValueChanged);
            // 
            // cbDBType
            // 
            this.cbDBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDBType.FormattingEnabled = true;
            this.cbDBType.Location = new System.Drawing.Point(83, 18);
            this.cbDBType.MaxLength = 8;
            this.cbDBType.Name = "cbDBType";
            this.cbDBType.Size = new System.Drawing.Size(217, 20);
            this.cbDBType.TabIndex = 5;
            this.cbDBType.SelectedValueChanged += new System.EventHandler(this.cbDBType_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "表名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "数据库名称:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "数据库类型:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.rdbContinue);
            this.groupBox2.Controls.Add(this.rdbDelete);
            this.groupBox2.Controls.Add(this.ckbColumn);
            this.groupBox2.Controls.Add(this.txtEnd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtBegin);
            this.groupBox2.Controls.Add(this.cbBasis);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCount);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(13, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "基础设置";
            // 
            // cbHistroyName
            // 
            this.cbHistroyName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHistroyName.FormattingEnabled = true;
            this.cbHistroyName.Location = new System.Drawing.Point(97, 191);
            this.cbHistroyName.MaxLength = 8;
            this.cbHistroyName.Name = "cbHistroyName";
            this.cbHistroyName.Size = new System.Drawing.Size(204, 20);
            this.cbHistroyName.TabIndex = 8;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 195);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "历史导入项";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(445, 24);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(47, 21);
            this.txtCount.TabIndex = 6;
            this.txtCount.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "每次导入数量:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbDBTableG);
            this.groupBox3.Controls.Add(this.cbDBNameG);
            this.groupBox3.Controls.Add(this.cbDBTypeG);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(13, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 100);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "目标库";
            // 
            // cbDBTableG
            // 
            this.cbDBTableG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDBTableG.FormattingEnabled = true;
            this.cbDBTableG.Location = new System.Drawing.Point(83, 65);
            this.cbDBTableG.MaxLength = 8;
            this.cbDBTableG.Name = "cbDBTableG";
            this.cbDBTableG.Size = new System.Drawing.Size(217, 20);
            this.cbDBTableG.TabIndex = 7;
            this.cbDBTableG.SelectedValueChanged += new System.EventHandler(this.cbDBTableG_SelectedValueChanged);
            // 
            // cbDBNameG
            // 
            this.cbDBNameG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDBNameG.FormattingEnabled = true;
            this.cbDBNameG.Location = new System.Drawing.Point(83, 40);
            this.cbDBNameG.MaxLength = 8;
            this.cbDBNameG.Name = "cbDBNameG";
            this.cbDBNameG.Size = new System.Drawing.Size(217, 20);
            this.cbDBNameG.TabIndex = 6;
            this.cbDBNameG.SelectedIndexChanged += new System.EventHandler(this.cbDBNameG_SelectedIndexChanged);
            // 
            // cbDBTypeG
            // 
            this.cbDBTypeG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDBTypeG.FormattingEnabled = true;
            this.cbDBTypeG.Location = new System.Drawing.Point(83, 18);
            this.cbDBTypeG.MaxLength = 8;
            this.cbDBTypeG.Name = "cbDBTypeG";
            this.cbDBTypeG.Size = new System.Drawing.Size(217, 20);
            this.cbDBTypeG.TabIndex = 5;
            this.cbDBTypeG.SelectedValueChanged += new System.EventHandler(this.cbDBTypeG_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "表名:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "数据库名称:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "数据库类型:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbHistroyName);
            this.groupBox4.Controls.Add(this.gvMacth);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.btSubmit);
            this.groupBox4.Controls.Add(this.btSureMacth);
            this.groupBox4.Controls.Add(this.btImportMacth);
            this.groupBox4.Location = new System.Drawing.Point(12, 236);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(671, 229);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "匹配";
            // 
            // gvMacth
            // 
            this.gvMacth.AllowUserToAddRows = false;
            this.gvMacth.AllowUserToDeleteRows = false;
            this.gvMacth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMacth.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MacthName,
            this.MatchOther,
            this.CheckColumn});
            this.gvMacth.Location = new System.Drawing.Point(9, 20);
            this.gvMacth.Name = "gvMacth";
            this.gvMacth.RowTemplate.Height = 23;
            this.gvMacth.Size = new System.Drawing.Size(642, 150);
            this.gvMacth.TabIndex = 4;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(551, 188);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(100, 29);
            this.btSubmit.TabIndex = 3;
            this.btSubmit.Text = "开始导入";
            this.btSubmit.UseVisualStyleBackColor = true;
            // 
            // btSureMacth
            // 
            this.btSureMacth.Location = new System.Drawing.Point(438, 188);
            this.btSureMacth.Name = "btSureMacth";
            this.btSureMacth.Size = new System.Drawing.Size(100, 29);
            this.btSureMacth.TabIndex = 2;
            this.btSureMacth.Text = "确认匹配项";
            this.btSureMacth.UseVisualStyleBackColor = true;
            // 
            // btImportMacth
            // 
            this.btImportMacth.Location = new System.Drawing.Point(322, 188);
            this.btImportMacth.Name = "btImportMacth";
            this.btImportMacth.Size = new System.Drawing.Size(100, 29);
            this.btImportMacth.TabIndex = 1;
            this.btImportMacth.Text = "生成SQL";
            this.btImportMacth.UseVisualStyleBackColor = true;
            this.btImportMacth.Click += new System.EventHandler(this.btImportMacth_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lstV);
            this.groupBox5.Location = new System.Drawing.Point(12, 471);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(671, 132);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "LOG";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "导入依据:";
            // 
            // cbBasis
            // 
            this.cbBasis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBasis.FormattingEnabled = true;
            this.cbBasis.Location = new System.Drawing.Point(163, 20);
            this.cbBasis.MaxLength = 8;
            this.cbBasis.Name = "cbBasis";
            this.cbBasis.Size = new System.Drawing.Size(137, 20);
            this.cbBasis.TabIndex = 9;
            // 
            // txtBegin
            // 
            this.txtBegin.Location = new System.Drawing.Point(83, 54);
            this.txtBegin.Name = "txtBegin";
            this.txtBegin.Size = new System.Drawing.Size(217, 21);
            this.txtBegin.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 11;
            this.label9.Text = "起始:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "终止:";
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(83, 88);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(217, 21);
            this.txtEnd.TabIndex = 13;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ColumnName";
            this.Column1.HeaderText = "目标库表字段";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // MacthName
            // 
            this.MacthName.HeaderText = "数据源表字段";
            this.MacthName.Name = "MacthName";
            this.MacthName.Width = 200;
            // 
            // MatchOther
            // 
            this.MatchOther.HeaderText = "自定义字段";
            this.MatchOther.Name = "MatchOther";
            this.MatchOther.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MatchOther.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CheckColumn
            // 
            this.CheckColumn.HeaderText = "唯一性检查项";
            this.CheckColumn.Name = "CheckColumn";
            // 
            // ckbColumn
            // 
            this.ckbColumn.AutoSize = true;
            this.ckbColumn.Location = new System.Drawing.Point(358, 58);
            this.ckbColumn.Name = "ckbColumn";
            this.ckbColumn.Size = new System.Drawing.Size(84, 16);
            this.ckbColumn.TabIndex = 14;
            this.ckbColumn.Text = "唯一性检查";
            this.ckbColumn.UseVisualStyleBackColor = true;
            this.ckbColumn.CheckedChanged += new System.EventHandler(this.ckbColumn_CheckedChanged);
            // 
            // rdbDelete
            // 
            this.rdbDelete.AutoSize = true;
            this.rdbDelete.Checked = true;
            this.rdbDelete.Location = new System.Drawing.Point(449, 57);
            this.rdbDelete.Name = "rdbDelete";
            this.rdbDelete.Size = new System.Drawing.Size(47, 16);
            this.rdbDelete.TabIndex = 15;
            this.rdbDelete.TabStop = true;
            this.rdbDelete.Text = "删除";
            this.rdbDelete.UseVisualStyleBackColor = true;
            // 
            // rdbContinue
            // 
            this.rdbContinue.AutoSize = true;
            this.rdbContinue.Location = new System.Drawing.Point(502, 57);
            this.rdbContinue.Name = "rdbContinue";
            this.rdbContinue.Size = new System.Drawing.Size(47, 16);
            this.rdbContinue.TabIndex = 16;
            this.rdbContinue.Text = "跳过";
            this.rdbContinue.UseVisualStyleBackColor = true;
            // 
            // lstV
            // 
            this.lstV.Location = new System.Drawing.Point(9, 20);
            this.lstV.Name = "lstV";
            this.lstV.Size = new System.Drawing.Size(656, 106);
            this.lstV.TabIndex = 0;
            this.lstV.UseCompatibleStateImageBehavior = false;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "时间",
            "ID"});
            this.cbType.Location = new System.Drawing.Point(83, 20);
            this.cbType.MaxLength = 8;
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(74, 20);
            this.cbType.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(499, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "label11";
            // 
            // ImportDataMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 615);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImportDataMain";
            this.Text = "数据导入工具";
            this.Load += new System.EventHandler(this.ImportDataMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMacth)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbDBTable;
        private System.Windows.Forms.ComboBox cbDBName;
        private System.Windows.Forms.ComboBox cbDBType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbDBTableG;
        private System.Windows.Forms.ComboBox cbDBNameG;
        private System.Windows.Forms.ComboBox cbDBTypeG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbHistroyName;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btSureMacth;
        private System.Windows.Forms.Button btImportMacth;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView gvMacth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBegin;
        private System.Windows.Forms.ComboBox cbBasis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn MacthName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchOther;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckColumn;
        private System.Windows.Forms.RadioButton rdbContinue;
        private System.Windows.Forms.RadioButton rdbDelete;
        private System.Windows.Forms.CheckBox ckbColumn;
        private System.Windows.Forms.ListView lstV;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label11;
    }
}

