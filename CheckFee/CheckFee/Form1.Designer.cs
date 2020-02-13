namespace CheckFee
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkFeeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feeDBDataSet = new CheckFee.FeeDBDataSet();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.srchTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.departComboBox = new System.Windows.Forms.ComboBox();
            this.feeCheckBox = new System.Windows.Forms.CheckBox();
            this.del_btn = new System.Windows.Forms.Button();
            this.updt_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.checkFeeTableTableAdapter = new CheckFee.FeeDBDataSetTableAdapters.CheckFeeTableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFeeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.studentIDDataGridViewTextBoxColumn,
            this.departDataGridViewTextBoxColumn,
            this.feeDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.checkFeeTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(386, 150);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "학번";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departDataGridViewTextBoxColumn
            // 
            this.departDataGridViewTextBoxColumn.DataPropertyName = "depart";
            this.departDataGridViewTextBoxColumn.HeaderText = "학과";
            this.departDataGridViewTextBoxColumn.Name = "departDataGridViewTextBoxColumn";
            this.departDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // feeDataGridViewCheckBoxColumn
            // 
            this.feeDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.feeDataGridViewCheckBoxColumn.DataPropertyName = "fee";
            this.feeDataGridViewCheckBoxColumn.HeaderText = "학회비";
            this.feeDataGridViewCheckBoxColumn.Name = "feeDataGridViewCheckBoxColumn";
            this.feeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.feeDataGridViewCheckBoxColumn.Width = 47;
            // 
            // checkFeeTableBindingSource
            // 
            this.checkFeeTableBindingSource.DataMember = "CheckFeeTable";
            this.checkFeeTableBindingSource.DataSource = this.feeDBDataSet;
            // 
            // feeDBDataSet
            // 
            this.feeDBDataSet.DataSetName = "FeeDBDataSet";
            this.feeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(89, 66);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(121, 21);
            this.studentIDTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "학과";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "학번";
            // 
            // srchTextBox
            // 
            this.srchTextBox.Location = new System.Drawing.Point(318, 155);
            this.srchTextBox.Name = "srchTextBox";
            this.srchTextBox.Size = new System.Drawing.Size(100, 21);
            this.srchTextBox.TabIndex = 8;
            this.srchTextBox.TextChanged += new System.EventHandler(this.srchTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(89, 39);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(121, 21);
            this.nameTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "검색";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 27;
            this.label1.Text = "이름";
            // 
            // departComboBox
            // 
            this.departComboBox.FormattingEnabled = true;
            this.departComboBox.Items.AddRange(new object[] {
            "컴퓨터학부",
            "소프트웨어",
            "응용컴퓨팅"});
            this.departComboBox.Location = new System.Drawing.Point(89, 93);
            this.departComboBox.Name = "departComboBox";
            this.departComboBox.Size = new System.Drawing.Size(121, 20);
            this.departComboBox.TabIndex = 3;
            // 
            // feeCheckBox
            // 
            this.feeCheckBox.AutoSize = true;
            this.feeCheckBox.Location = new System.Drawing.Point(47, 119);
            this.feeCheckBox.Name = "feeCheckBox";
            this.feeCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.feeCheckBox.Size = new System.Drawing.Size(60, 16);
            this.feeCheckBox.TabIndex = 4;
            this.feeCheckBox.Text = "학회비";
            this.feeCheckBox.UseVisualStyleBackColor = true;
            // 
            // del_btn
            // 
            this.del_btn.Location = new System.Drawing.Point(194, 152);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(75, 23);
            this.del_btn.TabIndex = 7;
            this.del_btn.Text = "삭제";
            this.del_btn.UseVisualStyleBackColor = true;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // updt_btn
            // 
            this.updt_btn.Location = new System.Drawing.Point(113, 152);
            this.updt_btn.Name = "updt_btn";
            this.updt_btn.Size = new System.Drawing.Size(75, 23);
            this.updt_btn.TabIndex = 6;
            this.updt_btn.Text = "수정";
            this.updt_btn.UseVisualStyleBackColor = true;
            this.updt_btn.Click += new System.EventHandler(this.updt_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(32, 152);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(75, 23);
            this.save_btn.TabIndex = 5;
            this.save_btn.Text = "저장";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // checkFeeTableTableAdapter
            // 
            this.checkFeeTableTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 341);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.srchTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departComboBox);
            this.Controls.Add(this.feeCheckBox);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.updt_btn);
            this.Controls.Add(this.save_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFeeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox srchTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox departComboBox;
        private System.Windows.Forms.CheckBox feeCheckBox;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button updt_btn;
        private System.Windows.Forms.Button save_btn;
        private FeeDBDataSet feeDBDataSet;
        private System.Windows.Forms.BindingSource checkFeeTableBindingSource;
        private FeeDBDataSetTableAdapters.CheckFeeTableTableAdapter checkFeeTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn feeDataGridViewCheckBoxColumn;
    }
}

