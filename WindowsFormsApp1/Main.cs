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
    public partial class Main : Form
    {
        Money money = new Money();
        Plans plans = new Plans();
        Users users = new Users();
        Help help = new Help();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            money.Show();
        }

        private void btnPlans_Click(object sender, EventArgs e)
        {
            plans.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            users.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help.Show();
        }
    }
}
