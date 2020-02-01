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
        public Plans()
        {
            InitializeComponent();
        }

        private void Plans_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.Plan". При необходимости она может быть перемещена или удалена.
            this.planTableAdapter.Fill(this.moneyDataSet.Plan);

        }
    }
}
