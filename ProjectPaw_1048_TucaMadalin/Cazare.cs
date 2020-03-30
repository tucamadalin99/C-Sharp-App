using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW_Tuca_Madalin_1048
{
    class Cazare : ICloneable, IComparable, IPretMediu
    {
        private string locatie;
        private int nrZile;
        private string denumire;
        private int nrCamera;
        private string tipCamera;
        private double[] preturi;
        private double pretMediu;
        private int id;
        public static int contor = 0;

        public Cazare()
        {
            locatie = "N/a";
            nrZile = 0;
            denumire = "N/a";
            nrCamera = 0;
            tipCamera = "Default";
            preturi = null;
            pretMediu = 0.0f;
            id = (contor++);
        }

        public Cazare(string l, int nrZ, string den, int nrC, string tipC, double[] p, double pM)
        {
            locatie = l;
            nrZile = nrZ;
            denumire = den;
            nrCamera = nrC;
            tipCamera = tipC;
            preturi = p;
            pretMediu = pM;
            id = (contor++);
        }

        public string Locatie
        {
            get { return locatie; }
            set
            {
                if (value != null)
                    locatie = value;
            }
        }

        public int NrZile
        {
            get { return nrZile; }
            set
            {
                if (value >= 0)
                    nrZile = value;
            }
        }

        public string Denumire
        {
            get { return denumire; }
            set
            {
                if (value != null)
                    denumire = value;
            }
        }

        public int NrCamera
        {
            get { return nrCamera; }
            set
            {
                if (value >= 0)
                    nrCamera = value;
            }
        }

        public double PretMediu
        {
            get { return pretMediu; }
            set
            {
                if (value >= 0)
                    pretMediu = value;
            }
        }


        public double[] Preturi
        {
            get { return preturi; }
            set
            {
                for (int i = 0; i < this.nrCamera; i++)
                    if(value[i] >= 0)
                    this.preturi[i] = value[i];
            }
        }

        public Object Clone()
        {
            return (Cazare)this.MemberwiseClone();
        }

        public int CompareTo(Object obj)
        {
            Cazare c = (Cazare)obj;
            if (this.pretMediu < c.pretMediu)
                return 1;
            else if (this.pretMediu > c.pretMediu)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            string result = "Locatia: " + locatie + "\n" + "Denumire: " + denumire + "\n"
                + "Numar zile: " + nrZile + "\n" + "Numarul camerelor: " + nrCamera + "\n"
                + "Tip camera: " + tipCamera + "\n" + "Pret mediu: " + pretMediu + "\nPreturi: "
                + String.Join(", ", preturi.Select(p => p.ToString()).ToArray());
            
            return result;
           
        }

        public static explicit operator double(Cazare c)
        {
            if (c.preturi != null)
            {
                double sum = 0.0f;
                for (int i = 0; i < c.nrCamera; i++)
                    sum += c.preturi[i];
                return (double)sum / c.nrCamera;

            }
            else return 0;
        }

        public double calcPretMediu()
        {
            return (double)this;
        }

        public static Cazare operator+(Cazare c, double pret)
        {
            double[] preturiNoi = new double[c.preturi.Length + 1];
            c.nrCamera++;
            for(int i = 0; i < c.preturi.Length; i++)
            {
                preturiNoi[i] = c.preturi[i];
            }
            preturiNoi[c.preturi.Length] = pret;
            c.preturi = preturiNoi;
            return c;
        }


    }
}
