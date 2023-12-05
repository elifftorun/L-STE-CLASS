using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace liste_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Ogrenci ogrenci;
        private void Form1_Load(object sender, EventArgs e)
        {
            List<Ogrenci> ogrenciListesi = new List<Ogrenci>();

            ogrenciListesi.Add(new Ogrenci(26, "Elif Torun", "10A", "75934756978"));
            ogrenciListesi.Add(new Ogrenci(44,"Kevser Ramazanoğlu","10A","055087424455"));
            ogrenciListesi.Add(new Ogrenci(321,"Göknur Duran", "10A", "7635962476"));
            ogrenciListesi.Add(new Ogrenci(1544,"Rukiye Balı", "10A", "823087424455"));
            ogrenciListesi.Add(new Ogrenci(822,"HiraNur Kulakçı", "10A", "764343562476"));
            ogrenciListesi.Add(new Ogrenci(240,"Sedef Şirin", "10A", "7633462476"));

            dataGridView1.DataSource = ogrenciListesi.ToList();



        }
    }
}
