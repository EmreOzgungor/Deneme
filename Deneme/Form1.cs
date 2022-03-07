using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Enabled = false;
            pictureBox1.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Element element = new Element();
            element.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bileşik bileşik = new Bileşik();
            bileşik.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hangi konudan soru çözmek istersiniz?";
        }
        Random rastgele = new Random();
        int i;

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button9.Visible = false;
            button9.Enabled = false;
            button6.Enabled = false;
            button6.Visible = false;
            label2.Visible = true;
            label2.Enabled = true;
            int a = rastgele.Next(50, 65);
            int cevap = rastgele.Next(1, 3);
            pictureBox1.Enabled = true;
            pictureBox1.Visible = true;
            button4.Visible = true;
            button4.Enabled = true;
            button5.Visible = true;
            button5.Enabled = true;
            label1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            label1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button3.Enabled = false;
            pictureBox1.ImageLocation = "C:\\Users\\Emre\\Pictures\\" + a + ".jpg";
            if (cevap == 1)
            {
                if (a == 50)
                {
                    button4.Text = "3 ve 4";
                    button5.Text = "2,3 ve 4";
                }
                if (a == 51)
                {
                    button4.Text = "H ve K birer alkali metaldir";
                    button5.Text = "X'in yarıçapı Y'nin yarı çapından büyüktür";
                }
                if (a == 52)
                {
                    button4.Text = "2 ve 3";
                    button5.Text = "1ve 3";
                }
                if (a == 53)
                {
                    button4.Text = "Periyot no: 4, Grup no: 2A";
                    button5.Text = "Periyot no:3, Grup no: 5A";
                }
                if (a == 54)
                {
                    button4.Text = "Elementin kimlik özellikleri atom numarasını belirler";
                    button5.Text = "Bütün elementlerin X ışını spektrumu aynıdır";
                }
                if (a == 55)
                {
                    button4.Text = "Periyot no: 3, Grup no: 5A";
                    button5.Text = "Periyor no: 3 Grup no 3A";
                }
                if (a == 56)
                {
                    button4.Text = "2A";
                    button5.Text = "3A";
                }
                if (a == 57)
                {
                    button4.Text = "80";
                    button5.Text = "81";
                }
                if (a == 58)
                {
                    button4.Text = "Analitik Kimya";
                    button5.Text = "Anorganik Kimya";
                }
                if (a == 59)
                {
                    button4.Text = "Üçü de elektrik akımını iletir";
                    button5.Text = "Atom yarıçapları arasında K>Al>Mg ilişkisi vardır";
                }
                if (a == 60)
                {
                    button4.Text = "Yalnız ||";
                    button5.Text = "| ve ||";
                }
                if (a == 61)
                {
                    button4.Text = "4";
                    button5.Text = "5";
                }
                if (a == 62)
                {
                    button4.Text = "1:c, 2:a, 3:b";
                    button5.Text = "1:a, 2:c, 3:b";
                }
                if (a == 63)
                {
                    button4.Text = "|,|| ve |||";
                    button5.Text = "| ve ||";
                }
                if (a == 64)
                {
                    button4.Text = "H ve Ar aralarında bileşik oluşturmazlar.";
                    button5.Text = "Ca ve C bileşik oluşturmaz";
                }

                i = 0;
            }
            if (cevap == 2)
            {
                if (a == 50)
                {
                    button5.Text = "3 ve 4";
                    button4.Text = "2,3 ve 4";
                }
                if (a == 51)
                {
                    button5.Text = "H ve K birer alkali metaldir";
                    button4.Text = "X'in yarıçapı Y'nin yarı çapından büyüktür";
                }
                if (a == 52)
                {
                    button5.Text = "2 ve 3";
                    button4.Text = "1ve 3";
                }
                if (a == 53)
                {
                    button5.Text = "Periyot no: 4, Grup no: 2A";
                    button4.Text = "Periyot no:3, Grup no: 5A";
                }
                if (a == 54)
                {
                    button5.Text = "Elementin kimlik özellikleri atom numarasını belirler";
                    button4.Text = "Bütün elementlerin X ışını spektrumu aynıdır";
                }
                if (a == 55)
                {
                    button5.Text = "Periyot no: 3, Grup no: 5A";
                    button4.Text = "Periyor no: 3 Grup no 3A";
                }
                if (a == 56)
                {
                    button5.Text = "2A";
                    button4.Text = "3A";
                }
                if (a == 57)
                {
                    button5.Text = "80";
                    button4.Text = "81";
                }
                if (a == 58)
                {
                    button5.Text = "Analitik Kimya";
                    button4.Text = "Anorganik Kimya";
                }
                if (a == 59)
                {
                    button5.Text = "Üçü de elektrik akımını iletir";
                    button4.Text = "Atom yarıçapları arasında K>Al>Mg ilişkisi vardır";
                }
                if (a == 60)
                {
                    button5.Text = "Yalnız ||";
                    button4.Text = "| ve ||";
                }
                if (a == 61)
                {
                    button5.Text = "4";
                    button4.Text = "5";
                }
                if (a == 62)
                {
                    button5.Text = "1:c, 2:a, 3:b";
                    button4.Text = "1:a, 2:c, 3:b";
                }
                if (a == 63)
                {
                    button5.Text = "|,|| ve |||";
                    button4.Text = "| ve ||";
                }
                if (a == 64)
                {
                    button5.Text = "H ve Ar aralarında bileşik oluşturmazlar.";
                    button4.Text = "Ca ve C bileşik oluşturmaz";
                }

                i = 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(50, 65);
            int cevap = rastgele.Next(1, 3);
            if (i == 0)
            {
                MessageBox.Show("Doğru cevap");
            }
            else
            {
                MessageBox.Show("Yanlış cevap");
            }
            pictureBox1.ImageLocation = "C:\\Users\\Emre\\Pictures\\" + a + ".jpg";
            if (cevap == 1)
            {
                if (a == 50)
                {
                    button4.Text = "3 ve 4";
                    button5.Text = "2,3 ve 4";
                }
                if (a == 51)
                {
                    button4.Text = "H ve K birer alkali metaldir";
                    button5.Text = "X'in yarıçapı Y'nin yarı çapından büyüktür";
                }
                if (a == 52)
                {
                    button4.Text = "2 ve 3";
                    button5.Text = "1ve 3";
                }
                if (a == 53)
                {
                    button4.Text = "Periyot no: 4, Grup no: 2A";
                    button5.Text = "Periyot no:3, Grup no: 5A";
                }
                if (a == 54)
                {
                    button4.Text = "Elementin kimlik özellikleri atom numarasını belirler";
                    button5.Text = "Bütün elementlerin X ışını spektrumu aynıdır";
                }
                if (a == 55)
                {
                    button4.Text = "Periyot no: 3, Grup no: 5A";
                    button5.Text = "Periyot no: 3 Grup no 3A";
                }
                if (a == 56)
                {
                    button4.Text = "2A";
                    button5.Text = "4A";
                }
                if (a == 57)
                {
                    button4.Text = "80";
                    button5.Text = "81";
                }
                if (a == 58)
                {
                    button4.Text = "Analitik Kimya";
                    button5.Text = "Anorganik Kimya";
                }
                if (a == 59)
                {
                    button4.Text = "Üçü de elektrik akımını iletir";
                    button5.Text = "Atom yarıçapları arasında K>Al>Mg ilişkisi vardır";
                }
                if (a == 60)
                {
                    button4.Text = "Yalnız ||";
                    button5.Text = "| ve ||";
                }
                if (a == 61)
                {
                    button4.Text = "4";
                    button5.Text = "5";
                }
                if (a == 62)
                {
                    button4.Text = "1:c, 2:a, 3:b";
                    button5.Text = "1:a, 2:c, 3:b";
                }
                if (a == 63)
                {
                    button4.Text = "|,|| ve |||";
                    button5.Text = "| ve ||";
                }
                if (a == 64)
                {
                    button4.Text = "H ve Ar aralarında bileşik oluşturmazlar.";
                    button5.Text = "Ca ve C bileşik oluşturmaz";
                }

                i = 0;
                tik = 0;
            }
            if (cevap == 2)
            {
                if (a == 50)
                {
                    button5.Text = "3 ve 4";
                    button4.Text = "2,3 ve 4";
                }
                if (a == 51)
                {
                    button5.Text = "H ve K birer alkali metaldir";
                    button4.Text = "X'in yarıçapı Y'nin yarı çapından büyüktür";
                }
                if (a == 52)
                {
                    button5.Text = "2 ve 3";
                    button4.Text = "1ve 3";
                }
                if (a == 53)
                {
                    button5.Text = "Periyot no: 4, Grup no: 2A";
                    button4.Text = "Periyot no:3, Grup no: 5A";
                }
                if (a == 54)
                {
                    button5.Text = "Elementin kimlik özellikleri atom numarasını belirler";
                    button4.Text = "Bütün elementlerin X ışını spektrumu aynıdır";
                }
                if (a == 55)
                {
                    button5.Text = "Periyot no: 3, Grup no: 5A";
                    button4.Text = "Periyor no: 3 Grup no 3A";
                }
                if (a == 56)
                {
                    button5.Text = "2A";
                    button4.Text = "3A";
                }
                if (a == 57)
                {
                    button5.Text = "80";
                    button4.Text = "81";
                }
                if (a == 58)
                {
                    button5.Text = "Analitik Kimya";
                    button4.Text = "Anorganik Kimya";
                }
                if (a == 59)
                {
                    button5.Text = "Üçü de elektrik akımını iletir";
                    button4.Text = "Atom yarıçapları arasında K>Al>Mg ilişkisi vardır";
                }
                if (a == 60)
                {
                    button5.Text = "Yalnız ||";
                    button4.Text = "| ve ||";
                }
                if (a == 61)
                {
                    button5.Text = "4";
                    button4.Text = "5";
                }
                if (a == 62)
                {
                    button5.Text = "1:c, 2:a, 3:b";
                    button4.Text = "1:a, 2:c, 3:b";
                }
                if (a == 63)
                {
                    button5.Text = "|,|| ve |||";
                    button4.Text = "| ve ||";
                }
                if (a == 64)
                {
                    button5.Text = "H ve Ar aralarında bileşik oluşturmazlar.";
                    button4.Text = "Ca ve C bileşik oluşturmaz";
                }

                tik = 0;
                i = 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(50, 65);
            int cevap = rastgele.Next(1, 3);
            if (i == 1)
            {
                MessageBox.Show("Doğru cevap");
            }
            else
            {
                MessageBox.Show("Yanlış cevap");
            }
            pictureBox1.ImageLocation = "C:\\Users\\Emre\\Pictures\\" + a + ".jpg";
            if (cevap == 1)
            {
                if (a == 50)
                {
                    button4.Text = "3 ve 4";
                    button5.Text = "2,3 ve 4";
                }
                if (a == 51)
                {
                    button4.Text = "H ve K birer alkali metaldir";
                    button5.Text = "X'in yarıçapı Y'nin yarı çapından büyüktür";
                }
                if (a == 52)
                {
                    button4.Text = "2 ve 3";
                    button5.Text = "1ve 3";
                }
                if (a == 53)
                {
                    button4.Text = "Periyot no: 4, Grup no: 2A";
                    button5.Text = "Periyot no:3, Grup no: 5A";
                }
                if (a == 54)
                {
                    button4.Text = "Elementin kimlik özellikleri atom numarasını belirler";
                    button5.Text = "Bütün elementlerin X ışını spektrumu aynıdır";
                }
                if (a == 55)
                {
                    button4.Text = "Periyot no: 3, Grup no: 5A";
                    button5.Text = "Periyor no: 3 Grup no 3A";
                }
                if (a == 56)
                {
                    button4.Text = "2A";
                    button5.Text = "3A";
                }
                if (a == 57)
                {
                    button4.Text = "80";
                    button5.Text = "81";
                }
                if (a == 58)
                {
                    button4.Text = "Analitik Kimya";
                    button5.Text = "Anorganik Kimya";
                }
                if (a == 59)
                {
                    button4.Text = "Üçü de elektrik akımını iletir";
                    button5.Text = "Atom yarıçapları arasında K>Al>Mg ilişkisi vardır";
                }
                if (a == 60)
                {
                    button4.Text = "Yalnız ||";
                    button5.Text = "| ve ||";
                }
                if (a == 61)
                {
                    button4.Text = "4";
                    button5.Text = "5";
                }
                if (a == 62)
                {
                    button4.Text = "1:c, 2:a, 3:b";
                    button5.Text = "1:a, 2:c, 3:b";
                }
                if (a == 63)
                {
                    button4.Text = "|,|| ve |||";
                    button5.Text = "| ve ||";
                }
                if (a == 64)
                {
                    button4.Text = "H ve Ar aralarında bileşik oluştururmazlar.";
                    button5.Text = "Ca ve C bileşik oluşturmaz";
                }

                i = 0;
                tik = 0;
            }
            if (cevap == 2)
            {
                if (a == 50)
                {
                    button5.Text = "3 ve 4";
                    button4.Text = "2,3 ve 4";
                }
                if (a == 51)
                {
                    button5.Text = "H ve K birer alkali metaldir";
                    button4.Text = "X'in yarıçapı Y'nin yarı çapından büyüktür";
                }
                if (a == 52)
                {
                    button5.Text = "2 ve 3";
                    button4.Text = "1ve 3";
                }
                if (a == 53)
                {
                    button5.Text = "Periyot no: 4, Grup no: 2A";
                    button4.Text = "Periyot no:3, Grup no: 5A";
                }
                if (a == 54)
                {
                    button5.Text = "Elementin kimlik özellikleri atom numarasını belirler";
                    button4.Text = "Bütün elementlerin X ışını spektrumu aynıdır";
                }
                if (a == 55)
                {
                    button5.Text = "Periyot no: 3, Grup no: 5A";
                    button4.Text = "Periyor no: 3 Grup no 3A";
                }
                if (a == 56)
                {
                    button5.Text = "2A";
                    button4.Text = "3A";
                }
                if (a == 57)
                {
                    button5.Text = "80";
                    button4.Text = "81";
                }
                if (a == 58)
                {
                    button5.Text = "Analitik Kimya";
                    button4.Text = "Anorganik Kimya";
                }
                if (a == 59)
                {
                    button5.Text = "Üçü de elektrik akımını iletir";
                    button4.Text = "Atom yarıçapları arasında K>Al>Mg ilişkisi vardır";
                }
                if (a == 60)
                {
                    button5.Text = "Yalnız ||";
                    button4.Text = "| ve ||";
                }
                if (a == 61)
                {
                    button5.Text = "4";
                    button4.Text = "5";
                }
                if (a == 62)
                {
                    button5.Text = "1:c, 2:a, 3:b";
                    button4.Text = "1:a, 2:c, 3:b";
                }
                if (a == 63)
                {
                    button5.Text = "|,|| ve |||";
                    button4.Text = "| ve ||";
                }
                if (a == 64)
                {
                    button5.Text = "H ve Ar aralarında bileşik oluşturmazlar.";
                    button4.Text = "Ca ve C bileşik oluşturmaz";
                }

                tik = 0;
                i = 1;
            }
        }
        int tik = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            tik++;
            label2.Text = "Saniye :" + tik.ToString();
            if (tik == 60)
            {
                MessageBox.Show("Soruları çözerken hızlanmanız gerek");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(100, 118);
            int cevap = rastgele.Next(1, 3);
            timer1.Start();
            button9.Visible = false;
            button9.Enabled = false;
            pictureBox2.Visible = true;
            pictureBox2.Enabled = true;
            label2.Visible = true;
            label2.Enabled = true;
            label1.Visible = false;
            label1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button6.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button6.Visible = false;
            button7.Visible = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button8.Visible = true;
            pictureBox2.ImageLocation = "C:\\Users\\Emre\\Pictures\\" + a + ".jpg";
            if (cevap == 1)
            {
                if (a == 100)
                {
                    button7.Text = "Cam Balon";
                    button8.Text = "Balon joje";
                }
                if (a == 101)
                {
                    button7.Text = "Balon joje";
                    button8.Text = "Erlenmayer";
                }
                if (a == 102)
                {
                    button7.Text = "Pipet";
                    button8.Text = "Baget";
                }
                if (a == 103)
                {
                    button7.Text = "Termometre";
                    button8.Text = "Sacayağı";
                }
                if (a == 104)
                {
                    button7.Text = "Beherglas";
                    button8.Text = "Erlenmayer";
                }
                if (a == 105)
                {
                    button7.Text = "Büret";
                    button8.Text = "Huni";
                }
                if (a == 106)
                {
                    button7.Text = "Mezür(Dereceli silindir)";
                    button8.Text = "Deney tüpü";
                }
                if (a == 107)
                {
                    button7.Text = "Deney tüpü";
                    button8.Text = "Huni";
                }
                if (a == 108)
                {
                    button7.Text = "Havan";
                    button8.Text = "Ayrıma Hunisi";
                }
                if (a == 109)
                {
                    button7.Text = "Kroze";
                    button8.Text = "İspirto Ocağı";
                }
                if (a == 110)
                {
                    button7.Text = "Spatül";
                    button8.Text = "Kroze";
                }
                if (a == 111)
                {
                    button7.Text = "Ayırma Hunisi";
                    button8.Text = "Beherglas";
                }
                if (a == 112)
                {
                    button7.Text = "Huni";
                    button8.Text = "Saat camı";
                }
                if (a == 113)
                {
                    button7.Text = "Erlenmayer";
                    button8.Text = "Balon joje";
                }
                if (a == 114)
                {
                    button7.Text = "Sacayağı";
                    button8.Text = "Cam balon";
                }
                if (a == 115)
                {
                    button7.Text = "Baget";
                    button8.Text = "Termometre";
                }
                if (a == 116)
                {
                    button7.Text = "İspirto Ocağı";
                    button8.Text = "Mezür(Dereceli silindir)";
                }
                if (a == 117)
                {
                    button7.Text = "Saat Camı";
                    button8.Text = "Sacayağı";
                }
                i = 0;
            }
            if (cevap == 2)
            {
                if (a == 100)
                {
                    button8.Text = "Cam Balon";
                    button7.Text = "Balon joje";
                }
                if (a == 101)
                {
                    button8.Text = "Balon joje";
                    button7.Text = "Erlenmayer";
                }
                if (a == 102)
                {
                    button8.Text = "Pipet";
                    button7.Text = "Baget";
                }
                if (a == 103)
                {
                    button8.Text = "Termometre";
                    button7.Text = "Sacayağı";
                }
                if (a == 104)
                {
                    button8.Text = "Beherglas";
                    button7.Text = "Erlenmayer";
                }
                if (a == 105)
                {
                    button8.Text = "Büret";
                    button7.Text = "Huni";
                }
                if (a == 106)
                {
                    button8.Text = "Mezür(Dereceli silindir)";
                    button7.Text = "Deney tüpü";
                }
                if (a == 107)
                {
                    button8.Text = "Deney tüpü";
                    button7.Text = "Huni";
                }
                if (a == 108)
                {
                    button8.Text = "Havan";
                    button7.Text = "Ayrıma Hunisi";
                }
                if (a == 109)
                {
                    button8.Text = "Kroze";
                    button7.Text = "İspirto Ocağı";
                }
                if (a == 110)
                {
                    button8.Text = "Spatül";
                    button7.Text = "Kroze";
                }
                if (a == 111)
                {
                    button8.Text = "Ayırma Hunisi";
                    button7.Text = "Beherglas";
                }
                if (a == 112)
                {
                    button8.Text = "Huni";
                    button7.Text = "Saat camı";
                }
                if (a == 113)
                {
                    button8.Text = "Erlenmayer";
                    button7.Text = "Balon joje";
                }
                if (a == 114)
                {
                    button8.Text = "Sacayağı";
                    button7.Text = "Cam balon";
                }
                if (a == 115)
                {
                    button8.Text = "Baget";
                    button7.Text = "Termometre";
                }
                if (a == 116)
                {
                    button8.Text = "İspirto Ocağı";
                    button7.Text = "Mezür(Dereceli silindir)";
                }
                if (a == 117)
                {
                    button8.Text = "Saat Camı";
                    button7.Text = "Sacayağı";
                }
                i = 1;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(100, 118);
            int cevap = rastgele.Next(1, 3);
            if (i == 0)
            {
                MessageBox.Show("Doğru cevap");
            }
            else
            {
                MessageBox.Show("Yanlış cevap");
            }
            pictureBox2.ImageLocation = "C:\\Users\\Emre\\Pictures\\" + a + ".jpg";
            if (cevap == 1)
            {
                if (a == 100)
                {
                    button7.Text = "Cam Balon";
                    button8.Text = "Balon joje";
                }
                if (a == 101)
                {
                    button7.Text = "Balon joje";
                    button8.Text = "Erlenmayer";
                }
                if (a == 102)
                {
                    button7.Text = "Pipet";
                    button8.Text = "Baget";
                }
                if (a == 103)
                {
                    button7.Text = "Termometre";
                    button8.Text = "Sacayağı";
                }
                if (a == 104)
                {
                    button7.Text = "Beherglas";
                    button8.Text = "Erlenmayer";
                }
                if (a == 105)
                {
                    button7.Text = "Büret";
                    button8.Text = "Huni";
                }
                if (a == 106)
                {
                    button7.Text = "Mezür(Dereceli silindir)";
                    button8.Text = "Deney tüpü";
                }
                if (a == 107)
                {
                    button7.Text = "Deney tüpü";
                    button8.Text = "Huni";
                }
                if (a == 108)
                {
                    button7.Text = "Havan";
                    button8.Text = "Ayrıma Hunisi";
                }
                if (a == 109)
                {
                    button7.Text = "Kroze";
                    button8.Text = "İspirto Ocağı";
                }
                if (a == 110)
                {
                    button7.Text = "Spatül";
                    button8.Text = "Kroze";
                }
                if (a == 111)
                {
                    button7.Text = "Ayırma Hunisi";
                    button8.Text = "Beherglas";
                }
                if (a == 112)
                {
                    button7.Text = "Huni";
                    button8.Text = "Saat camı";
                }
                if (a == 113)
                {
                    button7.Text = "Erlenmayer";
                    button8.Text = "Balon joje";
                }
                if (a == 114)
                {
                    button7.Text = "Sacayağı";
                    button8.Text = "Cam balon";
                }
                if (a == 115)
                {
                    button7.Text = "Baget";
                    button8.Text = "Termometre";
                }
                if (a == 116)
                {
                    button7.Text = "İspirto Ocağı";
                    button8.Text = "Mezür(Dereceli silindir)";
                }
                if (a == 117)
                {
                    button7.Text = "Saat Camı";
                    button8.Text = "Sacayağı";
                }
                i = 0;
                tik = 0;
            }
            if (cevap == 2)
            {
                if (a == 100)
                {
                    button8.Text = "Cam Balon";
                    button7.Text = "Balon joje";
                }
                if (a == 101)
                {
                    button8.Text = "Balon joje";
                    button7.Text = "Erlenmayer";
                }
                if (a == 102)
                {
                    button8.Text = "Pipet";
                    button7.Text = "Baget";
                }
                if (a == 103)
                {
                    button8.Text = "Termometre";
                    button7.Text = "Sacayağı";
                }
                if (a == 104)
                {
                    button8.Text = "Beherglas";
                    button7.Text = "Erlenmayer";
                }
                if (a == 105)
                {
                    button8.Text = "Büret";
                    button7.Text = "Huni";
                }
                if (a == 106)
                {
                    button8.Text = "Mezür(Dereceli silindir)";
                    button7.Text = "Deney tüpü";
                }
                if (a == 107)
                {
                    button8.Text = "Deney tüpü";
                    button7.Text = "Huni";
                }
                if (a == 108)
                {
                    button8.Text = "Havan";
                    button7.Text = "Ayrıma Hunisi";
                }
                if (a == 109)
                {
                    button8.Text = "Kroze";
                    button7.Text = "İspirto Ocağı";
                }
                if (a == 110)
                {
                    button8.Text = "Spatül";
                    button7.Text = "Kroze";
                }
                if (a == 111)
                {
                    button8.Text = "Ayırma Hunisi";
                    button7.Text = "Beherglas";
                }
                if (a == 112)
                {
                    button8.Text = "Huni";
                    button7.Text = "Saat camı";
                }
                if (a == 113)
                {
                    button8.Text = "Erlenmayer";
                    button7.Text = "Balon joje";
                }
                if (a == 114)
                {
                    button8.Text = "Sacayağı";
                    button7.Text = "Cam balon";
                }
                if (a == 115)
                {
                    button8.Text = "Baget";
                    button7.Text = "Termometre";
                }
                if (a == 116)
                {
                    button8.Text = "İspirto Ocağı";
                    button7.Text = "Mezür(Dereceli silindir)";
                }
                if (a == 117)
                {
                    button8.Text = "Saat Camı";
                    button7.Text = "Sacayağı";
                }
                i = 1;
                tik = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int a = rastgele.Next(100, 118);
            int cevap = rastgele.Next(1, 3);
            if (i == 1)
            {
                MessageBox.Show("Doğru cevap");
            }
            else
            {
                MessageBox.Show("Yanlış cevap");
            }
            pictureBox2.ImageLocation = "C:\\Users\\Emre\\Pictures\\" + a + ".jpg";
            if (cevap == 2)
            {
                if (a == 100)
                {
                    button7.Text = "Cam Balon";
                    button8.Text = "Balon joje";
                }
                if (a == 101)
                {
                    button7.Text = "Balon joje";
                    button8.Text = "Erlenmayer";
                }
                if (a == 102)
                {
                    button7.Text = "Pipet";
                    button8.Text = "Baget";
                }
                if (a == 103)
                {
                    button7.Text = "Termometre";
                    button8.Text = "Sacayağı";
                }
                if (a == 104)
                {
                    button7.Text = "Beherglas";
                    button8.Text = "Erlenmayer";
                }
                if (a == 105)
                {
                    button7.Text = "Büret";
                    button8.Text = "Huni";
                }
                if (a == 106)
                {
                    button7.Text = "Mezür(Dereceli silindir)";
                    button8.Text = "Deney tüpü";
                }
                if (a == 107)
                {
                    button7.Text = "Deney tüpü";
                    button8.Text = "Huni";
                }
                if (a == 108)
                {
                    button7.Text = "Havan";
                    button8.Text = "Ayrıma Hunisi";
                }
                if (a == 109)
                {
                    button7.Text = "Kroze";
                    button8.Text = "İspirto Ocağı";
                }
                if (a == 110)
                {
                    button7.Text = "Spatül";
                    button8.Text = "Kroze";
                }
                if (a == 111)
                {
                    button7.Text = "Ayırma Hunisi";
                    button8.Text = "Beherglas";
                }
                if (a == 112)
                {
                    button7.Text = "Huni";
                    button8.Text = "Saat camı";
                }
                if (a == 113)
                {
                    button7.Text = "Erlenmayer";
                    button8.Text = "Balon joje";
                }
                if (a == 114)
                {
                    button7.Text = "Sacayağı";
                    button8.Text = "Cam balon";
                }
                if (a == 115)
                {
                    button7.Text = "Baget";
                    button8.Text = "Termometre";
                }
                if (a == 116)
                {
                    button7.Text = "İspirto Ocağı";
                    button8.Text = "Mezür(Dereceli silindir)";
                }
                if (a == 117)
                {
                    button7.Text = "Saat Camı";
                    button8.Text = "Sacayağı";
                }
                i = 0;
                tik = 0;
            }
            if (cevap == 1)
            {
                if (a == 100)
                {
                    button8.Text = "Cam Balon";
                    button7.Text = "Balon joje";
                }
                if (a == 101)
                {
                    button8.Text = "Balon joje";
                    button7.Text = "Erlenmayer";
                }
                if (a == 102)
                {
                    button8.Text = "Pipet";
                    button7.Text = "Baget";
                }
                if (a == 103)
                {
                    button8.Text = "Termometre";
                    button7.Text = "Sacayağı";
                }
                if (a == 104)
                {
                    button8.Text = "Beherglas";
                    button7.Text = "Erlenmayer";
                }
                if (a == 105)
                {
                    button8.Text = "Büret";
                    button7.Text = "Huni";
                }
                if (a == 106)
                {
                    button8.Text = "Mezür(Dereceli silindir)";
                    button7.Text = "Deney tüpü";
                }
                if (a == 107)
                {
                    button8.Text = "Deney tüpü";
                    button7.Text = "Huni";
                }
                if (a == 108)
                {
                    button8.Text = "Havan";
                    button7.Text = "Ayrıma Hunisi";
                }
                if (a == 109)
                {
                    button8.Text = "Kroze";
                    button7.Text = "İspirto Ocağı";
                }
                if (a == 110)
                {
                    button8.Text = "Spatül";
                    button7.Text = "Kroze";
                }
                if (a == 111)
                {
                    button8.Text = "Ayırma Hunisi";
                    button7.Text = "Beherglas";
                }
                if (a == 112)
                {
                    button8.Text = "Huni";
                    button7.Text = "Saat camı";
                }
                if (a == 113)
                {
                    button8.Text = "Erlenmayer";
                    button7.Text = "Balon joje";
                }
                if (a == 114)
                {
                    button8.Text = "Sacayağı";
                    button7.Text = "Cam balon";
                }
                if (a == 115)
                {
                    button8.Text = "Baget";
                    button7.Text = "Termometre";
                }
                if (a == 116)
                {
                    button8.Text = "İspirto Ocağı";
                    button7.Text = "Mezür(Dereceli silindir)";
                }
                if (a == 117)
                {
                    button8.Text = "Saat Camı";
                    button7.Text = "Sacayağı";
                }
                i = 1;
                tik = 0;
            }
        }
        int u;
        string[] Binsani = { "Empedokles", "Democritus", "Aristo", "Cabir Bin Hayyan", "Ebu Bekir er-Razi", "Robert Boyle", "Antoine Lavoisier" };
        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox1.Enabled = false;
            pictureBox2.Visible = false;
            pictureBox2.Enabled = false;
            label3.Visible = true;
            label3.Enabled = true;
            label1.Visible = false;
            label1.Enabled = false; 
            button1.Visible = false;
            button1.Enabled = false;
            button2.Visible = false;
            button2.Enabled = false;
            button3.Visible = false;
            button3.Enabled = false;
            button4.Visible = false;
            button4.Enabled = false;
            button5.Visible = false;
            button5.Enabled = false;
            button6.Visible = false;
            button6.Enabled = false;
            button7.Visible = false;
            button7.Enabled = false;
            button8.Visible = false;
            button8.Enabled = false;
            button9.Visible = false;
            button9.Enabled = false;
            button10.Enabled = true;
            button10.Visible = true;
            button11.Visible = true;    
            button11.Enabled = true;
            //Buradan al
            int rs = rastgele.Next(0, 2);
            int ba = rastgele.Next(Binsani.Length);
            int a = rastgele.Next(1,14);
            int ky = rastgele.Next(Binsani.Length);
            if (a == 1)
            {
                label3.Text = "MÖ 490'larda doğmuş ve bütün nesnelerin su, hava, toprak" + Environment.NewLine + "ve ateş olmak üzere dört temel maddeden oluştuğunu ileri sürmüştür.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 2)
            {
                label3.Text = "Sevgi ve nefret gibi kavramları madde ile özleştirerek" + Environment.NewLine + "maddenin itme ve çekme kuvvetleri sayesinde" + Environment.NewLine + "bir arada bulunduğuna inanmıştır.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 3)
            {
                label3.Text = "Atom fikrini ortaya ilk atan simyacıdır";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Democritus";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Democritus";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 4)
            {
                label3.Text = "Bu kişiye göre evren dört temel elementten oluşur," + Environment.NewLine + "bu elementler toprak, hava ve sudur. Bu" + Environment.NewLine + "elementlerin sıcak, soğuk, kuru ve ıslak olmak" + Environment.NewLine + "üzere dört özelliğinin olduğunu ileri sürmüştür.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Aristo";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Aristo";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 5)
            {
                label3.Text = "Dünyanın ilk kimya laboratuvarını kuran kişidir";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 6)
            {
                label3.Text = "Atomun parçalanabileceğine olan inancını şu şekilde dile getirmiştir:" + Environment.NewLine + "'Maddenin en küçük parçası olan atomda yoğun bir enerji vardır." + Environment.NewLine + "Yunan bilginlerinin söylediği gibi bunun" + Environment.NewLine + "parçalanamayacağı söylenemez. Atom parçalanabilir.'";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 7)
            {
                label3.Text = "Sitrik asit, asetik asit, tartarik asit, arsenik tozu, nitrik asit," + Environment.NewLine + "hidrojen klörür, sülfürik asit, kral suyunu elde etmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 8)
            {
                label3.Text = "İmbiği geliştirmiş, baz kavramıyla" + Environment.NewLine + "kimyanın gelişmesine katkıda bulunmuştur.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 9)
            {
                label3.Text = "Kroze, fırın gibi laboratuvar aletlerini geliştirmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 10)
            {
                label3.Text = "Alkolü antiseptik olarak tıpta kullanmıştır." + Environment.NewLine + "Karıncalardan damıtma yoluyla formik asidi elde etmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 11)
            {
                label3.Text = "Ünlü eseri Kuşkucu Kimyager adlı kitabında; elementi," + Environment.NewLine + "kendinden daha basit maddelere ayrılamayan saf madde" + Environment.NewLine + "olarak tanımlamış ve dört element kuramını reddetmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 11)
            {
                label3.Text = "Bir gazın hacmi ile basıncı arasındaki" + Environment.NewLine + "ilişkinin belirlenmesine katkıda bulunmuştur.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 12)
            {
                label3.Text = "Modern kimyanın babası olarak kabul edilir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 13)
            {
                label3.Text = "Kütlenin korunumu kanununu" + Environment.NewLine + "bulmuştur, yanma olayını açıklamıştır.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (u == 0)
            {
                MessageBox.Show("Doğru cevap");
            }
            if (u == 1)
            {
                MessageBox.Show("Yanlış cevap");
            }
            int rs = rastgele.Next(0, 2);
            int ba = rastgele.Next(Binsani.Length);
            int a = rastgele.Next(1, 14);
            int ky = rastgele.Next(Binsani.Length);
            if (a == 1)
            {
                label3.Text = "MÖ 490'larda doğmuş ve bütün nesnelerin su, hava, toprak" + Environment.NewLine + "ve ateş olmak üzere dört temel maddeden oluştuğunu ileri sürmüştür.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 2)
            {
                label3.Text = "Sevgi ve nefret gibi kavramları madde ile özleştirerek" + Environment.NewLine + "maddenin itme ve çekme kuvvetleri sayesinde" + Environment.NewLine + "bir arada bulunduğuna inanmıştır.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 3)
            {
                label3.Text = "Atom fikrini ortaya ilk atan simyacıdır";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Democritus";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Democritus";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 4)
            {
                label3.Text = "Bu kişiye göre evren dört temel elementten oluşur," + Environment.NewLine + "bu elementler toprak, hava ve sudur. Bu" + Environment.NewLine + "elementlerin sıcak, soğuk, kuru ve ıslak olmak" + Environment.NewLine + "üzere dört özelliğinin olduğunu ileri sürmüştür.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Aristo";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Aristo";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 5)
            {
                label3.Text = "Dünyanın ilk kimya laboratuvarını kuran kişidir";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 6)
            {
                label3.Text = "Atomun parçalanabileceğine olan inancını şu şekilde dile getirmiştir:" + Environment.NewLine + "'Maddenin en küçük parçası olan atomda yoğun bir enerji vardır." + Environment.NewLine + "Yunan bilginlerinin söylediği gibi bunun" + Environment.NewLine + "parçalanamayacağı söylenemez. Atom parçalanabilir.'";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 7)
            {
                label3.Text = "Sitrik asit, asetik asit, tartarik asit, arsenik tozu, nitrik asit," + Environment.NewLine + "hidrojen klörür, sülfürik asit, kral suyunu elde etmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 8)
            {
                label3.Text = "İmbiği geliştirmiş, baz kavramıyla" + Environment.NewLine + "kimyanın gelişmesine katkıda bulunmuştur.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 9)
            {
                label3.Text = "Kroze, fırın gibi laboratuvar aletlerini geliştirmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 10)
            {
                label3.Text = "Alkolü antiseptik olarak tıpta kullanmıştır." + Environment.NewLine + "Karıncalardan damıtma yoluyla formik asidi elde etmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 11)
            {
                label3.Text = "Ünlü eseri Kuşkucu Kimyager adlı kitabında; elementi," + Environment.NewLine + "kendinden daha basit maddelere ayrılamayan saf madde" + Environment.NewLine + "olarak tanımlamış ve dört element kuramını reddetmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 11)
            {
                label3.Text = "Bir gazın hacmi ile basıncı arasındaki" + Environment.NewLine + "ilişkinin belirlenmesine katkıda bulunmuştur.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 12)
            {
                label3.Text = "Modern kimyanın babası olarak kabul edilir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 13)
            {
                label3.Text = "Kütlenin korunumu kanununu" + Environment.NewLine + "bulmuştur, yanma olayını açıklamıştır.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (u == 1)
            {
                MessageBox.Show("Doğru cevap");
            }
            if (u == 0)
            {
                MessageBox.Show("Yanlış cevap");
            }
            int rs = rastgele.Next(0, 2);
            int ba = rastgele.Next(Binsani.Length);
            int a = rastgele.Next(1, 14);
            int ky = rastgele.Next(Binsani.Length);
            if (a == 1)
            {
                label3.Text = "MÖ 490'larda doğmuş ve bütün nesnelerin su, hava, toprak" + Environment.NewLine + "ve ateş olmak üzere dört temel maddeden oluştuğunu ileri sürmüştür.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 2)
            {
                label3.Text = "Sevgi ve nefret gibi kavramları madde ile özleştirerek" + Environment.NewLine + "maddenin itme ve çekme kuvvetleri sayesinde" + Environment.NewLine + "bir arada bulunduğuna inanmıştır.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Empedokles";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 3)
            {
                label3.Text = "Atom fikrini ortaya ilk atan simyacıdır";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Democritus";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Democritus";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 4)
            {
                label3.Text = "Bu kişiye göre evren dört temel elementten oluşur," + Environment.NewLine + "bu elementler toprak, hava ve sudur. Bu" + Environment.NewLine + "elementlerin sıcak, soğuk, kuru ve ıslak olmak" + Environment.NewLine + "üzere dört özelliğinin olduğunu ileri sürmüştür.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Aristo";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Aristo";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 5)
            {
                label3.Text = "Dünyanın ilk kimya laboratuvarını kuran kişidir";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 6)
            {
                label3.Text = "Atomun parçalanabileceğine olan inancını şu şekilde dile getirmiştir:" + Environment.NewLine + "'Maddenin en küçük parçası olan atomda yoğun bir enerji vardır." + Environment.NewLine + "Yunan bilginlerinin söylediği gibi bunun" + Environment.NewLine + "parçalanamayacağı söylenemez. Atom parçalanabilir.'";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 7)
            {
                label3.Text = "Sitrik asit, asetik asit, tartarik asit, arsenik tozu, nitrik asit," + Environment.NewLine + "hidrojen klörür, sülfürik asit, kral suyunu elde etmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 8)
            {
                label3.Text = "İmbiği geliştirmiş, baz kavramıyla" + Environment.NewLine + "kimyanın gelişmesine katkıda bulunmuştur.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Cabir bin Hayyan";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 9)
            {
                label3.Text = "Kroze, fırın gibi laboratuvar aletlerini geliştirmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 10)
            {
                label3.Text = "Alkolü antiseptik olarak tıpta kullanmıştır." + Environment.NewLine + "Karıncalardan damıtma yoluyla formik asidi elde etmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Ebu Bekir er-Razi";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 11)
            {
                label3.Text = "Ünlü eseri Kuşkucu Kimyager adlı kitabında; elementi," + Environment.NewLine + "kendinden daha basit maddelere ayrılamayan saf madde" + Environment.NewLine + "olarak tanımlamış ve dört element kuramını reddetmiştir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 11)
            {
                label3.Text = "Bir gazın hacmi ile basıncı arasındaki" + Environment.NewLine + "ilişkinin belirlenmesine katkıda bulunmuştur.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Robert Boyle";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 12)
            {
                label3.Text = "Modern kimyanın babası olarak kabul edilir.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            }
            if (a == 13)
            {
                label3.Text = "Kütlenin korunumu kanununu" + Environment.NewLine + "bulmuştur, yanma olayını açıklamıştır.";
                if (rs == 0)
                {
                    button10.Text = Binsani[ba];
                    button11.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button10.Text = Binsani[ky];
                    }
                    u = 1;
                }
                if (rs == 1)
                {
                    button11.Text = Binsani[ba];
                    button10.Text = "Antoine Lavoisier";
                    if (button10.Text == button11.Text)
                    {
                        button11.Text = Binsani[ky];
                    }
                    u = 0;
                }
            } 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
