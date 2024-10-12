namespace Laboratorio12
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
            txtVel = new TextBox();
            txtTiempo = new TextBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            lblResultado = new Label();
            textBoxResultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(320, 32);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Movil";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 116);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 1;
            label2.Text = "Velocidad del Movil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 164);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Tiempo";
            // 
            // txtVel
            // 
            txtVel.Location = new Point(270, 116);
            txtVel.Margin = new Padding(3, 4, 3, 4);
            txtVel.Name = "txtVel";
            txtVel.Size = new Size(156, 27);
            txtVel.TabIndex = 3;
            txtVel.TextChanged += txtVel_TextChanged;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(270, 164);
            txtTiempo.Margin = new Padding(3, 4, 3, 4);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(156, 27);
            txtTiempo.TabIndex = 4;
            txtTiempo.TextChanged += txtTiempo_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(110, 292);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(86, 31);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(270, 292);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(421, 292);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(73, 436);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // textBoxResultado
            // 
            textBoxResultado.Location = new Point(241, 432);
            textBoxResultado.Margin = new Padding(3, 4, 3, 4);
            textBoxResultado.Name = "textBoxResultado";
            textBoxResultado.Size = new Size(114, 27);
            textBoxResultado.TabIndex = 9;
            textBoxResultado.TextChanged += textBoxResultado_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 600);
            Controls.Add(textBoxResultado);
            Controls.Add(lblResultado);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(txtTiempo);
            Controls.Add(txtVel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtVel;
        private TextBox txtTiempo;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Button btnSalir;
        private Label lblResultado;
        private TextBox textBoxResultado;
    }
}
