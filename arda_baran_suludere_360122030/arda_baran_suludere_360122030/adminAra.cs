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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace arda_baran_suludere_360122030
{
    public partial class adminAra : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable tablo;
        public adminAra()
        {
            InitializeComponent();
        }
        private void Filmgetir()
        {
            string sorgu = "SELECT Film.FilmID, Film.FilmAdi, Yonetmenler.YonetmenID, Yonetmenler.YonetmenAdi, Film.Musait FROM Film" +
            " INNER JOIN Yonetmenler ON Film.YonetmenAdi = Yonetmenler.YonetmenAdi order by Film.FilmID ASC";
            conn = new SqlConnection("Data Source=.; Initial Catalog=vtysfinal; Integrated Security=True");
            adapter = new SqlDataAdapter(sorgu, conn);
            ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "Film");
            dgv.DataSource = ds.Tables["Film"];
            conn.Close();
        }
        private void adminAra_Load(object sender, EventArgs e)
        {
            Filmgetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataView dv = ds.Tables["Film"].DefaultView;
            dv.RowFilter = "FilmAdi Like '%" + txtAra.Text + "%' or YonetmenAdi Like '%" + txtAra.Text + "%'";
            dgv.DataSource = dv;
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
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
