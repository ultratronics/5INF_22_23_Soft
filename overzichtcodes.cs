using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @struct
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        struct Adam { 
            
            public int stoel; 
            public int leef; 
        
        public Adam(int stoel, int leef)
            {
               this.stoel = stoel;
               this.leef = leef;

            }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            joran joranWesley = new joran("wesley", "192.168.0.1");
            joran ahmetJoran = new joran("Ahmet", "145.145.145.2");


            List<joran> jorans= new List<joran>();
            jorans.Add(ahmetJoran);
            jorans.Add(new joran("test", "192.168.1.12"));
            jorans.RemoveAt(0);
            joran backup = jorans.ElementAt(0);

            backup.ipAdress = "192.168.200.2";
            jorans.RemoveAt(0);
            jorans.Add(backup);

        }




        struct joran
        {

            public string naam;
            public string ipAdress;
            public joran (string naam,string ip){  
            this.naam = naam;
             ipAdress = ip;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBox1.CreateGraphics();
            Pen mijnPen = new Pen(Color.Black);


            paper.DrawEllipse(mijnPen, 100, 200, 300, 300);
        }
    }
}
