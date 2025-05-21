using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontakliste
{
    public class Datei
    {
        private string datei;
        private FileStream stream;

        public Datei(string d)
        {
            datei = d;
        }

        public Datei()
        {
            datei = @"C:\Users\tn\source\kontaktliste.txt";
        }

        public void schreibeCSV(List<Kontakt> liKon)
        {
            stream = new FileStream(datei, FileMode.Create, FileAccess.Write);
            StreamWriter sr = new StreamWriter(stream);

            foreach (Kontakt k in liKon)
            {
                sr.WriteLine(k.toCSV());
            }

            sr.Close();
            stream.Close();

        }
        public List<Kontakt> liesCSV()
        {
            List<Kontakt> liKon = new List<Kontakt>();
            string s;
            string[] arrstr;
            stream = 
                new FileStream(datei, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(stream);

            while( sr.Peek() != -1 )
            {
                s = sr.ReadLine();
                arrstr = s.Split(';');
                liKon.Add(
                    new Kontakt(arrstr[0], arrstr[1],
                                arrstr[2], arrstr[3], 
                                arrstr[4], int.Parse(arrstr[5]),
                                arrstr[6], arrstr[7] ) );
            }

            sr.Close();
            stream.Close();

            return liKon;
        }
    }
}
