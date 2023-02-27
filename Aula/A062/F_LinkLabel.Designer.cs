namespace A062
{
    partial class F_LinkLabel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            ll_canal = new LinkLabel();
            ll_calculadora = new LinkLabel();
            ll_multiplosLinks = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite seu Nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(287, 23);
            textBox1.TabIndex = 1;
            // 
            // ll_canal
            // 
            ll_canal.AutoSize = true;
            ll_canal.Location = new Point(12, 99);
            ll_canal.Name = "ll_canal";
            ll_canal.Size = new Size(37, 15);
            ll_canal.TabIndex = 2;
            ll_canal.TabStop = true;
            ll_canal.Text = "Canal";
            ll_canal.LinkClicked += Ll_canal_LinkClicked;
            // 
            // ll_calculadora
            // 
            ll_calculadora.AutoSize = true;
            ll_calculadora.Location = new Point(83, 99);
            ll_calculadora.Name = "ll_calculadora";
            ll_calculadora.Size = new Size(70, 15);
            ll_calculadora.TabIndex = 3;
            ll_calculadora.TabStop = true;
            ll_calculadora.Text = "Calculadora";
            ll_calculadora.LinkClicked += Ll_calculadora_LinkClicked;
            // 
            // ll_multiplosLinks
            // 
            ll_multiplosLinks.AutoSize = true;
            ll_multiplosLinks.Location = new Point(12, 162);
            ll_multiplosLinks.Name = "ll_multiplosLinks";
            ll_multiplosLinks.Size = new Size(141, 15);
            ll_multiplosLinks.TabIndex = 4;
            ll_multiplosLinks.TabStop = true;
            ll_multiplosLinks.Text = "Google - Canal - Youtube";
            ll_multiplosLinks.LinkClicked += Ll_multiplosLinks_LinkClicked;
            // 
            // F_LinkLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ll_multiplosLinks);
            Controls.Add(ll_calculadora);
            Controls.Add(ll_canal);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "F_LinkLabel";
            Text = "F_LinkLabel";
            Load += F_LinkLabel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private LinkLabel ll_canal;
        private LinkLabel ll_calculadora;
        private LinkLabel ll_multiplosLinks;
    }
}