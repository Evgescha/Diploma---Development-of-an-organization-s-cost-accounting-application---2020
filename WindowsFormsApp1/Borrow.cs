using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.MoneyDataSetTableAdapters;

namespace WindowsFormsApp1
{
    public partial class Borrow : Form
    {
        private BorrowTableAdapter borrowTableAdapter;
        private BindingSource borrowBindingSource;
        private DataGridViewRow row;
        private MoneyDataSet moneyDataSet;
        bool isNew = false;
       

        public Borrow(BorrowTableAdapter borrowTableAdapter, BindingSource borrowBindingSource, DataGridViewRow row, MoneyDataSet moneyDataSet)
        {
            InitializeComponent();
            this.borrowTableAdapter = borrowTableAdapter;
            this.borrowBindingSource = borrowBindingSource;
            this.row = row;
            this.moneyDataSet = moneyDataSet;
            isNew = row == null;
        }

        public Dolg Dolg
        {
            get => default(Dolg);
            set
            {
            }
        }

        private void Borrow_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.moneyDataSet1.Users);
            if (!isNew) {
                comboBox1.SelectedValue = int.Parse(row.Cells[1].Value.ToString());
                textBox1.Text = row.Cells[5].Value.ToString();
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
                checkBox1.Checked = bool.Parse(row.Cells[4].Value.ToString());
                textBox2.Text = row.Cells[6].Value.ToString();
                textBox3.Text = row.Cells[7].Value.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length > 0)
                    if (isNew) insert(); else update();
            }
            catch (Exception ex) { }

        }
        private void insert()
        {
            DataRowView row = (DataRowView)borrowBindingSource.AddNew();

            row["userId"] = comboBox1.SelectedValue;
            row["kto"] = textBox1.Text;
            row["datePol"] = dateTimePicker1.Value;
            row["isOplachen"] = checkBox1.Checked;
            row["comment"] = textBox2.Text;
            row["count"] = textBox3.Text;

            borrowBindingSource.EndEdit();
            this.borrowTableAdapter.Update(moneyDataSet);
            MessageBox.Show("Сохранено");

            this.Close();
        }
        private void update()
        {

            row.Cells[1].Value = comboBox1.SelectedValue;
            row.Cells[2].Value = comboBox1.Text;
            row.Cells[5].Value = textBox1.Text;
            row.Cells[3].Value = dateTimePicker1.Value;
            row.Cells[4].Value = checkBox1.Checked;
            row.Cells[6].Value = textBox2.Text;
            row.Cells[7].Value = textBox3.Text;
            borrowBindingSource.EndEdit();

            this.borrowTableAdapter.Update(((DataRowView)row.DataBoundItem).Row);
            MessageBox.Show("Сохранено");
            this.Close();
        }
    }
}
