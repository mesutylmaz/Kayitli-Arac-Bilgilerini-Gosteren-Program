using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Örnek_1
{
    public class Arabalar
    {
        public string Marka { get; set; }

        public string Renk { get; set; }

        public string Model { get; set; }

        public string UretimYili { get; set; }

        public string ÖzellikleriYazdir()
        {

            return "Markası: " + Marka + "\nModeli: " + Model + "\nRengi: " + Renk + "\nÜretim Yılı: " + UretimYili;
        }
        public override string ToString()
        {
            return Marka + "-" + Model;
        }
    }
}
