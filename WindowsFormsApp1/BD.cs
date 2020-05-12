using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    // название класса для работы с бд
    class BD
    {
        // создаем в нем подключение
        OleDbConnection connection = new OleDbConnection();
        // конструктор по умолчанию
        public BD()
        {
            // при создании экземпляра класса сразу прописываем путь к бд
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Money.accdb;Persist Security Info = False; ";
        }

        public Main Main
        {
            get => default(Main);
            set
            {
            }
        }


        //вывести данные в грид, принимает команду и грид, в который все это выводить
        public void SelectGridPlus(string com, DataGridView dg)
        {
            try
            {
                connection.Open();
                OleDbCommand mes = new OleDbCommand();
                mes.Connection = connection;
                mes.CommandText = com;
                // резервируем место и создаем новый адаптер, в который считываются значения из таблицы в зависимости от команды
                OleDbDataAdapter da = new OleDbDataAdapter(mes.CommandText, connection);
                // создаем новую таблицу, в которую мы запишем все, что принял адаптер
                DataTable dt = new DataTable();
                // сейчас записываем это
                da.Fill(dt);
                // выводим данные из таблиц в грил
                dg.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAIL" + ex);
                connection.Close();
            }
        }
        // загрузить в выпадающие списки
        // принимаем команду, какой столбез загрузить и в какой комбобокс
        public void LoadBox(string com, string collums, ComboBox cb)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                // присваиваем команду нашему подключению
                command.CommandText = com;
                OleDbDataReader reader = command.ExecuteReader();
                // считываем базу              
                while (reader.Read())
                {
                    // добавляем в выпадающий список
                    cb.Items.Add(reader[collums].ToString());
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAIL" + ex);
                connection.Close();
            }
        }

    
        // запись данных в текстбоксы
        public void LoadTexbox(string com, string collums, TextBox tb)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = com;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tb.Text += reader[collums].ToString();
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAIL" + ex);
                connection.Close();
            }
        }
        // метод обновления, реализация как и добавления
        public void SqlCommand(string com)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = com;
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("All Good!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAIL" + ex);
                connection.Close();
            }
        }
        
        // загрузка нужных данных в комбобокс
        public string ReturnString(string com)
        {
            try
            {
                String temp;
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = com;
                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();
                temp = reader[0].ToString();
                reader.Close();
                connection.Close();
                return temp;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAIL" + ex);
                connection.Close();
                return "";
            }
        }

        //получить массив данных
        public Dictionary<int, string> getDictionary(string com, int collumnCount)
        {
            Dictionary<int, string> dict= new Dictionary<int, string>();
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = com;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0; i < collumnCount; i++) {
                    dict.Add(i, reader[i].ToString());

                    }
                    
                }
                reader.Close();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAIL" + ex);
                connection.Close();
            }
            return dict;
        }

    }
}