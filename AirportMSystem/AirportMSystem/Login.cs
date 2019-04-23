using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Sql;
using DAL4;

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

            if (Kontrol_Et.checkUser(emailTxt.Text, passwordTxt.Text))
            {
                
                IndexGeneral yeni = new IndexGeneral(Kontrol_Et.GetEmployee(emailTxt.Text));
                yeni.Show();
                this.Hide();
            }
            else
                MessageBox.Show("No Match Found");
        }
    }
}
