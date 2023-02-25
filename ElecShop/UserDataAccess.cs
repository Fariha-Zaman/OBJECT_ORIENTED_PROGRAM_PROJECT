
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElecShop.DataAccess

{ 
  
        public class Userdataaccess
        {
            DataAccess da;

            public Userdataaccess()
            {
             da = new DataAccess();
            }

        
          public UserLogin GetthatUser(string Name)
          {
              string sql = "SELECT * FROM Users where Name='" + Name + "'";
              SqlDataReader reader = da.GetData(sql);
              UserLogin p = new UserLogin();
              while (reader.Read())
              {
                  p.UserId = (int)reader["Userid"];
                  p.Name = reader["Name"].ToString();
                  p.Password = reader["Password"].ToString();
                  p.UserType = reader["UserType"].ToString();

              }
              return p;

          }
        public List<UserLogin> GetAllUsers()
        {
            string sql = "SELECT * FROM Users";
            SqlDataReader reader = da.GetData(sql);
            List<UserLogin> list = new List<UserLogin>();
            while (reader.Read())
            {
                UserLogin p = new UserLogin();
 
                p.Name = reader["Name"].ToString();
                p.Password = reader["Password"].ToString();
                p.UserType = reader["UserType"].ToString();

                list.Add(p);

            }


            return list;

        }
        public int AddUser(UserLogin p)
            {
                string sql = "INSERT INTO Users (Name,Password,UserType) VALUES('" +p.Name+ "','" +p.Password+ "','" +p.UserType+ "')";

                return da.ExecuteQuery(sql);
            }
            

           
        }
    }



