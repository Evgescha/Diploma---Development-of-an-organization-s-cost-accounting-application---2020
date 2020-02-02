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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.moneyDataSet.Users);
            loadData();
        }
        public void loadData()
        {
            try
            {
                string showUsers;
                if (checkBox1.Checked)
                    showUsers = "";
                else
                    showUsers = $" AND User= {comboBox1.SelectedValue.ToString()}";
                //showUsers = $" AND User= {Main.DataBase.ReturnString($"SELECT * FROM Users WHERE name=\"{comboBox1.Text}\"")} ";
                string command = $"SELECT Money.id as [№], Category.name as [Категория], SubCategory.name as [Подкатегория], Users.name as [Пользователь], Money.DateTime as [Дата], Money.Cost as [Стоимость], Money.Comment as [Комментарий] FROM Users INNER JOIN((Category INNER JOIN [Money] ON Category.Id = Money.Category) INNER JOIN SubCategory ON(SubCategory.id = Money.SubCategory) AND(Category.Id = SubCategory.categoryId)) ON Users.id = Money.User WHERE(([Category].[Id] =[Money].[Category]) AND([SubCategory].[id] =[Money].[SubCategory]) AND([Users].[id] =[Money].[User]) AND (YEAR(DateTime)={domainUpDown2.Text} AND MONTH(DateTime)={domainUpDown1.Text} {showUsers}) );";
                Main.DataBase.SelectGridPlus(command, dataGridView1);
            }
            catch (Exception ex) { }
        }
        // кнопка добавить
        private void button1_Click(object sender, EventArgs e)
        {
            new PlanOperation(-1).Show();
        }
        //кнопка изменить
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

                new PlanOperation(int.Parse(id)).Show();
            }
            catch (Exception ex) { MessageBox.Show("Нечего редактировать"); };
        }
        //кнопка удалить
        private void button3_Click(object sender, EventArgs e)
        {
            // если нажали ок
            if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // смотрим какой телефон удалить
                int id = int.Parse(dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value.ToString());
                // команду удалить
                string command = "DELETE FROM [Money] WHERE id = " + id;
                // выполнить удаление
                Main.DataBase.SqlCommand(command);
                loadData();
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
