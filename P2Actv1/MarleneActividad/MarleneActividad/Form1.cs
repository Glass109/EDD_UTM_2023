using System.Runtime.InteropServices.Marshalling;

namespace MarleneActividad
{
    public partial class Form1 : Form
    {

        int productNameNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (disponiblesListView.SelectedItems.Count > 0)
                detallarProducto();
            revisarEstadoBotones();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createNAddProduct();
            revisarEstadoBotones();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            regresarItem();
            revisarEstadoBotones();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cleanButton_Click(object sender, EventArgs e)
        {
            detailDataGridView.Rows.Clear();
        }
        private void eliminadosListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            revisarEstadoBotones();
        }

        //
        // METODOS CREADOS A MANO
        //

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            elminarItem();
            revisarEstadoBotones();
        }

        void createNAddProduct()
        {
            Product product = new Product("Producto #" + ++productNameNumber);
            ListViewItem item = new ListViewItem(product.Name);
            item.Tag = product;
            disponiblesListView.Items.Add(item);
        }
        void elminarItem()
        {
            ListViewItem item = (ListViewItem)disponiblesListView.SelectedItems[0];
            disponiblesListView.Items.Remove(disponiblesListView.SelectedItems[0]);
            eliminadosListView.Items.Add(item);
            if (disponiblesListView.Items.Count > 0)
                disponiblesListView.Items[0].Selected = true;
        }
        void regresarItem()
        {
            ListViewItem item = eliminadosListView.SelectedItems[0];
            eliminadosListView.Items.Remove(item);
            disponiblesListView.Items.Add(item);
            if (disponiblesListView.Items.Count > 0)
                disponiblesListView.Items[0].Selected = true;
        }
        void revisarEstadoBotones()
        {
            eliminarButton.Enabled = disponiblesListView.Items.Count > 0 && disponiblesListView.SelectedItems.Count > 0 ? true : false;
            regresarButton.Enabled = eliminadosListView.Items.Count > 0 && eliminadosListView.SelectedItems.Count > 0 ? true : false;
        }
        void detallarProducto()
        {
            var seleccionado = disponiblesListView.SelectedItems[0];
            Product prod = (Product)seleccionado.Tag!;

            DataGridViewRow fila1 = new DataGridViewRow();

            DataGridViewTextBoxCell nameDataCell = new DataGridViewTextBoxCell();
            nameDataCell.Value = seleccionado.Text;
            fila1.Cells.Add(nameDataCell);
            DataGridViewTextBoxCell priceDataCell = new DataGridViewTextBoxCell();
            priceDataCell.Value = prod.Price;
            fila1.Cells.Add(priceDataCell);
            DataGridViewTextBoxCell qtyDataCell = new DataGridViewTextBoxCell();
            qtyDataCell.Value = prod.Qty;
            fila1.Cells.Add(qtyDataCell);
            detailDataGridView.Rows.Add(fila1);
        }

        
    }


}

    