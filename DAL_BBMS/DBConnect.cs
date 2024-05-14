using System.Data.SqlClient;

namespace DAL_BBMS
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection("Data Source=PHOENIX_PC;Initial Catalog=BBMS;Integrated Security=True");
    }
}
