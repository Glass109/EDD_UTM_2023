namespace Actividad2
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
            listView1 = new ListView();
            listView2 = new ListView();
            listView3 = new ListView();
            randomFillButton = new Button();
            groupButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(19, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(212, 330);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            listView2.Location = new Point(260, 40);
            listView2.Name = "listView2";
            listView2.Size = new Size(239, 415);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            listView3.Location = new Point(528, 40);
            listView3.Name = "listView3";
            listView3.Size = new Size(239, 415);
            listView3.TabIndex = 2;
            listView3.UseCompatibleStateImageBehavior = false;
            // 
            // randomFillButton
            // 
            randomFillButton.Location = new Point(19, 388);
            randomFillButton.Name = "randomFillButton";
            randomFillButton.Size = new Size(212, 23);
            randomFillButton.TabIndex = 3;
            randomFillButton.Text = "Rellenar";
            randomFillButton.UseVisualStyleBackColor = true;
            randomFillButton.Click += randomFillButton_Click;
            // 
            // groupButton
            // 
            groupButton.Location = new Point(19, 417);
            groupButton.Name = "groupButton";
            groupButton.Size = new Size(212, 23);
            groupButton.TabIndex = 4;
            groupButton.Text = "Filtrar";
            groupButton.UseVisualStyleBackColor = true;
            groupButton.Click += groupButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 22);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 5;
            label1.Text = "Todos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 22);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 6;
            label2.Text = "Pares";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 22);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 7;
            label3.Text = "Inpares";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(randomFillButton);
            Controls.Add(groupButton);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private Button randomFillButton;
        private Button groupButton;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}