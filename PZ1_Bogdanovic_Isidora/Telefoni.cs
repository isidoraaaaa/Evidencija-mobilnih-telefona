using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ1_Bogdanovic_Isidora
{
    [Serializable]
   public class Telefoni
    {
        private string slika_telefona; //slika uredjaja
        private string IMEI; //jedinstvena oznaka telefona
        private string model_telefona; //model telefona
        private string datum_izlaska_telefona; //datum izlaska telefona
        private string interna_memorija; //interna memorija telefona, Gb ili Mb
        private int tip_sim; //Dual ili single SIM tip
        private string RTF_IME; //polje za referenciranje RTB-a

        public Telefoni() { }

        public Telefoni(string slika_telefona, string iMEI, string model_telefona, string datum_izlaska_telefona, string interna_memorija, int tip_sim, string rTF_IME)
        {
            Slika_telefona = slika_telefona;
            IMEI1 = iMEI;
            Model_telefona = model_telefona;
            Datum_izlaska_telefona = datum_izlaska_telefona;
            Interna_memorija = interna_memorija;
            Tip_sim = tip_sim;
            RTF_IME1 = rTF_IME;
        }

        public string Slika_telefona { get => slika_telefona; set => slika_telefona = value; }
        public string IMEI1 { get => IMEI; set => IMEI = value; }
        public string Model_telefona { get => model_telefona; set => model_telefona = value; }
        public string Datum_izlaska_telefona { get => datum_izlaska_telefona; set => datum_izlaska_telefona = value; }
        public string Interna_memorija { get => interna_memorija; set => interna_memorija = value; }
        public int Tip_sim { get => tip_sim; set => tip_sim = value; }
        public string RTF_IME1 { get => RTF_IME; set => RTF_IME = value; }
    }
}
