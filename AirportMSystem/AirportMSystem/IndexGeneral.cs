using ClassLibrary1;
using DAL4;
using System;
using System.Windows.Forms;

namespace AirportMSystem
{
    public partial class IndexGeneral : Form
    {
        public static Employee a;
        public IndexGeneral(Employee s)
        {
            a = s;
            InitializeComponent();

            if (s is Admin && s.Privilige>0) {
                dataView.DataSource = Kontrol_Et.görüntüle(s);
                securityGroup.Visible=false;
                cargoGroup.Visible = false;
                traficGroup.Visible = false;
                cargoGroup.Update();
            }
            if((s is Security || s is Staff || s is Danışma) && s.Privilige>0)
            {
                if (s is Staff) securityGroup.Text = "Staff Menu";
                traficGroup.Visible = false;
                adminGroup.Visible = false;
                cargoGroup.Visible = false;
                cargoGroup.Update();
            }
            if (s is CargoMan && s.Privilige > 0)
            {
                if (s.Privilige > 1)
                {
                    traficGroup.Visible = false;
                    adminGroup.Visible = false;
                    securityGroup.Visible = false;
                    securityGroup.Update();
                }
                else {
                    removecargoBtn.Visible = false;
                    traficGroup.Visible = false;
                    adminGroup.Visible = false;
                    securityGroup.Visible = false;
                    securityGroup.Update();
                }
            }
            if (s is HavaKontrol && s.Privilige > 0)
            {
                if (s.Privilige > 1) { 
                securityGroup.Visible = false;
                adminGroup.Visible = false;
                cargoGroup.Visible = false;
                traficGroup.Update();}
                else
                {
                    removefligthBtn.Visible = false;
                    securityGroup.Visible = false;
                    adminGroup.Visible = false;
                    cargoGroup.Visible = false;
                    traficGroup.Update();
                }
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            int x = -1;
            if (idTxt.Text != "")
                x = int.Parse(idTxt.Text);
            try
            {
                Kontrol_Et.sorguAdmin(2, x, nameTxt.Text, emailTxt.Text, passwordTxt.Text, typeCBox.SelectedIndex, priviligeCBox.SelectedIndex);
                MessageBox.Show("Added succesfully");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to insert to database");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int x = -1;
            if (idTxt.Text != "")
                x = int.Parse(idTxt.Text);
            try
            {
                Kontrol_Et.sorguAdmin(1, x, nameTxt.Text, emailTxt.Text, passwordTxt.Text, typeCBox.SelectedIndex, priviligeCBox.SelectedIndex);
                MessageBox.Show("Deletion Succesfull");
            }
            catch (Exception)
            {

                MessageBox.Show("Deletion failed");
            }
            
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            int x = -1;
            if (idTxt.Text!="")
                  x= int.Parse(idTxt.Text);
            dataView.DataSource = Kontrol_Et.sorguAdmin(0, x, nameTxt.Text, emailTxt.Text,passwordTxt.Text, typeCBox.SelectedIndex, priviligeCBox.SelectedIndex);
            dataView.Update();
        }

        private void addsecurityBtn_Click(object sender, EventArgs e)
        {
            int x = -1;
            int deger=1;
            if (emailsecurityTxt.Text != "") deger = 0;
            if (securitytypeCBox.SelectedIndex != -1) deger = 0;
            if (idsecurityTxt.Text != "") 
              x = int.Parse(idsecurityTxt.Text);
            dataView.DataSource = Kontrol_Et.sorguSecurity(deger,2, x, namesecurityTxt.Text, emailsecurityTxt.Text, securitytypeCBox.SelectedIndex, priviligesecurityCBox.SelectedIndex, workplaceTxt.Text, worktimeTxt.Text, worktypeTxt.Text,a);
            dataView.Update();
        }

        private void deletesecurityBtn_Click(object sender, EventArgs e)
        {
            int x = -1;
            int deger = 1;
            if (emailsecurityTxt.Text != "") deger = 0;
            if (securitytypeCBox.SelectedIndex != -1) deger = 0;
            if (idsecurityTxt.Text != "")
                x = int.Parse(idsecurityTxt.Text);
            dataView.DataSource = Kontrol_Et.sorguSecurity(deger, 1, x, namesecurityTxt.Text, emailsecurityTxt.Text, securitytypeCBox.SelectedIndex, priviligesecurityCBox.SelectedIndex, workplaceTxt.Text, worktimeTxt.Text, worktypeTxt.Text, a);
            dataView.Update();
        }

        private void showsecurityBtn_Click(object sender, EventArgs e)
        {
            int x = -1;
            int deger = 1;
            if (emailsecurityTxt.Text != "") deger = 0;
            if (securitytypeCBox.SelectedIndex != -1) deger = 0;
            if (idsecurityTxt.Text != "")
                x = int.Parse(idsecurityTxt.Text);
            dataView.DataSource = Kontrol_Et.sorguSecurity(deger, 0, x, namesecurityTxt.Text, emailsecurityTxt.Text, securitytypeCBox.SelectedIndex, priviligesecurityCBox.SelectedIndex, workplaceTxt.Text, worktimeTxt.Text, worktypeTxt.Text, a);
            dataView.Update();
        }

        private void addcargoBtn_Click(object sender, EventArgs e)
        {
            int x = -1;

            if (cargoidTxt.Text != "")
                x = int.Parse(cargoidTxt.Text);
            dataView.DataSource = Kontrol_Et.sorguCargo(2, x, fromTxt.Text , toTxt.Text, cargomannameTxt.Text, cargomanidTxt.Text,cargofromnameTxt.Text);
            dataView.Update();
        }

        private void searchcargoBtn_Click(object sender, EventArgs e)
        {
            int x = -1;

            if (cargoidTxt.Text != "")
                x = int.Parse(cargoidTxt.Text);
            dataView.DataSource = Kontrol_Et.sorguCargo(0, x, fromTxt.Text, toTxt.Text, cargomannameTxt.Text, cargomanidTxt.Text, cargofromnameTxt.Text);
            dataView.Update();
        }

        private void removecargoBtn_Click(object sender, EventArgs e)
        {
            int x = -1;

            if (cargoidTxt.Text != "")
                x = int.Parse(cargoidTxt.Text);
            dataView.DataSource = Kontrol_Et.sorguCargo(1, x, fromTxt.Text, toTxt.Text, cargomannameTxt.Text, cargomanidTxt.Text, cargofromnameTxt.Text);
            dataView.Update();
        }

        private void searchflightBtn_Click(object sender, EventArgs e)
        {
            int x = -1;

            if (flightidTxt.Text != "")
                x = int.Parse(flightidTxt.Text);
            dataView.DataSource = Kontrol_Et.sorguFlight(0, x, departureidTxt.Text, arrivalidTxt.Text, acepilotnameTxt.Text, acepilotidTxt.Text, secondarypilotnameTxt.Text, secondarypilotidTxt.Text, host1nameTxt.Text, host1idTxt.Text, host2nameTxt.Text, host2idTxt.Text, host3nameTxt.Text, host3idTxt.Text);
            dataView.Update();
        }

        private void removefligthBtn_Click(object sender, EventArgs e)
        {
            int x = -1;

            if (flightidTxt.Text != "")
                x = int.Parse(flightidTxt.Text);
            dataView.DataSource = Kontrol_Et.sorguFlight(1, x, departureidTxt.Text, arrivalidTxt.Text, acepilotnameTxt.Text, acepilotidTxt.Text, secondarypilotnameTxt.Text,secondarypilotidTxt.Text,host1nameTxt.Text,host1idTxt.Text,host2nameTxt.Text, host2idTxt.Text, host3nameTxt.Text, host3idTxt.Text);
            dataView.Update();
        }

        private void addflightBtn_Click(object sender, EventArgs e)
        {
            int x = -1;

            if (flightidTxt.Text != "")
                x = int.Parse(flightidTxt.Text);
            dataView.DataSource = Kontrol_Et.sorguFlight(2, x, departureidTxt.Text, arrivalidTxt.Text, acepilotnameTxt.Text, acepilotidTxt.Text, secondarypilotnameTxt.Text, secondarypilotidTxt.Text, host1nameTxt.Text, host1idTxt.Text, host2nameTxt.Text, host2idTxt.Text, host3nameTxt.Text, host3idTxt.Text);
            dataView.Update();
        }
    }
}
