namespace A062
{
    public partial class F_veiculos : Form
    {
        F_principal fp;
        public F_veiculos(string v, F_principal f)
        {
            InitializeComponent();

            tb_listaveiculos.Text = v;

            fp = f;
            f.num = 10;
        }

        private void F_veiculos_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void F_veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            fp.tb_listaveiculos.Text = tb_listaveiculos.Text;

        }
    }
}
