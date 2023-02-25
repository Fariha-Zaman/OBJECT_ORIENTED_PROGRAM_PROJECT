using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElecShop.DataAccess
{
    class ProductDataAccess
    {
      
            DataAccess da;

            public ProductDataAccess()
            {
                da = new DataAccess();
            }

        public List<ProductList> GetAllProducts()
        {
            string sql = "SELECT * FROM ProductsList";
            SqlDataReader reader = da.GetData(sql);
            List<ProductList> list = new List<ProductList>();
            while (reader.Read())
            {
                ProductList p = new ProductList();
                p.ProductId = reader["ProductId"].ToString();
                p.Name = reader["Name"].ToString();
                p.Price = reader["Price"].ToString();
                p.Company = reader["Company"].ToString();
                p.Details = reader["Details"].ToString();

                list.Add(p);

            }


            return list;

        }


        public List<ProductList> SearchProduct(String pda)
        {
            string sql = "SELECT * from ProductsList where Name Like '%"+pda+"%'";
            SqlDataReader reader = da.GetData(sql);
            List<ProductList> list = new List<ProductList>();
            while (reader.Read())
            {
                ProductList p = new ProductList();
                p.ProductId = reader["ProductId"].ToString();
                p.Name = reader["Name"].ToString();
                p.Price = reader["Price"].ToString();
                p.Company = reader["Company"].ToString();
                p.Details = reader["Details"].ToString();

                list.Add(p);


            }

            return list;
            
        }

        public int AddProduct(ProductList p)
        {
            string sql = "INSERT INTO ProductsList (ProductId,Name,Price,Company,Details) VALUES('" + p.ProductId + "','" + p.Name + "','" + p.Price + "','" + p.Company + "','"+p.Details+"')";

            return da.ExecuteQuery(sql);
        }
        public int DeleteProduct(int id)
        {
            string sql = "DELETE FROM ProductsList where ProductId=" +id;
            return da.ExecuteQuery(sql);
        }




    }
}





