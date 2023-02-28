namespace A062
{
    public partial class F_listView : Form
    {
        public F_listView()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            tb_id.Clear();
            tb_preco.Clear();
            tb_produto.Clear();
            tb_qtde.Clear();
            tb_id.Focus();
        }

        private void Btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("ID não pode ser nulo!");
                tb_id.Focus(); return;
            }
            if (tb_produto.Text == "")
            {
                MessageBox.Show("Produto não pode ser nulo!");
                tb_produto.Focus(); return;
            }
            string[] pr = new string[4];
            pr[0] = tb_id.Text;
            pr[1] = tb_produto.Text;
            pr[2] = tb_qtde.Text;
            pr[3] = tb_preco.Text;

            ListViewItem l = new(pr);
            lv_produtos.Items.Add(l);
            Limpar();
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            try { lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]); }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Nenhum item a ser removido !"); }
        }

        private void Lv_produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tb_id.Text = lv_produtos.SelectedItems[0].SubItems[0].Text;
                tb_produto.Text = lv_produtos.SelectedItems[0].SubItems[1].Text;
                tb_qtde.Text = lv_produtos.SelectedItems[0].SubItems[2].Text;
                tb_preco.Text = lv_produtos.SelectedItems[0].SubItems[3].Text;
            }
            catch (System.ArgumentOutOfRangeException) { return; }
        }
    }
}