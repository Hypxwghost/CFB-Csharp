using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A062
{
    public partial class F_FilhoCheckBox : Form
    {
        public F_CheckBox fcb;
        public F_FilhoCheckBox()
        {
            InitializeComponent();
            try
            {
                fcb = Application.OpenForms["F_CheckBox"] as F_CheckBox;
                cb_carro.Checked = fcb.cb_carro.Checked;
                cb_aviao.Checked = fcb.cb_aviao.Checked;
                cb_navio.Checked = fcb.cb_navio.Checked;
                cb_onibus.Checked = fcb.cb_onibus.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir o formulário!");
            }
        }

        private void F_FilhoCheckBox_Load(object sender, EventArgs e)
        {

        }

        private void Cb_carro_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_carro.Checked = cb_carro.Checked;
        }

        private void Cb_aviao_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_aviao.Checked = cb_aviao.Checked;
        }

        private void Cb_navio_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_navio.Checked = cb_navio.Checked;
        }

        private void Cb_onibus_CheckedChanged(object sender, EventArgs e)
        {
            fcb.cb_onibus.Checked = cb_onibus.Checked;
        }
    }
}
