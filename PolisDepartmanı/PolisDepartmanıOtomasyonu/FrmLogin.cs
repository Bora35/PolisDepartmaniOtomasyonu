using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PolisDepartmanıOtomasyonu
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // SqlConnection nesnesi, veritabanına bağlantıyı temsil eder.
        private readonly SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["VeritabaniBaglanti"].ToString());

        // Giriş butonu tıklandığında çağrılan metod.
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // TextBox'lardan kullanıcı adı ve şifreyi alır.
            string Id = TxtId.Text;
            string Pass = TxtPass.Text;

            // Kullanıcı adı veya şifre boşsa hata mesajı gösterir.
            if (string.IsNullOrEmpty(Id) || string.IsNullOrEmpty(Pass))
            {
                MessageBox.Show("Kullanıcı adı ve şifre alanları boş olamaz!");
                return;
            }

            try
            {
                // Veritabanı bağlantısını açar.
                baglanti.Open();

                // Kullanıcı adına göre sorgu yapar.
                string query = "SELECT * FROM Gorevliler WHERE KullaniciAdi = @kadi";
                SqlCommand cmd = new SqlCommand(query, baglanti); // SqlCommand nesnesi oluşturuluyor.
                cmd.Parameters.AddWithValue("@kadi", Id); // Parametre ekleniyor.

                // SqlDataReader ile sorgu sonuçlarını okur.
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    // Eğer kullanıcı varsa
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            // Veritabanındaki şifreyi alır.
                            string savedPassword = reader["sifre"].ToString();

                            // Eğer girdiğiniz şifre doğruysa ana ekrana geçiş yapar.
                            if (savedPassword == Pass)
                            {
                                FrmAnaEkran ana = new FrmAnaEkran();

                                // Kullanıcı adı ve yetkileri VeriDeposu sınıfına kaydedilir.
                                VeriDeposu.Veri.KullaniciAdi = Id;
                                VeriDeposu.Veri.KullaniciYetki = reader["Gorevli"].ToString();

                                ana.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Şifreniz Yanlış!");
                            }
                        }
                    }

                    reader.Close();

                    // TextBox'ları temizler.
                    TxtId.Text = "";
                    TxtPass.Text = "";
                }

                // Veritabanı bağlantısını kapatır.
                baglanti.Close();
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi mesajı gösterir.
                MessageBox.Show(ex.ToString());
            }
        }

        // Form kapatıldığında uygulamayı kapatır.
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        // VeriDeposu sınıfı, kullanıcı adı ve yetkilerini depolamak için kullanılır.
        public class VeriDeposu
        {
            private static VeriDeposu veri;

            public string KullaniciAdi { get; set; }
            public string KullaniciYetki { get; set; }

            private VeriDeposu() { }

            // Singleton tasarım deseni kullanılarak VeriDeposu sınıfının tek bir örneğini oluşturur.
            public static VeriDeposu Veri
            {
                get
                {
                    if (veri == null)
                    {
                        veri = new VeriDeposu();
                    }
                    return veri;
                }
            }
        }

    }
}
