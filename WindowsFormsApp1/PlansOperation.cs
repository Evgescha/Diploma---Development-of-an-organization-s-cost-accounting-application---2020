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
    public partial class PlansOperation : Form
    {
        int id;
        string command;
        public PlansOperation(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void PlansOperation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.moneyDataSet.Category);

            if (id >0) loadData();
        }

        private void loadData() {
            command = "SELECT * FROM [Plan] WHERE id="+id;
            Dictionary<int,string> dict =  Main.DataBase.getDictionary(command,7);
            //comboBox1.SelectedValue = Main.DataBase.ReturnString($"SELECT name FROM [Category] WHERE id={dict[1]}");
            comboBox1.SelectedValue = dict[1];
            textBox1.Text = dict[2];
            textBox3.Text = dict[3];
            textBox2.Text = dict[5];
            dateTimePicker1.Text = dict[6];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1) return;
            if (textBox2.Text.Length < 1) return;
            int think = int.Parse(textBox1.Text);
            int pay = int.Parse(textBox3.Text);
            if (id < 1)
                command = $"INSERT INTO [Plan] ([Categoty], [Think],[Pay], [Rasn],[Comment], [DateTime]) VALUES({comboBox1.SelectedValue},{think},{pay},{think - pay},\"{textBox2.Text}\",\"{dateTimePicker1.Text}\") ";
            else command = $"UPDATE [Plan] SET [Categoty]={comboBox1.SelectedValue}, [Think]={think},[Pay]={pay}, [Rasn]={think - pay},[Comment]=\"{textBox2.Text}\", [DateTime]=\"{dateTimePicker1.Text}\" WHERE id={id}";
            Console.WriteLine(command);
            try
            {
                Main.DataBase.SqlCommand(command);
                Main.money.loadData();
                Main.plans.loadData();
            }
            catch (Exception ex) { }
        }
    }
}
