namespace AirportMSystem
{
    partial class IndexGeneral
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.adminGroup = new System.Windows.Forms.GroupBox();
            this.priviligeCBox = new System.Windows.Forms.ComboBox();
            this.priviligeLbl = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.typeCBox = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.securityGroup = new System.Windows.Forms.GroupBox();
            this.priviligesecurityCBox = new System.Windows.Forms.ComboBox();
            this.priviligesecurityLbl = new System.Windows.Forms.Label();
            this.worktypeLbl = new System.Windows.Forms.Label();
            this.worktypeTxt = new System.Windows.Forms.TextBox();
            this.worktimeTxt = new System.Windows.Forms.TextBox();
            this.worktimeLbl = new System.Windows.Forms.Label();
            this.workplaceLbl = new System.Windows.Forms.Label();
            this.workplaceTxt = new System.Windows.Forms.TextBox();
            this.showsecurityBtn = new System.Windows.Forms.Button();
            this.IDsecurityLbl = new System.Windows.Forms.Label();
            this.idsecurityTxt = new System.Windows.Forms.TextBox();
            this.addsecurityBtn = new System.Windows.Forms.Button();
            this.securitytypeCBox = new System.Windows.Forms.ComboBox();
            this.emailsecurityTxt = new System.Windows.Forms.TextBox();
            this.namesecurityTxt = new System.Windows.Forms.TextBox();
            this.namesecurityLbl = new System.Windows.Forms.Label();
            this.typesecurityLbl = new System.Windows.Forms.Label();
            this.emailsecurityLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.adminGroup.SuspendLayout();
            this.securityGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.AllowUserToAddRows = false;
            this.dataView.AllowUserToDeleteRows = false;
            this.dataView.BackgroundColor = System.Drawing.Color.Azure;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Location = new System.Drawing.Point(12, 31);
            this.dataView.Name = "dataView";
            this.dataView.ReadOnly = true;
            this.dataView.RowTemplate.Height = 24;
            this.dataView.Size = new System.Drawing.Size(572, 489);
            this.dataView.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(1021, 487);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(116, 33);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(67, 35);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(71, 17);
            this.nameLbl.TabIndex = 3;
            this.nameLbl.Text = "Full Name";
            this.nameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(96, 127);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 4;
            this.emailLbl.Text = "Email";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(69, 80);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(69, 17);
            this.passwordLbl.TabIndex = 5;
            this.passwordLbl.Text = "Password";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(32, 169);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(106, 17);
            this.typeLbl.TabIndex = 6;
            this.typeLbl.Text = "Employee Type";
            // 
            // adminGroup
            // 
            this.adminGroup.Controls.Add(this.priviligeCBox);
            this.adminGroup.Controls.Add(this.priviligeLbl);
            this.adminGroup.Controls.Add(this.showBtn);
            this.adminGroup.Controls.Add(this.idLbl);
            this.adminGroup.Controls.Add(this.idTxt);
            this.adminGroup.Controls.Add(this.addBtn);
            this.adminGroup.Controls.Add(this.deleteBtn);
            this.adminGroup.Controls.Add(this.typeCBox);
            this.adminGroup.Controls.Add(this.updateBtn);
            this.adminGroup.Controls.Add(this.emailTxt);
            this.adminGroup.Controls.Add(this.passwordTxt);
            this.adminGroup.Controls.Add(this.nameTxt);
            this.adminGroup.Controls.Add(this.nameLbl);
            this.adminGroup.Controls.Add(this.typeLbl);
            this.adminGroup.Controls.Add(this.passwordLbl);
            this.adminGroup.Controls.Add(this.emailLbl);
            this.adminGroup.Location = new System.Drawing.Point(625, 31);
            this.adminGroup.Name = "adminGroup";
            this.adminGroup.Size = new System.Drawing.Size(476, 380);
            this.adminGroup.TabIndex = 7;
            this.adminGroup.TabStop = false;
            this.adminGroup.Text = "Admin Panel";
            // 
            // priviligeCBox
            // 
            this.priviligeCBox.FormattingEnabled = true;
            this.priviligeCBox.Location = new System.Drawing.Point(200, 209);
            this.priviligeCBox.Name = "priviligeCBox";
            this.priviligeCBox.Size = new System.Drawing.Size(234, 24);
            this.priviligeCBox.TabIndex = 15;
            // 
            // priviligeLbl
            // 
            this.priviligeLbl.AutoSize = true;
            this.priviligeLbl.Location = new System.Drawing.Point(59, 212);
            this.priviligeLbl.Name = "priviligeLbl";
            this.priviligeLbl.Size = new System.Drawing.Size(79, 17);
            this.priviligeLbl.TabIndex = 14;
            this.priviligeLbl.Text = "Privilige No";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(389, 246);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 30);
            this.showBtn.TabIndex = 13;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(100, 254);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(21, 17);
            this.idLbl.TabIndex = 12;
            this.idLbl.Text = "ID";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(127, 251);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(81, 22);
            this.idTxt.TabIndex = 11;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(10, 247);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 30);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(308, 247);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 29);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // typeCBox
            // 
            this.typeCBox.FormattingEnabled = true;
            this.typeCBox.Location = new System.Drawing.Point(200, 169);
            this.typeCBox.Name = "typeCBox";
            this.typeCBox.Size = new System.Drawing.Size(234, 24);
            this.typeCBox.TabIndex = 10;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(227, 248);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 29);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(200, 127);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(234, 22);
            this.emailTxt.TabIndex = 9;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(200, 80);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(234, 22);
            this.passwordTxt.TabIndex = 8;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(200, 35);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(234, 22);
            this.nameTxt.TabIndex = 7;
            // 
            // securityGroup
            // 
            this.securityGroup.Controls.Add(this.priviligesecurityCBox);
            this.securityGroup.Controls.Add(this.priviligesecurityLbl);
            this.securityGroup.Controls.Add(this.worktypeLbl);
            this.securityGroup.Controls.Add(this.worktypeTxt);
            this.securityGroup.Controls.Add(this.worktimeTxt);
            this.securityGroup.Controls.Add(this.worktimeLbl);
            this.securityGroup.Controls.Add(this.workplaceLbl);
            this.securityGroup.Controls.Add(this.workplaceTxt);
            this.securityGroup.Controls.Add(this.showsecurityBtn);
            this.securityGroup.Controls.Add(this.IDsecurityLbl);
            this.securityGroup.Controls.Add(this.idsecurityTxt);
            this.securityGroup.Controls.Add(this.addsecurityBtn);
            this.securityGroup.Controls.Add(this.securitytypeCBox);
            this.securityGroup.Controls.Add(this.emailsecurityTxt);
            this.securityGroup.Controls.Add(this.namesecurityTxt);
            this.securityGroup.Controls.Add(this.namesecurityLbl);
            this.securityGroup.Controls.Add(this.typesecurityLbl);
            this.securityGroup.Controls.Add(this.emailsecurityLbl);
            this.securityGroup.Location = new System.Drawing.Point(625, 31);
            this.securityGroup.Name = "securityGroup";
            this.securityGroup.Size = new System.Drawing.Size(470, 386);
            this.securityGroup.TabIndex = 8;
            this.securityGroup.TabStop = false;
            this.securityGroup.Text = "Security Control";
            // 
            // priviligesecurityCBox
            // 
            this.priviligesecurityCBox.FormattingEnabled = true;
            this.priviligesecurityCBox.Location = new System.Drawing.Point(202, 149);
            this.priviligesecurityCBox.Name = "priviligesecurityCBox";
            this.priviligesecurityCBox.Size = new System.Drawing.Size(234, 24);
            this.priviligesecurityCBox.TabIndex = 35;
            // 
            // priviligesecurityLbl
            // 
            this.priviligesecurityLbl.AutoSize = true;
            this.priviligesecurityLbl.Location = new System.Drawing.Point(69, 152);
            this.priviligesecurityLbl.Name = "priviligesecurityLbl";
            this.priviligesecurityLbl.Size = new System.Drawing.Size(79, 17);
            this.priviligesecurityLbl.TabIndex = 34;
            this.priviligesecurityLbl.Text = "Privilige No";
            // 
            // worktypeLbl
            // 
            this.worktypeLbl.AutoSize = true;
            this.worktypeLbl.Location = new System.Drawing.Point(26, 315);
            this.worktypeLbl.Name = "worktypeLbl";
            this.worktypeLbl.Size = new System.Drawing.Size(77, 17);
            this.worktypeLbl.TabIndex = 33;
            this.worktypeLbl.Text = "Work Type";
            // 
            // worktypeTxt
            // 
            this.worktypeTxt.Location = new System.Drawing.Point(146, 315);
            this.worktypeTxt.Name = "worktypeTxt";
            this.worktypeTxt.Size = new System.Drawing.Size(199, 22);
            this.worktypeTxt.TabIndex = 32;
            // 
            // worktimeTxt
            // 
            this.worktimeTxt.Location = new System.Drawing.Point(146, 284);
            this.worktimeTxt.Name = "worktimeTxt";
            this.worktimeTxt.Size = new System.Drawing.Size(199, 22);
            this.worktimeTxt.TabIndex = 31;
            // 
            // worktimeLbl
            // 
            this.worktimeLbl.AutoSize = true;
            this.worktimeLbl.Location = new System.Drawing.Point(30, 284);
            this.worktimeLbl.Name = "worktimeLbl";
            this.worktimeLbl.Size = new System.Drawing.Size(76, 17);
            this.worktimeLbl.TabIndex = 30;
            this.worktimeLbl.Text = "Work Time";
            // 
            // workplaceLbl
            // 
            this.workplaceLbl.AutoSize = true;
            this.workplaceLbl.Location = new System.Drawing.Point(26, 246);
            this.workplaceLbl.Name = "workplaceLbl";
            this.workplaceLbl.Size = new System.Drawing.Size(80, 17);
            this.workplaceLbl.TabIndex = 29;
            this.workplaceLbl.Text = "Work Place";
            // 
            // workplaceTxt
            // 
            this.workplaceTxt.Location = new System.Drawing.Point(146, 246);
            this.workplaceTxt.Name = "workplaceTxt";
            this.workplaceTxt.Size = new System.Drawing.Size(199, 22);
            this.workplaceTxt.TabIndex = 28;
            // 
            // showsecurityBtn
            // 
            this.showsecurityBtn.Location = new System.Drawing.Point(361, 190);
            this.showsecurityBtn.Name = "showsecurityBtn";
            this.showsecurityBtn.Size = new System.Drawing.Size(75, 30);
            this.showsecurityBtn.TabIndex = 27;
            this.showsecurityBtn.Text = "Show";
            this.showsecurityBtn.UseVisualStyleBackColor = true;
            // 
            // IDsecurityLbl
            // 
            this.IDsecurityLbl.AutoSize = true;
            this.IDsecurityLbl.Location = new System.Drawing.Point(199, 193);
            this.IDsecurityLbl.Name = "IDsecurityLbl";
            this.IDsecurityLbl.Size = new System.Drawing.Size(21, 17);
            this.IDsecurityLbl.TabIndex = 26;
            this.IDsecurityLbl.Text = "ID";
            // 
            // idsecurityTxt
            // 
            this.idsecurityTxt.Location = new System.Drawing.Point(264, 190);
            this.idsecurityTxt.Name = "idsecurityTxt";
            this.idsecurityTxt.Size = new System.Drawing.Size(81, 22);
            this.idsecurityTxt.TabIndex = 25;
            // 
            // addsecurityBtn
            // 
            this.addsecurityBtn.Location = new System.Drawing.Point(353, 341);
            this.addsecurityBtn.Name = "addsecurityBtn";
            this.addsecurityBtn.Size = new System.Drawing.Size(75, 30);
            this.addsecurityBtn.TabIndex = 19;
            this.addsecurityBtn.Text = "Add";
            this.addsecurityBtn.UseVisualStyleBackColor = true;
            // 
            // securitytypeCBox
            // 
            this.securitytypeCBox.FormattingEnabled = true;
            this.securitytypeCBox.Location = new System.Drawing.Point(202, 110);
            this.securitytypeCBox.Name = "securitytypeCBox";
            this.securitytypeCBox.Size = new System.Drawing.Size(234, 24);
            this.securitytypeCBox.TabIndex = 24;
            // 
            // emailsecurityTxt
            // 
            this.emailsecurityTxt.Location = new System.Drawing.Point(202, 63);
            this.emailsecurityTxt.Name = "emailsecurityTxt";
            this.emailsecurityTxt.Size = new System.Drawing.Size(234, 22);
            this.emailsecurityTxt.TabIndex = 22;
            // 
            // namesecurityTxt
            // 
            this.namesecurityTxt.Location = new System.Drawing.Point(202, 22);
            this.namesecurityTxt.Name = "namesecurityTxt";
            this.namesecurityTxt.Size = new System.Drawing.Size(234, 22);
            this.namesecurityTxt.TabIndex = 18;
            // 
            // namesecurityLbl
            // 
            this.namesecurityLbl.AutoSize = true;
            this.namesecurityLbl.Location = new System.Drawing.Point(69, 22);
            this.namesecurityLbl.Name = "namesecurityLbl";
            this.namesecurityLbl.Size = new System.Drawing.Size(71, 17);
            this.namesecurityLbl.TabIndex = 14;
            this.namesecurityLbl.Text = "Full Name";
            // 
            // typesecurityLbl
            // 
            this.typesecurityLbl.AutoSize = true;
            this.typesecurityLbl.Location = new System.Drawing.Point(34, 110);
            this.typesecurityLbl.Name = "typesecurityLbl";
            this.typesecurityLbl.Size = new System.Drawing.Size(106, 17);
            this.typesecurityLbl.TabIndex = 17;
            this.typesecurityLbl.Text = "Employee Type";
            // 
            // emailsecurityLbl
            // 
            this.emailsecurityLbl.AutoSize = true;
            this.emailsecurityLbl.Location = new System.Drawing.Point(98, 63);
            this.emailsecurityLbl.Name = "emailsecurityLbl";
            this.emailsecurityLbl.Size = new System.Drawing.Size(42, 17);
            this.emailsecurityLbl.TabIndex = 15;
            this.emailsecurityLbl.Text = "Email";
            // 
            // IndexGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 532);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.dataView);
            this.Controls.Add(this.adminGroup);
            this.Controls.Add(this.securityGroup);
            this.Name = "IndexGeneral";
            this.Text = "IndexGeneral";
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.adminGroup.ResumeLayout(false);
            this.adminGroup.PerformLayout();
            this.securityGroup.ResumeLayout(false);
            this.securityGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.GroupBox adminGroup;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ComboBox typeCBox;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.GroupBox securityGroup;
        private System.Windows.Forms.Label worktypeLbl;
        private System.Windows.Forms.TextBox worktypeTxt;
        private System.Windows.Forms.TextBox worktimeTxt;
        private System.Windows.Forms.Label worktimeLbl;
        private System.Windows.Forms.Label workplaceLbl;
        private System.Windows.Forms.TextBox workplaceTxt;
        private System.Windows.Forms.Button showsecurityBtn;
        private System.Windows.Forms.Label IDsecurityLbl;
        private System.Windows.Forms.TextBox idsecurityTxt;
        private System.Windows.Forms.Button addsecurityBtn;
        private System.Windows.Forms.ComboBox securitytypeCBox;
        private System.Windows.Forms.TextBox emailsecurityTxt;
        private System.Windows.Forms.TextBox namesecurityTxt;
        private System.Windows.Forms.Label namesecurityLbl;
        private System.Windows.Forms.Label typesecurityLbl;
        private System.Windows.Forms.Label emailsecurityLbl;
        private System.Windows.Forms.ComboBox priviligeCBox;
        private System.Windows.Forms.Label priviligeLbl;
        private System.Windows.Forms.ComboBox priviligesecurityCBox;
        private System.Windows.Forms.Label priviligesecurityLbl;
    }
}