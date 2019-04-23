using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SQLite;
using ClassLibrary1;

namespace DAL4
{
    public class Kontrol_Et
    {

        /* Yapılacaklar ---
         * Class'lara özel data tabloları oluşturulup buradaki "Görüntüle" metodu ona göre düzenlenecek.
         * Ara yüz sorguları, eklemeler, güncellemeler eklenecek.*/


        static string executable;
        static string path;
        static string connectionString;
        static SQLiteConnection conn;
        static SQLiteCommand cmd;
        public static object görüntüle(Employee s)
        {
            DataTable dt = new DataTable();
            conn.Open();
            /* Admin        0
             * Security     1
             * Staff        2
             * Danışma      3
             * Hostess      4
             * Hava Kontrol 5
             * Cargo Man    6*/
            if(s is Admin)
                cmd.CommandText = "select Id,NAMEFULL,Email,EmployeeType,Privilige from users";
            if(s is Security)
                cmd.CommandText = "select Id,NAMEFULL,Email,EmployeeType,Privilige from users where EmployeeType > 0 and EmployeeType<5";
            if(s is Staff)
                cmd.CommandText = "select Id,NAMEFULL,Email,EmployeeType,Privilige from users where EmployeeType=2";
            if(s is Danışma)
                cmd.CommandText = "select Id,NAMEFULL,Email,EmployeeType,Privilige from users where EmployeeType =2";
            if(s is Hostess)
                cmd.CommandText = "select Id,NAMEFULL,Email,EmployeeType,Privilige from users where EmployeeType =4";
            if(s is HavaKontrol)
                cmd.CommandText = "select * from flights";
            if(s is CargoMan)
                cmd.CommandText = "select * from cargoes";
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public static Employee GetEmployee(string email)
        {
            try
            {
                // IMPLEMENT TO ADD DATA BASE. AND RETURN THEM WITH PROPER VALUES. 
                conn.Open();
                cmd.CommandText = string.Format("Select * from Users where email='{0}'", email);
                SQLiteDataReader reader = cmd.ExecuteReader();
                Employee oluşan = new Employee();
                int deger=2;
                if (reader.Read()) {

                    oluşan.Privilige = int.Parse(reader["privilige"].ToString());
                    oluşan.Password= reader["password"].ToString();
                    oluşan.ID1 = int.Parse(reader["ID"].ToString());
                    oluşan.FullName = reader["NAMEFULL"].ToString();
                    deger = int.Parse(reader["EmployeeType"].ToString());
                }
                oluşan.Email = email;
                oluşan.Type = deger;
                reader.Close();
                conn.Close();

                if (deger == 0)
                {
                    Admin a1 = new Admin(oluşan);
                    return a1;
                }
                if (deger == 1)
                {
                    Security a1 = new Security(oluşan);
                    return a1;
                }
                if (deger == 2)
                {
                    Staff a1 = new Staff(oluşan);
                    return a1;
                }
                if (deger == 3)
                {
                    Danışma a1 = new Danışma(oluşan);
                    return a1;
                }
                if (deger == 4)
                {
                    Hostess a1 = new Hostess(oluşan);
                    return a1;
                }
                if (deger == 5)
                {
                    HavaKontrol a1 = new HavaKontrol(oluşan);
                    return a1;
                }
                if (deger == 6)
                {
                    CargoMan a1 = new CargoMan(oluşan);
                    return a1;
                }

                return oluşan;
            }
            catch (Exception)
            {
                throw;
            }

        }
        public static void initiliaze()
        {
            executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
             connectionString = @"data source = |DataDirectory|\AirPortManagementSystem.db";
            
             conn = new SQLiteConnection(connectionString);
             cmd = new SQLiteCommand(conn);
        }
        public static bool checkUser(string email, string password)
        {
            bool result = false;
            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                cmd.CommandText = string.Format("Select * from Users where email='{0}' and password='{1}'", email, password);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                
                if (dt.Rows.Count > 0) result = true;

                conn.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
    }
}
