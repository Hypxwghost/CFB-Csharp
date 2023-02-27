namespace A062
{
    public partial class F_DateTimePicker : Form
    {
        public F_DateTimePicker()
        {
            InitializeComponent();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_obterData_Click(object sender, EventArgs e)
        {
            Tb_data.Text = dtp_data.Text;
            Tb_dia.Text = dtp_data.Value.Day.ToString();
            Tb_mes.Text = dtp_data.Value.Month.ToString();
            Tb_ano.Text = dtp_data.Value.Year.ToString();
        }

        private void Btn_setarData_Click(object sender, EventArgs e)
        {
            int d, m, a;
            d = Int32.Parse(Tb_dia.Text);
            m = Int32.Parse(Tb_mes.Text);
            a = Int32.Parse(Tb_ano.Text);

            DateTime dt = new(a, m, d);

            dtp_data.Value = dt;
            Tb_data.Text = dt.ToString();
        }

        private void Btn_hoje_Click(object sender, EventArgs e)
        {
            dtp_data.Value = DateTime.Today;
            Tb_data.Text = DateTime.Now.ToString();
        }
    }
}
