using System.Data;
using MySql.Data.MySqlClient;

namespace Actv1;

public partial class Form1 : Form
{
    private MySqlConnection mySqlConnection;
    private MySqlDataAdapter mySqlDataAdapter;
    private DataTable dataTable;
    private string connectionString = "Server=localhost;Database=refaccionaria;Uid=root;\r\n";

    public Form1()
    {
        InitializeComponent();
        // Initialize SqlConnection and SqlDataAdapter
        reemplazarDatos(connectionString);
    }

    private void reemplazarDatos(string connectionString)
    {
        mySqlConnection = new(connectionString);
        mySqlDataAdapter = new("SELECT * FROM Camion", mySqlConnection);
        dataTable = new DataTable();
        mySqlDataAdapter.Fill(dataTable);
        tabla.DataSource = dataTable;
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        List<string> items = new();
        var row = tabla.Rows[e.RowIndex];
        foreach (DataGridViewCell cell in row.Cells)
        {
            items.Add(cell.Value.ToString());
        }

        MessageBox.Show(string.Join('\n', items))
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (mySqlConnection.State == ConnectionState.Closed)
        {
            mySqlConnection.Open();
        }
        //Preparense para la solución más harcodeada que he visto
        //Extrae el valor de los textbox y los inserta en la base de datos
        string query = $"INSERT INTO Camion (Nombre, Marca, Totalmacenaje, Placas) VALUES ('{nameTextBox.Text}', '{brandTextBox.Text}', '{weightTextBox.Text}', '{plateTextBox.Text}')";
        MySqlCommand command = new(query, mySqlConnection);
        command.ExecuteNonQuery();
        reemplazarDatos(connectionString);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
     
    }

    private void weightTextBox_TextChanged(object sender, EventArgs e)
    {
        //Cuando el texto cambie, cambia el TextBox a un color aleatorio
        Random random = new();
        weightTextBox.BackColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));


    }

    private void button3_Click(object sender, EventArgs e)
    {
        emptyAllTextBox();
        reemplazarDatos(connectionString);
    }

    private void emptyAllTextBox()
    {
        foreach (Control control in this.Controls)
        {
            if (control is TextBox)
            {
                ((TextBox)control).Text = "";
            }
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        //NO TENGO IDEA DE COMO HICE ESTO, PERO FUNCIONA
        string query = "SELECT * FROM Camion";
        List<string> conditions = new List<string>();

        if (!string.IsNullOrEmpty(nameTextBox.Text))
            conditions.Add($"Nombre LIKE '%{nameTextBox.Text}%'");
        if (!string.IsNullOrEmpty(brandTextBox.Text))
            conditions.Add($"Marca LIKE '%{brandTextBox.Text}%'");
        if (!string.IsNullOrEmpty(weightTextBox.Text))
            conditions.Add($"Totalmacenaje LIKE '%{weightTextBox.Text}%'");
        if (!string.IsNullOrEmpty(plateTextBox.Text))
            conditions.Add($"Placas LIKE '%{plateTextBox.Text}%'");

        if (conditions.Count > 0) 
            query += " WHERE " + string.Join(" AND ", conditions);


        MySqlCommand command = new(query, mySqlConnection);
        mySqlDataAdapter = new(command);
        dataTable = new DataTable();
        mySqlDataAdapter.Fill(dataTable);
        tabla.DataSource = dataTable;   
    }
}