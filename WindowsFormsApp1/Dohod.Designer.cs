namespace WindowsFormsApp1
{
    partial class Dohod
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
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dohodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.usersTableAdapter = new WindowsFormsApp1.MoneyDataSetTableAdapters.UsersTableAdapter();
            this.dohodTableAdapter = new WindowsFormsApp1.MoneyDataSetTableAdapters.DohodTableAdapter();
            this.dohodTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dohodTypesTableAdapter = new WindowsFormsApp1.MoneyDataSetTableAdapters.DohodTypesTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dohodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dohodTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usersBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.TextChanged += new System.EventHandler(this.domainUpDown1_TextChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Пользователь: ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(179, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column1});
            this.dataGridView1.DataSource = this.dohodBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(775, 365);
            this.dataGridView1.TabIndex = 21;
            // 
            // dohodBindingSource
            // 
            this.dohodBindingSource.DataMember = "Dohod";
            this.dohodBindingSource.DataSource = this.moneyDataSet;
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Items.Add("2020");
            this.domainUpDown2.Items.Add("2021");
            this.domainUpDown2.Items.Add("2022");
            this.domainUpDown2.Items.Add("2023");
            this.domainUpDown2.Items.Add("2024");
            this.domainUpDown2.Items.Add("2025");
            this.domainUpDown2.Items.Add("2026");
            this.domainUpDown2.Items.Add("2027");
            this.domainUpDown2.Items.Add("2028");
            this.domainUpDown2.Items.Add("2029");
            this.domainUpDown2.Items.Add("2030");
            this.domainUpDown2.Location = new System.Drawing.Point(411, 50);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.ReadOnly = true;
            this.domainUpDown2.Size = new System.Drawing.Size(76, 20);
            this.domainUpDown2.TabIndex = 20;
            this.domainUpDown2.Text = "2020";
            this.domainUpDown2.TextChanged += new System.EventHandler(this.domainUpDown1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Год";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("12");
            this.domainUpDown1.Items.Add("11");
            this.domainUpDown1.Items.Add("10");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Location = new System.Drawing.Point(292, 49);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.ReadOnly = true;
            this.domainUpDown1.Size = new System.Drawing.Size(55, 20);
            this.domainUpDown1.TabIndex = 18;
            this.domainUpDown1.Text = "1";
            this.domainUpDown1.TextChanged += new System.EventHandler(this.domainUpDown1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "| Месяц: ";
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // dohodTableAdapter
            // 
            this.dohodTableAdapter.ClearBeforeFill = true;
            // 
            // dohodTypesBindingSource
            // 
            this.dohodTypesBindingSource.DataMember = "DohodTypes";
            this.dohodTypesBindingSource.DataSource = this.moneyDataSet;
            // 
            // dohodTypesTableAdapter
            // 
            this.dohodTypesTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "userId";
            this.dataGridViewTextBoxColumn2.HeaderText = "userId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 61;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "typesId";
            this.dataGridViewTextBoxColumn3.HeaderText = "typesId";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 66;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "count";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 91;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dates";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 58;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "comment";
            this.dataGridViewTextBoxColumn6.HeaderText = "Комментарий";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 102;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Откуда";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 68;
            // 
            // Dohod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 458);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.label2);
            this.Name = "Dohod";
            this.Text = "Доходы";
            this.Load += new System.EventHandler(this.Dohod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dohodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dohodTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label2;
        private MoneyDataSet moneyDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private MoneyDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dohodBindingSource;
        private MoneyDataSetTableAdapters.DohodTableAdapter dohodTableAdapter;
        private System.Windows.Forms.BindingSource dohodTypesBindingSource;
        private MoneyDataSetTableAdapters.DohodTypesTableAdapter dohodTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}