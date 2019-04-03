namespace AirportMSystem
{
    partial class IndexSecurity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ekleBtn = new System.Windows.Forms.Button();
            this.cikarBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.roleChckbx = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ekleBtn
            // 
            this.ekleBtn.Location = new System.Drawing.Point(224, 338);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(75, 60);
            this.ekleBtn.TabIndex = 0;
            this.ekleBtn.Text = "Add User";
            this.ekleBtn.UseVisualStyleBackColor = true;
            // 
            // cikarBtn
            // 
            this.cikarBtn.Location = new System.Drawing.Point(436, 338);
            this.cikarBtn.Name = "cikarBtn";
            this.cikarBtn.Size = new System.Drawing.Size(75, 60);
            this.cikarBtn.TabIndex = 1;
            this.cikarBtn.Text = "Remove User";
            this.cikarBtn.UseVisualStyleBackColor = true;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(699, 384);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 38);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(182, 65);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(21, 17);
            this.idLbl.TabIndex = 3;
            this.idLbl.Text = "ID";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(182, 121);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(71, 17);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Full Name";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(182, 165);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Email";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(182, 212);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(69, 17);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Password";
            // 
            // roleChckbx
            // 
            this.roleChckbx.AutoSize = true;
            this.roleChckbx.Location = new System.Drawing.Point(182, 259);
            this.roleChckbx.Name = "roleChckbx";
            this.roleChckbx.Size = new System.Drawing.Size(37, 17);
            this.roleChckbx.TabIndex = 7;
            this.roleChckbx.Text = "Role";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(330, 259);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(181, 24);
            this.comboBox2.TabIndex = 8;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(330, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(181, 22);
            this.textBox5.TabIndex = 9;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(330, 212);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(181, 22);
            this.textBox6.TabIndex = 10;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(330, 165);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(181, 22);
            this.textBox7.TabIndex = 11;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(330, 121);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(181, 22);
            this.textBox8.TabIndex = 12;
            // 
            // IndexAdmin
            // 
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.roleChckbx);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.cikarBtn);
            this.Controls.Add(this.ekleBtn);
            this.Name = "IndexAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button cikarBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label roleChckbx;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
    }
}