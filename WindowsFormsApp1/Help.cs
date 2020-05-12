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
    public partial class Help : Form
    {
        public Help()
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

        public Main Main1
        {
            get => default(Main);
            set
            {
            }
        }

        private void Help_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.DohodTypes". При необходимости она может быть перемещена или удалена.
            this.dohodTypesTableAdapter.Fill(this.moneyDataSet.DohodTypes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.SubCategory". При необходимости она может быть перемещена или удалена.
            this.subCategoryTableAdapter.Fill(this.moneyDataSet.SubCategory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "moneyDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.moneyDataSet.Category);

        }
        // обновить 2 таблицу
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.subCategoryTableAdapter.Update(this.moneyDataSet);
            }
            catch (Exception ex) { MessageBox.Show("Вы не сохранили категорию"); }
        }
        //удалить в 2 таблице
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.categorySubCategoryBindingSource.RemoveCurrent();
            }
            catch (Exception ex) { MessageBox.Show("Нечего удалять"); }
        }
        //удалить в первой таблице
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryBindingSource.RemoveCurrent();
        }
            catch (Exception ex) { MessageBox.Show("Нечего удалять"); }
}
        //сохранить в первой таблице
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoryTableAdapter.Update(this.moneyDataSet);
            this.categoryTableAdapter.Fill(this.moneyDataSet.Category);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка сохранения категории. Проверьте данные"); }
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e)
        {
            dohodTypesTableAdapter.Update(this.moneyDataSet);
        }
    }
}
