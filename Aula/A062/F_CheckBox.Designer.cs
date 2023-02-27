namespace A062
{
    partial class F_CheckBox
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
            cb_carro = new CheckBox();
            cb_aviao = new CheckBox();
            cb_navio = new CheckBox();
            cb_onibus = new CheckBox();
            btn_transportesMarcados = new Button();
            cb_patinete = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // cb_carro
            // 
            cb_carro.AutoSize = true;
            cb_carro.Location = new Point(12, 9);
            cb_carro.Name = "cb_carro";
            cb_carro.Size = new Size(55, 19);
            cb_carro.TabIndex = 0;
            cb_carro.Text = "Carro";
            cb_carro.UseVisualStyleBackColor = true;
            // 
            // cb_aviao
            // 
            cb_aviao.AutoSize = true;
            cb_aviao.Location = new Point(12, 34);
            cb_aviao.Name = "cb_aviao";
            cb_aviao.Size = new Size(56, 19);
            cb_aviao.TabIndex = 1;
            cb_aviao.Text = "Avião";
            cb_aviao.UseVisualStyleBackColor = true;
            // 
            // cb_navio
            // 
            cb_navio.AutoSize = true;
            cb_navio.Location = new Point(12, 59);
            cb_navio.Name = "cb_navio";
            cb_navio.Size = new Size(57, 19);
            cb_navio.TabIndex = 2;
            cb_navio.Text = "Navio";
            cb_navio.UseVisualStyleBackColor = true;
            cb_navio.CheckedChanged += CheckBox3_CheckedChanged;
            // 
            // cb_onibus
            // 
            cb_onibus.AutoSize = true;
            cb_onibus.Location = new Point(12, 84);
            cb_onibus.Name = "cb_onibus";
            cb_onibus.Size = new Size(64, 19);
            cb_onibus.TabIndex = 3;
            cb_onibus.Text = "Ônibus";
            cb_onibus.UseVisualStyleBackColor = true;
            // 
            // btn_transportesMarcados
            // 
            btn_transportesMarcados.Location = new Point(158, 9);
            btn_transportesMarcados.Name = "btn_transportesMarcados";
            btn_transportesMarcados.Size = new Size(139, 23);
            btn_transportesMarcados.TabIndex = 4;
            btn_transportesMarcados.Text = "Transportes marcados";
            btn_transportesMarcados.UseVisualStyleBackColor = true;
            btn_transportesMarcados.Click += TransportesMarcados_Click;
            // 
            // cb_patinete
            // 
            cb_patinete.AutoSize = true;
            cb_patinete.Location = new Point(12, 109);
            cb_patinete.Name = "cb_patinete";
            cb_patinete.Size = new Size(69, 19);
            cb_patinete.TabIndex = 5;
            cb_patinete.Text = "Patinete";
            cb_patinete.UseVisualStyleBackColor = true;
            cb_patinete.CheckedChanged += cb_patinete_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(158, 38);
            button1.Name = "button1";
            button1.Size = new Size(139, 23);
            button1.TabIndex = 6;
            button1.Text = "Filho";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // F_CheckBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 317);
            Controls.Add(button1);
            Controls.Add(cb_patinete);
            Controls.Add(btn_transportesMarcados);
            Controls.Add(cb_onibus);
            Controls.Add(cb_navio);
            Controls.Add(cb_aviao);
            Controls.Add(cb_carro);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_CheckBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CheckBox";
            Load += F_CheckBox_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_transportesMarcados;
        private CheckBox cb_patinete;
        public CheckBox cb_carro;
        public CheckBox cb_aviao;
        public CheckBox cb_navio;
        public CheckBox cb_onibus;
        private Button button1;
    }
}