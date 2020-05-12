namespace WindowsFormsApp1
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMoney = new System.Windows.Forms.Button();
            this.btnPlans = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoney
            // 
            this.btnMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoney.Location = new System.Drawing.Point(50, 12);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(141, 39);
            this.btnMoney.TabIndex = 0;
            this.btnMoney.Text = "Расходы";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // btnPlans
            // 
            this.btnPlans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlans.Location = new System.Drawing.Point(50, 148);
            this.btnPlans.Name = "btnPlans";
            this.btnPlans.Size = new System.Drawing.Size(141, 39);
            this.btnPlans.TabIndex = 1;
            this.btnPlans.Text = "Планы";
            this.btnPlans.UseVisualStyleBackColor = true;
            this.btnPlans.Click += new System.EventHandler(this.btnPlans_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUsers.Location = new System.Drawing.Point(50, 193);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(141, 39);
            this.btnUsers.TabIndex = 2;
            this.btnUsers.Text = "Пользователи";
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.Location = new System.Drawing.Point(50, 238);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(141, 39);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Справочник";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnReports
            // 
            this.btnReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReports.Location = new System.Drawing.Point(50, 283);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(141, 39);
            this.btnReports.TabIndex = 4;
            this.btnReports.Text = "Отчеты";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(50, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Доходы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(50, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Долги";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 329);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnUsers);
            this.Controls.Add(this.btnPlans);
            this.Controls.Add(this.btnMoney);
            this.Name = "Main";
            this.Text = "Учёт расходов";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnPlans;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

