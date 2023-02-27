namespace A062
{
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void Btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";

            foreach (string t in clb_transportes.CheckedItems)
            {
                txt += t + ", ";
            }

            MessageBox.Show(txt);
        }

        private void Btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();
        }

        private void Btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_transportes.Items.Clear();

            List<string> tr = new()
            {
                "Carro",
                "Avião",
                "Navio",
                "Ônibus",
                "Trem"
            };

            clb_transportes.Items.AddRange(tr.ToArray());
        }

        private void Btn_addNovoTransporte_Click(object sender, EventArgs e)
        {
            if (tb_novoTransporte.Text != "")
            {
                clb_transportes.Items.Add(tb_novoTransporte.Text);
                tb_novoTransporte.Clear();
                tb_novoTransporte.Focus();
            }
        }
    }
}
