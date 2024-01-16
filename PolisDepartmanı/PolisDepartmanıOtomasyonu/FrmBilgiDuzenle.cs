using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// FrmLogin sınıfından VeriDeposu sınıfını import ediyoruz.
using static PolisDepartmanıOtomasyonu.FrmLogin;

namespace PolisDepartmanıOtomasyonu
{
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde çağrılan metod.
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            // Kullanıcı adı düzenleme işlemi için devre dışı bırakılır.
            TxtKullaniciAdi.Enabled = false;

            // Veritabanından kullanıcı bilgilerini getirmek için SQL sorgusu.
            string Sql = "select * from Gorevliler where KullaniciAdi=@KullaniciAdi";

            // SqlParameter dizisi, SQL sorgusundaki parametrelerin değerlerini tutar.
            SqlParameter[] Param = new SqlParameter[]
            {
                new SqlParameter("KullaniciAdi", VeriDeposu.Veri.KullaniciAdi)
            };

            // Veritabanından okuma ve yazma işlemleri gerçekleştiren SqlDataReader nesnesi.
            SqlDataReader OkuYaz = Veritabani.OkuYaz(Sql, Param);

            // SqlDataReader'dan okuma yapar.
            if (OkuYaz.Read())
            {
                // Okunan verilerle TextBox'lara değerler atanır.
                TxtKullaniciAdi.Text = OkuYaz["KullaniciAdi"].ToString();
                TxtSifre.Text = OkuYaz["Sifre"].ToString();
                TxtAd.Text = OkuYaz["Ad"].ToString();
                TxtSoyad.Text = OkuYaz["Soyad"].ToString();
                TxtTelefon.Text = OkuYaz["Telefon"].ToString();
            }

            // Okuma işlemini kapatır ve belleği temizler bırakır.
            OkuYaz.Close();
            OkuYaz.Dispose();
        }

        // "Güncelle" butonuna tıklandığında çağrılan metod.
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            // Veritabanında kullanıcı bilgilerini güncellemek için SQL sorgusu.
            string Sql = "update Gorevliler set Sifre=@Sifre,Ad=@Ad,Soyad=@Soyad,Telefon=@Telefon where KullaniciAdi=@KullaniciAdi";

            // SqlParameter dizisi, SQL sorgusundaki parametrelerin değerlerini tutar.
            SqlParameter[] Param = new SqlParameter[]
            {
                new SqlParameter("KullaniciAdi",TxtKullaniciAdi.Text),
                new SqlParameter("Sifre",TxtSifre.Text),
                new SqlParameter("Ad",TxtAd.Text),
                new SqlParameter("Soyad", TxtSoyad.Text),
                new SqlParameter("Telefon", TxtTelefon.Text),
            };

            // Veritabanında okuma ve yazma işlemleri gerçekleştiren SqlDataReader nesnesi.
            SqlDataReader OkuYaz = Veritabani.OkuYaz(Sql, Param);

            // Okuma işlemini kapatır ve belleği temizler bırakır.
            OkuYaz.Close();
            OkuYaz.Dispose();

            // Kullanıcıya güncelleme başarılı mesajı gösterir.
            MessageBox.Show("Güncelleme Başarılı!");
        }

        // "İptal" butonuna tıklandığında çağrılan metod.
        private void BtnIptal_Click(object sender, EventArgs e)
        {
            // İptal metodunu çağırarak formu kapatır ve ana ekrana döner.
            Iptal();
        }

        // Form kapatıldığında çağrılan metod.
        private void FrmBilgiDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            // İptal metodunu çağırarak formu kapatır ve ana ekrana döner.
            Iptal();
        }

        // İptal metodunu tanımlayan özel metod.
        private void Iptal()
        {
            // Ana ekran formunu oluşturur ve gösterir, bu formu gizler.
            FrmAnaEkran Ana = new FrmAnaEkran();
            Ana.Show();
            Hide();
        }
    }
}
