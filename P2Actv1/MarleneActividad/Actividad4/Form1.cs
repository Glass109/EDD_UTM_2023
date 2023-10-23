namespace Actividad4
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text)) return;

            dataGridView1.Rows.Add(nameTextBox.Text, precioNumericBox.Value);
            nameTextBox.Clear();
            precioNumericBox.Value = 50;
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            decimal numTotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                numTotal += (decimal)row.Cells[1].Value;
            }

            cambiarTotal(numTotal);
        }

        void cambiarTotal(decimal total)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                dataGridView2.Rows.Add("Total", 0M);
            }
            dataGridView2.Rows[0].Cells[1].Value = total;
        }

        private void rndProdButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string[] nombresProductos = {
                "Camiseta",
                "Pantalones",
                "Zapatos deportivos",
                "Reloj",
                "Mochila",
                "Portátil",
                "Teléfono móvil",
                "Auriculares",
                "Televisor",
                "Lavadora",
                "Refrigeradora",
                "Microondas",
                "Sofá",
                "Mesa de comedor",
                "Silla",
                "Libro",
                "Gafas de sol",
                "Cámara digital",
                "Impresora",
                "Tablet",
                "Bolso de mano",
                "Cepillo de dientes",
                "Jabón de baño",
                "Champú",
                "Cepillo de pelo",
                "Bicicleta",
                "Monitor de computadora",
                "Teclado",
                "Mouse",
                "Altavoces",
                "Horno tostador",
                "Horno de microondas",
                "Licuadora",
                "Cafetera",
                "Sartén",
                "Cuchillo de chef",
                "Tetera",
                "Secadora de pelo",
                "Plancha de ropa",
                "Aspiradora",
                "Hojas de papel",
                "Lápices de colores",
                "Pintura al óleo",
                "Batería externa",
                "Juego de ajedrez",
                "Pelota de fútbol",
                "Raqueta de tenis",
                "Guantes de jardinería",
                "Saco de dormir"
            };
            dataGridView1.Rows.Add(nombresProductos[rnd.Next(nombresProductos.Length)], (decimal)(rnd.Next(10000) * .01));
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}