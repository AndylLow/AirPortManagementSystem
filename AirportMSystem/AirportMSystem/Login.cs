using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;

namespace AirportMSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void girisBtn_Click(object sender, EventArgs e)
        {
            Kontrol_Et dataAccessLayer = new Kontrol_Et();
            
            Index yeni = new Index();
            yeni.Show();
            this.Hide();
        }
    }
}
