namespace simuladorABB
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
            tablita = new DataGridView();
            insertarTB = new TextBox();
            InsertarButton = new Button();
            borrarTB = new TextBox();
            BorrarButton = new Button();
            BuscarButton = new Button();
            buscarTB = new TextBox();
            RecorridoButton = new Button();
            actualizarButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)tablita).BeginInit();
            SuspendLayout();
            // 
            // tablita
            // 
            tablita.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablita.Location = new Point(23, 133);
            tablita.Name = "tablita";
            tablita.RowTemplate.Height = 25;
            tablita.Size = new Size(1805, 785);
            tablita.TabIndex = 0;
            // 
            // insertarTB
            // 
            insertarTB.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            insertarTB.Location = new Point(51, 12);
            insertarTB.Name = "insertarTB";
            insertarTB.Size = new Size(359, 39);
            insertarTB.TabIndex = 2;
            // 
            // InsertarButton
            // 
            InsertarButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            InsertarButton.Location = new Point(51, 57);
            InsertarButton.Name = "InsertarButton";
            InsertarButton.Size = new Size(359, 57);
            InsertarButton.TabIndex = 3;
            InsertarButton.Text = "Insertar";
            InsertarButton.UseVisualStyleBackColor = true;
            InsertarButton.Click += button1_Click;
            // 
            // borrarTB
            // 
            borrarTB.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            borrarTB.Location = new Point(437, 12);
            borrarTB.Name = "borrarTB";
            borrarTB.Size = new Size(359, 39);
            borrarTB.TabIndex = 4;
            // 
            // BorrarButton
            // 
            BorrarButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BorrarButton.Location = new Point(437, 57);
            BorrarButton.Name = "BorrarButton";
            BorrarButton.Size = new Size(359, 57);
            BorrarButton.TabIndex = 5;
            BorrarButton.Text = "Borrar";
            BorrarButton.UseVisualStyleBackColor = true;
            BorrarButton.Click += BorrarButton_Click;
            // 
            // BuscarButton
            // 
            BuscarButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            BuscarButton.Location = new Point(807, 57);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(359, 57);
            BuscarButton.TabIndex = 6;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = true;
            BuscarButton.Click += BuscarButton_Click;
            // 
            // buscarTB
            // 
            buscarTB.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buscarTB.Location = new Point(807, 12);
            buscarTB.Name = "buscarTB";
            buscarTB.Size = new Size(359, 39);
            buscarTB.TabIndex = 7;
            // 
            // RecorridoButton
            // 
            RecorridoButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RecorridoButton.Location = new Point(1195, 12);
            RecorridoButton.Name = "RecorridoButton";
            RecorridoButton.Size = new Size(129, 50);
            RecorridoButton.TabIndex = 8;
            RecorridoButton.Text = "PreOrden";
            RecorridoButton.UseVisualStyleBackColor = true;
            RecorridoButton.Click += RecorridoButton_Click;
            // 
            // actualizarButton
            // 
            actualizarButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            actualizarButton.Location = new Point(1501, 12);
            actualizarButton.Name = "actualizarButton";
            actualizarButton.Size = new Size(311, 102);
            actualizarButton.TabIndex = 9;
            actualizarButton.Text = "Actualizar";
            actualizarButton.UseVisualStyleBackColor = true;
            actualizarButton.Click += actualizarButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1195, 64);
            button1.Name = "button1";
            button1.Size = new Size(129, 50);
            button1.TabIndex = 10;
            button1.Text = "InOrden";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1327, 64);
            button2.Name = "button2";
            button2.Size = new Size(129, 50);
            button2.TabIndex = 12;
            button2.Text = "Anchura";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(1327, 12);
            button3.Name = "button3";
            button3.Size = new Size(129, 50);
            button3.TabIndex = 11;
            button3.Text = "PostOrden";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1849, 930);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(actualizarButton);
            Controls.Add(RecorridoButton);
            Controls.Add(buscarTB);
            Controls.Add(BuscarButton);
            Controls.Add(BorrarButton);
            Controls.Add(borrarTB);
            Controls.Add(InsertarButton);
            Controls.Add(insertarTB);
            Controls.Add(tablita);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tablita).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView tablita;
        private TextBox insertarTB;
        private Button InsertarButton;
        private TextBox borrarTB;
        private Button BorrarButton;
        private Button BuscarButton;
        private TextBox buscarTB;
        private Button RecorridoButton;
        private Button actualizarButton;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
