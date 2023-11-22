namespace Actv1;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        nameLabel = new Label();
        weightLabel = new Label();
        plateLabel = new Label();
        brandLabel = new Label();
        button1 = new Button();
        tabla = new DataGridView();
        SelectButtonColumn = new DataGridViewButtonColumn();
        nameTextBox = new TextBox();
        weightTextBox = new TextBox();
        plateTextBox = new TextBox();
        brandTextBox = new TextBox();
        button2 = new Button();
        button3 = new Button();
        ((System.ComponentModel.ISupportInitialize)tabla).BeginInit();
        SuspendLayout();
        // 
        // nameLabel
        // 
        nameLabel.AutoSize = true;
        nameLabel.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
        nameLabel.Location = new Point(115, 9);
        nameLabel.Name = "nameLabel";
        nameLabel.Size = new Size(113, 32);
        nameLabel.TabIndex = 0;
        nameLabel.Text = "Nombre";
        // 
        // weightLabel
        // 
        weightLabel.AutoSize = true;
        weightLabel.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
        weightLabel.Location = new Point(311, 9);
        weightLabel.Name = "weightLabel";
        weightLabel.Size = new Size(299, 32);
        weightLabel.TabIndex = 2;
        weightLabel.Text = "Tonelaje de almacenaje";
        // 
        // plateLabel
        // 
        plateLabel.AutoSize = true;
        plateLabel.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
        plateLabel.Location = new Point(124, 106);
        plateLabel.Name = "plateLabel";
        plateLabel.Size = new Size(92, 32);
        plateLabel.TabIndex = 4;
        plateLabel.Text = "Placas";
        // 
        // brandLabel
        // 
        brandLabel.AutoSize = true;
        brandLabel.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
        brandLabel.Location = new Point(409, 106);
        brandLabel.Name = "brandLabel";
        brandLabel.Size = new Size(90, 32);
        brandLabel.TabIndex = 5;
        brandLabel.Text = "Marca";
        // 
        // button1
        // 
        button1.Font = new Font("Cambria", 24F, FontStyle.Bold);
        button1.Location = new Point(856, 12);
        button1.Name = "button1";
        button1.Size = new Size(223, 105);
        button1.TabIndex = 8;
        button1.Text = "Agregar";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // tabla
        // 
        tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        tabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        tabla.Columns.AddRange(new DataGridViewColumn[] { SelectButtonColumn });
        tabla.Location = new Point(28, 193);
        tabla.Name = "tabla";
        tabla.Size = new Size(1051, 384);
        tabla.TabIndex = 9;
        tabla.CellContentClick += dataGridView1_CellContentClick;
        // 
        // SelectButtonColumn
        // 
        SelectButtonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        SelectButtonColumn.HeaderText = "SELECCIONAR";
        SelectButtonColumn.Name = "SelectButtonColumn";
        SelectButtonColumn.Text = "SELECT";
        SelectButtonColumn.UseColumnTextForButtonValue = true;
        SelectButtonColumn.Width = 89;
        // 
        // nameTextBox
        // 
        nameTextBox.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
        nameTextBox.Location = new Point(37, 44);
        nameTextBox.Name = "nameTextBox";
        nameTextBox.Size = new Size(277, 39);
        nameTextBox.TabIndex = 10;
        // 
        // weightTextBox
        // 
        weightTextBox.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
        weightTextBox.Location = new Point(320, 44);
        weightTextBox.Name = "weightTextBox";
        weightTextBox.Size = new Size(277, 39);
        weightTextBox.TabIndex = 11;
        weightTextBox.TextChanged += weightTextBox_TextChanged;
        // 
        // plateTextBox
        // 
        plateTextBox.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
        plateTextBox.Location = new Point(37, 141);
        plateTextBox.Name = "plateTextBox";
        plateTextBox.Size = new Size(277, 39);
        plateTextBox.TabIndex = 12;
        // 
        // brandTextBox
        // 
        brandTextBox.Font = new Font("Cambria", 20.25F, FontStyle.Bold);
        brandTextBox.Location = new Point(320, 141);
        brandTextBox.Name = "brandTextBox";
        brandTextBox.Size = new Size(277, 39);
        brandTextBox.TabIndex = 13;
        // 
        // button2
        // 
        button2.Font = new Font("Cambria", 24F, FontStyle.Bold);
        button2.Location = new Point(626, 12);
        button2.Name = "button2";
        button2.Size = new Size(223, 105);
        button2.TabIndex = 14;
        button2.Text = "Buscar";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Font = new Font("Cambria", 24F, FontStyle.Bold);
        button3.Location = new Point(626, 123);
        button3.Name = "button3";
        button3.Size = new Size(453, 52);
        button3.TabIndex = 15;
        button3.Text = "Vaciar búsqueda";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1115, 589);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(brandTextBox);
        Controls.Add(plateTextBox);
        Controls.Add(weightTextBox);
        Controls.Add(nameTextBox);
        Controls.Add(tabla);
        Controls.Add(button1);
        Controls.Add(brandLabel);
        Controls.Add(plateLabel);
        Controls.Add(weightLabel);
        Controls.Add(nameLabel);
        Name = "Form1";
        Text = "Refaccionaria";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)tabla).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label nameLabel;
    private Label weightLabel;
    private Label plateLabel;
    private Label brandLabel;
    private Button button1;
    private DataGridView tabla;
    private TextBox nameTextBox;
    private TextBox weightTextBox;
    private TextBox plateTextBox;
    private TextBox brandTextBox;
    private Button button2;
    private Button button3;
    private DataGridViewButtonColumn SelectButtonColumn;
}