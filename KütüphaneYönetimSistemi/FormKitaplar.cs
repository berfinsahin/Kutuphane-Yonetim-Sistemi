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

namespace KütüphaneYönetimSistemi
{
    public partial class FormKitaplar : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-D2GFNLE;Initial Catalog=DbBerNurKütüphane;Integrated Security=True");

        public FormKitaplar()
        {
            InitializeComponent();
        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO TableKitaplar(KitapAdi, YazarAdi, YazarSoyadi, ISBN, Durum, KitapTurKodu) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                sqlCommand.Parameters.AddWithValue("@p1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@p2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@p3", textBoxYazarSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@p4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@p5", "True");
                sqlCommand.Parameters.AddWithValue("@p6", textBoxKitapTurKodu.Text);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap eklenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            verilerigoster();
        }
        private void verilerigoster()
        {
            try
            {
                String q = "SELECT *FROM TableKitaplar";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormKitaplar_Load(object sender, EventArgs e)
        {
            verilerigoster();
            WindowState = FormWindowState.Maximized;

        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelGecikmeBedeli.Text = "0";
            int secilensatir = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            labelID.Text = dataGridViewKitaplar.Rows[secilensatir].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[secilensatir].Cells[1].Value.ToString();
            textBoxYazarAdi.Text = dataGridViewKitaplar.Rows[secilensatir].Cells[2].Value.ToString();
            textBoxYazarSoyad.Text = dataGridViewKitaplar.Rows[secilensatir].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[secilensatir].Cells[4].Value.ToString();
            textBoxKitapTurKodu.Text = dataGridViewKitaplar.Rows[secilensatir].Cells[8].Value.ToString();

            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[secilensatir].Cells[6].Value.ToString();
            if (dataGridViewKitaplar.Rows[secilensatir].Cells[7].Value != DBNull.Value)
                dateTimePickerOduncAlmaTarihi.Value = (DateTime)dataGridViewKitaplar.Rows[secilensatir].Cells[7].Value;
        }

        private void buttonKitapBilgiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {


                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand(" UPDATE TableKitaplar SET KitapAdi=@p1, YazarAdi=@p2, YazarSoyadi=@p3, ISBN=@p4, KitapTurKodu=@p5 WHERE ID=@p6 ", baglanti);
                sqlCommand.Parameters.AddWithValue("@p1", textBoxKitapAdi.Text);
                sqlCommand.Parameters.AddWithValue("@p2", textBoxYazarAdi.Text);
                sqlCommand.Parameters.AddWithValue("@p3", textBoxYazarSoyad.Text);
                sqlCommand.Parameters.AddWithValue("@p4", textBoxISBN.Text);
                sqlCommand.Parameters.AddWithValue("@p5", textBoxKitapTurKodu.Text);
                sqlCommand.Parameters.AddWithValue("@p6", labelID.Text);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap güncellenirken hata oluştu !" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            verilerigoster();
        }

        private void buttonKitapOduncVer_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {


                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand(" UPDATE TableKitaplar SET OduncAlan=@p1,OduncAlmaTarihi=@p2,Durum=@p3 WHERE ID=@p4 ", baglanti);
                    sqlCommand.Parameters.AddWithValue("@p1", textBoxOduncAlan.Text);
                    sqlCommand.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePickerOduncAlmaTarihi.Value.Date;
                    sqlCommand.Parameters.AddWithValue("@p3", "False");
                    sqlCommand.Parameters.AddWithValue("@p4", labelID.Text);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                verilerigoster();
            }
            else
            {
                MessageBox.Show("Lütfen Listeden Bir Kitap Seçiniz !");
            }

        }

        private void buttonGecikmeBedeliHesapla_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                DateTime bugununTarihi = DateTime.Now;
                int gunFarki = (int)(bugununTarihi - dateTimePickerOduncAlmaTarihi.Value.Date).TotalDays;
                if (gunFarki >1)
                {
                    int gecikmeBedeli = gunFarki * 1;
                    labelGecikmeBedeli.Text = gecikmeBedeli.ToString();
                }
            }
        }

        private void buttonKitabiIadeEt_Click(object sender, EventArgs e)
        {
            if (labelID.Text != "-")
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE TableKitaplar SET OduncAlan = @P1, OduncAlmaTarihi=@P2, Durum=@P3 WHERE ID = @P4", baglanti);

                    sqlCommand.Parameters.AddWithValue("@P1", "");
                    sqlCommand.Parameters.Add("@P2", SqlDbType.Date).Value = DBNull.Value;
                    sqlCommand.Parameters.AddWithValue("@P3", "True");
                    sqlCommand.Parameters.AddWithValue("@P4", labelID.Text);
                    sqlCommand.ExecuteNonQuery();
                    textBoxOduncAlan.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Kitap iade işlemi sırasında hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                verilerigoster();
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            metinKutulariniTemizle();
        }

        public void metinKutulariniTemizle()
        {
            labelID.Text = "-";
            textBoxKitapAdi.Text = "";
            textBoxYazarAdi.Text = "";
            textBoxYazarSoyad.Text = "";
            textBoxISBN.Text = "";
            textBoxKitapTurKodu.Text = "";
            textBoxOduncAlan.Text = "";
        }

        private void buttonAra_Click(object sender, EventArgs e)
        {
            aramaSonuclariniGoster();
        }
        private void aramaSonuclariniGoster()
        {
            try
            {
                string q = "SELECT* FROM TableKitaplar WHERE KitapAdi LIKE '" + textBoxKitapAdi.Text
                                                                             + "%' AND YazarAdi LIKE '" + textBoxYazarAdi.Text + "%' "
                                                                             + " AND YazarSoyadi LIKE '" + textBoxYazarSoyad.Text + "%' "
                                                                             + " AND ISBN LIKE '" + textBoxISBN.Text + "%' "
                                                                             + " AND KitapTurKodu LIKE '" + textBoxKitapTurKodu.Text + "%' "
                                                                             + " AND OduncAlan LIKE '" + textBoxOduncAlan.Text + "%' ";
                SqlDataAdapter da = new SqlDataAdapter(q, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dataGridViewKitaplar.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonTumKıtaplarıGoster_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (labelID.Text == "-" || labelID.Text == "")
            {
                MessageBox.Show("Lütfen Listeden silinecek kitabı seçiniz !");
            }
            else
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM TableKitaplar WHERE ID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", labelID.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(" Kitap silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }

                verilerigoster();
                metinKutulariniTemizle();
            }
        }

        private void FormKitaplar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
     
    }
    }
