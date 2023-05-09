using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jaspershop
{
    public partial class Form1 : Form
    {


        List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            products.Add(new Product(txtProductNaam.Text,Convert.ToInt32(txtAantal.Text)));
            listBox1.Items.Add(txtProductNaam.Text + "  " + Convert.ToInt32(txtAantal.Text));
           
        }

        public struct Product
        {
            public Product(string productNaam, int aantal)
            {
                this.productNaam = productNaam;
                this.aantal = aantal;
 
            }

            public string productNaam { get; set; }
            public int aantal { get; set; }
   
        }

        private void btnBekijken_Click(object sender, EventArgs e)
        {
           txtAantal.Text = products.ElementAt(listBox1.SelectedIndex).aantal.ToString();

           txtProductNaam.Text=  products.ElementAt(listBox1.SelectedIndex).productNaam;        



        }

        private void btnVeranderen_Click(object sender, EventArgs e)
        {
           Product backup =  products.ElementAt(listBox1.SelectedIndex);

            int indexBackup = listBox1.SelectedIndex;

            listBox1.Items.Clear();
            products.RemoveAt(indexBackup);
            

            backup.aantal = Convert.ToInt32(txtAantal.Text);
            backup.productNaam = txtProductNaam.Text;
            products.Insert(indexBackup, backup);


            foreach (Product productt in products){
                listBox1.Items.Add(productt.productNaam + "  " + Convert.ToInt32(productt.aantal));


            }

        }
    }
}
