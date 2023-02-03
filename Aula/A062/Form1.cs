namespace A062
{
    public partial class F_principal : Form
    {
        public F_principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Tb_veiculo_TextChanged(object sender, EventArgs e)
        {

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
    }
}