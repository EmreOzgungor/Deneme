using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Bileşik : Form
    {
        public string[] Bileşikler = { "Su","Tuz ruhu","Zaç yağı","Kezzap","Sirke asidi","Kireç taşı","Yemek sodası","Amonyak","Sönmüş kireç","Sud kostik","Potas kostik","Sönmemiş kireç","Yemek tuzu" };
        public string[] Bileşiksembolleri = {"H2O","HCl","H2SO4","HNO3","CH3COOH","CaCO3","NaHCO3","NH3","Ca(OH)2","NaOH","KOH","Cao","NaCl" };
        Random random = new Random();
        public Bileşik()
        {
            InitializeComponent();
        }
        int i;
        int skor = 0;
        private void Bileşik_Load(object sender, EventArgs e)
        {
            int rs = random.Next(0, 13);
            int rs2 = random.Next(0, 2);
            int rs3 = random.Next(0, 13);
            int rs4 = random.Next(0, 13);
            label1.Text = Bileşikler[rs] + " bileşiğinin sembolünü giriniz";
            if (rs2 == 0)
            {
                button1.Text = Bileşiksembolleri[rs];
                button2.Text = Bileşiksembolleri[rs3];
                if (button1.Text == button2.Text)
                {
                    button2.Text = Bileşikler[rs4];
                }
                i = 1;
            }
            if (rs2 == 1)
            {
                button2.Text = Bileşiksembolleri[rs];
                button1.Text = Bileşiksembolleri[rs3];
                if (button1.Text == button2.Text)
                {
                    button1.Text = Bileşikler[rs4];
                }
                i = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                skor = skor + 10;
                MessageBox.Show("skorunuz :" + skor, "Doğru Cevap");
                if (button1.Text == "H2O")
                {
                    MessageBox.Show("Sistematik adı Dihidrojen Monoksit'tir" + Environment.NewLine + "Suyun kaynama noktası 100 derece iken donma noktası 0 derecedir." + Environment.NewLine, "Su Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "HCl")
                {
                    MessageBox.Show("Sistematik adı Hidroklorik Asit'tir" + Environment.NewLine + "İçinde karbon bulunmadığından İnorganik asittir." + Environment.NewLine + "çok keskin kokuya sahiptir. oldukça aşındırıcı, insanlara ve çevreye son derece zararlıdır.", "Tuz ruhu Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "H2SO4")
                {
                    MessageBox.Show("Sistematik adı Sülfürik Asit'tir" + Environment.NewLine + "Su içinde çözünebilir" + Environment.NewLine, "Zaç yağı bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "HNO3")
                {
                    MessageBox.Show("Sistematik adı Nitrik Asit'tir" + Environment.NewLine + "Saf bileşik renksizdir. Ancak uzun süre bekleyen eski asitler azot oksitleri ve suya ayrışması nedeniyle sarı renge dönebilme özelliğindedirler." + Environment.NewLine, "Kezzap bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "CH3COOH")
                {
                    MessageBox.Show("Sistematik adı Asetik Asittir." + Environment.NewLine + "İçinde Karbon bulunduğundan organik asittir" + Environment.NewLine, "Sirke Asidi Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "CaCO3")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Karbonat'tır", "Kireç Taşı Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "NaHCO3")
                {
                    MessageBox.Show("Sistematik adı Sodyum bikarbonat'tır" + Environment.NewLine + "Yemek sodası suda kolaylıkla çözünür ve suyu alkali hale getirir.", "Yemek sodası Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "NH3")
                {
                    MessageBox.Show("Sistematik adı Amonyum Nitrat'dır", "Amonyak Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "Ca(OH)2")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Hidroksit'tir" + Environment.NewLine + "Sönmemiş kirece su ilave edilmesiyle elde edilen kimyasal bileşiktir.", "Sonmuş kireç Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "NaOH")
                {
                    MessageBox.Show("Sistematik adı Sodyum Hidroksit'tir", "Sud Kostik Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "KOH")
                {
                    MessageBox.Show("Sistematik adı Potasyum Hidroksit'tir" + Environment.NewLine + "Suda eridiği vakit ısı açığa çıkarır.", "Potas Kostk Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "CaO")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Oksit'tir", "Sönmemiş Kireç Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "NaCl")
                {
                    MessageBox.Show("Sistematik adı Sodyum Klörür'dür." + Environment.NewLine + "pH değeri 7'dir.", "Yemek Tuzu Bileşiği hakkında bilgiler:");
                }

            }
            else
            {
                skor = skor- 30;
                MessageBox.Show("skorunuz :" + skor, "Yanlış Cevap");
                if (button2.Text == "H2O")
                {
                    MessageBox.Show("Sistematik adı Dihidrojen Monoksit'tir" + Environment.NewLine + "Suyun kaynama noktası 100 derece iken donma noktası 0 derecedir." + Environment.NewLine, "Su Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "HCl")
                {
                    MessageBox.Show("Sistematik adı Hidroklorik Asit'tir" + Environment.NewLine + "İçinde karbon bulunmadığından İnorganik asittir." + Environment.NewLine + "çok keskin kokuya sahiptir. oldukça aşındırıcı, insanlara ve çevreye son derece zararlıdır.", "Tuz ruhu Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "H2SO4")
                {
                    MessageBox.Show("Sistematik adı Sülfürik Asit'tir" + Environment.NewLine + "Su içinde çözünebilir" + Environment.NewLine, "Zaç yağı bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "HNO3")
                {
                    MessageBox.Show("Sistematik adı Nitrik Asit'tir" + Environment.NewLine + "Saf bileşik renksizdir. Ancak uzun süre bekleyen eski asitler azot oksitleri ve suya ayrışması nedeniyle sarı renge dönebilme özelliğindedirler." + Environment.NewLine, "Kezzap bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "CH3COOH")
                {
                    MessageBox.Show("Sistematik adı Asetik Asittir." + Environment.NewLine + "İçinde Karbon bulunduğundan organik asittir" + Environment.NewLine, "Sirke Asidi Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "CaCO3")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Karbonat'tır", "Kireç Taşı Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "NaHCO3")
                {
                    MessageBox.Show("Sistematik adı Sodyum bikarbonat'tır" + Environment.NewLine + "Yemek sodası suda kolaylıkla çözünür ve suyu alkali hale getirir.", "Yemek sodası Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "NH3")
                {
                    MessageBox.Show("Sistematik adı Amonyum Nitrat'dır", "Amonyak Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "Ca(OH)2")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Hidroksit'tir" + Environment.NewLine + "Sönmemiş kirece su ilave edilmesiyle elde edilen kimyasal bileşiktir.", "Sonmuş kireç Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "NaOH")
                {
                    MessageBox.Show("Sistematik adı Sodyum Hidroksit'tir", "Sud Kostik Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "KOH")
                {
                    MessageBox.Show("Sistematik adı Potasyum Hidroksit'tir" + Environment.NewLine + "Suda eridiği vakit ısı açığa çıkarır.", "Potas Kostk Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "CaO")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Oksit'tir", "Sönmemiş Kireç Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "NaCl")
                {
                    MessageBox.Show("Sistematik adı Sodyum Klörür'dür." + Environment.NewLine + "pH değeri 7'dir.", "Yemek Tuzu Bileşiği hakkında bilgiler:");
                }
            }
            int rs = random.Next(0, 13);
            int rs2 = random.Next(0, 2);
            int rs3 = random.Next(0, 13);
            int rs4 = random.Next(0, 13);
            label1.Text = Bileşikler[rs] + " bileşiğinin sembolünü giriniz";
            if (rs2 == 0)
            {
                button1.Text = Bileşiksembolleri[rs];
                button2.Text = Bileşiksembolleri[rs3];
                if (button1.Text == button2.Text)
                {
                    button2.Text = Bileşiksembolleri[rs4];
                }
                i = 1;
            }
            if (rs2 == 1)
            {
                button2.Text = Bileşiksembolleri[rs];
                button1.Text = Bileşiksembolleri[rs3];
                if (button1.Text == button2.Text)
                {
                    button1.Text = Bileşiksembolleri[rs4];
                }
                i = 2;
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 2)
            {
                skor = skor+ 10; 
                MessageBox.Show("skorunuz :"+skor, "Doğru Cevap");
                if (button1.Text == "H2O")
                {
                    MessageBox.Show("Sistematik adı Dihidrojen Monoksit'tir" + Environment.NewLine + "Suyun kaynama noktası 100 derece iken donma noktası 0 derecedir." + Environment.NewLine, "Su Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "HCl")
                {
                    MessageBox.Show("Sistematik adı Hidroklorik Asit'tir" + Environment.NewLine + "İçinde karbon bulunmadığından İnorganik asittir." + Environment.NewLine + "çok keskin kokuya sahiptir. oldukça aşındırıcı, insanlara ve çevreye son derece zararlıdır.", "Tuz ruhu Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "H2SO4")
                {
                    MessageBox.Show("Sistematik adı Sülfürik Asit'tir" + Environment.NewLine + "Su içinde çözünebilir" + Environment.NewLine, "Zaç yağı bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "HNO3")
                {
                    MessageBox.Show("Sistematik adı Nitrik Asit'tir" + Environment.NewLine + "Saf bileşik renksizdir. Ancak uzun süre bekleyen eski asitler azot oksitleri ve suya ayrışması nedeniyle sarı renge dönebilme özelliğindedirler." + Environment.NewLine, "Kezzap bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "CH3COOH")
                {
                    MessageBox.Show("Sistematik adı Asetik Asittir." + Environment.NewLine + "İçinde Karbon bulunduğundan organik asittir" + Environment.NewLine, "Sirke Asidi Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "CaCO3")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Karbonat'tır", "Kireç Taşı Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "NaHCO3")
                {
                    MessageBox.Show("Sistematik adı Sodyum bikarbonat'tır" + Environment.NewLine + "Yemek sodası suda kolaylıkla çözünür ve suyu alkali hale getirir.", "Yemek sodası Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "NH3")
                {
                    MessageBox.Show("Sistematik adı Amonyum Nitrat'dır", "Amonyak Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "Ca(OH)2")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Hidroksit'tir" + Environment.NewLine + "Sönmemiş kirece su ilave edilmesiyle elde edilen kimyasal bileşiktir.", "Sonmuş kireç Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "NaOH")
                {
                    MessageBox.Show("Sistematik adı Sodyum Hidroksit'tir", "Sud Kostik Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "KOH")
                {
                    MessageBox.Show("Sistematik adı Potasyum Hidroksit'tir" + Environment.NewLine + "Suda eridiği vakit ısı açığa çıkarır.", "Potas Kostk Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "CaO")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Oksit'tir", "Sönmemiş Kireç Bileşiği hakkında bilgiler:");
                }
                if (button1.Text == "NaCl")
                {
                    MessageBox.Show("Sistematik adı Sodyum Klörür'dür." + Environment.NewLine + "pH değeri 7'dir.", "Yemek Tuzu Bileşiği hakkında bilgiler:");
                }
            }
            else
            {
                skor = skor- 30;
                MessageBox.Show("skorunuz :" + skor, "Yanlış Cevap");
                if (button2.Text == "H2O")
                {
                    MessageBox.Show("Sistematik adı Dihidrojen Monoksit'tir" + Environment.NewLine + "Suyun kaynama noktası 100 derece iken donma noktası 0 derecedir." + Environment.NewLine, "Su Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "HCl")
                {
                    MessageBox.Show("Sistematik adı Hidroklorik Asit'tir" + Environment.NewLine + "İçinde karbon bulunmadığından İnorganik asittir." + Environment.NewLine + "çok keskin kokuya sahiptir. oldukça aşındırıcı, insanlara ve çevreye son derece zararlıdır.", "Tuz ruhu Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "H2SO4")
                {
                    MessageBox.Show("Sistematik adı Sülfürik Asit'tir" + Environment.NewLine + "Su içinde çözünebilir" + Environment.NewLine, "Zaç yağı bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "HNO3")
                {
                    MessageBox.Show("Sistematik adı Nitrik Asit'tir" + Environment.NewLine + "Saf bileşik renksizdir. Ancak uzun süre bekleyen eski asitler azot oksitleri ve suya ayrışması nedeniyle sarı renge dönebilme özelliğindedirler." + Environment.NewLine, "Kezzap bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "CH3COOH")
                {
                    MessageBox.Show("Sistematik adı Asetik Asittir." + Environment.NewLine + "İçinde Karbon bulunduğundan organik asittir" + Environment.NewLine, "Sirke Asidi Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "CaCO3")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Karbonat'tır", "Kireç Taşı Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "NaHCO3")
                {
                    MessageBox.Show("Sistematik adı Sodyum bikarbonat'tır" + Environment.NewLine + "Yemek sodası suda kolaylıkla çözünür ve suyu alkali hale getirir.", "Yemek sodası Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "NH3")
                {
                    MessageBox.Show("Sistematik adı Amonyum Nitrat'dır", "Amonyak Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "Ca(OH)2")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Hidroksit'tir" + Environment.NewLine + "Sönmemiş kirece su ilave edilmesiyle elde edilen kimyasal bileşiktir.", "Sonmuş kireç Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "NaOH")
                {
                    MessageBox.Show("Sistematik adı Sodyum Hidroksit'tir", "Sud Kostik Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "KOH")
                {
                    MessageBox.Show("Sistematik adı Potasyum Hidroksit'tir" + Environment.NewLine + "Suda eridiği vakit ısı açığa çıkarır.", "Potas Kostk Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "CaO")
                {
                    MessageBox.Show("Sistematik adı Kalsiyum Oksit'tir", "Sönmemiş Kireç Bileşiği hakkında bilgiler:");
                }
                if (button2.Text == "NaCl")
                {
                    MessageBox.Show("Sistematik adı Sodyum Klörür'dür." + Environment.NewLine + "pH değeri 7'dir.", "Yemek Tuzu Bileşiği hakkında bilgiler:");
                }
            }
            int rs = random.Next(0, 13);
            int rs2 = random.Next(0, 2);
            int rs3 = random.Next(0, 13);
            int rs4 = random.Next(0, 13);
            label1.Text = Bileşikler[rs] + " bileşiğinin sembolünü giriniz";
            if (rs2 == 0)
            {
                button1.Text = Bileşiksembolleri[rs];
                button2.Text = Bileşiksembolleri[rs3];
                if (button1.Text == button2.Text)
                {
                    button2.Text = Bileşiksembolleri[rs4];
                }
                i = 1;
            }
            if (rs2 == 1)
            {
                button2.Text = Bileşiksembolleri[rs];
                button1.Text = Bileşiksembolleri[rs3];
                if (button1.Text == button2.Text)
                {
                    button1.Text = Bileşiksembolleri[rs4];
                }
                i = 2;
            }
        }
    }
}
