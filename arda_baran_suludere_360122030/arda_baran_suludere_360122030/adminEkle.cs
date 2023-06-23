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
    public partial class adminEkle : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;

        public adminEkle()
        {
            InitializeComponent();
        }
      
        private void Comboyenile()
        {
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "Data Source=.; Initial Catalog=vtysfinal; Integrated Security=True";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Yonetmenler";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;

            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr["YonetmenAdi"]);
            }
            baglanti.Close();
        }
        private void Filmgetir()
        {
            string sorgu = "SELECT Film.FilmID,Film.FilmAdi,Yonetmenler.YonetmenID,Yonetmenler.YonetmenAdi,Film.Musait FROM Film" +
            " INNER JOIN Yonetmenler ON Film.YonetmenAdi = Yonetmenler.YonetmenAdi" +
            " order by Film.FilmID ASC";
            conn = new SqlConnection("Data Source=.; Initial Catalog=vtysfinal; Integrated Security=True");
            adapter = new SqlDataAdapter(sorgu, conn);
            ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "Film");
            dgv.DataSource = ds.Tables["Film"];
            conn.Close();
        }

        private void adminEkle_Load(object sender, EventArgs e)
        {
            Filmgetir();
            Comboyenile();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert Into Film(FilmAdi,YonetmenAdi,Musait) VALUES(@FilmAdi,@YonetmenAdi,@Musait)";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@FilmAdi", txtFAdi.Text);
            cmd.Parameters.AddWithValue("@YonetmenAdi", comboBox2.SelectedItem.ToString());
            cmd.Parameters.AddWithValue("@Musait", comboBox1.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Film Eklendi!");
            Filmgetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Film where FilmID=@FilmID";
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@FilmID", dgv.CurrentRow.Cells[0].Value);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Seçili film silindi!");
            Filmgetir();
        }

        private void txtYEkle_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert Into Yonetmenler(Yonetmenadi) VALUES(@YonetmenAdi)";
            cmd = new SqlCommand(sorgu,conn);
            cmd.Parameters.AddWithValue("@YonetmenAdi", txtYAd.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            Comboyenile();
            txtYAd.Text = string.Empty;
            MessageBox.Show("Yönetmen Eklendi!");
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string SelectedFilmAdi = dgv.CurrentRow.Cells["FilmAdi"].Value.ToString();
            string sorgu = "SELECT Kira.KiralanmaTarihi, Kira.TeslimTarihi,Kira.FilmAdi FROM Kira WHERE Kira.FilmAdi = @FilmAdi";           
            conn.Open();
            using (SqlCommand cmd = new SqlCommand(sorgu, conn))
            { 
                cmd.Parameters.AddWithValue("@FilmAdi", SelectedFilmAdi);
                
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {  
                        while (reader.Read())
                        {
                               
                            string kiralanmaTarihi = reader["KiralanmaTarihi"].ToString();
                            string teslimTarihi = reader["TeslimTarihi"].ToString();
                            MessageBox.Show("Kiralanma Tarihi: " + reader["kiralanmaTarihi"] + "\n Teslim Tarihi: " + reader["teslimTarihi"]);
                        }

                       
                     }
                }
            }
            conn.Close();
        }

    }
    
}

