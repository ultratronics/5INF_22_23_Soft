using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patient
{
    public partial class Form1 : Form
    {
        List<Film> films= new List<Film>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            films.Add(new Film());
            films.ElementAt(0).naam = txtNieuweFilm.Text;
            listBox1.Items.Add(films.ElementAt(0).naam);
        }

        private void btnActeur_Click(object sender, EventArgs e)
        {
            films.ElementAt(listBox1.SelectedIndex).Acteurs.Add(txtActeur.Text);
            listBox2.Items.Clear();
            listBox2.Items.AddRange(films.ElementAt(listBox1.SelectedIndex).Acteurs.ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (listBox1.SelectedIndex != -1){
                listBox2.Items.Clear();
                listBox2.Items.AddRange(films.ElementAt(listBox1.SelectedIndex).Acteurs.ToArray());
            }
            }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            films.RemoveAt(listBox1.SelectedIndex);
            
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
