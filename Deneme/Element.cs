using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Element : Form
    {
        public string[] Elementler = { "Hidrojen", "Helyum", "Lityum", "Berilyum", "Bor", "Karbon", "Azot", "Oksijen", "Flor", "Neon", "Sodyum", "Magnezyum", "Aliminyum", "Silisyum", "Fosfor", "Kükürt", "Klor", "Argon", "potasyum", "Kalsiyum" };
        public string[] Elementsembolleri = { "H", "He", "Li", "Be", "B", "C", "N", "O", "F", "Ne", "Na", "Mg", "Al", "Si", "P", "S", "Cl", "Ar", "K", "Ca" };
        Random random = new Random();
        int i;
        int skor = 0;
        public Element()
        {
            InitializeComponent();
            int rs = random.Next(0, 20);
            int rs2 = random.Next(0, 2);
            int rs3 = random.Next(0, 20);
            int rs4 = random.Next(0, 20);
            label1.Text = Elementler[rs] + " elementinin sembolünü giriniz";
            
            if (rs2 == 0)
            {
                button1.Text = Elementsembolleri[rs];
                button2.Text = Elementsembolleri[rs3];
                if (button1.Text == button2.Text)
                {
                    button2.Text = Elementsembolleri[rs4];
                }
                i = 1;
            }
            if (rs2 == 1)
            {
                button2.Text = Elementsembolleri[rs];
                button1.Text = Elementsembolleri[rs3];
                i = 2;
                if (button1.Text == button2.Text)
                {
                    button1.Text = Elementsembolleri[rs4];
                }
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                skor = skor + 10;
                MessageBox.Show("skorunuz :" + skor, "Doğru Cevap");
                if (button1.Text == "H")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 1'dir." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Doğada Diatomik olarak bulunur." + Environment.NewLine + "Yanıcıdır", "Hidrojen Elementi hakkında bilgiler:");
                }
                if (button1.Text == "He")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 2'dir." + Environment.NewLine + "Soygazdır" + Environment.NewLine + "Tepkimeye girmez." + Environment.NewLine + "Yoğunluğu havadan hafif olduğu için uçan balonlarda kullanılır.", "Helyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Li")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 3'dür." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Yoğunluğu en düşük olan metaldir." + Environment.NewLine + "Doğada saf halde bulunmaz", "Lityum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Be")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 4'tür." + Environment.NewLine + "Toprak alkali grubundan elementtir.", "Berilyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "B")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 5'tir." + Environment.NewLine + "Yarımetaldir." + Environment.NewLine + "Yarı iletkendir." + Environment.NewLine + "Kaynak olarak en fazla Türkiye'de bulunur.", "Bor Elementi hakkında bilgiler:");
                }
                if (button1.Text == "C")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 6'dır." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Tüm elementler içerisinde karbon en yüksek erime noktasına sahip olan elementtir.", "Karbon Elementi hakkında bilgiler:");
                }
                if (button1.Text == "N")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 7'dir." + Environment.NewLine + "Toprak ametaller grubunda yer alır." + Environment.NewLine + "Dünya atmosferinin yaklaşık 78%'sini oluşturur.", "Azot Elementi hakkında bilgiler:");
                }
                if (button1.Text == "O")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 8'dir." + Environment.NewLine + "ametaldir." + Environment.NewLine + "Yakıcıdır.", "Oksijen Elementi hakkında bilgiler:");
                }
                if (button1.Text == "F")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 9'dur." + Environment.NewLine + "Halojendir." + Environment.NewLine + "Vücuda eksik alınırsa diş çürüğüne sebep olur.", "Flor Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Ne")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 10'dur." + Environment.NewLine + "Soygazdır." + Environment.NewLine + "Hiçbir madde ile tepkimeye girmez." + Environment.NewLine + "Reklam panolarında kullanılır.", "Neon Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Na")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 11'dir." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Sinir ve Kas sisteminin çalışmasını sağlar.", "Sodyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Mg")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 12'dir." + Environment.NewLine + "Toprak alkali metaldir." + Environment.NewLine + "Klorofilin yapısına katılır.", "Magnezyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Al")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 13'tür." + Environment.NewLine + "Metaldir." + Environment.NewLine + " Kolaylıkla dövülebilir, makinede işlenebilir ve dökülebilir.", "Aliminyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Si")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 14'tür." + Environment.NewLine + "Yarımetaldir." + Environment.NewLine + "Çok sert bir elementtir.", "Silisyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "P")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 15'dir." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Kemik ve diş oluşumunda görev alır.", "Fosfor Elementi hakkında bilgiler:");
                }
                if (button1.Text == "S")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 16'dır." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Yanıcı ve patlayıcıdır.", "Kükürt Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Cl")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 17'dir." + Environment.NewLine + "Halojendir." + Environment.NewLine + "Su arıtımında kullanılır." + Environment.NewLine + "Sudda çözünebilir.", "Klor Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Ar")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 18'dir." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Renksiz,kokusuz,zehirsiz bir gazdır.", "Argon Elementi hakkında bilgiler:");
                }
                if (button1.Text == "K")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 19'dur." + Environment.NewLine 
                    + "Alkali metaldir." + Environment.NewLine + "Vücuda yeterli miktarda " +
                    "alınmazsa kaslarda kramp,kalp ritminde bozukluk,yorgunluk görülür.", "Potasyum " +
                    "Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Ca")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 20'dir." + Environment.NewLine + "Toprak alkali metaldir." + Environment.NewLine + "Kemik ve dişlerin yapısına katılır.", "Kalsiyum Elementi hakkında bilgiler:");
                }
            }
            else
            {
                skor = skor - 30;
                MessageBox.Show("skorunuz :" + skor, "Yanlış Cevap");
                if (button1.Text == "H")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 1'dir." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Doğada Diatomik olarak bulunur." + Environment.NewLine + "Yanıcıdır", "Hidrojen Elementi hakkında bilgiler:");
                }
                if (button1.Text == "He")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 2'dir." + Environment.NewLine + "Soygazdır" + Environment.NewLine + "Tepkimeye girmez." + Environment.NewLine + "Yoğunluğu havadan hafif olduğu için uçan balonlarda kullanılır.", "Helyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Li")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 3'dür." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Yoğunluğu en düşük olan metaldir." + Environment.NewLine + "Doğada saf halde bulunmaz", "Lityum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Be")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 4'tür." + Environment.NewLine + "Toprak alkali grubundan elementtir.", "Berilyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "B")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 5'tir." + Environment.NewLine + "Yarımetaldir." + Environment.NewLine + "Yarı iletkendir." + Environment.NewLine + "Kaynak olarak en fazla Türkiye'de bulunur.", "Bor Elementi hakkında bilgiler:");
                }
                if (button1.Text == "C")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 6'dır." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Tüm elementler içerisinde karbon en yüksek erime noktasına sahip olan elementtir.", "Karbon Elementi hakkında bilgiler:");
                }
                if (button1.Text == "N")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 7'dir." + Environment.NewLine + "Toprak ametaller grubunda yer alır." + Environment.NewLine + "Dünya atmosferinin yaklaşık 78%'sini oluşturur.", "Azot Elementi hakkında bilgiler:");
                }
                if (button1.Text == "O")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 8'dir." + Environment.NewLine + "ametaldir." + Environment.NewLine + "Yakıcıdır.", "Oksijen Elementi hakkında bilgiler:");
                }
                if (button1.Text == "F")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 9'dur." + Environment.NewLine + "Halojendir." + Environment.NewLine + "Vücuda eksik alınırsa diş çürüğüne sebep olur.", "Flor Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Ne")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 10'dur." + Environment.NewLine + "Soygazdır." + Environment.NewLine + "Hiçbir madde ile tepkimeye girmez." + Environment.NewLine + "Reklam panolarında kullanılır.", "Neon Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Na")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 11'dir." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Sinir ve Kas sisteminin çalışmasını sağlar.", "Sodyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Mg")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 12'dir." + Environment.NewLine + "Toprak alkali metaldir." + Environment.NewLine + "Klorofilin yapısına katılır.", "Magnezyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Al")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 13'tür." + Environment.NewLine + "Metaldir." + Environment.NewLine + " Kolaylıkla dövülebilir, makinede işlenebilir ve dökülebilir.", "Aliminyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Si")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 14'tür." + Environment.NewLine + "Yarımetaldir." + Environment.NewLine + "Çok sert bir elementtir.", "Silisyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "P")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 15'dir." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Kemik ve diş oluşumunda görev alır.", "Fosfor Elementi hakkında bilgiler:");
                }
                if (button1.Text == "S")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 16'dır." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Yanıcı ve patlayıcıdır.", "Kükürt Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Cl")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 17'dir." + Environment.NewLine + "Halojendir." + Environment.NewLine + "Su arıtımında kullanılır." + Environment.NewLine + "Sudda çözünebilir.", "Klor Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Ar")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 18'dir." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Renksiz,kokusuz,zehirsiz bir gazdır.", "Argon Elementi hakkında bilgiler:");
                }
                if (button1.Text == "K")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 19'dur." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Vücuda yeterli miktarda alınmazsa kaslarda kramp,kalp ritminde bozukluk,yorgunluk görülür.", "Potasyum Elementi hakkında bilgiler:");
                }
                if (button1.Text == "Ca")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 20'dir." + Environment.NewLine + "Toprak alkali metaldir." + Environment.NewLine + "Kemik ve dişlerin yapısına katılır.", "Kalsiyum Elementi hakkında bilgiler:");
                }
            }
            int rs = random.Next(0, 20);
            int rs2 = random.Next(0, 2);
            int rs3 = random.Next(0, 20);
            int rs4 = random.Next(0, 20);
            label1.Text = Elementler[rs] + " elementinin sembolünü giriniz";

            if (rs2 == 0)
            {
                button1.Text = Elementsembolleri[rs];
                button2.Text = Elementsembolleri[rs3];
                if (button1.Text == button2.Text)
                {
                    button2.Text = Elementsembolleri[rs4];
                }
                i = 1;
            }
            if (rs2 == 1)
            {
                button2.Text = Elementsembolleri[rs];
                button1.Text = Elementsembolleri[rs3];
                i = 2;
                if (button1.Text == button2.Text)
                {
                    button1.Text = Elementsembolleri[rs4];
                }
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 2)
            {
                skor = skor + 10;
                MessageBox.Show("skorunuz :" + skor, "Doğru Cevap");
                if (button2.Text == "H")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 1'dir." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Doğada Diatomik olarak bulunur." + Environment.NewLine + "Yanıcıdır", "Hidrojen Elementi hakkında bilgiler:");
                }
                if (button2.Text == "He")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 2'dir." + Environment.NewLine + "Soygazdır" + Environment.NewLine + "Tepkimeye girmez." + Environment.NewLine + "Yoğunluğu havadan hafif olduğu için uçan balonlarda kullanılır.", "Helyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Li")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 3'dür." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Yoğunluğu en düşük olan metaldir." + Environment.NewLine + "Doğada saf halde bulunmaz", "Lityum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Be")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 4'tür." + Environment.NewLine + "Toprak alkali grubundan elementtir.", "Berilyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "B")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 5'tir." + Environment.NewLine + "Yarımetaldir." + Environment.NewLine + "Yarı iletkendir." + Environment.NewLine + "Kaynak olarak en fazla Türkiye'de bulunur.", "Bor Elementi hakkında bilgiler:");
                }
                if (button2.Text == "C")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 6'dır." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Tüm elementler içerisinde karbon en yüksek erime noktasına sahip olan elementtir.", "Karbon Elementi hakkında bilgiler:");
                }
                if (button2.Text == "N")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 7'dir." + Environment.NewLine + "Toprak ametaller grubunda yer alır." + Environment.NewLine + "Dünya atmosferinin yaklaşık 78%'sini oluşturur.", "Azot Elementi hakkında bilgiler:");
                }
                if (button2.Text == "O")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 8'dir." + Environment.NewLine + "ametaldir." + Environment.NewLine + "Yakıcıdır.", "Oksijen Elementi hakkında bilgiler:");
                }
                if (button2.Text == "F")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 9'dur." + Environment.NewLine + "Halojendir." + Environment.NewLine + "Vücuda eksik alınırsa diş çürüğüne sebep olur.", "Flor Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Ne")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 10'dur." + Environment.NewLine + "Soygazdır." + Environment.NewLine + "Hiçbir madde ile tepkimeye girmez." + Environment.NewLine + "Reklam panolarında kullanılır.", "Neon Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Na")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 11'dir." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Sinir ve Kas sisteminin çalışmasını sağlar.", "Sodyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Mg")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 12'dir." + Environment.NewLine + "Toprak alkali metaldir." + Environment.NewLine + "Klorofilin yapısına katılır.", "Magnezyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Al")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 13'tür." + Environment.NewLine + "Metaldir." + Environment.NewLine + " Kolaylıkla dövülebilir, makinede işlenebilir ve dökülebilir.", "Aliminyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Si")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 14'tür." + Environment.NewLine + "Yarımetaldir." + Environment.NewLine + "Çok sert bir elementtir.", "Silisyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "P")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 15'dir." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Kemik ve diş oluşumunda görev alır.", "Fosfor Elementi hakkında bilgiler:");
                }
                if (button2.Text == "S")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 16'dır." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Yanıcı ve patlayıcıdır.", "Kükürt Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Cl")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 17'dir." + Environment.NewLine + "Halojendir." + Environment.NewLine + "Su arıtımında kullanılır." + Environment.NewLine + "Sudda çözünebilir.", "Klor Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Ar")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 18'dir." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Renksiz,kokusuz,zehirsiz bir gazdır.", "Argon Elementi hakkında bilgiler:");
                }
                if (button2.Text == "K")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 19'dur." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Vücuda yeterli miktarda alınmazsa kaslarda kramp,kalp ritminde bozukluk,yorgunluk görülür.", "Potasyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Ca")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 20'dir." + Environment.NewLine + "Toprak alkali metaldir." + Environment.NewLine + "Kemik ve dişlerin yapısına katılır.", "Kalsiyum Elementi hakkında bilgiler:");
                }

            }
            else
            {
                skor = skor - 30;
                MessageBox.Show("skorunuz :" + skor, "Yanlış Cevap");
                if (button2.Text == "H")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 1'dir." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Doğada Diatomik olarak bulunur." + Environment.NewLine + "Yanıcıdır", "Hidrojen Elementi hakkında bilgiler:");
                }
                if (button2.Text == "He")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 2'dir." + Environment.NewLine + "Soygazdır" + Environment.NewLine + "Tepkimeye girmez." + Environment.NewLine + "Yoğunluğu havadan hafif olduğu için uçan balonlarda kullanılır.", "Helyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Li")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 3'dür." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Yoğunluğu en düşük olan metaldir." + Environment.NewLine + "Doğada saf halde bulunmaz", "Lityum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Be")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 4'tür." + Environment.NewLine + "Toprak alkali grubundan elementtir.", "Berilyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "B")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 5'tir." + Environment.NewLine + "Yarımetaldir." + Environment.NewLine + "Yarı iletkendir." + Environment.NewLine + "Kaynak olarak en fazla Türkiye'de bulunur.", "Bor Elementi hakkında bilgiler:");
                }
                if (button2.Text == "C")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 6'dır." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Tüm elementler içerisinde karbon en yüksek erime noktasına sahip olan elementtir.", "Karbon Elementi hakkında bilgiler:");
                }
                if (button2.Text == "N")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 7'dir." + Environment.NewLine + "Toprak ametaller grubunda yer alır." + Environment.NewLine + "Dünya atmosferinin yaklaşık 78%'sini oluşturur.", "Azot Elementi hakkında bilgiler:");
                }
                if (button2.Text == "O")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 8'dir." + Environment.NewLine + "ametaldir." + Environment.NewLine + "Yakıcıdır.", "Oksijen Elementi hakkında bilgiler:");
                }
                if (button2.Text == "F")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 9'dur." + Environment.NewLine + "Halojendir." + Environment.NewLine + "Vücuda eksik alınırsa diş çürüğüne sebep olur.", "Flor Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Ne")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 10'dur." + Environment.NewLine + "Soygazdır." + Environment.NewLine + "Hiçbir madde ile tepkimeye girmez." + Environment.NewLine + "Reklam panolarında kullanılır.", "Neon Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Na")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 11'dir." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Sinir ve Kas sisteminin çalışmasını sağlar.", "Sodyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Mg")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 12'dir." + Environment.NewLine + "Toprak alkali metaldir." + Environment.NewLine + "Klorofilin yapısına katılır.", "Magnezyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Al")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 13'tür." + Environment.NewLine + "Metaldir." + Environment.NewLine + " Kolaylıkla dövülebilir, makinede işlenebilir ve dökülebilir.", "Aliminyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Si")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 14'tür." + Environment.NewLine + "Yarımetaldir." + Environment.NewLine + "Çok sert bir elementtir.", "Silisyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "P")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 15'dir." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Kemik ve diş oluşumunda görev alır.", "Fosfor Elementi hakkında bilgiler:");
                }
                if (button2.Text == "S")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 16'dır." + Environment.NewLine + "Ametaldir." + Environment.NewLine + "Yanıcı ve patlayıcıdır.", "Kükürt Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Cl")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 17'dir." + Environment.NewLine + "Halojendir." + Environment.NewLine + "Su arıtımında kullanılır." + Environment.NewLine + "Sudda çözünebilir.", "Klor Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Ar")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 18'dir." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Renksiz,kokusuz,zehirsiz bir gazdır.", "Argon Elementi hakkında bilgiler:");
                }
                if (button2.Text == "K")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 19'dur." + Environment.NewLine + "Alkali metaldir." + Environment.NewLine + "Vücuda yeterli miktarda alınmazsa kaslarda kramp,kalp ritminde bozukluk,yorgunluk görülür.", "Potasyum Elementi hakkında bilgiler:");
                }
                if (button2.Text == "Ca")
                {
                    MessageBox.Show("Atom numarası(Proton sayısı) 20'dir." + Environment.NewLine + "Toprak alkali metaldir." + Environment.NewLine + "Kemik ve dişlerin yapısına katılır.", "Kalsiyum Elementi hakkında bilgiler:");
                }
            }
            int rs = random.Next(0, 20);
            int rs2 = random.Next(0, 2);
            int rs3 = random.Next(0, 20);
            int rs4 = random.Next(0, 20);
            label1.Text = Elementler[rs] + " elementinin sembolünü giriniz";

            if (rs2 == 0)
            {
                button1.Text = Elementsembolleri[rs];
                button2.Text = Elementsembolleri[rs3];
                if (button1.Text == button2.Text)
                {
                    button2.Text = Elementsembolleri[rs4];
                }
                i = 1;
            }
            if (rs2 == 1)
            {
                button2.Text = Elementsembolleri[rs];
                button1.Text = Elementsembolleri[rs3];
                i = 2;
                if (button1.Text == button2.Text)
                {
                    button1.Text = Elementsembolleri[rs4];
                }
            }
        }

        private void Element_Load(object sender, EventArgs e)
        {
            
        }
    }
}
