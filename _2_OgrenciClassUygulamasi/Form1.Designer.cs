namespace _2_OgrenciClassUygulamasi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOdenecekMiktar = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.txtAranacak = new System.Windows.Forms.TextBox();
            this.cmbSinifi = new System.Windows.Forms.ComboBox();
            this.cmbKatildigiKurs = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnOgrGetir = new System.Windows.Forms.Button();
            this.btnAdaGoreAra = new System.Windows.Forms.Button();
            this.lsbOgrenciler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADI : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYADI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "NO :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SINIFI : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "KATILDIĞI KURS :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "ÖDENECEK MİKTAR:";
            // 
            // lblOdenecekMiktar
            // 
            this.lblOdenecekMiktar.AutoSize = true;
            this.lblOdenecekMiktar.Location = new System.Drawing.Point(159, 253);
            this.lblOdenecekMiktar.Name = "lblOdenecekMiktar";
            this.lblOdenecekMiktar.Size = new System.Drawing.Size(0, 13);
            this.lblOdenecekMiktar.TabIndex = 6;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(138, 15);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(121, 20);
            this.txtAdi.TabIndex = 7;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(138, 50);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(121, 20);
            this.txtSoyadi.TabIndex = 8;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(138, 88);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(121, 20);
            this.txtNo.TabIndex = 9;
            // 
            // txtAranacak
            // 
            this.txtAranacak.Location = new System.Drawing.Point(355, 206);
            this.txtAranacak.Name = "txtAranacak";
            this.txtAranacak.Size = new System.Drawing.Size(100, 20);
            this.txtAranacak.TabIndex = 10;
            // 
            // cmbSinifi
            // 
            this.cmbSinifi.FormattingEnabled = true;
            this.cmbSinifi.Items.AddRange(new object[] {
            "Yazılım Sınıfı",
            "Grafik Sınıfı",
            "Donanım Sınıfı",
            "Yapay Zeka Sınıfı"});
            this.cmbSinifi.Location = new System.Drawing.Point(138, 122);
            this.cmbSinifi.Name = "cmbSinifi";
            this.cmbSinifi.Size = new System.Drawing.Size(121, 21);
            this.cmbSinifi.TabIndex = 11;
            // 
            // cmbKatildigiKurs
            // 
            this.cmbKatildigiKurs.FormattingEnabled = true;
            this.cmbKatildigiKurs.Items.AddRange(new object[] {
            "Yazılım",
            "Grafik",
            "Web"});
            this.cmbKatildigiKurs.Location = new System.Drawing.Point(138, 161);
            this.cmbKatildigiKurs.Name = "cmbKatildigiKurs";
            this.cmbKatildigiKurs.Size = new System.Drawing.Size(121, 21);
            this.cmbKatildigiKurs.TabIndex = 12;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(103, 206);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 13;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(184, 207);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(113, 22);
            this.btnTemizle.TabIndex = 14;
            this.btnTemizle.Text = "FORMU TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnOgrGetir
            // 
            this.btnOgrGetir.Location = new System.Drawing.Point(294, 161);
            this.btnOgrGetir.Name = "btnOgrGetir";
            this.btnOgrGetir.Size = new System.Drawing.Size(147, 23);
            this.btnOgrGetir.TabIndex = 15;
            this.btnOgrGetir.Text = "ÖĞRENCİLERİ GETİR";
            this.btnOgrGetir.UseVisualStyleBackColor = true;
            this.btnOgrGetir.Click += new System.EventHandler(this.btnOgrGetir_Click);
            // 
            // btnAdaGoreAra
            // 
            this.btnAdaGoreAra.Location = new System.Drawing.Point(355, 232);
            this.btnAdaGoreAra.Name = "btnAdaGoreAra";
            this.btnAdaGoreAra.Size = new System.Drawing.Size(100, 22);
            this.btnAdaGoreAra.TabIndex = 16;
            this.btnAdaGoreAra.Text = "ADA GÖRE ARA";
            this.btnAdaGoreAra.UseVisualStyleBackColor = true;
            this.btnAdaGoreAra.Click += new System.EventHandler(this.btnAdaGoreAra_Click);
            // 
            // lsbOgrenciler
            // 
            this.lsbOgrenciler.FormattingEnabled = true;
            this.lsbOgrenciler.Location = new System.Drawing.Point(294, 9);
            this.lsbOgrenciler.Name = "lsbOgrenciler";
            this.lsbOgrenciler.Size = new System.Drawing.Size(217, 147);
            this.lsbOgrenciler.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 299);
            this.Controls.Add(this.lsbOgrenciler);
            this.Controls.Add(this.btnAdaGoreAra);
            this.Controls.Add(this.btnOgrGetir);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.cmbKatildigiKurs);
            this.Controls.Add(this.cmbSinifi);
            this.Controls.Add(this.txtAranacak);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.lblOdenecekMiktar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOdenecekMiktar;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.TextBox txtAranacak;
        private System.Windows.Forms.ComboBox cmbSinifi;
        private System.Windows.Forms.ComboBox cmbKatildigiKurs;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnOgrGetir;
        private System.Windows.Forms.Button btnAdaGoreAra;
        private System.Windows.Forms.ListBox lsbOgrenciler;
    }
}

