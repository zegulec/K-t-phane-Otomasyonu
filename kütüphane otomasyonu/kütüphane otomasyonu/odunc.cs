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
    public partial class odunc : Form
    {
        int adet = 0;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\kutuphane.mdb");
        public odunc()
        {
            InitializeComponent();
        }

        private void bul_Click(object sender, EventArgs e)
        {
            
            int i =0;

            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ogrenci where tc=" + tbtc.Text + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            i = int.Parse(dt.Rows.Count.ToString());
            if (i==0)
            {
                MessageBox.Show("Kayıt bulunamadı.");
            }

            else
            {
            foreach(DataRow dr in dt.Rows)
            {
                tbadsoyad.Text=dr["adsoyad"].ToString();
                tbfakulte.Text=dr["fakulte"].ToString();
                tbbolum.Text=dr["bolum"].ToString();
                tbtel.Text=dr["tel"].ToString();
                tbmail.Text=dr["mail"].ToString();
                tamam.Enabled = iptal.Enabled = true;
            }
            }
        }

        private void odunc_Load(object sender, EventArgs e)
        {
            if(conn.State==ConnectionState.Open) conn.Close();
            conn.Open();
            tbkitapkodu.Text = kitap.giden.ToString();
            tbkitapadi.Text = kitap.giden2.ToString();
        }

        private void tamam_Click(object sender, EventArgs e)
        {
            
                int adet = 0;

                OleDbCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "select * from kitap where kitapkodu=" + tbkitapkodu.Text + "";
                cmd2.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                OleDbDataAdapter da1 = new OleDbDataAdapter(cmd2);
                da1.Fill(dt1);
                foreach (DataRow dr1 in dt1.Rows)
                {
                    adet = int.Parse(dr1["kullanilabilir"].ToString());
                }

                if (adet > 0)
                {
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "insert into odunc(tc,kitapkodu,kitapadi,verilistarihi,teslimtarihi,teslim) values('" + tbtc.Text + "','" + tbkitapkodu.Text + "','" + tbkitapadi.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "','" + 0 + "')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt başarılı.");

                    OleDbCommand cmd1 = conn.CreateCommand();
                    cmd1.CommandType = CommandType.Text;
                    cmd1.CommandText = "update kitap set kullanilabilir=kullanilabilir-1 where kitapkodu=" + tbkitapkodu.Text + "";
                    cmd1.ExecuteNonQuery();


                    tbtc.Text = "";
                    tbadsoyad.Text = "";
                    tbfakulte.Text = "";
                    tbbolum.Text = "";
                    tbtel.Text = "";
                    tbmail.Text = "";
                    tbkitapkodu.Text = "";
                    tbkitapadi.Text = "";
                    dateTimePicker1.ResetText();
                    dateTimePicker2.ResetText();
                }
                else
                {
                    MessageBox.Show("Bu kitaptan yeterli sayıda bulunmamakta.");
                }
           
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            tbtc.Text = "";
            tbadsoyad.Text = "";
            tbfakulte.Text = "";
            tbbolum.Text = "";
            tbtel.Text = "";
            tbmail.Text = "";
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
        }
    }
}
