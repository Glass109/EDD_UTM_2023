
namespace simuladorABB
{
    public partial class Form1 : Form
    {
        ArbolBinario arbolito;
        public Form1()
        {
            InitializeComponent();
            arbolito = new ArbolBinario();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int valor;
            try
            {
                valor = int.Parse(insertarTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un valor valido");
                return;
            }

            arbolito.Insertar(valor);
            actualizarTabla();
        }


        private void actualizarButton_Click(object sender, EventArgs e)
        {
            actualizarTabla();
        }

        private void actualizarTabla()
        {
            int[,] matrix = arbolito.aMatriz();
            MatrizADatagridview(ref tablita, matrix);
            CambiarCerosAStringsVacios(tablita);
            tablita.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablita.Update();
        }

        public void MatrizADatagridview(ref DataGridView tabla, int[,] matrix)
        {
            tabla.ColumnCount = matrix.GetLength(1);
            tabla.RowCount = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    tabla.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }
        public void CambiarCerosAStringsVacios(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString() == "0")
                    {
                        cell.Value = string.Empty;
                        cell.Style.BackColor = Color.Aqua;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void RecorridoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arbolito.RecorridoPreOrder());
        }

        private void BorrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                int.Parse(borrarTB.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un valor valido");
                return;
            }
            arbolito.Eliminar(int.Parse(borrarTB.Text));
            actualizarTabla();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            var nodoEncontrado = arbolito.Buscar(int.Parse(buscarTB.Text));
            if (nodoEncontrado != null)
                MessageBox.Show("Nodo encontrado");
            else
                MessageBox.Show("Nodo no encontrado");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arbolito.RecorridoPostOrder());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(arbolito.RecorridoInOrder());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(arbolito.RecorridoPorAnchura());
        }
    }
}
