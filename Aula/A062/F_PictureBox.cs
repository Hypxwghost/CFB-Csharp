namespace A062
{
    public partial class F_PictureBox : Form
    {
        public F_PictureBox()
        {
            InitializeComponent();
        }

        private void F_PictureBox_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Resources.NomeCanal;
            label2.Text = Properties.Resources.EndereçoCanal;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.rabisco;
        }
    }
}
