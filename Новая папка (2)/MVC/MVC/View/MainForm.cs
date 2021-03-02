using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MVC.Controller;

namespace MVC.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            dataGridView1.DataSource = MainController.GetItems();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var form = new ItemForm();
            form.ShowDialog();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MainController.GetItems();


        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            var rowIndex = dataGridView1.SelectedRows[0].Index;

            var items = MainController.GetItems();
            var item = items[rowIndex];

            MainController.DeleteItem(item);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = MainController.GetItems();
        }
    }
}
