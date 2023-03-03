namespace A062
{
    partial class F_MaskedTextBox
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
            mtb_senha = new MaskedTextBox();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            SuspendLayout();
            // 
            // mtb_senha
            // 
            mtb_senha.Location = new Point(12, 27);
            mtb_senha.Name = "mtb_senha";
            mtb_senha.PasswordChar = '*';
            mtb_senha.Size = new Size(191, 23);
            mtb_senha.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Senha";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(12, 97);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(191, 23);
            maskedTextBox1.TabIndex = 2;
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // button1
            // 
            button1.Location = new Point(319, 97);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(209, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(104, 19);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Somente Texto";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(209, 31);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(102, 19);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Mostrar Senha";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += CheckBox2_CheckedChanged;
            // 
            // F_MaskedTextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 293);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Controls.Add(mtb_senha);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "F_MaskedTextBox";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "F_MaskedTextBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtb_senha;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
    }
}