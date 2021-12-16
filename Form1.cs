using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemperatureCalculator02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // input
            // นี้คืองง
            // textBoxC.Text = "hello";
            //get input form textbox
            string input = textBoxC.Text;
            double C = Convert.ToDouble(input);
            // [°F] = [°C] × ​9⁄5 + 32.
            double F = C * 9 / 5 + 32;
            // show input to textbox
            textBoxF.Text = F.ToString();
            // [°C] = (5/9)x([°F]-32)

         


        }

        private void Convert2_Click(object sender, EventArgs e)
        {
            string input = textBoxF.Text;
            double f = Convert.ToDouble(input);
            // [°C] = (5/9)x([°F]-32)
            double c = (f - 32) * 5 / 9;
            // show input to textbox
            textBoxC.Text = c.ToString();
            

        }
    }
}
