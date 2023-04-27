using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rekenmachine
{
    public partial class Form1 : Form
    {

        int waarde = 0;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNummer1_Click(object sender, EventArgs e)
        {
            txtInvoer.Text += "1";
        }

        private void btnNummer2_Click(object sender, EventArgs e)
        {
            txtInvoer.Text += "2";
        }

        private void btnNummer3_Click(object sender, EventArgs e)
        {
            txtInvoer.Text += "3";
        }

        private void btnNummer4_Click(object sender, EventArgs e)
        {
            txtInvoer.Text += "4";
        }

        private void btnNummer5_Click(object sender, EventArgs e)
        {
            txtInvoer.Text += "5";
        }

        private void btnNummer6_Click(object sender, EventArgs e)
        {
            txtInvoer.Text += "6";
        }

        private void btnNummer7_Click(object sender, EventArgs e)
        {
            txtInvoer.Text += "7";
        }

        private void btnNummer8_Click(object sender, EventArgs e)
        {
            txtInvoer.Text += "8";
        }

        private void btnNummer9_Click(object sender, EventArgs e)
        {
            txtInvoer.Text += "9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            waarde = Convert.ToInt32(txtInvoer.Text);
            txtInvoer.Clear();
            op = '+';
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (op == '+')
            {

                txtInvoer.Text = Convert.ToString(Convert.ToInt32(txtInvoer.Text) + waarde);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInvoer.Clear();
            waarde = 0;
        }
    }
}
