using ClassLibrary1;
using DAL4;
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
    public partial class IndexGeneral : Form
    {
        public IndexGeneral(Employee s)
        {
            InitializeComponent();

            if (s is Admin) {
                dataView.DataSource = Kontrol_Et.görüntüle(s);
                securityGroup.Visible=false;
                securityGroup.Update(); }
            if(s is Security)
            {
                adminGroup.Visible = false;
                adminGroup.Update();
            }
        }

        private void hostHostessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login yeni = new Login();
            yeni.Show();
            this.Hide();
        }
    }
}
