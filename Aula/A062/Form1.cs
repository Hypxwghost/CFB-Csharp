namespace A062
{
    public partial class F_principal : Form
    {
        public int num;
        public F_principal()
        {
            InitializeComponent();

            num = 0;
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_veiculo.Text == "" || tb_veiculo.Text == " ")
            {
                MessageBox.Show("Digite um veiculo");
                tb_veiculo.Focus();
                return;
            }
            else
            {
                tb_listaveiculos.Text += tb_veiculo.Text + ", ";
                tb_veiculo.Clear();
                tb_veiculo.Focus();
            }
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            tb_listaveiculos.Clear();
            tb_veiculo.Clear();
            tb_veiculo.Focus();
        }

        private void Btn_mostrar_Click(object sender, EventArgs e)
        {
            F_veiculos f_Veiculos = new(tb_listaveiculos.Text, this);
            f_Veiculos.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (num > 0)
            {
                MessageBox.Show(num.ToString());
            }
        }

        private void CheckBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckBox f_CheckBox = new();
            f_CheckBox.ShowDialog();
        }

        private void CheckedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new();
            f_CheckedListBox.ShowDialog();
        }

        private void ComboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ComboBox f_ComboBox = new();
            f_ComboBox.ShowDialog();
        }

        private void DateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_DateTimePicker f_DateTimePicker = new();
            f_DateTimePicker.ShowDialog();
        }

        private void LabelLinkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_LinkLabel f_LinkLabel = new();
            f_LinkLabel.ShowDialog();
        }

        private void ListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_listBox f_ListBox = new();
            f_ListBox.ShowDialog();
        }

        private void ListViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_listView f_ListView = new();
            f_ListView.ShowDialog();
        }

        private void MaskedTextBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MaskedTextBox f_MaskedTextBox = new();
            f_MaskedTextBox.ShowDialog();
        }

        private void MonthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_MonthCalendar f_MonthCalendar = new();
            f_MonthCalendar.ShowDialog();
        }

        private void MenuNotificacoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "tsm_Fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "tsm_Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "tsm_Mensagem")
            {
                MessageBox.Show("CFB Cursos- curso de C#");
            }
        }

        private void NumericUpDownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NumericUpDown f_NumericUpDown = new();
            f_NumericUpDown.ShowDialog();
        }

        private void PictureBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_PictureBox f_PictureBox = new();
            f_PictureBox.ShowDialog();
        }

        private void ProgressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ProgressBar f_ProgressBar = new();
            f_ProgressBar.ShowDialog();
        }

        private void RadioButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_RadioButton f_RadioButton = new();
            f_RadioButton.ShowDialog();
        }
    }
}