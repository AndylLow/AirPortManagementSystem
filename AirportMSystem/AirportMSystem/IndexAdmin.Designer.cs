namespace AirportMSystem
{
    partial class IndexAdmin
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
            this.logoutBtn = new System.Windows.Forms.Button();
            this.removeUserBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.idLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.employeeTypeLbl = new System.Windows.Forms.Label();
            this.employeeBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(670, 375);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 30);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.Location = new System.Drawing.Point(473, 330);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(118, 75);
            this.removeUserBtn.TabIndex = 1;
            this.removeUserBtn.Text = "Remove User";
            this.removeUserBtn.UseVisualStyleBackColor = true;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(203, 330);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(118, 75);
            this.addUserBtn.TabIndex = 2;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(235, 62);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(55, 17);
            this.idLbl.TabIndex = 3;
            this.idLbl.Text = "User ID";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(219, 106);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(71, 17);
            this.nameLbl.TabIndex = 4;
            this.nameLbl.Text = "Full Name";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(248, 156);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 5;
            this.emailLbl.Text = "Email";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(221, 200);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(69, 17);
            this.passwordLbl.TabIndex = 6;
            this.passwordLbl.Text = "Password";
            // 
            // employeeTypeLbl
            // 
            this.employeeTypeLbl.AutoSize = true;
            this.employeeTypeLbl.Location = new System.Drawing.Point(184, 249);
            this.employeeTypeLbl.Name = "employeeTypeLbl";
            this.employeeTypeLbl.Size = new System.Drawing.Size(106, 17);
            this.employeeTypeLbl.TabIndex = 7;
            this.employeeTypeLbl.Text = "Employee Type";
            // 
            // employeeBox
            // 
            this.employeeBox.FormattingEnabled = true;
            this.employeeBox.Items.AddRange(new object[] {
            "Admin",
            "Security"});
            this.employeeBox.Location = new System.Drawing.Point(353, 249);
            this.employeeBox.Name = "employeeBox";
            this.employeeBox.Size = new System.Drawing.Size(178, 24);
            this.employeeBox.TabIndex = 8;
            // 
            // IndexAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.employeeBox);
            this.Controls.Add(this.employeeTypeLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.removeUserBtn);
            this.Controls.Add(this.logoutBtn);
            this.Name = "IndexAdmin";
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button removeUserBtn;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label employeeTypeLbl;
        private System.Windows.Forms.ComboBox employeeBox;
    }
}