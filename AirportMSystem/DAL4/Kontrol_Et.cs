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

        public static object sorguSecurity(int deger,int sorgu, int id, string fullname, string email, int type, int privilige,string place,string time,string worktype,Employee s)
        {
            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                int x = 0;
                if(s is Security) { 
                if (sorgu == 0)
                    cmd.CommandText = "Select Id,fullname,place,time,worktype from gorevler where ";
                if (sorgu == 1)
                    cmd.CommandText = "delete from gorevler where ";
                if (sorgu == 2)
                    cmd.CommandText = "insert into gorevler values ( ";
                if (sorgu == 2 && id == -1) cmd.CommandText = "insert into gorevler (fullname,privilige,place,time,worktype) values ( ";

                }
                if (s is Staff)
                {
                    if (sorgu == 0)
                        cmd.CommandText = "Select Id,fullname,place,time,worktype from gorevler2 where ";
                    if (sorgu == 1)
                        cmd.CommandText = "delete from gorevler2 where ";
                    if (sorgu == 2)
                        cmd.CommandText = "insert into gorevler2 values ( ";
                    if (sorgu == 2 && id == -1) cmd.CommandText = "insert into gorevler2 (fullname,privilige,place,time,worktype) values ( ";

                }
                if (s is Danışma)
                {
                    if (sorgu == 0)
                        cmd.CommandText = "Select Id,fullname,place,time,worktype from gorevler3 where ";
                    if (sorgu == 1)
                        cmd.CommandText = "delete from gorevler3 where ";
                    if (sorgu == 2)
                        cmd.CommandText = "insert into gorevler3 values ( ";
                    if (sorgu == 2 && id == -1) cmd.CommandText = "insert into gorevler3 (fullname,privilige,place,time,worktype) values ( ";

                }

                

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
                            cmd.CommandText += "fullname ='" + fullname + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + fullname + "' ";
                        else
                            cmd.CommandText += "AND fullname ='" + fullname + "' ";
                    }
                }
                

                if(privilige ==-1&&sorgu==2&&x>0) cmd.CommandText += " ,'' ";
                if(privilige ==-1&&sorgu==2&&x==0) cmd.CommandText += " '' ";
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
                if (place == "" && sorgu == 2 && x>0) cmd.CommandText += " ,'' ";
                if (place == "" && sorgu == 2 && x==0) cmd.CommandText += " '' ";
                if (place != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + place + "' ";
                        else
                            cmd.CommandText += "place='" + place + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + place + "' ";
                        else
                            cmd.CommandText += "AND place ='" + place + "' ";
                    }
                }
                if (time == "" && sorgu == 2 && x > 0) cmd.CommandText += " ,'' ";
                if (time == "" && sorgu == 2 && x == 0) cmd.CommandText += " '' ";

                if (time != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + time + "' ";
                        else
                            cmd.CommandText += "time='" + time + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + time + "' ";
                        else
                            cmd.CommandText += "AND time ='" + time + "' ";
                    }
                }
                if (worktype == "" && sorgu == 2 && x > 0) cmd.CommandText += " ,'' ";
                if (worktype == "" && sorgu == 2 && x == 0) cmd.CommandText += " '' ";
                if (worktype != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + worktype + "' ";
                        else
                            cmd.CommandText += "worktype='" + worktype + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + worktype + "' ";
                        else
                            cmd.CommandText += "AND worktype ='" + worktype + "' ";
                    }
                }
                if (x == 0&&s is Security) cmd.CommandText = "Select * from gorevler";
                if (x == 0&&s is Staff) cmd.CommandText = "Select * from gorevler2";
                if (x == 0&&s is Danışma) cmd.CommandText = "Select * from gorevler3";
                if (sorgu == 2) cmd.CommandText += ") ";
                if (deger == 0&& s is Security) return sorguAdmin(0,id,fullname,email,"",1,privilige);
                if (deger == 0&& s is Staff) return sorguAdmin(0,id,fullname,email,"",2,privilige);
                if (deger == 0&& s is Danışma) return sorguAdmin(0,id,fullname,email,"",3,privilige);
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception) { throw; }

        }

        public static object sorguCargo(int sorgu, int id, string departure, string goingto, string cargomanName, string cargomanID, string shipperName)
        {
            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                int x = 0;
                if (sorgu == 0)
                    cmd.CommandText = "Select * from Cargoes where ";
                if (sorgu == 1)
                    cmd.CommandText = "delete from Cargoes where ";
                if (sorgu == 2)
                    cmd.CommandText = "insert into Cargoes values ( ";
                if (sorgu == 2 && id == -1) cmd.CommandText = "insert into Cargoes (departureID,GOINGTOID,CargoManNAME,CargoManID,ShipperNAME) values ( ";



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
                if (departure != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + departure + "' ";
                        else
                            cmd.CommandText += "DepartureID ='" + departure + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + departure + "' ";
                        else
                            cmd.CommandText += "AND DepartureID ='" + departure + "' ";
                    }
                }
                if (goingto != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + goingto + "' ";
                        else
                            cmd.CommandText += "GOINGTOID ='" + goingto + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + goingto + "' ";
                        else
                            cmd.CommandText += "AND GOINGTOID ='" + goingto + "' ";
                    }
                }
                if (cargomanName != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + cargomanName + "' ";
                        else
                            cmd.CommandText += "CargoManNAME='" + cargomanName + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + cargomanName + "' ";
                        else
                            cmd.CommandText += "AND CargoManNAME ='" + cargomanName + "' ";
                    }
                }

                if (cargomanID != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + cargomanID + "' ";
                        else
                            cmd.CommandText += "CargoManID ='" + cargomanID + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + cargomanID + "' ";
                        else
                            cmd.CommandText += "AND CargoManID ='" + cargomanID + "' ";
                    }
                }
                if (shipperName != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + shipperName + "' ";
                        else
                            cmd.CommandText += "shipperName ='" + shipperName + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + shipperName + "' ";
                        else
                            cmd.CommandText += "AND shipperName ='" + shipperName + "' ";
                    }
                }
                if (x == 0) cmd.CommandText = "Select * from Cargoes";
                if (sorgu == 2) cmd.CommandText += ") ";
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception) { throw; }
        }

        public static object sorguFlight(int sorgu, int id, string departure, string goingto, string acepilotname, string acepilotid, string secondarypilotname, string secondarypilotid,string host1name,string host1id, string host2name, string host2id, string host3name, string host3id)
        {
            try
            {
                DataTable dt = new DataTable();
                conn.Open();
                int x = 0;
                if (sorgu == 0)
                    cmd.CommandText = "Select * from Flights where ";
                if (sorgu == 1)
                    cmd.CommandText = "delete from Flights where ";
                if (sorgu == 2)
                    cmd.CommandText = "insert into Flights values ( ";
                if (sorgu == 2 && id == -1) cmd.CommandText = "insert into Flights (departureID,GOINGTOID,acepilotname,acepilotid,secondarypilotname,secondarypilotid,hostess1name,hostess1id,hostess2name,hostess2id,hostess3name,hostess3id) values ( ";



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
                if (departure != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + departure + "' ";
                        else
                            cmd.CommandText += "DepartureID ='" + departure + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + departure + "' ";
                        else
                            cmd.CommandText += "AND DepartureID ='" + departure + "' ";
                    }
                }
                if (goingto != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + goingto + "' ";
                        else
                            cmd.CommandText += "GOINGTOID ='" + goingto + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + goingto + "' ";
                        else
                            cmd.CommandText += "AND GOINGTOID ='" + goingto + "' ";
                    }
                }
                if (acepilotname != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + acepilotname + "' ";
                        else
                            cmd.CommandText += "AcePilotNAME='" + acepilotname + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + acepilotname + "' ";
                        else
                            cmd.CommandText += "AND AcePilotName ='" + acepilotname + "' ";
                    }
                }

                if (acepilotid != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + acepilotid + "' ";
                        else
                            cmd.CommandText += "acepilotid ='" + acepilotid + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + acepilotid + "' ";
                        else
                            cmd.CommandText += "AND acepilotid ='" + acepilotid + "' ";
                    }
                }
                if (secondarypilotname == "" && sorgu == 2 && x > 0) cmd.CommandText += " ,'' ";
                if (secondarypilotname == "" && sorgu == 2 && x == 0) cmd.CommandText += " '' ";
                if (secondarypilotname != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + secondarypilotname + "' ";
                        else
                            cmd.CommandText += "SecondaryPilotNAME ='" + secondarypilotname + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + secondarypilotname + "' ";
                        else
                            cmd.CommandText += "AND SecondaryPilotNAME ='" + secondarypilotname + "' ";
                    }
                }
                if (secondarypilotid == "" && sorgu == 2 && x > 0) cmd.CommandText += " ,'' ";
                if (secondarypilotid == "" && sorgu == 2 && x == 0) cmd.CommandText += " '' ";
                if (secondarypilotid != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + secondarypilotid + "' ";
                        else
                            cmd.CommandText += "secondarypilotid ='" + secondarypilotid + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + secondarypilotid + "' ";
                        else
                            cmd.CommandText += "AND secondarypilotid ='" + secondarypilotid + "' ";
                    }
                }
                if (host1name == "" && sorgu == 2 && x > 0) cmd.CommandText += " ,'' ";
                if (host1name == "" && sorgu == 2 && x == 0) cmd.CommandText += " '' ";
                if (host1name != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + host1name + "' ";
                        else
                            cmd.CommandText += "hostess1name ='" + host1name + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + host1name + "' ";
                        else
                            cmd.CommandText += "AND hostess1name ='" + host1name + "' ";
                    }
                }
                if (host1id == "" && sorgu == 2 && x > 0) cmd.CommandText += " ,'' ";
                if (host1id == "" && sorgu == 2 && x == 0) cmd.CommandText += " '' ";
                if (host1id != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + host1id + "' ";
                        else
                            cmd.CommandText += "hostess1id ='" + host1id + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + host1id + "' ";
                        else
                            cmd.CommandText += "AND hostess1id ='" + host1id + "' ";
                    }
                }
                if (host2name == "" && sorgu == 2 && x > 0) cmd.CommandText += " ,'' ";
                if (host2name == "" && sorgu == 2 && x == 0) cmd.CommandText += " '' ";
                if (host2name != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + host2name + "' ";
                        else
                            cmd.CommandText += "hostess2name ='" + host2name + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + host2name + "' ";
                        else
                            cmd.CommandText += "AND hostess2name ='" + host2name + "' ";
                    }
                }
                if (host2id == "" && sorgu == 2 && x > 0) cmd.CommandText += " ,'' ";
                if (host2id == "" && sorgu == 2 && x == 0) cmd.CommandText += " '' ";
                if (host2id != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + host2id + "' ";
                        else
                            cmd.CommandText += "hostess2id ='" + host2id + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + host2id + "' ";
                        else
                            cmd.CommandText += "AND hostess2id ='" + host2id + "' ";
                    }
                }
                if (host3name == "" && sorgu == 2 && x > 0) cmd.CommandText += " ,'' ";
                if (host3name == "" && sorgu == 2 && x == 0) cmd.CommandText += " '' ";
                if (host3name != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + host3name + "' ";
                        else
                            cmd.CommandText += "hostess3name ='" + host3name + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + host3name + "' ";
                        else
                            cmd.CommandText += "AND hostess3name ='" + host3name + "' ";
                    }
                }
                if (host3id == "" && sorgu == 2 && x > 0) cmd.CommandText += " ,'' ";
                if (host3id == "" && sorgu == 2 && x == 0) cmd.CommandText += " '' ";
                if (host3id != "")
                {

                    if (x == 0)
                    {
                        if (sorgu == 2)
                            cmd.CommandText += " '" + host3id + "' ";
                        else
                            cmd.CommandText += "hostess3id ='" + host3id + "' ";
                        x++;
                    }
                    else
                    {
                        if (sorgu == 2)
                            cmd.CommandText += ",'" + host3id + "' ";
                        else
                            cmd.CommandText += "AND hostess3id ='" + host3id + "' ";
                    }
                }
                if (x == 0) cmd.CommandText = "Select * from Flights";
                if (sorgu == 2) cmd.CommandText += ") ";
                SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
                da.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception) { throw; }
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
                if(sorgu == 2 && id==-1) cmd.CommandText = "insert into users (namefull,password,email,employeetype,privilige) values ( ";



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
                if (privilige == -1 && sorgu == 2 && x > 0) cmd.CommandText += " ,'' ";
                if (privilige == -1 && sorgu == 2 && x == 0) cmd.CommandText += " '' ";
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
