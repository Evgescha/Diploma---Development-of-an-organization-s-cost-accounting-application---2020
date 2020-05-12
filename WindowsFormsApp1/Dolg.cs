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
    public partial class Dolg : Form
    {
        public Dolg()
        {
            InitializeComponent();
        }

        public Main Main
        {
            get => default(Main);
            set
            {
            }
        }

        private void Dolg_Load(object sender, EventArgs e)
        {
           this.usersTableAdapter.Fill(this.moneyDataSet.Users);
           this.borrowTableAdapter.Fill(this.moneyDataSet.Borrow);
           this.lendTableAdapter.Fill(this.moneyDataSet.Lend);

            find();
        }
        //add lend

        private void button1_Click(object sender, EventArgs e)
        {
            new Lend(lendTableAdapter, lendBindingSource, moneyDataSet, null).Show();
        }
        //update lend
        private void button2_Click(object sender, EventArgs e)
        {
            //dataGridView1.BeginEdit(true);
            if(dataGridView1.RowCount>0 && dataGridView1.CurrentRow!=null)
            new Lend(lendTableAdapter, lendBindingSource, moneyDataSet, dataGridView1.CurrentRow).Show();
            
        }
        //delete lend
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.RowCount > 0 && dataGridView1.SelectedCells.Count > 0)
                    if ((DialogResult = MessageBox.Show("Удалить выбранное?", "Удаление", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                    {
                        lendBindingSource.RemoveAt(dataGridView1.CurrentRow.Index);
                        lendTableAdapter.Update(moneyDataSet.Lend);
                    }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }
        //add borrow
        private void button6_Click(object sender, EventArgs e)
        {
            new Borrow(borrowTableAdapter, borrowBindingSource,null, moneyDataSet).Show();
        }
        //update borrow
        private void button5_Click(object sender, EventArgs e)
        {
            //dataGridView2.BeginEdit(true);
            if (dataGridView2.RowCount > 0 && dataGridView2.CurrentRow != null)
                new Borrow(borrowTableAdapter, borrowBindingSource, dataGridView2.CurrentRow, moneyDataSet).Show();

        }
        //delete borrow
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.RowCount > 0 && dataGridView2.SelectedCells.Count > 0)
                    if ((DialogResult = MessageBox.Show("Удалить выбранное?", "Удаление", MessageBoxButtons.YesNo)) == DialogResult.Yes)
                    {
                        borrowBindingSource.RemoveAt(dataGridView2.CurrentRow.Index);
                        borrowTableAdapter.Update(moneyDataSet.Borrow);
                    }
            }
            catch (Exception ex) { MessageBox.Show("Ошибка. Возможно вы пытаетесь удалить используемый объект"); }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            find();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            find();
        }
        private void find() {
            try
            {
                lendTableAdapter.FillByUserIdAndIsReturn(moneyDataSet.Lend, (int)comboBox1.SelectedValue,!checkBox1.Checked);
                borrowTableAdapter.FillByUserIdAndIsOplachen(moneyDataSet.Borrow, (int)comboBox1.SelectedValue, !checkBox2.Checked);
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    int index1 = usersBindingSource.Find("id", dataGridView1[1, i].Value.ToString());
                    dataGridView1[2, i].Value = ((DataRowView)(usersBindingSource[index1]))[1];
                }
                for (int i = 0; i < dataGridView2.RowCount; i++)
                {
                    int index1 = usersBindingSource.Find("id", dataGridView2[1, i].Value.ToString());
                    dataGridView2[2, i].Value = ((DataRowView)(usersBindingSource[index1]))[1];
                }
            }
            catch (Exception ex) { }
        }
    }
}
