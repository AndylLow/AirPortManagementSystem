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
            this.nameLbl = new System.Windows.Forms.Label();
            this.cameraPlacesCBox = new System.Windows.Forms.ComboBox();
            this.placeLbl = new System.Windows.Forms.Label();
            this.cameraPlaceLbl = new System.Windows.Forms.Label();
            this.typeLbl = new System.Windows.Forms.Label();
            this.allCameraPlacesLbl = new System.Windows.Forms.Label();
            this.allCameraPlacesCBox = new System.Windows.Forms.ComboBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.physicalPlacesLbl = new System.Windows.Forms.Label();
            this.physicalPlacesCBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(33, 22);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(45, 17);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // cameraPlacesCBox
            // 
            this.cameraPlacesCBox.FormattingEnabled = true;
            this.cameraPlacesCBox.Location = new System.Drawing.Point(446, 75);
            this.cameraPlacesCBox.Name = "cameraPlacesCBox";
            this.cameraPlacesCBox.Size = new System.Drawing.Size(246, 24);
            this.cameraPlacesCBox.TabIndex = 2;
            // 
            // placeLbl
            // 
            this.placeLbl.AutoSize = true;
            this.placeLbl.Location = new System.Drawing.Point(33, 135);
            this.placeLbl.Name = "placeLbl";
            this.placeLbl.Size = new System.Drawing.Size(76, 17);
            this.placeLbl.TabIndex = 3;
            this.placeLbl.Text = "Duty Place";
            this.placeLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // cameraPlaceLbl
            // 
            this.cameraPlaceLbl.AutoSize = true;
            this.cameraPlaceLbl.Location = new System.Drawing.Point(292, 75);
            this.cameraPlaceLbl.Name = "cameraPlaceLbl";
            this.cameraPlaceLbl.Size = new System.Drawing.Size(103, 17);
            this.cameraPlaceLbl.TabIndex = 4;
            this.cameraPlaceLbl.Text = "Camera Places";
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(33, 75);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(73, 17);
            this.typeLbl.TabIndex = 5;
            this.typeLbl.Text = "Duty Type";
            // 
            // allCameraPlacesLbl
            // 
            this.allCameraPlacesLbl.AutoSize = true;
            this.allCameraPlacesLbl.Location = new System.Drawing.Point(292, 223);
            this.allCameraPlacesLbl.Name = "allCameraPlacesLbl";
            this.allCameraPlacesLbl.Size = new System.Drawing.Size(122, 17);
            this.allCameraPlacesLbl.TabIndex = 6;
            this.allCameraPlacesLbl.Text = "All Camera Places";
            // 
            // allCameraPlacesCBox
            // 
            this.allCameraPlacesCBox.FormattingEnabled = true;
            this.allCameraPlacesCBox.Location = new System.Drawing.Point(446, 220);
            this.allCameraPlacesCBox.Name = "allCameraPlacesCBox";
            this.allCameraPlacesCBox.Size = new System.Drawing.Size(246, 24);
            this.allCameraPlacesCBox.TabIndex = 7;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(665, 374);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 28);
            this.logoutBtn.TabIndex = 8;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // physicalPlacesLbl
            // 
            this.physicalPlacesLbl.AutoSize = true;
            this.physicalPlacesLbl.Location = new System.Drawing.Point(292, 144);
            this.physicalPlacesLbl.Name = "physicalPlacesLbl";
            this.physicalPlacesLbl.Size = new System.Drawing.Size(106, 17);
            this.physicalPlacesLbl.TabIndex = 9;
            this.physicalPlacesLbl.Text = "Physical Places";
            // 
            // physicalPlacesCBox
            // 
            this.physicalPlacesCBox.FormattingEnabled = true;
            this.physicalPlacesCBox.Location = new System.Drawing.Point(446, 144);
            this.physicalPlacesCBox.Name = "physicalPlacesCBox";
            this.physicalPlacesCBox.Size = new System.Drawing.Size(246, 24);
            this.physicalPlacesCBox.TabIndex = 10;
            // 
            // IndexSecurity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.physicalPlacesCBox);
            this.Controls.Add(this.physicalPlacesLbl);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.allCameraPlacesCBox);
            this.Controls.Add(this.allCameraPlacesLbl);
            this.Controls.Add(this.typeLbl);
            this.Controls.Add(this.cameraPlaceLbl);
            this.Controls.Add(this.placeLbl);
            this.Controls.Add(this.cameraPlacesCBox);
            this.Controls.Add(this.nameLbl);
            this.Name = "IndexSecurity";
            this.Text = "Security";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.ComboBox cameraPlacesCBox;
        private System.Windows.Forms.Label placeLbl;
        private System.Windows.Forms.Label cameraPlaceLbl;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.ComboBox allCameraPlacesCBox;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label allCameraPlacesLbl;
        private System.Windows.Forms.Label physicalPlacesLbl;
        private System.Windows.Forms.ComboBox physicalPlacesCBox;
    }
}