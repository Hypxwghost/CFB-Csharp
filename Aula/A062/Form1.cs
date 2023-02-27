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

        private void cHeckedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_CheckedListBox f_CheckedListBox = new();
            f_CheckedListBox.ShowDialog();
        }
    }
}