using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElecShop
{
    public partial class OptionView : Form
    {
        UserLogin user = new UserLogin();

        public OptionView()
        { InitializeComponent(); }
       


        


        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            
            AddMember AE = new AddMember();
            AE.Visible = true;
            this.Visible = false;

           

        }

       

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            CRUD CD = new CRUD();

            CD.Visible = true;
            this.Visible = false;

        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
           

            ViewProducts VP = new ViewProducts();
            
           // VP.ShowDialog();
            VP.Visible = true;
            this.Visible = false;
            


        }

        private void OptionView_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration PV = new Registration();

            PV.Visible = true;
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMember PV = new AddMember();

            PV.Visible = true;
            this.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProductCarts PV = new ProductCarts();

            PV.Visible = true;
            this.Visible = false;
        }
    }
}
