using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        //protected SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Trungtamtinhoc.mdf;Integrated Security=True");
        protected SqlConnection conn = new SqlConnection("initial catalog = TTTH; data source = PhuHoang; integrated security = true");
    }
}
