using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arda_baran_suludere_360122030
{
    public partial class uyekayit : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        public uyekayit()
        {
            InitializeComponent();
        }
        private void btnUyeol_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert Into Uye(UyeAdi,UyeSifre,UyeTel) VALUES(@UyeAdi, @UyeSifre, @UyeTel)";
            conn = new SqlConnection("Data Source=.;Initial Catalog=vtysfinal; Integrated Security=True");
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@UyeAdi", txtAd.Text);
            cmd.Parameters.AddWithValue("@UyeSifre", txtSifre.Text);
            cmd.Parameters.AddWithValue("@UyeTel", txtTel.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kayıt Başarılı");

            uyegiris uyegiris = new uyegiris();
            uyegiris.Show();
            this.Hide();
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            uyegiris uyegiris = new uyegiris();
            uyegiris.Show();
            this.Hide();
        }
    }
}
