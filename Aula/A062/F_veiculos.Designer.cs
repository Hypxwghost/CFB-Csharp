namespace A062
{
    partial class F_veiculos
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
            this.tb_listaveiculos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_listaveiculos
            // 
            this.tb_listaveiculos.Location = new System.Drawing.Point(12, 12);
            this.tb_listaveiculos.Multiline = true;
            this.tb_listaveiculos.Name = "tb_listaveiculos";
            this.tb_listaveiculos.Size = new System.Drawing.Size(541, 445);
            this.tb_listaveiculos.TabIndex = 0;
            this.tb_listaveiculos.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // F_veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 469);
            this.Controls.Add(this.tb_listaveiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Veiculos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_veiculos_FormClosed);
            this.Load += new System.EventHandler(this.F_veiculos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_listaveiculos;
    }
}