using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        int ballX = 0; // X-positie van de bal
        int ballY = 0; // Y-positie van de bal
        int ballSpeedX = 5; // Snelheid van de bal in de X-richting
        int ballSpeedY = 5; // Snelheid van de bal in de Y-richting
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Speler 1 (links)
            if (e.KeyCode == Keys.W)
            {
                panel1.Top -= 10; // Verplaats de peddel omhoog
            }
            else if (e.KeyCode == Keys.S)
            {
                panel1.Top += 10; // Verplaats de peddel omlaag
            }

            // Speler 2 (rechts)
            if (e.KeyCode == Keys.Up)
            {
                panel2.Top -= 10; // Verplaats de peddel omhoog
            }
            else if (e.KeyCode == Keys.Down)
            {
                panel2.Top += 10; // Verplaats de peddel omlaag
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = "Ik zit in de timer";
            // Beweeg de bal

            // Controleer op botsingen met de boven- en onderkant van het speelveld
            if (panel3.Top <= pictureBox1.Top || panel3.Top >= pictureBox1.Height + pictureBox1.Top - panel3.Height)
            {
                ballSpeedY *= -1; // Keer de richting van de bal om
            }

            // Controleer op botsingen met de peddels
            if (panel1.Bounds.IntersectsWith(panel3.Bounds) || panel2.Bounds.IntersectsWith(panel3.Bounds))
            {
                ballSpeedX *= -1; // Keer de richting van de bal om
            }


            panel3.Left += ballSpeedX;
            panel3.Top += ballSpeedY;
        }
    }
}
