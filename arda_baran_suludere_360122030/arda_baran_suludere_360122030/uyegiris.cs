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
    public partial class uyegiris : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        public uyegiris()
        {
            InitializeComponent();
        }

        public static string kullaniciadi;

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Uye WHERE UyeAdi=@UyeAdi and UyeSifre=@UyeSifre";
            conn = new SqlConnection("Data Source=.; Initial Catalog=vtysfinal; Integrated Security=True");
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@UyeAdi", txtAd.Text); ;
            cmd.Parameters.AddWithValue("@UyeSifre", txtSifre.Text);
            conn.Open();
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                kullaniciadi = txtAd.Text;
                MessageBox.Show("Giriş başarılı!");
                uyeAnaSayfa uyeAnaSayfa = new uyeAnaSayfa();
                uyeAnaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre hatalı!");
            }
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

        private void label4_Click(object sender, EventArgs e)
        {
            uyekayit uyekayit = new uyekayit();
            uyekayit.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            giris giris = new giris();
            giris.Show();
            this.Hide();
        }
    }
}