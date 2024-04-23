using Npgsql;

namespace WinFormsApp1
{
    internal class DB
    {
        NpgsqlConnection con = new NpgsqlConnection("Host=localhost;Port=5434;Username=espyz;Password=33215033q;Database=urfu_vaccination");

        public void openConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return con;
        }
    }
}
