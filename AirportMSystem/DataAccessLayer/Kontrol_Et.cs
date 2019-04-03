using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace DataAccessLayer
{
    public class Kontrol_Et
    {
        static SQLiteConnection conn = new SQLiteConnection(@"Data Source=C:\Users\portr\Source\Repos\AndylLow\AirPortManagementSystem\AirportMSystem\DataAccessLayer\AirPortManagementSystem.db;");
        static SQLiteCommand cmd = new SQLiteCommand(conn);
        public static bool checkUser(string email,string password)
        {
            bool result = false;
            try
            {
                conn.Open();
                
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
    }
}
