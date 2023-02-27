namespace A062
{
    partial class F_CheckedListBox
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
            clb_transportes = new CheckedListBox();
            btn_mostrarSelecionados = new Button();
            btn_limparLista = new Button();
            btn_resetarLista = new Button();
            btn_addNovoTransporte = new Button();
            tb_novoTransporte = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // clb_transportes
            // 
            clb_transportes.FormattingEnabled = true;
            clb_transportes.Items.AddRange(new object[] { "Carro", "Avião", "Navio", "Ônibus", "Trem" });
            clb_transportes.Location = new Point(12, 12);
            clb_transportes.Name = "clb_transportes";
            clb_transportes.Size = new Size(120, 454);
            clb_transportes.TabIndex = 0;
            // 
            // btn_mostrarSelecionados
            // 
            btn_mostrarSelecionados.Location = new Point(138, 12);
            btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            btn_mostrarSelecionados.Size = new Size(114, 23);
            btn_mostrarSelecionados.TabIndex = 1;
            btn_mostrarSelecionados.Text = "Mostrar Selecionados";
            btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            btn_mostrarSelecionados.Click += Btn_mostrarSelecionados_Click;
            // 
            // btn_limparLista
            // 
            btn_limparLista.Location = new Point(138, 41);
            btn_limparLista.Name = "btn_limparLista";
            btn_limparLista.Size = new Size(114, 23);
            btn_limparLista.TabIndex = 2;
            btn_limparLista.Text = "Limpar Lista";
            btn_limparLista.UseVisualStyleBackColor = true;
            btn_limparLista.Click += Btn_limparLista_Click;
            // 
            // btn_resetarLista
            // 
            btn_resetarLista.Location = new Point(138, 70);
            btn_resetarLista.Name = "btn_resetarLista";
            btn_resetarLista.Size = new Size(114, 23);
            btn_resetarLista.TabIndex = 3;
            btn_resetarLista.Text = "Resetar Lista";
            btn_resetarLista.UseVisualStyleBackColor = true;
            btn_resetarLista.Click += Btn_resetarLista_Click;
            // 
            // btn_addNovoTransporte
            // 
            btn_addNovoTransporte.Location = new Point(138, 127);
            btn_addNovoTransporte.Name = "btn_addNovoTransporte";
            btn_addNovoTransporte.Size = new Size(147, 23);
            btn_addNovoTransporte.TabIndex = 4;
            btn_addNovoTransporte.Text = "Novo Transporte";
            btn_addNovoTransporte.UseVisualStyleBackColor = true;
            btn_addNovoTransporte.Click += Btn_addNovoTransporte_Click;
            // 
            // tb_novoTransporte
            // 
            tb_novoTransporte.Location = new Point(138, 156);
            tb_novoTransporte.Name = "tb_novoTransporte";
            tb_novoTransporte.Size = new Size(147, 23);
            tb_novoTransporte.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 109);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 6;
            label1.Text = "Digite um novo Transporte";
            // 
            // F_CheckedListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 475);
            Controls.Add(label1);
            Controls.Add(tb_novoTransporte);
            Controls.Add(btn_addNovoTransporte);
            Controls.Add(btn_resetarLista);
            Controls.Add(btn_limparLista);
            Controls.Add(btn_mostrarSelecionados);
            Controls.Add(clb_transportes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_CheckedListBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckedListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox clb_transportes;
        private Button btn_mostrarSelecionados;
        private Button btn_limparLista;
        private Button btn_resetarLista;
        private Button btn_addNovoTransporte;
        private TextBox tb_novoTransporte;
        private Label label1;
    }
}