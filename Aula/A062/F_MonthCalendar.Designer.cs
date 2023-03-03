namespace A062
{
    partial class F_MonthCalendar
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
            monthCalendar1 = new MonthCalendar();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Btn_pegarData = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 18);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(257, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(257, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // Btn_pegarData
            // 
            Btn_pegarData.Location = new Point(257, 76);
            Btn_pegarData.Name = "Btn_pegarData";
            Btn_pegarData.Size = new Size(100, 23);
            Btn_pegarData.TabIndex = 3;
            Btn_pegarData.Text = "Pegar Data";
            Btn_pegarData.UseVisualStyleBackColor = true;
            Btn_pegarData.Click += Btn_pegarData_Click;
            // 
            // F_MonthCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 462);
            Controls.Add(Btn_pegarData);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(monthCalendar1);
            Name = "F_MonthCalendar";
            Text = "F_MonthCalendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Btn_pegarData;
    }
}