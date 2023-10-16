using System.Text;

namespace Actividad_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in unfilteredListView.Items)
            {
                ListViewItem clon = new ListViewItem();
                clon.Text = item.Text;
                clon.Group = new ListViewGroup("Test", "Test");
                groupedListView.Items.Add(clon);
            }
            foreach (ListViewItem item in groupedListView.Items)
            {
                char primeraLetra = item.Text[0];
                ListViewGroup? grupoEncontrado = EncontrarGrupo(primeraLetra.ToString(), groupedListView);
                ListViewGroup grupo = grupoEncontrado != null ? grupoEncontrado : new ListViewGroup(primeraLetra.ToString());
                if (!groupedListView.Groups.Contains(grupo)) { groupedListView.Groups.Add(grupo); }
                item.Group = grupo;

            }
            unfilteredListView.Items.Clear();



        }
        static ListViewGroup? EncontrarGrupo(string llave, ListView listView)
        {
            foreach (ListViewGroup a in listView.Groups)
            {
                if (a.Header == llave) return a;
            }

            return null;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((palabraTextBox.Text) == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre primero");
                return;
            }
            unfilteredListView.Items.Add(new ListViewItem(palabraTextBox.Text.ToUpper()));
            palabraTextBox.Text = string.Empty;
        }

        private void randomButton_Click_1(object sender, EventArgs e)
        {
            unfilteredListView.Items.Add(new ListViewItem(GenerarPalabraRandom(10)));
        }

        static string GenerarPalabraRandom(int tamanoPalabra)
        {
            Random rnd = new Random();
            const string chars = "ABCDEFGHIJKLMNÑOPQRSTUV";
            StringBuilder word = new StringBuilder();

            for (int i = 0; i < tamanoPalabra; i++)
            {
                word.Append(chars[rnd.Next(chars.Length)]);
            }

            return word.ToString();
        }

        private void palabraTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addButton.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}