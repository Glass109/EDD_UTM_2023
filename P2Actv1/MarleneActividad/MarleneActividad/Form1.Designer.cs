namespace MarleneActividad
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
            eliminadosListView = new ListView();
            agregarButton = new Button();
            eliminarButton = new Button();
            regresarButton = new Button();
            label1 = new Label();
            label2 = new Label();
            disponiblesListView = new ListView();
            detailDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            cleanButton = new Button();
            ((System.ComponentModel.ISupportInitialize)detailDataGridView).BeginInit();
            SuspendLayout();
            // 
            // eliminadosListView
            // 
            eliminadosListView.Location = new Point(321, 66);
            eliminadosListView.MultiSelect = false;
            eliminadosListView.Name = "eliminadosListView";
            eliminadosListView.Size = new Size(133, 213);
            eliminadosListView.TabIndex = 2;
            eliminadosListView.UseCompatibleStateImageBehavior = false;
            eliminadosListView.SelectedIndexChanged += eliminadosListView_SelectedIndexChanged;
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(203, 93);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(89, 23);
            agregarButton.TabIndex = 3;
            agregarButton.Text = "Agregar...";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += button1_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Enabled = false;
            eliminarButton.Location = new Point(203, 135);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(89, 23);
            eliminarButton.TabIndex = 4;
            eliminarButton.Text = "Eliminar ->";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // regresarButton
            // 
            regresarButton.Enabled = false;
            regresarButton.Location = new Point(203, 182);
            regresarButton.Name = "regresarButton";
            regresarButton.Size = new Size(89, 23);
            regresarButton.TabIndex = 5;
            regresarButton.Text = "<- Regresar";
            regresarButton.UseVisualStyleBackColor = true;
            regresarButton.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 48);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 6;
            label1.Text = "Productos disponibles";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 48);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 7;
            label2.Text = "Productos eliminados";
            // 
            // disponiblesListView
            // 
            disponiblesListView.Location = new Point(35, 66);
            disponiblesListView.MultiSelect = false;
            disponiblesListView.Name = "disponiblesListView";
            disponiblesListView.Size = new Size(148, 213);
            disponiblesListView.TabIndex = 1;
            disponiblesListView.UseCompatibleStateImageBehavior = false;
            disponiblesListView.MouseDoubleClick += disponiblesListView_MouseDoubleClick;
            // 
            // detailDataGridView
            // 
            detailDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            detailDataGridView.Location = new Point(35, 351);
            detailDataGridView.Name = "detailDataGridView";
            detailDataGridView.ReadOnly = true;
            detailDataGridView.RowHeadersWidth = 40;
            detailDataGridView.Size = new Size(419, 48);
            detailDataGridView.TabIndex = 8;
            detailDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Precio";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column3.HeaderText = "Cantidad";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // cleanButton
            // 
            cleanButton.Location = new Point(192, 430);
            cleanButton.Name = "cleanButton";
            cleanButton.Size = new Size(111, 23);
            cleanButton.TabIndex = 9;
            cleanButton.Text = "Limpiar registro";
            cleanButton.UseVisualStyleBackColor = true;
            cleanButton.Click += cleanButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(507, 476);
            Controls.Add(cleanButton);
            Controls.Add(detailDataGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(regresarButton);
            Controls.Add(eliminarButton);
            Controls.Add(agregarButton);
            Controls.Add(eliminadosListView);
            Controls.Add(disponiblesListView);
            Name = "Form1";
            Text = "Actividad 1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)detailDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView eliminadosListView;
        private Button agregarButton;
        private Button eliminarButton;
        private Button regresarButton;
        private Label label1;
        private Label label2;
        private ListView disponiblesListView;
        private DataGridView detailDataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Button cleanButton;
    }
}
