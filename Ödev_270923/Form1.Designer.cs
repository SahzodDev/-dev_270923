namespace Ödev_270923
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
            txtSifre = new TextBox();
            lblSifreZorlugu = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(269, 63);
            label1.Name = "label1";
            label1.Size = new Size(226, 28);
            label1.TabIndex = 0;
            label1.Text = "Şifre Kontrol Programı";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(84, 154);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(647, 27);
            txtSifre.TabIndex = 1;
            txtSifre.TextChanged += textBox1_TextChanged;
            // 
            // lblSifreZorlugu
            // 
            lblSifreZorlugu.AutoSize = true;
            lblSifreZorlugu.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lblSifreZorlugu.Location = new Point(84, 289);
            lblSifreZorlugu.Name = "lblSifreZorlugu";
            lblSifreZorlugu.Size = new Size(0, 35);
            lblSifreZorlugu.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSifreZorlugu);
            Controls.Add(txtSifre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSifre;
        private Label lblSifreZorlugu;
    }
}