namespace Actividad_5
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
            ListViewGroup listViewGroup2 = new ListViewGroup("Test", HorizontalAlignment.Left);
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            groupBox1 = new GroupBox();
            randomButton = new Button();
            addButton = new Button();
            palabraTextBox = new TextBox();
            panel1 = new Panel();
            unfilteredListView = new ListView();
            label3 = new Label();
            groupButton = new Button();
            panel2 = new Panel();
            groupedListView = new ListView();
            Palabras = new ColumnHeader();
            unfilteredLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(groupButton, 2, 0);
            tableLayoutPanel1.Controls.Add(panel2, 3, 0);
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
            groupBox1.Controls.Add(addButton);
            groupBox1.Controls.Add(palabraTextBox);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(204, 494);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Palabra";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // randomButton
            // 
            randomButton.Anchor = AnchorStyles.None;
            randomButton.Location = new Point(46, 234);
            randomButton.Name = "randomButton";
            randomButton.Size = new Size(75, 48);
            randomButton.TabIndex = 10;
            randomButton.Text = "Palabra aleatoria";
            randomButton.UseVisualStyleBackColor = true;
            randomButton.Click += randomButton_Click_1;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.None;
            addButton.Location = new Point(46, 179);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 35);
            addButton.TabIndex = 9;
            addButton.Text = "Agregar";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // palabraTextBox
            // 
            palabraTextBox.Location = new Point(24, 139);
            palabraTextBox.Name = "palabraTextBox";
            palabraTextBox.Size = new Size(130, 23);
            palabraTextBox.TabIndex = 3;
            palabraTextBox.Text = "Juan";
            palabraTextBox.KeyDown += palabraTextBox_KeyDown;
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
            unfilteredListView.View = View.Tile;
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
            // groupButton
            // 
            groupButton.Anchor = AnchorStyles.None;
            groupButton.Location = new Point(495, 240);
            groupButton.Name = "groupButton";
            groupButton.Size = new Size(75, 23);
            groupButton.TabIndex = 4;
            groupButton.Text = "Agrupar";
            groupButton.UseVisualStyleBackColor = true;
            groupButton.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupedListView);
            panel2.Controls.Add(unfilteredLabel);
            panel2.Location = new Point(642, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 497);
            panel2.TabIndex = 8;
            // 
            // groupedListView
            // 
            groupedListView.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupedListView.AutoArrange = false;
            groupedListView.BorderStyle = BorderStyle.FixedSingle;
            groupedListView.Columns.AddRange(new ColumnHeader[] { Palabras });
            groupedListView.GridLines = true;
            listViewGroup2.Header = "Test";
            listViewGroup2.Name = "listViewGroup1";
            groupedListView.Groups.AddRange(new ListViewGroup[] { listViewGroup2 });
            groupedListView.Location = new Point(0, 18);
            groupedListView.Name = "groupedListView";
            groupedListView.Size = new Size(204, 465);
            groupedListView.Sorting = SortOrder.Ascending;
            groupedListView.TabIndex = 1;
            groupedListView.UseCompatibleStateImageBehavior = false;
            groupedListView.View = View.Tile;
            // 
            // Palabras
            // 
            Palabras.Width = 100;
            // 
            // unfilteredLabel
            // 
            unfilteredLabel.AutoSize = true;
            unfilteredLabel.Location = new Point(0, 0);
            unfilteredLabel.Name = "unfilteredLabel";
            unfilteredLabel.Size = new Size(60, 15);
            unfilteredLabel.TabIndex = 5;
            unfilteredLabel.Text = "Agrupado";
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
            Text = "Actividad 5";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private GroupBox groupBox1;
        private TextBox palabraTextBox;
        private Button groupButton;
        private ListView unfilteredListView;
        private Panel panel1;
        private Label label3;
        private Panel panel2;
        private ListView groupedListView;
        private Label unfilteredLabel;
        private Button addButton;
        private Button randomButton;
        private ColumnHeader Palabras;
    }
}