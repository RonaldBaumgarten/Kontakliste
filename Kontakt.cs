using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakliste
{
    public class Kontakt
    {
        private string name;
        private string vorname;
        private string email;
        private string handynummer;
        private string strasse;
        private int hausnummer;
        private string postleitzahl;
        private string stadt;

        public string Name { get => name; set => name = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Email { get => email; set => email = value; }
        public string Handynummer { get => handynummer; set => handynummer = value; }
        public string Strasse { get => strasse; set => strasse = value; }
        public int Hausnummer { get => hausnummer; set => hausnummer = value; }
        public string Postleitzahl { get => postleitzahl; set => postleitzahl = value; }
        public string Stadt { get => stadt; set => stadt = value; }

        public Kontakt(string name, string vorname, string email, string handynummer, string strasse, int hausnummer, string postleitzahl, string stadt)
        {
            this.name = name;
            this.vorname = vorname;
            this.email = email;
            this.handynummer = handynummer;
            this.strasse = strasse;
            this.hausnummer = hausnummer;
            this.postleitzahl = postleitzahl;
            this.stadt = stadt;
        }

        public string kontaktinfo()
        {
            return "(" + Vorname + ", " + Name + ")";
        }

        public string[] getAll()
        {
            int nrOfAttributes = this.GetType().GetProperties().Length;
            string[] all = new string[nrOfAttributes];
            all[0] = name;
            all[1] = vorname;
            all[2] = email;
            all[3] = handynummer;
            all[4] = strasse;
            all[5] = hausnummer.ToString();
            all[6] = postleitzahl;
            all[7] = stadt;

            return all;
        }
    }

}
