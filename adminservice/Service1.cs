using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace adminservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        string connection = ConfigurationManager.ConnectionStrings["xyz"].ConnectionString;
        public List<string> LoginUserDetails(UserDetails userInfo)
        {

            List<string> user = new List<string>();
            
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            SqlCommand cmd = new SqlCommand("loginsert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@email", userInfo.Email);
            cmd.Parameters.AddWithValue("@password", userInfo.Password);         
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                user.Add(dr[0].ToString());               
            }
            con.Close();
            return user;
        }
       
        
    }
}
