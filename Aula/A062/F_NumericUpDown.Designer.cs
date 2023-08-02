namespace A062
{
    partial class F_NumericUpDown
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
            NumericUpDown1 = new NumericUpDown();
            tb_Valor = new TextBox();
            btn_DefinirValor = new Button();
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // NumericUpDown1
            // 
            NumericUpDown1.ForeColor = SystemColors.MenuHighlight;
            NumericUpDown1.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown1.Location = new Point(12, 12);
            NumericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            NumericUpDown1.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            NumericUpDown1.Name = "NumericUpDown1";
            NumericUpDown1.Size = new Size(120, 23);
            NumericUpDown1.TabIndex = 0;
            NumericUpDown1.TextAlign = HorizontalAlignment.Center;
            NumericUpDown1.UpDownAlign = LeftRightAlignment.Left;
            NumericUpDown1.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // tb_Valor
            // 
            tb_Valor.Location = new Point(138, 11);
            tb_Valor.Name = "tb_Valor";
            tb_Valor.Size = new Size(100, 23);
            tb_Valor.TabIndex = 1;
            tb_Valor.Text = "0";
            // 
            // btn_DefinirValor
            // 
            btn_DefinirValor.Location = new Point(244, 11);
            btn_DefinirValor.Name = "btn_DefinirValor";
            btn_DefinirValor.Size = new Size(94, 23);
            btn_DefinirValor.TabIndex = 2;
            btn_DefinirValor.Text = "Definir Valor";
            btn_DefinirValor.UseVisualStyleBackColor = true;
            btn_DefinirValor.Click += Btn_DefinirValor_Click;
            // 
            // F_NumericUpDown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_DefinirValor);
            Controls.Add(tb_Valor);
            Controls.Add(NumericUpDown1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_NumericUpDown";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)NumericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown NumericUpDown1;
        private TextBox tb_Valor;
        private Button btn_DefinirValor;
    }
}