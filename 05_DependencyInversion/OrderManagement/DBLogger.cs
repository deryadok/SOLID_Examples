using Microsoft.Data.SqlClient;

namespace _05_DependencyInversion.OrderManagement
{
    internal class DBLogger
    {
        public void Log(string message)
        {
            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand("Insert", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
