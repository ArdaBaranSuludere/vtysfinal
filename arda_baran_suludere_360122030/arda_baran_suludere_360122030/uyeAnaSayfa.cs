using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arda_baran_suludere_360122030
{
    public partial class uyeAnaSayfa : Form
    {
        public uyeAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            uyefilmara uyefilm = new uyefilmara();
            uyefilm.MdiParent = this;
            uyefilm.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(uyefilm);
            uyefilm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();
        }

        private void btnKira_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            uyekiralanmis uyekiralanmis = new uyekiralanmis();
            uyekiralanmis.MdiParent = this;
            uyekiralanmis.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(uyekiralanmis);
            uyekiralanmis.Show();
        }
    }
}