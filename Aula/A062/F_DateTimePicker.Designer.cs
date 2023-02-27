namespace A062
{
    partial class F_DateTimePicker
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
            dtp_data = new DateTimePicker();
            btn_obterData = new Button();
            Tb_data = new TextBox();
            Tb_ano = new TextBox();
            Tb_mes = new TextBox();
            Tb_dia = new TextBox();
            btn_setarData = new Button();
            btn_hoje = new Button();
            SuspendLayout();
            // 
            // dtp_data
            // 
            dtp_data.Location = new Point(12, 12);
            dtp_data.Name = "dtp_data";
            dtp_data.Size = new Size(312, 23);
            dtp_data.TabIndex = 0;
            // 
            // btn_obterData
            // 
            btn_obterData.Location = new Point(333, 12);
            btn_obterData.Name = "btn_obterData";
            btn_obterData.Size = new Size(134, 23);
            btn_obterData.TabIndex = 1;
            btn_obterData.Text = "Obter data";
            btn_obterData.UseVisualStyleBackColor = true;
            btn_obterData.Click += Btn_obterData_Click;
            // 
            // Tb_data
            // 
            Tb_data.Location = new Point(12, 41);
            Tb_data.Name = "Tb_data";
            Tb_data.Size = new Size(312, 23);
            Tb_data.TabIndex = 2;
            // 
            // Tb_ano
            // 
            Tb_ano.Location = new Point(224, 70);
            Tb_ano.Name = "Tb_ano";
            Tb_ano.Size = new Size(100, 23);
            Tb_ano.TabIndex = 3;
            // 
            // Tb_mes
            // 
            Tb_mes.Location = new Point(118, 70);
            Tb_mes.Name = "Tb_mes";
            Tb_mes.Size = new Size(100, 23);
            Tb_mes.TabIndex = 4;
            Tb_mes.TextChanged += TextBox3_TextChanged;
            // 
            // Tb_dia
            // 
            Tb_dia.Location = new Point(12, 70);
            Tb_dia.Name = "Tb_dia";
            Tb_dia.Size = new Size(100, 23);
            Tb_dia.TabIndex = 5;
            // 
            // btn_setarData
            // 
            btn_setarData.Location = new Point(333, 70);
            btn_setarData.Name = "btn_setarData";
            btn_setarData.Size = new Size(134, 23);
            btn_setarData.TabIndex = 9;
            btn_setarData.Text = "Setar data";
            btn_setarData.UseVisualStyleBackColor = true;
            btn_setarData.Click += Btn_setarData_Click;
            // 
            // btn_hoje
            // 
            btn_hoje.Location = new Point(333, 99);
            btn_hoje.Name = "btn_hoje";
            btn_hoje.Size = new Size(134, 23);
            btn_hoje.TabIndex = 10;
            btn_hoje.Text = "Hoje";
            btn_hoje.UseVisualStyleBackColor = true;
            btn_hoje.Click += Btn_hoje_Click;
            // 
            // F_DateTimePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 450);
            Controls.Add(btn_hoje);
            Controls.Add(btn_setarData);
            Controls.Add(Tb_dia);
            Controls.Add(Tb_mes);
            Controls.Add(Tb_ano);
            Controls.Add(Tb_data);
            Controls.Add(btn_obterData);
            Controls.Add(dtp_data);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_DateTimePicker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_DateTimePicker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtp_data;
        private Button btn_obterData;
        private TextBox Tb_data;
        private TextBox Tb_ano;
        private TextBox Tb_mes;
        private TextBox Tb_dia;
        private Button btn_setarData;
        private Button btn_hoje;
    }
}