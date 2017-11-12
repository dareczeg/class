using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Równianiekwadratowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Klasa Delta = new Klasa();

            Delta.UstawDlugosc(Convert.ToDouble(textBox1.Text));
            Delta.UstawSzerokosc(Convert.ToDouble(textBox2.Text));
            Delta.UstawWysokosc(Convert.ToDouble(textBox3.Text));
            double obj1 = Delta.calculateDelta();
            label6.Text = Convert.ToString(obj1);
            double obj2 = Delta.calculateX1();
            label4.Text = Convert.ToString(obj2);
            double obj3 = Delta.calculateX2();
            label5.Text = Convert.ToString(obj3);
            
            

        }
    }
}
