namespace Kontakliste
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstKontakte = new ListBox();
            btnAdd = new Button();
            lblName = new Label();
            lblStadt = new Label();
            lblPlz = new Label();
            lblHausnummer = new Label();
            lblStreet = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblVname = new Label();
            txtName = new TextBox();
            txtStadt = new TextBox();
            txtPlz = new TextBox();
            txtHausnr = new TextBox();
            txtStrasse = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtVname = new TextBox();
            btnUpdate = new Button();
            lblWarning = new Label();
            SuspendLayout();
            // 
            // lstKontakte
            // 
            lstKontakte.FormattingEnabled = true;
            lstKontakte.ItemHeight = 15;
            lstKontakte.Location = new Point(553, 74);
            lstKontakte.Name = "lstKontakte";
            lstKontakte.Size = new Size(199, 319);
            lstKontakte.TabIndex = 0;
            lstKontakte.SelectedIndexChanged += lstKontakte_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(128, 465);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 37);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Hinzufuegen";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(128, 51);
            lblName.Name = "lblName";
            lblName.Size = new Size(55, 21);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblStadt
            // 
            lblStadt.AutoSize = true;
            lblStadt.Font = new Font("Segoe UI", 12F);
            lblStadt.Location = new Point(128, 386);
            lblStadt.Name = "lblStadt";
            lblStadt.Size = new Size(48, 21);
            lblStadt.TabIndex = 3;
            lblStadt.Text = "Stadt:";
            // 
            // lblPlz
            // 
            lblPlz.AutoSize = true;
            lblPlz.Font = new Font("Segoe UI", 12F);
            lblPlz.Location = new Point(128, 331);
            lblPlz.Name = "lblPlz";
            lblPlz.Size = new Size(39, 21);
            lblPlz.TabIndex = 4;
            lblPlz.Text = "PLZ:";
            // 
            // lblHausnummer
            // 
            lblHausnummer.AutoSize = true;
            lblHausnummer.Font = new Font("Segoe UI", 12F);
            lblHausnummer.Location = new Point(128, 286);
            lblHausnummer.Name = "lblHausnummer";
            lblHausnummer.Size = new Size(105, 21);
            lblHausnummer.TabIndex = 5;
            lblHausnummer.Text = "Hausnummer";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.Font = new Font("Segoe UI", 12F);
            lblStreet.Location = new Point(128, 229);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(62, 21);
            lblStreet.TabIndex = 6;
            lblStreet.Text = "Strasse:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F);
            lblPhone.Location = new Point(128, 189);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(73, 21);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "Handynr:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(128, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // lblVname
            // 
            lblVname.AutoSize = true;
            lblVname.Font = new Font("Segoe UI", 12F);
            lblVname.Location = new Point(128, 100);
            lblVname.Name = "lblVname";
            lblVname.Size = new Size(76, 21);
            lblVname.TabIndex = 9;
            lblVname.Text = "Vorname:";
            // 
            // txtName
            // 
            txtName.Location = new Point(228, 53);
            txtName.Name = "txtName";
            txtName.Size = new Size(202, 23);
            txtName.TabIndex = 10;
            // 
            // txtStadt
            // 
            txtStadt.Location = new Point(228, 388);
            txtStadt.Name = "txtStadt";
            txtStadt.Size = new Size(100, 23);
            txtStadt.TabIndex = 17;
            // 
            // txtPlz
            // 
            txtPlz.Location = new Point(228, 333);
            txtPlz.Name = "txtPlz";
            txtPlz.Size = new Size(100, 23);
            txtPlz.TabIndex = 16;
            // 
            // txtHausnr
            // 
            txtHausnr.Location = new Point(228, 288);
            txtHausnr.Name = "txtHausnr";
            txtHausnr.Size = new Size(100, 23);
            txtHausnr.TabIndex = 15;
            // 
            // txtStrasse
            // 
            txtStrasse.Location = new Point(228, 231);
            txtStrasse.Name = "txtStrasse";
            txtStrasse.Size = new Size(100, 23);
            txtStrasse.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(228, 191);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(100, 23);
            txtPhone.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(228, 147);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtVname
            // 
            txtVname.Location = new Point(228, 102);
            txtVname.Name = "txtVname";
            txtVname.Size = new Size(100, 23);
            txtVname.TabIndex = 11;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(300, 465);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 37);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Bearbeiten";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblWarning
            // 
            lblWarning.AutoSize = true;
            lblWarning.Font = new Font("Segoe UI", 14F);
            lblWarning.ForeColor = Color.Crimson;
            lblWarning.Location = new Point(311, 13);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(0, 25);
            lblWarning.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 576);
            Controls.Add(lblWarning);
            Controls.Add(btnUpdate);
            Controls.Add(txtVname);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtStrasse);
            Controls.Add(txtHausnr);
            Controls.Add(txtPlz);
            Controls.Add(txtStadt);
            Controls.Add(txtName);
            Controls.Add(lblVname);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblStreet);
            Controls.Add(lblHausnummer);
            Controls.Add(lblPlz);
            Controls.Add(lblStadt);
            Controls.Add(lblName);
            Controls.Add(btnAdd);
            Controls.Add(lstKontakte);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstKontakte;
        private Button btnAdd;
        private Label lblName;
        private Label lblStadt;
        private Label lblPlz;
        private Label lblHausnummer;
        private Label lblStreet;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblVname;
        private TextBox txtName;
        private TextBox txtStadt;
        private TextBox txtPlz;
        private TextBox txtHausnr;
        private TextBox txtStrasse;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtVname;
        private Button btnUpdate;
        private Label lblWarning;
    }
}
