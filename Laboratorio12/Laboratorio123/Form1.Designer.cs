namespace Laboratorio123
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
            txtBoxArea = new Label();
            txtBoxA = new TextBox();
            txtBoxB = new TextBox();
            txtBoxC = new TextBox();
            txtBoxSemP = new TextBox();
            textBox5 = new TextBox();
            btnSemiPeri = new Button();
            btnArea = new Button();
            btnReset = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 66);
            label1.Name = "label1";
            label1.Size = new Size(161, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingresa la longitud del lado A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 113);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 1;
            label2.Text = "Ingresa la longitud del lado B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 160);
            label3.Name = "label3";
            label3.Size = new Size(161, 15);
            label3.TabIndex = 2;
            label3.Text = "Ingresa la longitud del lado C";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 322);
            label4.Name = "label4";
            label4.Size = new Size(131, 15);
            label4.TabIndex = 3;
            label4.Text = "Calcular Semiperimetro";
            // 
            // txtBoxArea
            // 
            txtBoxArea.AutoSize = true;
            txtBoxArea.Location = new Point(65, 369);
            txtBoxArea.Name = "txtBoxArea";
            txtBoxArea.Size = new Size(102, 15);
            txtBoxArea.TabIndex = 4;
            txtBoxArea.Text = "Area del Triangulo";
            // 
            // txtBoxA
            // 
            txtBoxA.Location = new Point(262, 58);
            txtBoxA.Name = "txtBoxA";
            txtBoxA.Size = new Size(100, 23);
            txtBoxA.TabIndex = 5;
            txtBoxA.TextChanged += txtBoxA_TextChanged;
            // 
            // txtBoxB
            // 
            txtBoxB.Location = new Point(262, 105);
            txtBoxB.Name = "txtBoxB";
            txtBoxB.Size = new Size(100, 23);
            txtBoxB.TabIndex = 6;
            // 
            // txtBoxC
            // 
            txtBoxC.Location = new Point(262, 152);
            txtBoxC.Name = "txtBoxC";
            txtBoxC.Size = new Size(100, 23);
            txtBoxC.TabIndex = 7;
            // 
            // txtBoxSemP
            // 
            txtBoxSemP.Location = new Point(262, 314);
            txtBoxSemP.Name = "txtBoxSemP";
            txtBoxSemP.Size = new Size(100, 23);
            txtBoxSemP.TabIndex = 8;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(262, 366);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            // 
            // btnSemiPeri
            // 
            btnSemiPeri.Location = new Point(65, 240);
            btnSemiPeri.Name = "btnSemiPeri";
            btnSemiPeri.Size = new Size(99, 23);
            btnSemiPeri.TabIndex = 10;
            btnSemiPeri.Text = "Semiperimetro";
            btnSemiPeri.UseVisualStyleBackColor = true;
            btnSemiPeri.Click += btnSemiPeri_Click;
            // 
            // btnArea
            // 
            btnArea.Location = new Point(207, 240);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(75, 23);
            btnArea.TabIndex = 11;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(322, 240);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 12;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(457, 240);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salida";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnReset);
            Controls.Add(btnArea);
            Controls.Add(btnSemiPeri);
            Controls.Add(textBox5);
            Controls.Add(txtBoxSemP);
            Controls.Add(txtBoxC);
            Controls.Add(txtBoxB);
            Controls.Add(txtBoxA);
            Controls.Add(txtBoxArea);
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
        private Label txtBoxArea;
        private TextBox txtBoxA;
        private TextBox txtBoxB;
        private TextBox txtBoxC;
        private TextBox txtBoxSemP;
        private TextBox textBox5;
        private Button btnSemiPeri;
        private Button btnArea;
        private Button btnReset;
        private Button btnSalir;
    }
}
