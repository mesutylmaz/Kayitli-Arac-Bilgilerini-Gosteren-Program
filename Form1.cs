using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Örnek_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Arabalar a1 = new Arabalar()
            {
                Marka = "Mercedes",
                Model = "A180",
                Renk = "Siyah",
                UretimYili = "2010"
            };

            Arabalar a2 = new Arabalar()
            {
                Marka = "Ferrari",
                Model = "B180",
                Renk = "Mavi",
                UretimYili = "2013"
            };

            Arabalar a3 = new Arabalar();
            a3.Marka = "Bugatti";
            a3.Model = "C180";
            a3.Renk = "Beyaz";
            a3.UretimYili = "2019";

            Arabalar a4 = new Arabalar()
            {
                Marka = "Tesla",
                Model = "D180",
                Renk = "Gri",
                UretimYili = "2020"
            };

            lbxArabalar.Items.Add(a1);
            lbxArabalar.Items.Add(a2);
            lbxArabalar.Items.Add(a3);
            lbxArabalar.Items.Add(a4);
        }

        private void lbxArabalar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Arabalar araba = lbxArabalar.SelectedItem as Arabalar;
            lblGoruntule.Text = araba.ÖzellikleriYazdir();
        }
    }
}
