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
    public partial class Plans : Form
    {
        string command;
        public Plans()
        {
            InitializeComponent();
        }

        private void Plans_Load(object sender, EventArgs e)
        {
            loadData();
        }
        // добавить
        private void button2_Click(object sender, EventArgs e)
        {
            new PlansOperation(-1).Show();
        }
        //изменить
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();

                new PlansOperation(int.Parse(id)).Show();
            }
            catch (Exception ex) { MessageBox.Show("Нечего редактировать"); };
        }

        //удалить
        private void button4_Click(object sender, EventArgs e)
        {
            // если нажали ок
            if (MessageBox.Show("Действительно удалить ?", "Подтвердите удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // смотрим какой телефон удалить
                int id = int.Parse(dataGridView1[0, dataGridView1.SelectedCells[0].RowIndex].Value.ToString());
                // команду удалить
                string command = "DELETE FROM [Plan] WHERE id = " + id;
                // выполнить удаление
                Main.DataBase.SqlCommand(command);
                loadData();
            }
        }
        public void loadData(){
            command = $"SELECT Plan.id as [№], Category.name as [Категория], Plan.Think as [Предполагалось], Plan.Pay as [Фактичски],  Plan.Rasn as [Разница], Plan.Comment as [Комментарий], Plan.DateTime as [Дата] FROM Category INNER JOIN Plan ON Category.Id = Plan.Categoty WHERE(([Plan].[Categoty] =[Category].[Id]) AND (YEAR(DateTime)={domainUpDown2.Text} AND MONTH(DateTime)={domainUpDown1.Text})  ); ";
            Main.DataBase.SelectGridPlus(command, dataGridView1);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
