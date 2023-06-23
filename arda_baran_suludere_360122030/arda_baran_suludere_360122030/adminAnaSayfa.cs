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
    public partial class adminAnaSayfa : Form
    {
        public adminAnaSayfa()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            adminEkle ekle = new adminEkle();
            ekle.MdiParent = this;
            ekle.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(ekle);
            ekle.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            adminAra adminAra = new adminAra();
            adminAra.MdiParent = this;
            adminAra.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(adminAra);
            adminAra.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            adminkiralanmis kiralanmis = new adminkiralanmis();
            kiralanmis.MdiParent = this;
            kiralanmis .FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(kiralanmis);
            kiralanmis .Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            adminfilmkirala filmkirala = new adminfilmkirala();
            filmkirala .MdiParent = this;
            filmkirala.FormBorderStyle = FormBorderStyle.None;
            panel2.Controls.Add(filmkirala);
            filmkirala .Show();
        }


    }
}
