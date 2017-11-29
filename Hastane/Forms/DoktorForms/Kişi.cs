using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Forms.DoktorForms
{

    public enum cinsiyet {Kadın,Erkek}

    public enum kan_grubu {Sıfır_pozitif,Sıfır_negatif,A_pozitif,A_negatif,B_pozitif,B_negatif,AB_pozitif,AB_negatif}

    public enum unvan {Pratisyen, Aile_Hekimi, Uzman }

    public enum birim {Dahiliye,Kalp_cerrahisi,Cocuk_doktoru,Kadın_doğum }

    public class Kişi
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string TCKN { get; set; }
        public DateTime D_tarihi { get; set; }
        public string maas { get; set; }

    }
}
