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

            if (id < 1) loadData();
        }

        private void loadData() {
            command = "SELECT * FROM [Plan] WHERE id="+id;
            Dictionary<int,string> dic =  Main.DataBase.getDictionary(command,7);
            comboBox1.SelectedValue = dic[1];
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
