using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace CProject.Database
{
    public class DBService
    {
        
        public static SqlConnection ConnectDb()
        {
            string ConString = ConfigurationManager.ConnectionStrings["HMSConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(ConString);
            return con;
        }
    }
}
