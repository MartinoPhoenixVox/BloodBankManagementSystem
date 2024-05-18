using System.Data.SqlClient;

namespace DAL_BBMS
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=master;Integrated Security=True");
        protected SqlConnection _conn = new SqlConnection("Data Source=localhost;Initial Catalog=BBMS;Integrated Security=True");
    }
}
