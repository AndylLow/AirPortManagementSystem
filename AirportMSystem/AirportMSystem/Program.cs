using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL4;

namespace AirportMSystem
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Kontrol_Et.initiliaze();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Kontrol_Et.initiliaze();
            Login login = new Login();
            login.Show();
            Application.Run();
        }
    }
}
