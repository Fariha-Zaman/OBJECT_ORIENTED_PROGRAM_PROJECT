using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//using System.Data;
using ElecShop.DataAccess;


namespace ElecShop
{
    public partial class ViewProducts : Form
    {
        


        public ViewProducts()
        {
            InitializeComponent();
            ProductList ul = new ProductList();
            ProductDataAccess pd = new ProductDataAccess();

            dgvProductView.DataSource = pd.GetAllProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductDataAccess PDA = new ProductDataAccess();
            dgvProductView.DataSource = PDA.SearchProduct(txtSearch.Text);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ProductList ul = new ProductList();
            ProductDataAccess pd = new ProductDataAccess(); 
            
            dgvProductView.DataSource = pd.GetAllProducts();

            //this.Dispose();
        }
        

        private void ViewProducts_Load(object sender, EventArgs e)
        {

        }

        private void dgvProductView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnBuyProducts_Click(object sender, EventArgs e)
        {
            ProductCarts PC = new ProductCarts();

            PC.Visible = true;
            this.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginForm LF = new LoginForm();
            LF.Visible = true;
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            OptionView O = new OptionView();
            O.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OptionView LF = new OptionView();
            LF.Visible = true;
            this.Visible = false;
        }
    }
}
