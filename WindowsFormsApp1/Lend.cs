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
    public partial class Lend : Form
    {
        private LendTableAdapter lendTableAdapter;
        private BindingSource lendBindingSource;
        private MoneyDataSet moneyDataSet;
        private DataGridViewRow row;
        bool isNew = false;

        public Lend(LendTableAdapter lendTableAdapter, BindingSource lendBindingSource, MoneyDataSet moneyDataSet, DataGridViewRow row)
        {
            InitializeComponent();
            this.lendTableAdapter = lendTableAdapter;
            this.lendBindingSource = lendBindingSource;
            this.moneyDataSet = moneyDataSet;
            this.row = row;
            usersBindingSource.DataSource = moneyDataSet;
            
        }

        public Dolg Dolg
        {
            get => default(Dolg);
            set
            {
            }
        }

        private void Lend_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.moneyDataSet1.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.moneyDataSet1.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet1.Users". При необходимости она может быть перемещена или удалена.
            //this.usersTableAdapter.Fill(this.moneyDataSet1.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.moneyDataSet.Users);
            if (row == null) isNew = true;
            else {
                comboBox1.SelectedValue = int.Parse(row.Cells[1].Value.ToString());
                textBox1.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();
                checkBox1.Checked = bool.Parse(row.Cells[5].Value.ToString());
                textBox2.Text = row.Cells[6].Value.ToString();
                textBox3.Text = row.Cells[7].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            if(textBox1.Text.Length>0)
            if (isNew) insert(); else update();
            }
            catch (Exception ex) { }
        }
        private void insert()
        {
            DataRowView row = (DataRowView)lendBindingSource.AddNew();

            row[1] = comboBox1.SelectedValue;
            row[2] = textBox1.Text;
            row[3] = dateTimePicker1.Value;
            row[4] = checkBox1.Checked;
            row[5] = textBox2.Text;
            row[6] = textBox3.Text;

            lendBindingSource.EndEdit();
            this.lendTableAdapter.Update(moneyDataSet);
            MessageBox.Show("Сохранено");

            this.Close();
        }
        private void update()
        {
            
            row.Cells[1].Value = comboBox1.SelectedValue;
            row.Cells[2].Value = comboBox1.Text;
            row.Cells[3].Value = textBox1.Text;
            row.Cells[4].Value = dateTimePicker1.Value;
            row.Cells[5].Value = checkBox1.Checked;
            row.Cells[6].Value = textBox2.Text;
            row.Cells[7].Value = textBox3.Text;
            lendBindingSource.EndEdit();

            this.lendTableAdapter.Update(((DataRowView)row.DataBoundItem).Row);
            this.lendTableAdapter.Update(moneyDataSet);
            MessageBox.Show("Сохранено");
            this.Close();
        }
    }
}
