using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJEKT_CNET
{
    public partial class Form1 : Form
    {
        int wynik = 0;
        int maxPyt = 9;
        int numerPyt = 0;
        int poprawnePyt;
        Boolean f = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sprOdpowiedzEvent(object sender, EventArgs e)
        {
            f = false;
            btn4.Visible = false;
            btn5.Visible = false;
            var senderObject = (Button)sender;
            int btnTag = Convert.ToInt32(senderObject.Tag);
            if (btnTag == poprawnePyt)
            {
                wynik++;
            }
            if (numerPyt == maxPyt)
            {
                f = true;
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = true;
                btn5.Visible = true;
                lblPytanie.Text = "";
                pictureBox.Image = Properties.Resources.Emoji;
                MessageBox.Show(
                    "Gratulacje! Quiz zostal ukonczony!" + Environment.NewLine +
                    "Twoj wynik to: " + wynik + "/9" + Environment.NewLine +
                    "Aby zagrac ponownie nacisnij OK!");

                wynik = 0;
                numerPyt = 0;
            }

            if (f == false)
            {
                numerPyt++;
                zadajPyt(numerPyt);
            }
        }

        private void zadajPyt (int nrPyt)
        {
            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            switch (nrPyt)
            {
                case 1:
                    pictureBox.Image = Properties.Resources.Barbakan;
                    lblPytanie.Text = "Co to za budowla?";
                    btn1.Text = "Klasztor Karmelitów Bosych";
                    btn2.Text = "Warownia Podgórska";
                    btn3.Text = "Barbakan Krakowski";
                    poprawnePyt = 3;
                    break;

                case 2:
                    pictureBox.Image = Properties.Resources.Bernatka;
                    lblPytanie.Text = "Czyim imieniem nazwano ten most?";
                    btn1.Text = "Laetusa Bernatka";
                    btn2.Text = "Księżnej Bernadetty";
                    btn3.Text = "Joanny Bernadetty Molli";
                    poprawnePyt = 1;
                    break;

                case 3:
                    pictureBox.Image = Properties.Resources.Krakow;
                    lblPytanie.Text = "Jaka jest przybliżona powierzchnia Krakowa?";
                    btn1.Text = "326km^2";
                    btn2.Text = "150km^2";
                    btn3.Text = "250km^2";
                    poprawnePyt = 1;
                    break;

                case 4:
                    pictureBox.Image = Properties.Resources.KrakusKopiec;
                    lblPytanie.Text = "Na czyją cześć powstał ten kopiec?";
                    btn1.Text = "Jana Pawła II";
                    btn2.Text = "Krakusa";
                    btn3.Text = "Wandy";
                    poprawnePyt = 2;
                    break;

                case 5:
                    pictureBox.Image = Properties.Resources.Mariacki;
                    lblPytanie.Text = "Co to za kościół?";
                    btn1.Text = "Klasztor Dominikanów";
                    btn2.Text = "Bazylika Mariacka";
                    btn3.Text = "Klasztor Franciszkanów";
                    poprawnePyt = 2;
                    break;

                case 6:
                    pictureBox.Image = Properties.Resources.Tramwaj;
                    lblPytanie.Text = "Jaka jest najdłuższa linia tramwajowa w Krakowie?";
                    btn1.Text = "Łagiewniki - Pleszów nr 10: 20,6 km";
                    btn2.Text = "Nowy Bieżanów - Mistrzejowice nr 9: 19,1 km";
                    btn3.Text = "Borek Fałęcki - Kopiec Wandy nr 22: 21,7 km";
                    poprawnePyt = 1;
                    break;

                case 7:
                    pictureBox.Image = Properties.Resources.Centralny;
                    lblPytanie.Text = "Czyim imieniem nazwano to miejsce?";
                    btn1.Text = "Józefa Piłsudzkiego";
                    btn2.Text = "Tadeusza Kościuszki";
                    btn3.Text = "Ronalda Reagan'a";
                    poprawnePyt = 3;
                    break;

                case 8:
                    pictureBox.Image = Properties.Resources.Mechaniczny;
                    lblPytanie.Text = "Wydział którego uniwersytetu znajduje się na zdjęciu?";
                    btn1.Text = "AGH";
                    btn2.Text = "UJ";
                    btn3.Text = "PK";
                    poprawnePyt = 3;
                    break;

                case 9:
                    pictureBox.Image = Properties.Resources.UJ;
                    lblPytanie.Text = "Jak oryginalnie nazywał się ten budynek?";
                    btn1.Text = "Uniwersytet Jagiellonów";
                    btn2.Text = "Uczelnia Miasta Kraków";
                    btn3.Text = "Akademia Krakowska";
                    poprawnePyt = 3;
                    break;
            }
        }

        private void pctBox_Click(object sender, EventArgs e)
        {

        }

        private void historiaEvent(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
        }
    }
}
