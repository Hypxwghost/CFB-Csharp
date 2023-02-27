using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A062
{
    public partial class F_LinkLabel : Form
    {
        public F_LinkLabel()
        {
            InitializeComponent();
            ll_multiplosLinks.Links.Add(0, 6, "www.google.com.br");
            ll_multiplosLinks.Links.Add(9, 5, "http://youtube.com/cfbcursos");
            ll_multiplosLinks.Links.Add(17, 7, "http://youtube.com");

            ll_multiplosLinks.Links[2].Enabled = false;
        }

        private void Ll_canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo { FileName = "http://youtube.com/cfbcursos", UseShellExecute = true });

            LinkLabel ll = (LinkLabel)sender;
            ll.LinkVisited = true;
        }

        private void Ll_calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void F_LinkLabel_Load(object sender, EventArgs e)
        {

        }

        private void Ll_multiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()) { UseShellExecute = true });
            e.Link.Visited = true;
        }
    }
}
