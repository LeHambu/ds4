namespace Laboratorio13
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
            btnConnection = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // btnConnection
            // 
            btnConnection.Location = new Point(162, 61);
            btnConnection.Name = "btnConnection";
            btnConnection.Size = new Size(155, 57);
            btnConnection.TabIndex = 0;
            btnConnection.Text = "Conectar y desconectar  de SQL Server";
            btnConnection.UseVisualStyleBackColor = true;
            btnConnection.Click += btnConnection_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(116, 173);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(265, 229);
            listBox1.TabIndex = 1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 487);
            Controls.Add(listBox1);
            Controls.Add(btnConnection);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnConnection;
        private ListBox listBox1;
    }
}
