using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dohod : Form
    {
        private void Dohod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.DohodTypes". При необходимости она может быть перемещена или удалена.
            this.dohodTypesTableAdapter.Fill(this.moneyDataSet.DohodTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.Dohod". При необходимости она может быть перемещена или удалена.
            this.dohodTableAdapter.Fill(this.moneyDataSet.Dohod);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.moneyDataSet.Users);
            find();

        }
        public Dohod()
        {
            InitializeComponent();
        }
        //add
        private void button1_Click(object sender, EventArgs e)
        {
            new DohodOperation(dohodTableAdapter, dohodBindingSource, moneyDataSet, null).Show();
        }

        //update
        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0 && dataGridView1.CurrentRow != null)
                new DohodOperation(dohodTableAdapter, dohodBindingSource, moneyDataSet, dataGridView1.CurrentRow).Show();
        }
        //remove
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0 && dataGridView1.SelectedCells.Count > 0)
                    if ((DialogResult = MessageBox.Show("Удалить выбранное?", "Удаление", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                    {
                        dohodBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                        dohodTableAdapter.Update(moneyDataSet.Dohod);
                    }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }

        private void domainUpDown1_TextChanged(object sender, EventArgs e)
        {
            find();
        }
        private void find() {
            try
            {
                DateTime date = new DateTime(int.Parse(domainUpDown2.Text), int.Parse(domainUpDown1.Text), 1);
                this.dohodTableAdapter.FillBy(this.moneyDataSet.Dohod, date.AddDays(-1), date.AddMonths(1), int.Parse(comboBox1.SelectedValue.ToString()));

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int index1 = dohodTypesBindingSource.Find("id", dataGridView1[2, i].Value.ToString());
                    dataGridView1[6, i].Value = ((DataRowView)(dohodTypesBindingSource[index1]))[1];
                }
            }
            catch (Exception ex) { }
        }

        public Main Main
        {
            get => default(Main);
            set
            {
            }
        }
    }
}
