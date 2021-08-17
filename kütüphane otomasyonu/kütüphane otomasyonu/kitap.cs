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
    public partial class kitap : Form
    {
        public static string giden = "";
        public static string giden2 = "";
        public static DataSet ds = new DataSet();

        BindingSource bs = new BindingSource();
        int kacincikayit;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\kutuphane.mdb");
        public kitap()
        {
            InitializeComponent();
        }


        private void kaydet_Click(object sender, EventArgs e)
        {
            if (tbkitapadi.TextLength > 0 & tbyazar.TextLength > 0)
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into kitap(adi,yazari,basimevi,basimtarihi,basimyeri,tur,sayi,kullanilabilir) values('" + tbkitapadi.Text + "','" + tbyazar.Text + "','" + tbbasimevi.Text + "','" + dtpbasimtarihi.Text + "','" + tbbasimyeri.Text + "','" + cbtur.SelectedItem.ToString() + "','" + tbsayi.Text + "','" + tbsayi.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                cek();
                kacincikayit = int.Parse(dataGridView1.Rows.Count.ToString());
                bs.Position = kacincikayit;
                MessageBox.Show("Kayıt edildi.");
            }
            else
            {
                MessageBox.Show("Kitap adı ve yazarı boş bırakılamaz.");
            }

            temizle();

            kaydet.Enabled = iptal.Enabled = false;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cek();
            }

        }

        private void tbkitapara_TextChanged(object sender, EventArgs e)
        {
            int i = 0;

            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kitap where adi like '%" + tbkitapara.Text + "%' OR yazari like '%" + tbkitapara.Text + "%' OR kitapkodu like '%" + tbkitapara.Text + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            i = int.Parse(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;

            conn.Close();

            if (i == 0) MessageBox.Show("Kayıt bulunamadı.");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = 0;
            duzelt.Enabled = sil.Enabled = true;
            try
            { i = int.Parse(dataGridView1.SelectedCells[0].Value.ToString()); }
            catch
            {
                MessageBox.Show("Geçersiz işlem.");
            }

            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kitap where kitapkodu=" + i + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            i = int.Parse(dt.Rows.Count.ToString());
            dataGridView1.DataSource = bs;


            foreach (DataRow dr in dt.Rows)
            {
                tbkitapkodu.Text = dr["kitapkodu"].ToString();
                tbkitapadi.Text = dr["adi"].ToString();
                tbyazar.Text = dr["yazari"].ToString();
                tbbasimevi.Text = dr["basimevi"].ToString();
                dtpbasimtarihi.Value = Convert.ToDateTime(dr["basimtarihi"].ToString());
                tbbasimyeri.Text = dr["basimyeri"].ToString();
                cbtur.SelectedItem = dr["tur"].ToString();
                tbsayi.Text = dr["sayi"].ToString();
            }

            conn.Close();
            giden = tbkitapkodu.Text;
            giden2 = tbkitapadi.Text;
            checkBox1.Checked = false;

        }

        private void duzelt_Click(object sender, EventArgs e)
        {
            int i = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());

            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update kitap set adi='" + tbkitapadi.Text + "',yazari='" + tbyazar.Text + "',basimevi='" + tbbasimevi.Text + "',basimtarihi='" + dtpbasimtarihi.Text + "',basimyeri='" + tbbasimyeri.Text + "',tur='" + cbtur.SelectedItem.ToString() + "',sayi='" + tbsayi.Text + "',kullanilabilir='" + tbsayi.Text + "' where kitapkodu=" + i + "";
            cmd.ExecuteNonQuery();

            conn.Close();
            cek();
            kacincikayit = bs.Position;

            MessageBox.Show("Düzenleme kayıt edildi.");

            temizle();
            sil.Enabled = duzelt.Enabled = false;
        }

        void cek()
        {
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kitap";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;

            conn.Close();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            int i = int.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            DialogResult c = MessageBox.Show("Kayıt silinsin mi?", "Bilgi", MessageBoxButtons.YesNoCancel);
            if (c == DialogResult.Yes)
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from kitap where kitapkodu=" + i + "";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt silindi.");
                conn.Close();
                cek();

                temizle();
                sil.Enabled = duzelt.Enabled = false;
            }
        }

        private void yenikayit_Click(object sender, EventArgs e)
        {
            temizle();
            kaydet.Enabled = iptal.Enabled = true;

        }

        private void tbkitapara_MouseClick(object sender, MouseEventArgs e)
        {
            tbkitapara.Text = "";
            tbkitapara.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            tbkitapara.ForeColor = Color.Black;
        }

        void temizle()
        {
            tbkitapkodu.Text = "";
            tbkitapadi.Text = "";
            tbyazar.Text = "";
            tbbasimevi.Text = "";
            dtpbasimtarihi.ResetText();
            tbbasimyeri.Text = "";
            cbtur.SelectedIndex = 0;
            tbsayi.Text = "";
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            temizle();
            kaydet.Enabled = iptal.Enabled = false;
        }

        private void oduncver_Click(object sender, EventArgs e)
        {
            if (tbkitapkodu.TextLength > 0)
            {
                odunc odunc = new odunc();
                this.Hide();
                odunc.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Seçim yapınız.");
            }
        }

        private void ogrenciislemleri_Click(object sender, EventArgs e)
        {
            ogrenci ogrenci = new ogrenci();
            this.Hide();
            ogrenci.ShowDialog();
            this.Show();
        }

        private void ogrenciislemleri_MouseEnter(object sender, EventArgs e)
        {
            ogrenciislemleri.ForeColor = Color.OrangeRed;
        }

        private void ogrenciislemleri_MouseLeave(object sender, EventArgs e)
        {
            ogrenciislemleri.ForeColor = Color.DarkCyan;
        }

        private void rapor_Click(object sender, EventArgs e)
        {
            rapor rapor = new rapor();
            this.Hide();
            rapor.ShowDialog();
            this.Show();
        }

        private void kitap_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kitap";
            cmd.ExecuteNonQuery();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(ds,"kitap");
            conn.Close();
        }

    }
}

