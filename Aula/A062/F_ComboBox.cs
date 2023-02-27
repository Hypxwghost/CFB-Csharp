namespace A062
{
    public partial class F_ComboBox : Form
    {
        public F_ComboBox()
        {
            InitializeComponent();
        }

        private void Btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text);
        }

        private void Btn_limparElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void Btn_resetarElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();

            List<string> tr = new()
            {
                "Carro",
                "Avião",
                "Navio",
                "Ônibus",
                "Trem"
            };

            cb_transportes.Items.AddRange(tr.ToArray());
        }

        private void Cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tb_transporte.Text = cb_transportes.Text;
        }

        private void Btn_adicionarNovoTransporte_Click(object sender, EventArgs e)
        {
            if (Tb_transporte.Text != "")
            {
                if (cb_transportes.FindString(Tb_transporte.Text) < 0)
                {
                    cb_transportes.Items.Add(Tb_transporte.Text);
                    Tb_transporte.Clear();
                    Tb_transporte.Focus();
                }
                else
                {
                    MessageBox.Show("Transporte ja existente!");
                    Tb_transporte.Focus();
                }
            }
            else
            {
                MessageBox.Show("Digite um transporte!");
                Tb_transporte.Focus();
            }
        }
    }
}
