namespace Parcial2
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
            btnLbsKg = new Button();
            btnKgLbs = new Button();
            label1 = new Label();
            label2 = new Label();
            txtLibras = new TextBox();
            txtKg = new TextBox();
            label3 = new Label();
            txtResultadoLbs = new TextBox();
            txtResultadoKg = new TextBox();
            lstHistorial = new ListBox();
            SuspendLayout();
            // 
            // btnLbsKg
            // 
            btnLbsKg.Location = new Point(397, 110);
            btnLbsKg.Name = "btnLbsKg";
            btnLbsKg.Size = new Size(94, 29);
            btnLbsKg.TabIndex = 0;
            btnLbsKg.Text = "Convertir";
            btnLbsKg.UseVisualStyleBackColor = true;
            btnLbsKg.Click += btnLbsKg_Click;
            // 
            // btnKgLbs
            // 
            btnKgLbs.Location = new Point(397, 173);
            btnKgLbs.Name = "btnKgLbs";
            btnKgLbs.Size = new Size(94, 29);
            btnKgLbs.TabIndex = 1;
            btnKgLbs.Text = "Convertir";
            btnKgLbs.UseVisualStyleBackColor = true;
            btnKgLbs.Click += btnKgLbs_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 114);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 2;
            label1.Text = "Libras a Kilogramos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 182);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 3;
            label2.Text = "Kilogramos a Libras";
            // 
            // txtLibras
            // 
            txtLibras.Location = new Point(188, 112);
            txtLibras.Name = "txtLibras";
            txtLibras.Size = new Size(148, 27);
            txtLibras.TabIndex = 4;
            // 
            // txtKg
            // 
            txtKg.Location = new Point(188, 182);
            txtKg.Name = "txtKg";
            txtKg.Size = new Size(148, 27);
            txtKg.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 29);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 6;
            label3.Text = "Convertidor";
            label3.Click += label3_Click;
            // 
            // txtResultadoLbs
            // 
            txtResultadoLbs.Location = new Point(579, 175);
            txtResultadoLbs.Name = "txtResultadoLbs";
            txtResultadoLbs.Size = new Size(156, 27);
            txtResultadoLbs.TabIndex = 7;
            // 
            // txtResultadoKg
            // 
            txtResultadoKg.Location = new Point(579, 114);
            txtResultadoKg.Name = "txtResultadoKg";
            txtResultadoKg.Size = new Size(156, 27);
            txtResultadoKg.TabIndex = 8;
            // 
            // lstHistorial
            // 
            lstHistorial.FormattingEnabled = true;
            lstHistorial.Location = new Point(29, 259);
            lstHistorial.Name = "lstHistorial";
            lstHistorial.Size = new Size(150, 104);
            lstHistorial.TabIndex = 9;
            lstHistorial.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstHistorial);
            Controls.Add(txtResultadoKg);
            Controls.Add(txtResultadoLbs);
            Controls.Add(label3);
            Controls.Add(txtKg);
            Controls.Add(txtLibras);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnKgLbs);
            Controls.Add(btnLbsKg);
            Name = "Form1";
            Text = "Convertidor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLbsKg;
        private Button btnKgLbs;
        private Label label1;
        private Label label2;
        private TextBox txtLibras;
        private TextBox txtKg;
        private Label label3;
        private TextBox txtResultadoLbs;
        private TextBox txtResultadoKg;
        private ListBox lstHistorial;
    }
}
