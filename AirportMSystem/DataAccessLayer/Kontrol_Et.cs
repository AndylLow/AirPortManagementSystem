using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace DataAccessLayer
{
    public static class Kontrol_Et
    {
        
        public static bool checkUser(string email,string password)
        {
            bool result = false;
            try
            {

                SQLiteConnection conn;
                conn=new SQLiteConnection(@"Data Source=C:\Users\portr\Source\Repos\AndylLow\AirPortManagementSystem\AirportMSystem\DataAccessLayer\AirPortManagementSystem.db;");
                
                SQLiteCommand cmd = new SQLiteCommand(conn);
                conn.Open();
                cmd.CommandText=string.Format("Select * from Users where email='{0}' and password='{1}'",email,password);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0) result = true;
                conn.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("check user error "+ ex.Source+" "+ ex.StackTrace);
            }
            return result;
        }
    }
}
