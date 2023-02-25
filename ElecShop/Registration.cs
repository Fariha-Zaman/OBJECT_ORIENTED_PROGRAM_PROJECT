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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {

            UserLogin ul = new UserLogin();
            Userdataaccess pd = new Userdataaccess();
            ul.Name = NameTb.Text;
            ul.Password = PasswordTb.Text;
            ul.UserType = UserTypeTb.Text;
            pd.AddUser(ul);
            dataGridView1.DataSource = pd.GetAllUsers();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OptionView LF = new OptionView();
            LF.Visible = true;
            this.Visible = false;
        }
    }
}
