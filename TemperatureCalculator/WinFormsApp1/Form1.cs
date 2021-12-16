namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Convert_Click(object sender, EventArgs e)
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

        private void clear_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }
    }
}