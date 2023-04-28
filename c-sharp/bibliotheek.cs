using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliotheek
{
    public partial class Form1 : Form
    {
        Boek nieuwboek;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
             nieuwboek = new Boek(txtTitel.Text, txtAuteur.Text, chkBeschikbaar.Checked);
        }



        public struct Boek
        {
            public Boek(string titel, string auteur, bool beschikbaar)
            {
                this.titel = titel;
                this.auteur = auteur;
                this.beschikbaar = beschikbaar;
            }

            public string titel { get; set; }
            public string auteur { get; set; }
            public bool beschikbaar { get; set; }
        }

        private void btnBekijken_Click(object sender, EventArgs e)
        {
            txtTitel.Text = nieuwboek.titel;
            txtAuteur.Text = nieuwboek.auteur;
            chkBeschikbaar.Checked = nieuwboek.beschikbaar;
        }
    }
}
