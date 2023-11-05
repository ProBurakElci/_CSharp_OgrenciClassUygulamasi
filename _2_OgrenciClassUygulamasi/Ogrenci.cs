using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OgrenciClassUygulamasi
{
    class Ogrenci
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int No { get; set; }
        public string Sinifi { get; set; }
        public int KatildigiKurs { get; set; }
        public double KursUcreti { get; private set; } // read only
        public Ogretmen Hocasi { get; set; }
        public Ogrenci() { }
        public Ogrenci(string isim, string soyisim, int no, string sinif)
        {
            // Class içerisinde, classa ait bir yapıyı ifade etmek için this kullanınız.
            this.Adi = isim;
            this.Soyadi = soyisim;
            this.No = no;
            this.Sinifi = sinif;
        }
        public void KursUcretiniHesapla()
        {
            switch (this.KatildigiKurs)
            {
                case 0: // YAZILIM
                    this.KursUcreti = 2000;
                    break;
                case 1: // GRAFİK
                    this.KursUcreti = 1500;
                    break;
                case 2: // WEB
                    this.KursUcreti = 1000;
                    break;
            }

        } }}
