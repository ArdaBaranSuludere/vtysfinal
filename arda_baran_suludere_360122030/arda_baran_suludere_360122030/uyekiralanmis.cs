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
    public partial class uyekiralanmis : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable tablo;
        public uyekiralanmis()
        {
            InitializeComponent();
        }

        private void Filmgetir()
        {
            string sorgu = "SELECT * FROM Kira WHERE UyeAdi='"+ uyegiris.kullaniciadi +"'";
            conn = new SqlConnection("Data Source=.; Initial Catalog=vtysfinal; Integrated Security=True");
            adapter = new SqlDataAdapter(sorgu, conn);
            ds = new DataSet();
            conn.Open();
            adapter.Fill(ds, "Kira");
            dgv.DataSource = ds.Tables["Kira"];
            conn.Close();
        }
        private void uyekiralanmis_Load(object sender, EventArgs e)
        {
               Filmgetir();
        }
    }
}
