namespace A062
{
    partial class F_ComboBox
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
            cb_transportes = new ComboBox();
            btn_mostrarSelecionados = new Button();
            btn_limparElementos = new Button();
            btn_ResetarElementos = new Button();
            Tb_transporte = new TextBox();
            Btn_adicionarNovoTransporte = new Button();
            SuspendLayout();
            // 
            // cb_transportes
            // 
            cb_transportes.FormattingEnabled = true;
            cb_transportes.Items.AddRange(new object[] { "Carro", "Avião", "Navio", "Ônibus", "Trem" });
            cb_transportes.Location = new Point(12, 12);
            cb_transportes.Name = "cb_transportes";
            cb_transportes.Size = new Size(189, 23);
            cb_transportes.TabIndex = 0;
            cb_transportes.SelectedIndexChanged += Cb_transportes_SelectedIndexChanged;
            // 
            // btn_mostrarSelecionados
            // 
            btn_mostrarSelecionados.Location = new Point(207, 12);
            btn_mostrarSelecionados.Name = "btn_mostrarSelecionados";
            btn_mostrarSelecionados.Size = new Size(163, 23);
            btn_mostrarSelecionados.TabIndex = 1;
            btn_mostrarSelecionados.Text = "Mostrar Selecionados";
            btn_mostrarSelecionados.UseVisualStyleBackColor = true;
            btn_mostrarSelecionados.Click += Btn_mostrarSelecionados_Click;
            // 
            // btn_limparElementos
            // 
            btn_limparElementos.Location = new Point(207, 41);
            btn_limparElementos.Name = "btn_limparElementos";
            btn_limparElementos.Size = new Size(163, 23);
            btn_limparElementos.TabIndex = 2;
            btn_limparElementos.Text = "Limpar Elementos";
            btn_limparElementos.UseVisualStyleBackColor = true;
            btn_limparElementos.Click += Btn_limparElementos_Click;
            // 
            // btn_ResetarElementos
            // 
            btn_ResetarElementos.Location = new Point(206, 74);
            btn_ResetarElementos.Name = "btn_ResetarElementos";
            btn_ResetarElementos.Size = new Size(163, 23);
            btn_ResetarElementos.TabIndex = 3;
            btn_ResetarElementos.Text = "Resetar Elementos";
            btn_ResetarElementos.UseVisualStyleBackColor = true;
            btn_ResetarElementos.Click += Btn_resetarElementos_Click;
            // 
            // Tb_transporte
            // 
            Tb_transporte.Location = new Point(207, 128);
            Tb_transporte.Name = "Tb_transporte";
            Tb_transporte.Size = new Size(162, 23);
            Tb_transporte.TabIndex = 4;
            // 
            // Btn_adicionarNovoTransporte
            // 
            Btn_adicionarNovoTransporte.Location = new Point(207, 157);
            Btn_adicionarNovoTransporte.Name = "Btn_adicionarNovoTransporte";
            Btn_adicionarNovoTransporte.Size = new Size(162, 23);
            Btn_adicionarNovoTransporte.TabIndex = 5;
            Btn_adicionarNovoTransporte.Text = "Adicionar novo trasnporte";
            Btn_adicionarNovoTransporte.UseVisualStyleBackColor = true;
            Btn_adicionarNovoTransporte.Click += Btn_adicionarNovoTransporte_Click;
            // 
            // F_ComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 351);
            Controls.Add(Btn_adicionarNovoTransporte);
            Controls.Add(Tb_transporte);
            Controls.Add(btn_ResetarElementos);
            Controls.Add(btn_limparElementos);
            Controls.Add(btn_mostrarSelecionados);
            Controls.Add(cb_transportes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_ComboBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ComboBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cb_transportes;
        private Button btn_mostrarSelecionados;
        private Button btn_limparElementos;
        private Button btn_ResetarElementos;
        private TextBox Tb_transporte;
        private Button Btn_adicionarNovoTransporte;
    }
}