namespace AirportMSystem
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.headingLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // emailTxt
            // 
            this.emailTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.emailTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.emailTxt.Location = new System.Drawing.Point(317, 135);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(268, 22);
            this.emailTxt.TabIndex = 0;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(253, 135);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(42, 17);
            this.emailLbl.TabIndex = 1;
            this.emailLbl.Text = "Email";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(226, 198);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(69, 17);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(317, 198);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(268, 22);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(362, 278);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(75, 23);
            this.girisBtn.TabIndex = 4;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // headingLbl
            // 
            this.headingLbl.AutoSize = true;
            this.headingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.headingLbl.Location = new System.Drawing.Point(167, 41);
            this.headingLbl.Name = "headingLbl";
            this.headingLbl.Size = new System.Drawing.Size(504, 36);
            this.headingLbl.TabIndex = 5;
            this.headingLbl.Text = "AIRPORT MANAGEMENT SYSTEM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.headingLbl);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.emailTxt);
            this.Name = "Form1";
            this.Text = "Airport Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.Label headingLbl;
    }
}

