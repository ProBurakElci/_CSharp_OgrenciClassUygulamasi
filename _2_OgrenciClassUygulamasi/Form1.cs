using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_OgrenciClassUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ogrencilerList = new ArrayList();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();
            ogr.Adi = txtAdi.Text;
            ogr.Soyadi = txtSoyadi.Text;
            ogr.No = int.Parse(txtNo.Text);
            ogr.Sinifi = cmbSinifi.SelectedItem.ToString();
            ogr.KatildigiKurs = cmbKatildigiKurs.SelectedIndex;
            ogr.KursUcretiniHesapla();
            lblOdenecekMiktar.Text = ogr.KursUcreti + "";
            ogr.Hocasi = ogrt;            ogrencilerList.Add(ogr);        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    (ctrl as ComboBox).Text = "";
                }
                else if (ctrl.Name == "lblOdenecekMiktar")
                {
                    ((Label)ctrl).Text = "";
                }
            }
        }

        private void btnOgrGetir_Click(object sender, EventArgs e)
        {
            foreach (object ogrenci in ogrencilerList)
            {
                //Ogrenci ogr = ogrenci as Ogrenci;
                //lsbOgrenciler.Items.Add(ogr.Adi + " - " + ogr.KursUcreti);
                //lsbOgrenciler.Items.Add(ogr);
                //------------------------------------------------------
                lsbOgrenciler.Items.Add((ogrenci as Ogrenci).No + " - " + (ogrenci as
               Ogrenci).KursUcreti + " Hocası : " + (ogrenci as Ogrenci).Hocasi.Bransi);
            }
        }
        string aranacakIsim;

        private void btnAdaGoreAra_Click(object sender, EventArgs e)
        {
            aranacakIsim = txtAranacak.Text;
            foreach (object item in ogrencilerList)
            {
                if ((item as Ogrenci).Adi == aranacakIsim)
                {
                    lsbOgrenciler.Items.Add((item as Ogrenci).KursUcreti);
                }
            }

            }
        Ogretmen ogrt;

        private void Form1_Load(object sender, EventArgs e)
        {
            ogrt = new Ogretmen();
            ogrt.Adi = "Şükran";
            ogrt.Bransi = "Bilgisayar";
        }
    }
}
