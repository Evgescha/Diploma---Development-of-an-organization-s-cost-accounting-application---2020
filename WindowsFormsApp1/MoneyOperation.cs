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
    public partial class PlanOperation : Form
    {
        int id;
        // -1 значит добавить
        // остальные значить изменить
        public PlanOperation(int id)
        {
            InitializeComponent();
            this.id = id;
            
        }

        public Money Money
        {
            get => default(Money);
            set
            {
            }
        }

        public Plans Plans
        {
            get => default(Plans);
            set
            {
            }
        }

        private void MoneyOperation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.moneyDataSet.Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.moneyDataSet.Category);
            comboBox2.Items.Clear();
            Main.DataBase.LoadBox($"SELECT * FROM SubCategory WHERE categoryId in (Select id from Category Where Category.name=\"{comboBox1.Text}\")", "name", comboBox2);

            if (id > 0) loadData();

        }
        private void loadData() {
            Dictionary<int, string> dict = Main.DataBase.getDictionary($"Select * from [Money] Where id="+id,7);
            //MessageBox.Show(Main.DataBase.ReturnString($"SELECT name FROM Category WHERE id={dict[1]}"));

            comboBox1.Text  = Main.DataBase.ReturnString($"SELECT name FROM Category WHERE id={dict[1]}");
            comboBox2.Text = Main.DataBase.ReturnString($"SELECT name FROM SubCategory WHERE id={dict[2]}");
            comboBox3.Text = Main.DataBase.ReturnString($"SELECT name FROM Users WHERE id={dict[3]}");
            textBox1.Text = dict[5];
            dateTimePicker1.Text = dict[4];
            textBox2.Text = dict[6];
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            Main.DataBase.LoadBox($"SELECT * FROM SubCategory WHERE categoryId in (Select id from Category Where Category.name=\"{comboBox1.Text}\")", "name", comboBox2);
        }
        // кнопка хорошо
        private void button1_Click(object sender, EventArgs e)
        {
            //проверка на пустые значения
            if (comboBox1.Text.Length < 1) return;
            if (comboBox2.Text.Length < 1) return;
            if (comboBox2.Text.Length < 1) return;
            if (textBox1.Text.Length < 1) return;

            string command, category, subCategory, user;
            category = Main.DataBase.ReturnString($"SELECT id FROM Category WHERE name=\"{comboBox1.Text}\"");
            subCategory = Main.DataBase.ReturnString($"SELECT id FROM SubCategory WHERE name=\"{comboBox2.Text}\"");
            user = Main.DataBase.ReturnString($"SELECT * FROM Users WHERE name=\"{comboBox3.Text}\"");
            if (id == -1)
                command = $"INSERT INTO [Money] ( [Category], [SubCategory], [User], [DateTime], [Cost], [Comment] ) VALUES ({category},{subCategory},{user},\"{dateTimePicker1.Text}\", {textBox1.Text},\"{textBox2.Text}\")";
            else
                command = $"UPDATE [Money] SET [Category]={category}, [SubCategory]={subCategory}, [User]={user}, [DateTime]=\"{dateTimePicker1.Text}\", [Cost]={textBox1.Text}, [Comment]=\"{textBox2.Text}\" WHERE [id]={id}";
            //MessageBox.Show(command);
            Console.WriteLine(command);
            try
            {
                Main.DataBase.SqlCommand(command);
                Main.money.loadData();
            }
            catch (Exception ex) { }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && !((e.KeyChar == '.') &&
            (((TextBox)sender).Text.IndexOf(".") == -1) &&
            (((TextBox)sender).Text.Length != 0)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
