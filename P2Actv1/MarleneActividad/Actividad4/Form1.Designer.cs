namespace Actividad4
{
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
            dataGridView1 = new DataGridView();
            productNameColumn = new DataGridViewTextBoxColumn();
            priceColumn = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            groupBox1 = new GroupBox();
            rndProdButton = new Button();
            addButton = new Button();
            precioNumericBox = new NumericUpDown();
            nameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)precioNumericBox).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productNameColumn, priceColumn });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.Location = new Point(217, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.Size = new Size(240, 294);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 0;
            dataGridView1.RowsAdded += dataGridView1_RowsAdded;
            // 
            // productNameColumn
            // 
            productNameColumn.HeaderText = "Producto";
            productNameColumn.Name = "productNameColumn";
            // 
            // priceColumn
            // 
            priceColumn.HeaderText = "Precio";
            priceColumn.Name = "priceColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Precio";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Producto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridView2.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView2.Location = new Point(217, 327);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView2.Size = new Size(240, 99);
            dataGridView2.StandardTab = true;
            dataGridView2.TabIndex = 1;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rndProdButton);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(precioNumericBox);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(32, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(162, 242);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Producto";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rndProdButton
            // 
            rndProdButton.Location = new Point(17, 184);
            rndProdButton.Name = "rndProdButton";
            rndProdButton.Size = new Size(111, 40);
            rndProdButton.TabIndex = 4;
            rndProdButton.Text = "Producto Random";
            rndProdButton.UseVisualStyleBackColor = true;
            rndProdButton.Click += rndProdButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(17, 155);
            addButton.Name = "addButton";
            addButton.Size = new Size(111, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // precioNumericBox
            // 
            precioNumericBox.DecimalPlaces = 2;
            precioNumericBox.Location = new Point(17, 115);
            precioNumericBox.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            precioNumericBox.Name = "precioNumericBox";
            precioNumericBox.Size = new Size(111, 23);
            precioNumericBox.TabIndex = 3;
            precioNumericBox.Value = new decimal(new int[] { 1505, 0, 0, 65536 });
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(17, 47);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(111, 23);
            nameTextBox.TabIndex = 2;
            nameTextBox.Text = "Pescado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 83);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Precio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 19);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 429);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(dataGridView2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)precioNumericBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn productNameColumn;
        private DataGridViewTextBoxColumn priceColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridView dataGridView2;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private NumericUpDown precioNumericBox;
        private TextBox nameTextBox;
        private Button addButton;
        private Button rndProdButton;
    }
}