using ElecShop.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElecShop
{
    public partial class ProductCarts : Form
    {
        public ProductCarts()
        {
            InitializeComponent();
            Employeedataaccess PC = new Employeedataaccess();

            dataGridView1.DataSource = PC.GetAllEmplyee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OptionView LF = new OptionView();
            LF.Visible = true;
            this.Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Employeedataaccess PC = new Employeedataaccess();

            dataGridView1.DataSource = PC.GetAllEmplyee();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
