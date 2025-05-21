namespace Kontakliste {
    public partial class Form1 : Form
    {
        Kontakt k;
        List<Kontakt> kontakte = new List<Kontakt>();
        List<TextBox> tb = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
            tb.Add(txtName);
            tb.Add(txtVname);
            tb.Add(txtEmail);
            tb.Add(txtPhone);
            tb.Add(txtStrasse);
            tb.Add(txtHausnr);
            tb.Add(txtPlz);
            tb.Add(txtStadt);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            readKontakt();
            kontakte.Add(k);
            lstKontakte.Items.Add(k.kontaktinfo());
            clearText();
        }

        void clearText()
        {
            foreach (var tb in this.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            lblWarning.Text = "";

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int index = lstKontakte.SelectedIndices[0];
            readKontakt();
            kontakte[index] = k;
            lstKontakte.Items[index] = k.kontaktinfo();
        }

        private void lstKontakte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] attributes = k.getAll();
            for(int i = 0; i< attributes.Length; i++)
            {
                tb[i].Text = attributes[i];
            }
        }

        private void readKontakt()
        {
            string temp = txtHausnr.Text;
            int h = 0; ; // Pars int??
            if (int.TryParse(temp, out h))
            {
            }
            else
            {
                lblWarning.Text = "Fehler bei der Hausnummer!";
                return;
            };
            k = new Kontakt(txtName.Text, txtVname.Text, txtEmail.Text, txtPhone.Text, txtStrasse.Text, h, txtPlz.Text, txtStadt.Text);
        }
    }
}
