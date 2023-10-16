using System.Text;

namespace Actividad6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string InvertirPalabra(string palabra)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = palabra.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(palabra[i]);
            }
            return stringBuilder.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = InvertirPalabra(textBox1.Text).ToUpper();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = InvertirPalabra(textBox2.Text).ToUpper();
        }
    }
}