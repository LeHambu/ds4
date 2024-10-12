namespace Laboratorio122
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBoxNo1 = new TextBox();
            txtBoxNo2 = new TextBox();
            txtBoxNo3 = new TextBox();
            label5 = new Label();
            txtBoxNotaP = new TextBox();
            btnPromedio = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Nota Promedio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 81);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "NOTA No.1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 135);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "NOTA No.2";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 188);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 3;
            label4.Text = "NOTA No.3";
            label4.Click += label4_Click;
            // 
            // txtBoxNo1
            // 
            txtBoxNo1.Location = new Point(232, 73);
            txtBoxNo1.Name = "txtBoxNo1";
            txtBoxNo1.Size = new Size(100, 23);
            txtBoxNo1.TabIndex = 4;
            txtBoxNo1.TextChanged += txtBoxNo1_TextChanged;
            // 
            // txtBoxNo2
            // 
            txtBoxNo2.Location = new Point(232, 127);
            txtBoxNo2.Name = "txtBoxNo2";
            txtBoxNo2.Size = new Size(100, 23);
            txtBoxNo2.TabIndex = 5;
            // 
            // txtBoxNo3
            // 
            txtBoxNo3.Location = new Point(232, 185);
            txtBoxNo3.Name = "txtBoxNo3";
            txtBoxNo3.Size = new Size(100, 23);
            txtBoxNo3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 327);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 7;
            label5.Text = "Nota Promedio";
            // 
            // txtBoxNotaP
            // 
            txtBoxNotaP.Location = new Point(232, 319);
            txtBoxNotaP.Name = "txtBoxNotaP";
            txtBoxNotaP.Size = new Size(100, 23);
            txtBoxNotaP.TabIndex = 8;
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(86, 268);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(75, 23);
            btnPromedio.TabIndex = 9;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(232, 268);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(371, 268);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btnPromedio);
            Controls.Add(txtBoxNotaP);
            Controls.Add(label5);
            Controls.Add(txtBoxNo3);
            Controls.Add(txtBoxNo2);
            Controls.Add(txtBoxNo1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBoxNo1;
        private TextBox txtBoxNo2;
        private TextBox txtBoxNo3;
        private Label label5;
        private TextBox txtBoxNotaP;
        private Button btnPromedio;
        private Button btnReset;
        private Button btnSalir;
    }
}
