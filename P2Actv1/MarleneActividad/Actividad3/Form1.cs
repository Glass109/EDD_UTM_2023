namespace Actividad3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nombreTextbox.Text))
            {
                MessageBox.Show("RELLENA LOS DATOS PRIMERO");
                return;
            }
            Alumno alumno = new Alumno(nombreTextbox.Text,
                                      califNumeric.Value > 0 ? (float)califNumeric.Value : 0);
            ListViewItem alumnoItem = alumnoToItem(alumno);
            unfilteredListView.Items.Add(alumnoItem);


        }

        ListViewItem alumnoToItem(Alumno a)
        {
            ListViewItem alumnoItem = new ListViewItem();
            alumnoItem.Text = a.Name + ": " + a.Calificacion;
            alumnoItem.Tag = a;
            return alumnoItem;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<ListViewItem> aprobadosList = new List<ListViewItem>();
            List<ListViewItem> reprobadosList = new List<ListViewItem>();
            foreach (ListViewItem a in unfilteredListView.Items)
            {
                if (((Alumno)a.Tag).Calificacion < 7) reprobadosList.Add(a);
                else aprobadosList.Add(a);
            }
            unfilteredListView.Items.Clear();
            aprobadosListView.Items.AddRange(aprobadosList.ToArray());
            reprobadosListView.Items.AddRange(reprobadosList.ToArray());
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            ListViewItem alumnoItem = alumnoToItem(alumno);
            unfilteredListView.Items.Add(alumnoItem);
        }
    }
}