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
    public partial class adminkiralanmis : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;

        public adminkiralanmis()
        {
            InitializeComponent();
        }

        private void Filmgetir()
        {
            string sorgu = "SELECT * FROM Kira";
            conn = new SqlConnection("Data Source=.; Initial Catalog=vtysfinal; Integrated Security=True");
            adapter = new SqlDataAdapter(sorgu, conn);
            ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "Film");
            dgv.DataSource = ds.Tables["Film"];
            conn.Close();
        }

        private void kiralanmis_Load(object sender, EventArgs e)
        {
            Filmgetir();
        }

        private void btnTeslim_Click(object sender, EventArgs e)
        {
            int seciliSatirIndex = dgv.SelectedCells[0].RowIndex;
            string SeciliFilmAdi = dgv.Rows[seciliSatirIndex].Cells["FilmAdi"].Value.ToString();
            string sorgu = "DELETE FROM Kira WHERE FilmAdi = @FilmAdi " ;
            string query = "UPDATE Film SET Musait = 'Müsait' WHERE FilmAdi=@FilmAdi";

            conn.Open();
            cmd = new SqlCommand(sorgu, conn);
            cmd.Parameters.AddWithValue("@FilmAdi", SeciliFilmAdi);
            cmd.ExecuteNonQuery();
            conn.Close();

            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@FilmAdi", SeciliFilmAdi);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Film teslim edildi!");
            Filmgetir();
        }
    }
}