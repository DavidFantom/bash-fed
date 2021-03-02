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
using MVC.Model;

namespace MVC.View
{
    public partial class ItemForm : Form
    {
        public ItemForm()
        {
            InitializeComponent();

            comboBox1.DataSource = MainController.GetStatuses();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = new ToDoItem
            {
                Name = textBox1.Text,
                Description = textBox2.Text,
                Status = comboBox1.Text,
            };

            MainController.AddItem(item);
            this.Close();
        }
    }
}
