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
    public partial class adminfilmkirala : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        public adminfilmkirala()
        {
            InitializeComponent();
        }

        private void Filmgetir()
        {
            string sorgu = "SELECT * FROM Film WHERE Musait='Müsait'";
            conn = new SqlConnection("Data Source=.; Initial Catalog=vtysfinal; Integrated Security=True");
            adapter = new SqlDataAdapter(sorgu, conn);
            ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "Film");
            dgv.DataSource = ds.Tables["Film"];
            conn.Close();
        }
        private void Kiragetir()
        {
            string sorgu = "SELECT * FROM Kira";
            conn = new SqlConnection("Data Source=.; Initial Catalog=vtysfinal; Integrated Security=True");
            adapter = new SqlDataAdapter(sorgu, conn);
            ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "Kira");
            dgv.DataSource = ds.Tables["Kira"];
            conn.Close();
        }

        private void filmkirala_Load(object sender, EventArgs e)
        {
            Filmgetir();
        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO Kira(KiralanmaTarihi, TeslimTarihi, UyeAdi, FilmAdi,Musait)" +
                " VALUES(@KiralanmaTarihi,@TeslimTarihi,@UyeAdi,@FilmAdi,@Musait)";
            string query = "UPDATE Film SET Film.Musait = Kira.Musait FROM Film" +
                " INNER JOIN Kira ON Film.Filmadi = Kira.FilmAdi";
            string tel = "UPDATE Kira SET Kira.UyeTel = Uye.UyeTel FROM Kira " +
                "INNER JOIN Uye ON Kira.UyeAdi = Uye.Uyeadi";
            cmd = new SqlCommand(sorgu,conn);
            cmd.Parameters.AddWithValue("@KiralanmaTarihi", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@TeslimTarihi", dateTimePicker2.Value);
            cmd.Parameters.AddWithValue("@UyeAdi", txtUAd.Text);
            cmd.Parameters.AddWithValue("@FilmAdi", txtFAd.Text);
            cmd.Parameters.AddWithValue("@Musait", comboBox1.SelectedItem.ToString());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd = new SqlCommand(query,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd = new SqlCommand(tel, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Film Kiralandı!");
            Kiragetir();
        }
    }
}
