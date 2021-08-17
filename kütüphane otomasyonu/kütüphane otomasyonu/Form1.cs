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
    public partial class Form1 : Form
    {
       string tc= ogrenci.bilgi.ToString();
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\kutuphane.mdb");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from odunc where tc='" + tc.ToString() + "' AND teslim=" + 0 + "";
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                 lbedilmedi.Items.Add(dr["kitapadi"]);

            }
            conn.Close();

            conn.Open();
            OleDbCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from odunc where tc='" + tc.ToString() + "' AND teslim=" + 1 + "";
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                lbteslimedildi.Items.Add(dr1["kitapadi"]);

            }
            conn.Close();
        }

        private void lbedilmedi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from odunc where kitapadi='" + lbedilmedi.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    kitapkodu.Text = dr["kitapkodu"].ToString();
                    kitapadi.Text = dr["kitapadi"].ToString();
                    verilis.Text = dr["verilistarihi"].ToString();
                    teslim.Text = dr["teslimtarihi"].ToString();
                }
                conn.Close();
            }
            catch { }
        }

        private void Al_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update odunc set teslim="+ 1 +",teslimtarihi='"+ teslim.Text +"' where kitapadi='" + lbedilmedi.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            conn.Close();
           
            conn.Open();
            OleDbCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update kitap set kullanilabilir=kullanilabilir+1 where adi='" + lbedilmedi.SelectedItem.ToString() + "'";
            cmd1.ExecuteNonQuery();
            conn.Close();
            lbteslimedildi.Items.Add(lbedilmedi.SelectedItem);
            lbedilmedi.Items.Remove(lbedilmedi.SelectedItem);


        }
    }
}
