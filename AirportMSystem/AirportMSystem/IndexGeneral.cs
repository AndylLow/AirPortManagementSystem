using ClassLibrary1;
using DAL4;
using System;
using System.Windows.Forms;

namespace AirportMSystem
{
    public partial class IndexGeneral : Form
    {
        public IndexGeneral(Employee s)
        {
            InitializeComponent();

            if (s is Admin && s.Privilige>0) {
                dataView.DataSource = Kontrol_Et.görüntüle(s);
                securityGroup.Visible=false;
                securityGroup.Update(); }
            if((s is Security || s is Staff) && s.Privilige>0)
            {
                adminGroup.Visible = false;
                adminGroup.Update();
            }
            if (s is CargoMan && s.Privilige > 0)
            {
                //TO BE IMPLEMENTED
            }
            if (s is HavaKontrol && s.Privilige > 0)
            {
                //TO BE IMPLEMENTED
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
