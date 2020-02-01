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
            //this.moneyTableAdapter.Fill(this.moneyDataSet.Money);
            string command = "SELECT Money.id as [№], Category.name as [Категория], SubCategory.name as [Подкатегория], Users.name as [Пользователь], Money.DateTime as [Дата], Money.Cost as [Стоимость], Money.Comment as [Комментарий] FROM Users INNER JOIN((Category INNER JOIN [Money] ON Category.Id = Money.Category) INNER JOIN SubCategory ON(SubCategory.id = Money.SubCategory) AND(Category.Id = SubCategory.categoryId)) ON Users.id = Money.User WHERE(([Category].[Id] =[Money].[Category]) AND([SubCategory].[id] =[Money].[SubCategory]) AND([Users].[id] =[Money].[User]));";
            Main.DataBase.SelectGridPlus(command,dataGridView1);
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
