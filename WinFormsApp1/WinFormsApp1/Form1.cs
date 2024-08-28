namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private double peso;
        private double altura;
        private double IMC;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private TextBox GetTextBoxIMC()
        {
            return textBoxIMC;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            peso = Convert.ToDouble(textBoxPESO.Text);

            altura = Convert.ToDouble(textBoxAltura.Text);

            IMC = peso / (altura * altura);

            textBoxIMC.Text = IMC.ToString("F2");

            if (IMC < 18.5)
            {
                label1.Text = $"Usted tiene un peso muy bajo";
            }
            else if (IMC >= 18.5 && IMC <= 24.9)
            {
                label1.Text = $"Usted tiene un peso ideal";
            }
            else if (IMC <= 24.9)
            {
                label1.Text = $"Usted esta en sobrepeso";
            }

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
