using System.Text;

namespace Actividad7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 3)
            {
                textBox1.BackColor = SystemColors.GrayText;
                return;
            }

            string text = textBox1.Text;
            if (text == InvertirPalabra(text))
            {
                textBox1.BackColor = Color.SpringGreen;
            } else {
                textBox1 .BackColor = Color.Red;
            }
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
    }
}