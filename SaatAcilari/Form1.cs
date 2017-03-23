using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaatAcilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string akrep, yelkovan;
            akrep = textBox1.Text;
            yelkovan = textBox2.Text;
            int aci = 0;
            aci = get_angle(Convert.ToInt32(akrep), Convert.ToInt32(yelkovan));
            label1.Text = "Sonuç : " + aci + " Derece";
        }



        private static int get_angle(int saat, int dakika)
        {
            return Math.Abs((int)(saat * 30) - (int)(dakika * 5.5)); // math.abs mutlak değerini al 
        }
    }
}
