namespace A062
{
    partial class F_principal
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
            btn_adicionar = new Button();
            tb_veiculo = new TextBox();
            label1 = new Label();
            tb_listaveiculos = new TextBox();
            btn_limpar = new Button();
            btn_mostrar = new Button();
            btn_valnum = new Button();
            menuStrip1 = new MenuStrip();
            componentesToolStripMenuItem = new ToolStripMenuItem();
            checkBoxToolStripMenuItem = new ToolStripMenuItem();
            cHeckedListBoxToolStripMenuItem = new ToolStripMenuItem();
            comboBoxToolStripMenuItem = new ToolStripMenuItem();
            dateTimePickerToolStripMenuItem = new ToolStripMenuItem();
            labelLinkLabelToolStripMenuItem = new ToolStripMenuItem();
            listBoxToolStripMenuItem = new ToolStripMenuItem();
            listViewToolStripMenuItem = new ToolStripMenuItem();
            maskedTextBoxToolStripMenuItem = new ToolStripMenuItem();
            monthCalendarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_adicionar
            // 
            btn_adicionar.Location = new Point(136, 48);
            btn_adicionar.Name = "btn_adicionar";
            btn_adicionar.Size = new Size(96, 23);
            btn_adicionar.TabIndex = 0;
            btn_adicionar.Text = "OK";
            btn_adicionar.UseVisualStyleBackColor = true;
            btn_adicionar.Click += Btn_adicionar_Click;
            // 
            // tb_veiculo
            // 
            tb_veiculo.Location = new Point(12, 48);
            tb_veiculo.Name = "tb_veiculo";
            tb_veiculo.Size = new Size(118, 23);
            tb_veiculo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 30);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 2;
            label1.Text = "Digite um veiculo";
            // 
            // tb_listaveiculos
            // 
            tb_listaveiculos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_listaveiculos.Location = new Point(12, 77);
            tb_listaveiculos.Multiline = true;
            tb_listaveiculos.Name = "tb_listaveiculos";
            tb_listaveiculos.Size = new Size(220, 231);
            tb_listaveiculos.TabIndex = 3;
            // 
            // btn_limpar
            // 
            btn_limpar.Location = new Point(12, 314);
            btn_limpar.Name = "btn_limpar";
            btn_limpar.Size = new Size(220, 23);
            btn_limpar.TabIndex = 4;
            btn_limpar.Text = "Limpar";
            btn_limpar.UseVisualStyleBackColor = true;
            btn_limpar.Click += Btn_limpar_Click;
            // 
            // btn_mostrar
            // 
            btn_mostrar.Location = new Point(12, 343);
            btn_mostrar.Name = "btn_mostrar";
            btn_mostrar.Size = new Size(220, 23);
            btn_mostrar.TabIndex = 5;
            btn_mostrar.Text = "Mostrar Veiculos";
            btn_mostrar.UseVisualStyleBackColor = true;
            btn_mostrar.Click += Btn_mostrar_Click;
            // 
            // btn_valnum
            // 
            btn_valnum.Location = new Point(12, 372);
            btn_valnum.Name = "btn_valnum";
            btn_valnum.Size = new Size(220, 23);
            btn_valnum.TabIndex = 6;
            btn_valnum.Text = "Valor da Variavel num";
            btn_valnum.UseVisualStyleBackColor = true;
            btn_valnum.Click += Button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { componentesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(244, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            componentesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { checkBoxToolStripMenuItem, cHeckedListBoxToolStripMenuItem, comboBoxToolStripMenuItem, dateTimePickerToolStripMenuItem, labelLinkLabelToolStripMenuItem, listBoxToolStripMenuItem, listViewToolStripMenuItem, maskedTextBoxToolStripMenuItem, monthCalendarToolStripMenuItem });
            componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            componentesToolStripMenuItem.Size = new Size(94, 20);
            componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            checkBoxToolStripMenuItem.Size = new Size(180, 22);
            checkBoxToolStripMenuItem.Text = "CheckBox";
            checkBoxToolStripMenuItem.Click += CheckBoxToolStripMenuItem_Click;
            // 
            // cHeckedListBoxToolStripMenuItem
            // 
            cHeckedListBoxToolStripMenuItem.Name = "cHeckedListBoxToolStripMenuItem";
            cHeckedListBoxToolStripMenuItem.Size = new Size(180, 22);
            cHeckedListBoxToolStripMenuItem.Text = "CheckedListBox";
            cHeckedListBoxToolStripMenuItem.Click += CheckedListBoxToolStripMenuItem_Click;
            // 
            // comboBoxToolStripMenuItem
            // 
            comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            comboBoxToolStripMenuItem.Size = new Size(180, 22);
            comboBoxToolStripMenuItem.Text = "ComboBox";
            comboBoxToolStripMenuItem.Click += ComboBoxToolStripMenuItem_Click;
            // 
            // dateTimePickerToolStripMenuItem
            // 
            dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            dateTimePickerToolStripMenuItem.Size = new Size(180, 22);
            dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            dateTimePickerToolStripMenuItem.Click += DateTimePickerToolStripMenuItem_Click;
            // 
            // labelLinkLabelToolStripMenuItem
            // 
            labelLinkLabelToolStripMenuItem.Name = "labelLinkLabelToolStripMenuItem";
            labelLinkLabelToolStripMenuItem.Size = new Size(180, 22);
            labelLinkLabelToolStripMenuItem.Text = "Label/LinkLabel";
            labelLinkLabelToolStripMenuItem.Click += LabelLinkLabelToolStripMenuItem_Click;
            // 
            // listBoxToolStripMenuItem
            // 
            listBoxToolStripMenuItem.Name = "listBoxToolStripMenuItem";
            listBoxToolStripMenuItem.Size = new Size(180, 22);
            listBoxToolStripMenuItem.Text = "ListBox";
            listBoxToolStripMenuItem.Click += ListBoxToolStripMenuItem_Click;
            // 
            // listViewToolStripMenuItem
            // 
            listViewToolStripMenuItem.Name = "listViewToolStripMenuItem";
            listViewToolStripMenuItem.Size = new Size(180, 22);
            listViewToolStripMenuItem.Text = "ListView";
            listViewToolStripMenuItem.Click += ListViewToolStripMenuItem_Click;
            // 
            // maskedTextBoxToolStripMenuItem
            // 
            maskedTextBoxToolStripMenuItem.Name = "maskedTextBoxToolStripMenuItem";
            maskedTextBoxToolStripMenuItem.Size = new Size(180, 22);
            maskedTextBoxToolStripMenuItem.Text = "MaskedTextBox";
            maskedTextBoxToolStripMenuItem.Click += MaskedTextBoxToolStripMenuItem_Click;
            // 
            // monthCalendarToolStripMenuItem
            // 
            monthCalendarToolStripMenuItem.Name = "monthCalendarToolStripMenuItem";
            monthCalendarToolStripMenuItem.Size = new Size(180, 22);
            monthCalendarToolStripMenuItem.Text = "MonthCalendar";
            monthCalendarToolStripMenuItem.Click += MonthCalendarToolStripMenuItem_Click;
            // 
            // F_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 446);
            Controls.Add(btn_valnum);
            Controls.Add(btn_mostrar);
            Controls.Add(btn_limpar);
            Controls.Add(tb_listaveiculos);
            Controls.Add(label1);
            Controls.Add(tb_veiculo);
            Controls.Add(btn_adicionar);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "F_principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Componentes";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_adicionar;
        private TextBox tb_veiculo;
        private Label label1;
        private Button btn_limpar;
        private Button btn_mostrar;
        private Button btn_valnum;
        public TextBox tb_listaveiculos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem componentesToolStripMenuItem;
        private ToolStripMenuItem checkBoxToolStripMenuItem;
        private ToolStripMenuItem cHeckedListBoxToolStripMenuItem;
        private ToolStripMenuItem comboBoxToolStripMenuItem;
        private ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private ToolStripMenuItem labelLinkLabelToolStripMenuItem;
        private ToolStripMenuItem listBoxToolStripMenuItem;
        private ToolStripMenuItem listViewToolStripMenuItem;
        private ToolStripMenuItem maskedTextBoxToolStripMenuItem;
        private ToolStripMenuItem monthCalendarToolStripMenuItem;
    }
}