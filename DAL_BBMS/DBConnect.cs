using System.Data.SqlClient;

namespace DAL_BBMS
{
    internal class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=;Initial Catalog=BBMS;Integrated Security=True");
    }
}
