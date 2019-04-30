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
            conn.Close();
            return dt;
        }
        public static Employee GetEmployee(string email)
        {
            try
            {
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
        public static object sorguAdmin(int sorgu, int id, string fullname, string email,string password, int type, int privilige)
        {
            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                int x = 0;
                if (sorgu == 0)
                    cmd.CommandText = "Select Id,NAMEFULL,Email,EmployeeType,Privilige from users where ";
                if (sorgu == 1)
                    cmd.CommandText = "delete from users where ";
                if (sorgu == 2)
                    cmd.CommandText = "insert into users values ( ";

                if (id != -1)
                {
                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + id + "' ";
                        else
                            cmd.CommandText += "id ='" + id + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + id + "' ";
                        else
                            cmd.CommandText += "AND id ='" + id + "' ";
                    }
                }
                if (fullname != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + fullname + "' ";
                        else
                            cmd.CommandText += "namefull ='" + fullname + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + fullname + "' ";
                        else
                            cmd.CommandText += "AND namefull ='" + fullname + "' ";
                    }
                }
                if (email != "")
                {
                    
                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + email + "' ";
                        else 
                            cmd.CommandText += "email ='" + email + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + email + "' ";
                        else
                            cmd.CommandText += "AND email ='" + email + "' ";
                    }
                }
                if (password != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + password + "' ";
                        else 
                            cmd.CommandText += "password='" + password + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + password + "' ";
                        else
                            cmd.CommandText += "AND password ='" + password + "' ";
                    }
                }
               
                if (type != -1)
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + type + "' ";
                        else 
                            cmd.CommandText += "employeetype ='" + type + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + type + "' ";
                        else
                            cmd.CommandText += "AND employeetype ='" + type + "' ";
                    }
                }
                if (privilige != -1)
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + privilige + "' ";
                        else 
                            cmd.CommandText += "privilige ='" + privilige + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + privilige + "' ";
                        else
                            cmd.CommandText += "AND privilige ='" + privilige + "' ";
                    }
                }
                if (x == 0) cmd.CommandText = "Select Id,NAMEFULL,Email,EmployeeType,Privilige from users";
                if (sorgu == 2) cmd.CommandText += ") ";
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception) { throw; }
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
