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
    public partial class Reports : Form
    {
        int currentMonth = DateTime.Now.Month;
        string command;
        string report;
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.moneyDataSet.Users);
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MM/dd/yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: report0(DateTime.Now.Month,DateTime.Now.Year, "Расходы за текущий месяц"); break;
                case 1: report0(DateTime.Now.Month-1, DateTime.Now.Year, "Расходы за прошлый месяц"); break;
                case 2: report0(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, "Расходы за указанный месяц"); break;
                case 3: report3(); break;
                case 4: report4(); break;
            }
        }
        //Расходы за текущий месяц
        //Расходы за прошлый месяц
        //Расходы за указанный месяц
        private void report0(int monthInt,int year, string typeRep)
        {
            //MessageBox.Show($"Месяц {monthInt}, Год {year}");
            string month = "MONTH(DateTime)=",
                user = "";
            
            if (monthInt == 0) {
                monthInt = 12; year -= 1;
            }
            month += monthInt+" AND YEAR(DateTime)=" + year;
            report = "<===== Отчет ====>\r\n" +
                    $"Тип отчета: {typeRep}\r\n";
            Dictionary<string, float> dict = new Dictionary<string, float>();

            if (!checkBox1.Checked)
            {
                user += " AND User=" + comboBox2.SelectedValue;
            }
            else
                report += "По всем пользователям\r\n";

            command = $"SELECT Money.id as [№], Category.name as [Категория], SubCategory.name as [Подкатегория], Users.name as [Пользователь], Money.DateTime as [Дата], Money.Cost as [Стоимость], Money.Comment as [Комментарий] FROM Users INNER JOIN((Category INNER JOIN [Money] ON Category.Id = Money.Category) INNER JOIN SubCategory ON(SubCategory.id = Money.SubCategory) AND(Category.Id = SubCategory.categoryId)) ON Users.id = Money.User WHERE(([Category].[Id] =[Money].[Category]) AND([SubCategory].[id] =[Money].[SubCategory]) AND([Users].[id] =[Money].[User]) AND ({month}  {user}) );";
            Main.DataBase.SelectGridPlus(command, dataGridView1);
            string categ;
            float sum, all = 0;

            try
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    categ = dataGridView1[1, i].Value.ToString();
                    sum = float.Parse(dataGridView1[5, i].Value.ToString());
                    if (dict.ContainsKey(categ)) dict[categ] = dict[categ] + sum;
                    else
                        dict.Add(categ, sum);
                }

                report += $"Отчет за {currentMonth} {DateTime.Now.Year}\r\n" +
                    $"Дата/время создания отчета: {DateTime.Now}\r\n\r\n";
                foreach (string cat in dict.Keys)
                {
                    report += $"{cat}: {dict[cat]}\r\n";
                    all += dict[cat];
                }
                report += "\r\nИТОГО: " + all;
                textBox1.Text = report;
            }
            catch (Exception ex) { }
        }
       
        //Расходы за интервал времени
        private void report3()
        {
            string month = "", user = "";
            month = $" (DateTime BETWEEN #{dateTimePicker1.Text}# AND #{dateTimePicker2.Text}#) ";

            report = "<===== Отчет ====>\r\n" +
                    "Тип отчета: Расходы за интервал времени\r\n";
            Dictionary<string, float> dict = new Dictionary<string, float>();

            if (!checkBox1.Checked)
            {
                user += " AND User=" + comboBox2.SelectedValue;
            }
            else
                report += "По всем пользователям\r\n";

            command = $"SELECT Money.id as [№], Category.name as [Категория], SubCategory.name as [Подкатегория], Users.name as [Пользователь], Money.DateTime as [Дата], Money.Cost as [Стоимость], Money.Comment as [Комментарий] FROM Users INNER JOIN((Category INNER JOIN [Money] ON Category.Id = Money.Category) INNER JOIN SubCategory ON(SubCategory.id = Money.SubCategory) AND(Category.Id = SubCategory.categoryId)) ON Users.id = Money.User WHERE(([Category].[Id] =[Money].[Category]) AND([SubCategory].[id] =[Money].[SubCategory]) AND([Users].[id] =[Money].[User]) AND ({month}  {user}) );";
            Console.WriteLine(command);
            Main.DataBase.SelectGridPlus(command, dataGridView1);
            string categ;
            float sum, all = 0;

            try
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    categ = dataGridView1[1, i].Value.ToString();
                    sum = float.Parse(dataGridView1[5, i].Value.ToString());
                    if (dict.ContainsKey(categ)) dict[categ] = dict[categ] + sum;
                    else
                        dict.Add(categ, sum);
                }

                report += $"Отчет за {currentMonth} {DateTime.Now.Year}\r\n" +
                    $"Дата/время создания отчета: {DateTime.Now}\r\n\r\n";
                foreach (string cat in dict.Keys)
                {
                    report += $"{cat}: {dict[cat]}\r\n";
                    all += dict[cat];
                }
                report += "\r\nИТОГО: " + all;
                textBox1.Text = report;
            }
            catch (Exception ex) { }
        }
        //Кто сколько потратил за интервал
        private void report4()
        {
            string month = "", user = "";
            month = $" (DateTime BETWEEN #{dateTimePicker1.Text}# AND #{dateTimePicker2.Text}#) ";

            report = "<===== Отчет ====>\r\n" +
                    "Тип отчета: Кто сколько потратил за интервал\r\n";
            Dictionary<string, float> dict = new Dictionary<string, float>();

            if (!checkBox1.Checked)
            {
                user += " AND User=" + comboBox2.SelectedValue;
            }
            else
                report += "По всем пользователям\r\n";

            command = $"SELECT Money.id as [№], Category.name as [Категория], SubCategory.name as [Подкатегория], Users.name as [Пользователь], Money.DateTime as [Дата], Money.Cost as [Стоимость], Money.Comment as [Комментарий] FROM Users INNER JOIN((Category INNER JOIN [Money] ON Category.Id = Money.Category) INNER JOIN SubCategory ON(SubCategory.id = Money.SubCategory) AND(Category.Id = SubCategory.categoryId)) ON Users.id = Money.User WHERE(([Category].[Id] =[Money].[Category]) AND([SubCategory].[id] =[Money].[SubCategory]) AND([Users].[id] =[Money].[User]) AND ({month}  {user}) );";
            Console.WriteLine(command);
            Main.DataBase.SelectGridPlus(command, dataGridView1);
            string categ;
            float sum, all = 0;

            try
            {
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                {
                    categ = dataGridView1[3, i].Value.ToString();
                    sum = float.Parse(dataGridView1[5, i].Value.ToString());
                    if (dict.ContainsKey(categ)) dict[categ] = dict[categ] + sum;
                    else
                        dict.Add(categ, sum);
                }

                report += $"Отчет за {currentMonth} {DateTime.Now.Year}\r\n" +
                    $"Дата/время создания отчета: {DateTime.Now}\r\n\r\n";
                foreach (string cat in dict.Keys)
                {
                    report += $"{cat}: {dict[cat]}\r\n";
                    all += dict[cat];
                }
                report += "\r\nИТОГО: " + all;
                textBox1.Text = report;
            }
            catch (Exception ex) { }
        }
    }
}
