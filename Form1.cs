using System.Runtime.CompilerServices;
using System.IO;

namespace Kontakliste {
    public partial class Form1 : Form
    {
        Kontakt k;
        List<Kontakt> kontakte = new List<Kontakt>();
        List<TextBox> textBoxes = new List<TextBox>();
        public Form1()
        {
            InitializeComponent();
            foreach (var tb in this.Controls.OfType<TextBox>())
            {
                textBoxes.Add(tb);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            readKontakt();
            kontakte.Add(k);
            lstKontakte.Items.Add(k.kontaktinfo());
            clearText();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            int index = lstKontakte.SelectedIndices[0];
            readKontakt();
            kontakte[index] = k;
            //lstKontakte.Items[index] = k.kontaktinfo();
            updateList();
            clearText();
        }

        private void lstKontakte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ausgewaehlterIndex = lstKontakte.SelectedIndices[0];
            k = kontakte[ausgewaehlterIndex];

            string[] attributes = k.getAll();
            for (int i = 0; i < attributes.Length; i++)
            {
                textBoxes[i].Text = attributes[i];
            }
        }

        void clearText()
        {
            foreach (var tb in this.Controls.OfType<TextBox>())
            {
                tb.Clear();
            }
            lblWarning.Text = "";
        }

        private void updateList()
        {
            lstKontakte.Items.Clear();
            foreach (Kontakt ko in kontakte)
            {
                lstKontakte.Items.Add(ko.kontaktinfo());
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
                /*
                lblWarning.Text = "Fehler bei der Hausnummer!";
                return;
                */
                h = 0;
            };
            k = new Kontakt(txtName.Text, txtVname.Text, txtEmail.Text, txtPhone.Text, txtStrasse.Text, h, txtPlz.Text, txtStadt.Text);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            Datei d = new Datei();
            d.schreibeCSV(kontakte);
        }
    }
} 