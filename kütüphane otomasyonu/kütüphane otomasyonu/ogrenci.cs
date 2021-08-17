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
    public partial class ogrenci : Form
    {
        public static string bilgi = "";
        string secilen = "";
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        int kacincikayit;
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\kutuphane.mdb");
        public ogrenci()
        {
            InitializeComponent();
        }

        private void yenikayit_Click(object sender, EventArgs e)
        {
            temizle();
            kaydet.Enabled = iptal.Enabled = true;
        }

        void cek()
        {
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ogrenci";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            bs.DataSource = dt;
            dataGridView1.DataSource = bs;

            conn.Close();
        }

        void temizle()
        {
            try
            {
                tbtc.Text = "";
                tbadsoyad.Text = "";
                tbtel.Text = "";
                tbmail.Text = "";
                pictureBox1.ImageLocation = "";
                dtpdogum.ResetText();
                cbcinsiyet.SelectedIndex = 0;
                cbfakulte.SelectedIndex = 0;
                cbbolum.SelectedIndex = 0;
                
            }
            catch { }
        }

        private void kaydet_Click(object sender, EventArgs e)
        {
            if (tbtc.TextLength == 11 & tbadsoyad.TextLength > 0 & tbtel.TextLength > 0 & tbmail.TextLength > 0)
            {
                if (conn.State == ConnectionState.Open) conn.Close();

                conn.Open();
                OleDbCommand cmd1 = new OleDbCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "select * from ogrenci where tc=" + tbtc.Text + "";
                cmd1.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd1);
                da.Fill(dt);
                int say;
                say = Convert.ToInt32(dt.Rows.Count.ToString());
                conn.Close();
                if (say != 0)
                {
                    MessageBox.Show("Bu kimlik daha önce kaydedilmiş.");
                }
                else
                {
                   try
                   {
                        conn.Open();
                        OleDbCommand cmd = conn.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "insert into ogrenci(tc,adsoyad,dt,cinsiyet,fakulte,bolum,tel,mail,resim) values(" + tbtc.Text + ",'" + tbadsoyad.Text + "','" + dtpdogum.Text + "','" + cbcinsiyet.SelectedItem.ToString() + "','" + cbfakulte.SelectedItem.ToString() + "','" + cbbolum.SelectedItem.ToString() + "','" + tbtel.Text + "','" + tbmail.Text + "','" + pictureBox1.ImageLocation.ToString() + "')";
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        cek();
                        kacincikayit = int.Parse(dataGridView1.Rows.Count.ToString());
                        bs.Position = kacincikayit;
                        MessageBox.Show("Kayıt edildi.");
                    }
                    catch
                    {
                        MessageBox.Show("Eksik ya da yanlış bilgi girdiniz.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Eksik ya da hatalı bilgi girdiniz.");
            }

            temizle();

            kaydet.Enabled = iptal.Enabled = false;
        }

        private void resimekle_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath + "\\resimler\\";
            DialogResult sonuc = openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                cek();
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            double i = double.Parse(dataGridView1.SelectedCells[0].Value.ToString());
            DialogResult c = MessageBox.Show("Kayıt silinsin mi?", "Bilgi", MessageBoxButtons.YesNoCancel);
            if (c == DialogResult.Yes)
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from ogrenci where tc=" + i + "";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt silindi.");
                conn.Close();
                cek();

                temizle();
                sil.Enabled = duzelt.Enabled = false;
            }

        }

        private void duzelt_Click(object sender, EventArgs e)
        {
            double i = double.Parse(dataGridView1.SelectedCells[0].Value.ToString());

            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update ogrenci set tc='" + tbtc.Text + "',adsoyad='" + tbadsoyad.Text + "',dt='" + dtpdogum.Text + "',cinsiyet='" + cbcinsiyet.SelectedItem.ToString() + "',fakulte='" + cbfakulte.SelectedItem.ToString() + "',bolum='" + cbbolum.SelectedItem.ToString() + "',tel='" + tbtel.Text + "',mail='" + tbmail.Text + "',resim='" + pictureBox1.ImageLocation + "' where tc=" + i + "";
            cmd.ExecuteNonQuery();

            conn.Close();
            cek();
            kacincikayit = bs.Position;

            MessageBox.Show("Düzenleme kayıt edildi.");

            temizle();
            sil.Enabled = duzelt.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            double i = 0;
            duzelt.Enabled = sil.Enabled = kitaplarigor.Enabled= true;
            try
            { i = double.Parse(dataGridView1.SelectedCells[0].Value.ToString()); }
            catch
            {
                MessageBox.Show("Geçersiz işlem.");
            }

            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ogrenci where tc=" + i + "";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            i = int.Parse(dt.Rows.Count.ToString());
            dataGridView1.DataSource = bs;

            foreach(DataRow dr in dt.Rows)
            {
                tbtc.Text = dr["tc"].ToString();
                tbadsoyad.Text = dr["adsoyad"].ToString();
                dtpdogum.Value = Convert.ToDateTime(dr["dt"].ToString());
                cbcinsiyet.SelectedItem = dr["cinsiyet"].ToString();
                cbfakulte.SelectedItem = dr["fakulte"].ToString();
                cbbolum.SelectedItem = dr["bolum"].ToString();
                tbtel.Text = dr["tel"].ToString();
                tbmail.Text = dr["mail"].ToString();
                pictureBox1.ImageLocation = dr["resim"].ToString();
            }

            conn.Close();
            checkBox1.Checked = false;
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            temizle();
            kaydet.Enabled = iptal.Enabled = false;
        }

        private void tbarama_TextChanged(object sender, EventArgs e)
        {
            int i = 0;

            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from ogrenci where tc like '%" + tbarama.Text + "%' OR adsoyad like '%" + tbarama.Text + "%' OR bolum like '%" + tbarama.Text + "%' OR fakulte like '%"+ tbarama +"%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            i = int.Parse(dt.Rows.Count.ToString());
            dataGridView1.DataSource = dt;

            conn.Close();

            if (i == 0) MessageBox.Show("Kayıt bulunamadı.");
        }

        private void tbarama_MouseClick(object sender, MouseEventArgs e)
        {
            tbarama.Text = "";
            tbarama.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            tbarama.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bilgi = tbtc.Text;
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void ogrenci_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from fakulteler";
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbfakulte.Items.Add(dr["fakulte"]);
            }
            conn.Close();


        }
        private void cbfakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilen = cbfakulte.SelectedItem.ToString();
            cbbolum.Items.Clear();
        }

        private void cbbolum_MouseClick(object sender, MouseEventArgs e)
        {
            cbbolum.Items.Clear();

            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from bolumler where fakulte='"+ secilen +"'";
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbbolum.Items.Add(dr["bolum"].ToString());
            }
            conn.Close();
            cbbolum.SelectedIndex = 0;
        }

       
    }
}
