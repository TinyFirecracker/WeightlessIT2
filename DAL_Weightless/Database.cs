using System.Data.SqlClient;

namespace DAL_Weightless
{
    public class Database
    {
        //Yannick helped me with my Database :)
        private SqlConnection con = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi480277;User Id=dbi480277;Password=Ixs5v(GQ6q; ");

        public SqlConnection Connection()
        {
            return con;
        }
        public bool Open()
        {
            bool succes;
            try
            {
                con.Open();
                succes = true;
            }
            catch
            {
                succes = false;
            }
            return succes;
        }
        public bool Close()
        {
            bool succes;
            try
            {
                con.Close();
                succes = true;
            }
            catch
            {
                succes = false;
            }
            return succes;
        }


    }
}
