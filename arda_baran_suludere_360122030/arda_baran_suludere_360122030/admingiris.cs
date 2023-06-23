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
    public partial class admingiris : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public admingiris()
        {
            InitializeComponent();
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

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Admin WHERE AdminAdi=@AdminAdi and AdminSifre=@AdminSifre";
            conn = new SqlConnection("Data Source=.; Initial Catalog=vtysfinal; Integrated Security=True");
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@AdminAdi", txtAd.Text); ;
            cmd.Parameters.AddWithValue("@AdminSifre", txtSifre.Text);
            conn.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Giriş başarılı!");
                adminAnaSayfa adminana = new adminAnaSayfa();
                adminana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
