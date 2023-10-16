namespace Actividad3
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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            nombreTextbox = new TextBox();
            addButton = new Button();
            califNumeric = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            splitContainer1 = new SplitContainer();
            aprobadosLabel = new Label();
            aprobadosListView = new ListView();
            reprobadosLabel = new Label();
            reprobadosListView = new ListView();
            panel1 = new Panel();
            unfilteredListView = new ListView();
            label3 = new Label();
            randomButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)califNumeric).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 2, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 3, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Location = new Point(18, 15);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(852, 503);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(207, 497);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(randomButton);
            groupBox1.Controls.Add(nombreTextbox);
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(califNumeric);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 494);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alumno";
            // 
            // nombreTextbox
            // 
            nombreTextbox.Location = new Point(6, 111);
            nombreTextbox.Name = "nombreTextbox";
            nombreTextbox.Size = new Size(130, 23);
            nombreTextbox.TabIndex = 3;
            nombreTextbox.Text = "Juan";
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom;
            addButton.Location = new Point(61, 330);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // califNumeric
            // 
            califNumeric.DecimalPlaces = 1;
            califNumeric.Location = new Point(7, 206);
            califNumeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            califNumeric.Name = "califNumeric";
            califNumeric.Size = new Size(129, 23);
            califNumeric.TabIndex = 2;
            califNumeric.Value = new decimal(new int[] { 82, 0, 0, 65536 });
            // 
            // label2
            // 
            label2.Location = new Point(6, 158);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 1;
            label2.Text = "Calificacion";
            // 
            // label1
            // 
            label1.Location = new Point(6, 74);
            label1.Name = "label1";
            label1.Size = new Size(171, 117);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(495, 240);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Filtrar ->";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(642, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(aprobadosLabel);
            splitContainer1.Panel1.Controls.Add(aprobadosListView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(reprobadosLabel);
            splitContainer1.Panel2.Controls.Add(reprobadosListView);
            splitContainer1.Size = new Size(207, 497);
            splitContainer1.SplitterDistance = 248;
            splitContainer1.TabIndex = 2;
            // 
            // aprobadosLabel
            // 
            aprobadosLabel.AutoSize = true;
            aprobadosLabel.Location = new Point(0, 0);
            aprobadosLabel.Name = "aprobadosLabel";
            aprobadosLabel.Size = new Size(60, 15);
            aprobadosLabel.TabIndex = 2;
            aprobadosLabel.Text = "Aprobado";
            // 
            // aprobadosListView
            // 
            aprobadosListView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            aprobadosListView.AutoArrange = false;
            aprobadosListView.BorderStyle = BorderStyle.FixedSingle;
            aprobadosListView.GridLines = true;
            aprobadosListView.Location = new Point(3, 18);
            aprobadosListView.Name = "aprobadosListView";
            aprobadosListView.Size = new Size(207, 230);
            aprobadosListView.TabIndex = 1;
            aprobadosListView.UseCompatibleStateImageBehavior = false;
            aprobadosListView.View = View.List;
            // 
            // reprobadosLabel
            // 
            reprobadosLabel.AutoSize = true;
            reprobadosLabel.Location = new Point(3, 7);
            reprobadosLabel.Name = "reprobadosLabel";
            reprobadosLabel.Size = new Size(65, 15);
            reprobadosLabel.TabIndex = 3;
            reprobadosLabel.Text = "Reprobado";
            // 
            // reprobadosListView
            // 
            reprobadosListView.AutoArrange = false;
            reprobadosListView.BorderStyle = BorderStyle.FixedSingle;
            reprobadosListView.GridLines = true;
            reprobadosListView.Location = new Point(0, 25);
            reprobadosListView.Name = "reprobadosListView";
            reprobadosListView.Size = new Size(207, 220);
            reprobadosListView.TabIndex = 1;
            reprobadosListView.UseCompatibleStateImageBehavior = false;
            reprobadosListView.View = View.List;
            // 
            // panel1
            // 
            panel1.Controls.Add(unfilteredListView);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(216, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(207, 497);
            panel1.TabIndex = 7;
            // 
            // unfilteredListView
            // 
            unfilteredListView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            unfilteredListView.AutoArrange = false;
            unfilteredListView.BorderStyle = BorderStyle.FixedSingle;
            unfilteredListView.GridLines = true;
            unfilteredListView.Location = new Point(0, 23);
            unfilteredListView.Name = "unfilteredListView";
            unfilteredListView.Size = new Size(204, 465);
            unfilteredListView.TabIndex = 1;
            unfilteredListView.UseCompatibleStateImageBehavior = false;
            unfilteredListView.View = View.List;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 5;
            label3.Text = "Sin filtrar";
            // 
            // randomButton
            // 
            randomButton.Anchor = AnchorStyles.Bottom;
            randomButton.Location = new Point(61, 370);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(75, 23);
            randomButton.TabIndex = 4;
            randomButton.Text = "Random";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 532);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)califNumeric).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox nombreTextbox;
        private NumericUpDown califNumeric;
        private Label label2;
        private Label label1;
        private Button addButton;
        private SplitContainer splitContainer1;
        private ListView aprobadosListView;
        private ListView reprobadosListView;
        private Button button2;
        private ListView unfilteredListView;
        private Label aprobadosLabel;
        private Label reprobadosLabel;
        private Panel panel1;
        private Label label3;
        private Button randomButton;
    }
}