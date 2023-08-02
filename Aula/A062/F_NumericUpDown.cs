namespace A062
{
    public partial class F_NumericUpDown : Form
    {
        public F_NumericUpDown()
        {
            InitializeComponent();
        }

        private void Btn_DefinirValor_Click(object sender, EventArgs e)
        {
            if ((Decimal.Parse(tb_Valor.Text) >= NumericUpDown1.Minimum) & (Decimal.Parse(tb_Valor.Text) <= NumericUpDown1.Maximum))
                NumericUpDown1.Value = Decimal.Parse(tb_Valor.Text);
        }
    }
}