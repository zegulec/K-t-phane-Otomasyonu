using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace kütüphane_otomasyonu
{
    public partial class giris : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\kutuphane.mdb");
        public giris()
        {
            InitializeComponent();
        }

        private void giris_Load(object sender, EventArgs e)
        {
            tbkullaniciadi.Focus();

             if(conn.State==ConnectionState.Open) conn.Close();

            conn.Open();

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from kullanici where kullaniciadi='" + tbkullaniciadi.Text +"'and sifre='" + tbsifre.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            int say;
            say = Convert.ToInt32(dt.Rows.Count.ToString());
            if(say==0)
            {
                MessageBox.Show("Giriş bilgilerinizi kontrol edin.");
            }
            else
            {
                kitap kitap = new kitap();
                this.Hide();
                kitap.ShowDialog();
                tbkullaniciadi.Clear();
                tbsifre.Clear();
                this.Show();

            }

        }
    }
}
