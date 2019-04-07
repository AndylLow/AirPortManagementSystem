using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportMSystem
{
    public partial class IndexAdmin : Form
    {
        public IndexAdmin()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login yeni = new Login();
            yeni.Show();
            this.Close();
        }
    }
}
