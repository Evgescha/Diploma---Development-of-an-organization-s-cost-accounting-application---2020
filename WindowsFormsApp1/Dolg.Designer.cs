namespace WindowsFormsApp1
{
    partial class Dolg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyDataSet = new WindowsFormsApp1.MoneyDataSet();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.komyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReturnDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lendBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOplachenDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ktoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.usersTableAdapter = new WindowsFormsApp1.MoneyDataSetTableAdapters.UsersTableAdapter();
            this.lendTableAdapter = new WindowsFormsApp1.MoneyDataSetTableAdapters.LendTableAdapter();
            this.borrowTableAdapter = new WindowsFormsApp1.MoneyDataSetTableAdapters.BorrowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usersBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.moneyDataSet;
            // 
            // moneyDataSet
            // 
            this.moneyDataSet.DataSetName = "MoneyDataSet";
            this.moneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(433, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Пользователь: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 173);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Должны пользователю";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.Column1,
            this.komyDataGridViewTextBoxColumn,
            this.datesDataGridViewTextBoxColumn,
            this.isReturnDataGridViewCheckBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lendBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(767, 154);
            this.dataGridView1.TabIndex = 16;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 40;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn.Visible = false;
            this.userIdDataGridViewTextBoxColumn.Width = 61;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Кто";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // komyDataGridViewTextBoxColumn
            // 
            this.komyDataGridViewTextBoxColumn.DataPropertyName = "komy";
            this.komyDataGridViewTextBoxColumn.HeaderText = "Кому";
            this.komyDataGridViewTextBoxColumn.Name = "komyDataGridViewTextBoxColumn";
            this.komyDataGridViewTextBoxColumn.ReadOnly = true;
            this.komyDataGridViewTextBoxColumn.Width = 58;
            // 
            // datesDataGridViewTextBoxColumn
            // 
            this.datesDataGridViewTextBoxColumn.DataPropertyName = "dates";
            this.datesDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.datesDataGridViewTextBoxColumn.Name = "datesDataGridViewTextBoxColumn";
            this.datesDataGridViewTextBoxColumn.ReadOnly = true;
            this.datesDataGridViewTextBoxColumn.Width = 58;
            // 
            // isReturnDataGridViewCheckBoxColumn
            // 
            this.isReturnDataGridViewCheckBoxColumn.DataPropertyName = "isReturn";
            this.isReturnDataGridViewCheckBoxColumn.HeaderText = "Возвращен";
            this.isReturnDataGridViewCheckBoxColumn.Name = "isReturnDataGridViewCheckBoxColumn";
            this.isReturnDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isReturnDataGridViewCheckBoxColumn.Width = 71;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn.Width = 102;
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Сколько";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            this.countDataGridViewTextBoxColumn.ReadOnly = true;
            this.countDataGridViewTextBoxColumn.Width = 75;
            // 
            // lendBindingSource
            // 
            this.lendBindingSource.DataMember = "Lend";
            this.lendBindingSource.DataSource = this.moneyDataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(15, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(773, 198);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пользователь должен";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.userIdDataGridViewTextBoxColumn1,
            this.Column2,
            this.datePolDataGridViewTextBoxColumn,
            this.isOplachenDataGridViewCheckBoxColumn,
            this.ktoDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn1,
            this.countDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.borrowBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(767, 179);
            this.dataGridView2.TabIndex = 16;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 40;
            // 
            // userIdDataGridViewTextBoxColumn1
            // 
            this.userIdDataGridViewTextBoxColumn1.DataPropertyName = "userId";
            this.userIdDataGridViewTextBoxColumn1.HeaderText = "userId";
            this.userIdDataGridViewTextBoxColumn1.Name = "userIdDataGridViewTextBoxColumn1";
            this.userIdDataGridViewTextBoxColumn1.ReadOnly = true;
            this.userIdDataGridViewTextBoxColumn1.Visible = false;
            this.userIdDataGridViewTextBoxColumn1.Width = 61;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кто должен";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 91;
            // 
            // datePolDataGridViewTextBoxColumn
            // 
            this.datePolDataGridViewTextBoxColumn.DataPropertyName = "datePol";
            this.datePolDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.datePolDataGridViewTextBoxColumn.Name = "datePolDataGridViewTextBoxColumn";
            this.datePolDataGridViewTextBoxColumn.ReadOnly = true;
            this.datePolDataGridViewTextBoxColumn.Width = 58;
            // 
            // isOplachenDataGridViewCheckBoxColumn
            // 
            this.isOplachenDataGridViewCheckBoxColumn.DataPropertyName = "isOplachen";
            this.isOplachenDataGridViewCheckBoxColumn.HeaderText = "Оплачен";
            this.isOplachenDataGridViewCheckBoxColumn.Name = "isOplachenDataGridViewCheckBoxColumn";
            this.isOplachenDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isOplachenDataGridViewCheckBoxColumn.Width = 56;
            // 
            // ktoDataGridViewTextBoxColumn
            // 
            this.ktoDataGridViewTextBoxColumn.DataPropertyName = "kto";
            this.ktoDataGridViewTextBoxColumn.HeaderText = "Кто одолжил";
            this.ktoDataGridViewTextBoxColumn.Name = "ktoDataGridViewTextBoxColumn";
            this.ktoDataGridViewTextBoxColumn.ReadOnly = true;
            this.ktoDataGridViewTextBoxColumn.Width = 97;
            // 
            // commentDataGridViewTextBoxColumn1
            // 
            this.commentDataGridViewTextBoxColumn1.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn1.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn1.Name = "commentDataGridViewTextBoxColumn1";
            this.commentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.commentDataGridViewTextBoxColumn1.Width = 102;
            // 
            // countDataGridViewTextBoxColumn1
            // 
            this.countDataGridViewTextBoxColumn1.DataPropertyName = "count";
            this.countDataGridViewTextBoxColumn1.HeaderText = "Сколько";
            this.countDataGridViewTextBoxColumn1.Name = "countDataGridViewTextBoxColumn1";
            this.countDataGridViewTextBoxColumn1.ReadOnly = true;
            this.countDataGridViewTextBoxColumn1.Width = 75;
            // 
            // borrowBindingSource
            // 
            this.borrowBindingSource.DataMember = "Borrow";
            this.borrowBindingSource.DataSource = this.moneyDataSet;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(445, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(363, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 20;
            this.button5.Text = "Изменить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(281, 214);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 19;
            this.button6.Text = "Добавить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(526, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 22;
            this.checkBox1.Text = "Не оплаченные";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(526, 217);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(104, 17);
            this.checkBox2.TabIndex = 23;
            this.checkBox2.Text = "Не оплаченные";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // lendTableAdapter
            // 
            this.lendTableAdapter.ClearBeforeFill = true;
            // 
            // borrowTableAdapter
            // 
            this.borrowTableAdapter.ClearBeforeFill = true;
            // 
            // Dolg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Dolg";
            this.Text = "Долги";
            this.Load += new System.EventHandler(this.Dolg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lendBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private MoneyDataSet moneyDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MoneyDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource lendBindingSource;
        private MoneyDataSetTableAdapters.LendTableAdapter lendTableAdapter;
        private System.Windows.Forms.BindingSource borrowBindingSource;
        private MoneyDataSetTableAdapters.BorrowTableAdapter borrowTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn komyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReturnDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOplachenDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn1;
    }
}