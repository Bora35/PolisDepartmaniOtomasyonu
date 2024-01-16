using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PolisDepartmanıOtomasyonu
{
    public partial class FrmGorevli : Form
    {
        public FrmGorevli()
        {
            InitializeComponent();
        }

        // Form yüklenirken çalışan metod.
        private void FrmGorevli_Load(object sender, EventArgs e)
        {
            // BilgiGetir metodunu çağırır.
            BilgiGetir();

            // Sorgula metodunu çağırır ve parametre olarak boş bir string geçer.
            Sorgula("");
        }

        // Kaydet butonuna tıklandığında çalışan metot.
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // SQL sorgusu ile yeni bir kayıt eklenir.
            string Sql = "insert into Gorevliler(KullaniciAdi,Sifre,Ad,Soyad,Telefon,Gorevli) values(@KullaniciAdi,@Sifre,@Ad,@Soyad,@Telefon,@Gorevli)";

            // SQL sorgusunda kullanılacak parametreler tanımlanır.
            SqlParameter[] Param = new SqlParameter[]
            {
                new SqlParameter("KullaniciAdi",TxtKullaniciAdi.Text),
                new SqlParameter("Sifre", "12345"),
                new SqlParameter("Ad",TxtAd.Text),
                new SqlParameter("Soyad", TxtSoyad.Text),
                new SqlParameter("Telefon", TxtTelefon.Text),
                new SqlParameter("Gorevli", cBoxYetki.Checked ? "1" : "0")
            };

            // Veritabanına sorguyu gönderir ve okuma işlemini gerçekleştirir.
            SqlDataReader OkuYaz = Veritabani.OkuYaz(Sql, Param);

            // SqlDataReader nesnesini kapatır ve bellekten temizler.
            OkuYaz.Close();
            OkuYaz.Dispose();

            // Form üzerindeki giriş alanlarını temizler.
            TxtKullaniciAdi.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtTelefon.Text = "";
            cBoxYetki.Checked = false;

            // Kullanıcıya başarı mesajı gösterir.
            MessageBox.Show("Kayıt Başarılı!");

            // BilgiGetir ve Sorgula metodlarını çağırır.
            BilgiGetir();
            Sorgula("");
        }

        // Güncelle butonuna tıklandığında çalışan metot.
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            // SQL sorgusu ile kayıt güncellenir.
            string Sql = "update Gorevliler set Ad=@Ad,Soyad=@Soyad,Telefon=@Telefon,Gorevli=@Gorevli where KullaniciAdi=@KullaniciAdi";

            // SQL sorgusunda kullanılacak parametreler tanımlanır.
            SqlParameter[] Param = new SqlParameter[]
            {
                new SqlParameter("KullaniciAdi",TxtKullaniciAdi.Text),
                new SqlParameter("Ad",TxtAd.Text),
                new SqlParameter("Soyad", TxtSoyad.Text),
                new SqlParameter("Telefon", TxtTelefon.Text),
                new SqlParameter("Gorevli", cBoxYetki.Checked ? "1" : "0")
            };

            // Veritabanına sorguyu gönderir ve okuma işlemini gerçekleştirir.
            SqlDataReader OkuYaz = Veritabani.OkuYaz(Sql, Param);

            // SqlDataReader nesnesini kapatır ve bellekten temizler.
            OkuYaz.Close();
            OkuYaz.Dispose();

            // Kullanıcıya başarı mesajı gösterir.
            MessageBox.Show("Güncelleme Başarılı!");


            // Giriş alanlarını temizler
            TxtKullaniciAdi.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtTelefon.Text = "";
            cBoxYetki.Checked = false;

            // Kaydet butonunun etkinleştirilmesi.
            BtnKaydet.Enabled = true;
            // Kullanıcı adı giriş alanının etkinleştirilmesi.
            TxtKullaniciAdi.Enabled = true;

            // BilgiGetir ve Sorgula metodlarını çağırır.
            BilgiGetir();
            Sorgula("");
        }

        // Bilgi Sil butonuna tıklandığında çalışan metot.
        private void BtnBilgiSil_Click(object sender, EventArgs e)
        {
            // SQL sorgusu ile seçilen kayıt silinir.
            string Sql = "delete from Gorevliler where KullaniciID=@Id";

            // SQL sorgusunda kullanılacak parametreler tanımlanır.
            SqlParameter[] Param = new SqlParameter[]
            {
                new SqlParameter("Id", LstBoxBilgi.SelectedValue.ToString())
            };

            // Veritabanına sorguyu gönderir ve okuma işlemini gerçekleştirir.
            SqlDataReader OkuYaz = Veritabani.OkuYaz(Sql, Param);

            // SqlDataReader nesnesini kapatır ve bellekten temizler.
            OkuYaz.Close();
            OkuYaz.Dispose();

            // Kullanıcıya başarı mesajı gösterir.
            MessageBox.Show("Kişi Silindi!");

            // BilgiGetir ve Sorgula metodlarını çağırır.
            BilgiGetir();
            Sorgula("");

        }

        // Bilgi Getir butonuna tıklandığında çalışan metot.
        private void BtnBilgiGetir_Click(object sender, EventArgs e)
        {
            // SQL sorgusu ile seçilen kayıt bilgileri getirilir.
            string Sql = "select * from Gorevliler where KullaniciID=@Id";

            // SQL sorgusunda kullanılacak parametreler tanımlanır.
            SqlParameter[] Param = new SqlParameter[]
            {
                new SqlParameter("Id", LstBoxBilgi.SelectedValue.ToString())
            };

            // Veritabanına sorguyu gönderir ve okuma işlemini gerçekleştirir.
            SqlDataReader OkuYaz = Veritabani.OkuYaz(Sql, Param);

            // SqlDataReader nesnesi üzerinden bir satır okunmuşsa bu blok çalışır.
            if (OkuYaz.Read())
            {
                // Veritabanından alınan değerlerle ilgili form alanları doldurulur.
                TxtKullaniciAdi.Text = OkuYaz["KullaniciAdi"].ToString();
                TxtAd.Text = OkuYaz["Ad"].ToString();
                TxtSoyad.Text = OkuYaz["Soyad"].ToString();
                TxtTelefon.Text = OkuYaz["Telefon"].ToString();

                // Veritabanından alınan 'Gorevli' alanı bool türündedir, bu nedenle Convert.ToBoolean kullanılır.
                cBoxYetki.Checked = Convert.ToBoolean(OkuYaz["Gorevli"]);
            }

            // SqlDataReader nesnesini kapatır ve bellekten temizler.
            OkuYaz.Close();
            OkuYaz.Dispose();

            // Kaydet butonunun devre dışı bırakılması.
            BtnKaydet.Enabled = false;

            // Kullanıcı adı giriş alanının devre dışı bırakılması.
            TxtKullaniciAdi.Enabled = false;

        }

        // DataGridView'da bir hücreye tıklandığında çalışan metot.
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Satır indeksi 0'dan büyükse çalışır.
            if (e.RowIndex >= 0)
            {
                // Tıklanan satırı alır.
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];

                // SQL sorgusu ile tıklanan kullanıcı adına sahip kayıt bilgileri getirilir.
                string Sql = "select * from Gorevliler where KullaniciAdi = @KullaniciAdi";

                // SQL sorgusunda kullanılacak parametreler tanımlanır.
                SqlParameter[] Param = new SqlParameter[]
                {
                    new SqlParameter("KullaniciAdi",row.Cells["KullaniciAdi"].Value.ToString())
                };

                // Veritabanına sorguyu gönderir ve okuma işlemini gerçekleştirir.
                SqlDataReader OkuYaz = Veritabani.OkuYaz(Sql, Param);

                // SqlDataReader nesnesi üzerinden bir satır okunmuşsa bu blok çalışır.
                if (OkuYaz.Read())
                {
                    // Veritabanından alınan değerlerle ilgili form alanları doldurulur.
                    TxtKullaniciAdi.Text = OkuYaz["KullaniciAdi"].ToString();
                    TxtAd.Text = OkuYaz["Ad"].ToString();
                    TxtSoyad.Text = OkuYaz["Soyad"].ToString();
                    TxtTelefon.Text = OkuYaz["Telefon"].ToString();

                    // Veritabanından alınan 'Gorevli' alanı bool türündedir, bu nedenle Convert.ToBoolean kullanılır.
                    cBoxYetki.Checked = Convert.ToBoolean(OkuYaz["Gorevli"]);
                }

                // SqlDataReader nesnesini kapatır ve bellekten temizler.
                OkuYaz.Close();
                OkuYaz.Dispose();

                // Kaydet butonunun devre dışı bırakılması.
                BtnKaydet.Enabled = false;

                // Kullanıcı adı giriş alanının devre dışı bırakılması.
                TxtKullaniciAdi.Enabled = false;

            }
        }

        // İptal butonuna tıklandığında çalışan metot.
        private void BtnIptal_Click(object sender, EventArgs e)
        {
            // Giriş alanlarını temizler ve butonları etkinleştirir.
            TxtKullaniciAdi.Text = "";
            TxtAd.Text = "";
            TxtSoyad.Text = "";
            TxtTelefon.Text = "";
            cBoxYetki.Checked = false;

            // Kaydet butonunun etkinleştirilmesi.
            BtnKaydet.Enabled = true;
            // Kullanıcı adı giriş alanının etkinleştirilmesi.
            TxtKullaniciAdi.Enabled = true;
        }


        // Arama kutusunda metin değiştiğinde çalışan metot.
        private void TxtSorgu_TextChanged(object sender, EventArgs e)
        {
            // Sorgula metodunu çağırarak arama işlemini gerçekleştirir.
            Sorgula(TxtSorgu.Text);
        }

        // Bilgileri getirme metodunu tanımlar.
        private void BilgiGetir()
        {
            // SQL sorgusu ile kullanıcı adı ve soyadı bilgilerini içeren kayıtlar getirilir.
            string Sql = "select KullaniciId,Ad+space(1)+Soyad AdSoyad from Gorevliler";

            // Veritabanından gelen verileri ListBox kontrolüne bind eder.
            LstBoxBilgi.DataSource = Veritabani.VeriTablosu(Sql);
            LstBoxBilgi.DisplayMember = "AdSoyad";
            LstBoxBilgi.ValueMember = "KullaniciId";
        }

        // Arama yapma metodunu tanımlar.
        private void Sorgula(string Bilgi = null)
        {
            // SQL sorgusu ile kullanıcı adı, ad, soyad, telefon veya görevli bilgilerine göre arama yapılır.
            string Sql = "select KullaniciAdi,Ad,Soyad,Telefon,Gorevli from Gorevliler";

            // Eğer arama için bir bilgi varsa, SQL sorgusuna WHERE koşulu eklenir.
            if (Bilgi != null)
            {
                Sql += " where KullaniciAdi like'%'+@Bilgi+'%' or Ad like'%'+@Bilgi+'%' or Soyad like'%'+@Bilgi+'%' or Telefon like'%'+@Bilgi+'%' or Gorevli like'%'+@Bilgi+'%'";
            }

            // SQL sorgusunda kullanılacak parametreler tanımlanır.
            SqlParameter[] Param = new SqlParameter[]
            {
                new SqlParameter("Bilgi", Bilgi)
            };

            // Veritabanındaki sonuçları dataGridView kontrolüne bağlar.
            dataGridView.DataSource = Veritabani.VeriTablosu(Sql, Param);
        }

        // Form kapatıldığında çalışan metot.
        private void FrmGorevli_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Form kapatıldığında, ana ekrana dönülmesini sağlar.
            FrmAnaEkran Ana = new FrmAnaEkran();
            Ana.Show();
            Hide();
        }
    }
}
