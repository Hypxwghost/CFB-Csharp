namespace A062
{
    public partial class F_listBox : Form
    {
        List<string> carros = new();
        public F_listBox()
        {
            InitializeComponent();

            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            lb_carros.DataSource = carros;
        }

        private void F_listBox_Load(object sender, EventArgs e)
        {

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (tb_carro.Text == "")
            {
                MessageBox.Show("Digite um carro !");
                tb_carro.Focus();
            }
            else
            {
                carros.Add(tb_carro.Text);
                tb_carro.Clear();
                AtualizaLista(lb_carros, carros);
                tb_carro.Focus();
            }
        }

        private void Btn_remover_Click(object sender, EventArgs e)
        {
            try
            {
                carros.RemoveAt(lb_carros.SelectedIndex);
                AtualizaLista(lb_carros, carros);
                tb_carro.Focus();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Não há carros para serem removidos!");
            }
        }

        private void Btn_obter_Click(object sender, EventArgs e)
        {
            try
            {
                tb_carro.Text = carros[lb_carros.SelectedIndex];
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Nenhum carro selecionado!");
            }
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            carros.Clear();
            AtualizaLista(lb_carros, carros);
        }

        private static void AtualizaLista(ListBox lb, List<string> l)
        {
            lb.DataSource = null;
            lb.DataSource = l;
        }
    }
}
