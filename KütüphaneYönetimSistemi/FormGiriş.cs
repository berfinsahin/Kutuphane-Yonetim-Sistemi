using System.Data.SqlClient;

namespace KütüphaneYönetimSistemi
{
    public partial class FormGiriş : Form
    {
        FormKitaplar formKitaplar;
        public FormGiriş()
        {
            InitializeComponent();
        }

       SqlConnection baglanti =new  SqlConnection(@"Data Source=DESKTOP-D2GFNLE;Initial Catalog=DbBerNurKütüphane;Integrated Security=True");
        //SQL veritabanına bağlantı kurmanı sağlar
        private void buttonGiris_Click(object sender, EventArgs e)
        {
           try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi=@p1 AND Sifre=@p2 ",baglanti);
                sqlKomut.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);
                sqlKomut.Parameters.AddWithValue("@p2", textBoxSifre.Text);
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader();
            
                if (sqlDataReader.Read())
                {                  
                   formKitaplar = new FormKitaplar();
                   formKitaplar.Show();
                   this.Hide();         
                }
                else
                {                 
                    MessageBox.Show("Kullanıcı Adı veya Şifre hatalı!" );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bağlantı Hatası ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void FormGiriş_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

     
    }
}