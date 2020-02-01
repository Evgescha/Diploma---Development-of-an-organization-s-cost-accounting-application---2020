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
    public partial class Money : Form
    {
        public Money()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Money_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.Money". При необходимости она может быть перемещена или удалена.
            this.moneyTableAdapter.Fill(this.moneyDataSet.Money);

        }
        // кнопка добавить
        private void button1_Click(object sender, EventArgs e)
        {
            new MoneyOperation(-1).Show();
        }
        //кнопка изменить
        private void button2_Click(object sender, EventArgs e)
        {
            string id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

            new MoneyOperation(int.Parse(id)).Show();
        }
        //кнопка удалить
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
