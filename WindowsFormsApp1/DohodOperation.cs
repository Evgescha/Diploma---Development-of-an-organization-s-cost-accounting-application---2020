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
    public partial class DohodOperation : Form
    {
        private DohodTableAdapter dohodTableAdapter;
        private BindingSource dohodBindingSource;
        private MoneyDataSet moneyDataSet;
        private DataGridViewRow row;
        bool isNew = true;


        public DohodOperation(DohodTableAdapter dohodTableAdapter, BindingSource dohodBindingSource, MoneyDataSet moneyDataSet, DataGridViewRow currentRow)
        {
            InitializeComponent();
            this.dohodTableAdapter = dohodTableAdapter;
            this.dohodBindingSource = dohodBindingSource;
            this.moneyDataSet = moneyDataSet;
            this.row = currentRow;
            isNew = row == null;
        }

        public Dohod Dohod
        {
            get => default(Dohod);
            set
            {
            }
        }

        private void DohodOperation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet1.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.moneyDataSet1.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet1.DohodTypes". При необходимости она может быть перемещена или удалена.
            this.dohodTypesTableAdapter.Fill(this.moneyDataSet1.DohodTypes);
            if (!isNew)
            {
                comboBox3.SelectedValue = int.Parse(row.Cells[1].Value.ToString());
                comboBox1.SelectedValue = int.Parse(row.Cells[2].Value.ToString());
                textBox1.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = row.Cells[4].Value.ToString();
                textBox2.Text = row.Cells[5].Value.ToString();
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
            DataRowView row = (DataRowView)dohodBindingSource.AddNew();


           
            row[1] = comboBox3.SelectedValue;
            row[2] = comboBox1.SelectedValue;
            row[3] = textBox1.Text;
            row[4] = dateTimePicker1.Value;
            row[5] = textBox2.Text;


            dohodBindingSource.EndEdit();
            this.dohodTableAdapter.Update(moneyDataSet);
            MessageBox.Show("Сохранено");
            this.Close();
        }
        private void update()
        {
            row.Cells[1].Value = comboBox3.SelectedValue;
            row.Cells[2].Value = comboBox1.SelectedValue;
            row.Cells[3].Value = textBox1.Text;
            row.Cells[4].Value = dateTimePicker1.Value;
            row.Cells[5].Value = textBox2.Text;

            dohodBindingSource.EndEdit();

            this.dohodTableAdapter.Update(((DataRowView)row.DataBoundItem).Row);
            MessageBox.Show("Сохранено");
            this.Close();
        }
    }
}
