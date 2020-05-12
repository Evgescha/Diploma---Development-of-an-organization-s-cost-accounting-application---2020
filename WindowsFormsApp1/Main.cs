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
        private static BD dataBase = new BD();
        public static Money money = new Money();
        public static Plans plans = new Plans();
        public static Users users = new Users();
        public static Help help = new Help();
        public static Reports report = new Reports();

        internal static BD DataBase { get => dataBase; set => dataBase = value; }

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            money = new Money();
            money.Show();
        }

        private void btnPlans_Click(object sender, EventArgs e)
        {
            plans = new Plans();
            plans.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            users = new Users();
            users.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            help = new Help();
            help.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            report = new Reports();
            report.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Dohod().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Dolg().Show();
        }
    }
}
