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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void amdGiris_Click(object sender, EventArgs e)
        {
            admingiris admingiris = new admingiris();
            admingiris.Show();
            this.Hide();
        }

        private void uyeGiris_Click(object sender, EventArgs e)
        {
            uyegiris uyegiris = new uyegiris();
            uyegiris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
