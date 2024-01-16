using System;
using System.Data.SqlClient;
using System.Windows.Forms;

// FrmLogin sınıfından VeriDeposu sınıfını import ediyoruz.
using static PolisDepartmanıOtomasyonu.FrmLogin;

namespace PolisDepartmanıOtomasyonu
{
    public partial class FrmSuclu : Form
    {
        public FrmSuclu()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde çalışan metod.
        private void FrmSuclu_Load(object sender, EventArgs e)
        {
            // BilgiGetir ve Sorgula metodlarını çağırır.
            BilgiGetir();
            Sorgula("");

            // Yetkili kullanıcının adını TxtYetkiliAdi TextBox'ına ekler.
            TxtYetkiliAdi.Text = VeriDeposu.Veri.KullaniciAdi;
        }

        // Kaydet butonuna tıklandığında çalışan metot.
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            // Seçilen cinsiyeti belirlemek için foreach döngüsü.
            string secilenCinsiyet = "Diğer";

            foreach (object item in LstBoxCinsiyet.CheckedItems)
            {
                secilenCinsiyet = item.ToString();
            }

            // SQL sorgusu ile yeni bir mahkum kaydı eklenir.
            string Sql = "insert into Mahkumlar(YetkiliKadi,Ad,Soyad,DogumTarihi,Cinsiyet,CezaAlmaTarihi,CezaBitisTarihi,SucAdi,Telefon) values(@YetkiliKadi,@Ad,@Soyad,@DogumTarihi,@Cinsiyet,@CezaAlmaTarihi,@CezaBitisTarihi,@SucAdi,@Telefon)";

            // SQL sorgusunda kullanılacak parametreler tanımlanır.
            SqlParameter[] Param = new SqlParameter[]
            {
                new SqlParameter("YetkiliKadi",TxtYetkiliAdi.Text),
                new SqlParameter("Ad",TxtAd.Text),
                new SqlParameter("Soyad", TxtSoyad.Text),
                new SqlParameter("DogumTarihi", dateDogum.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("Cinsiyet", secilenCinsiyet),
                new SqlParameter("CezaAlmaTarihi", dateCezaAlma.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("CezaBitisTarihi", dateCezaBitis.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("SucAdi", TxtSuclar.Text),
                new SqlParameter("Telefon", TxtTelefon.Text)
            };

            // Veritabanına sorguyu gönderir ve okuma işlemini gerçekleştirir.
            SqlDataReader OkuYaz = Veritabani.OkuYaz(Sql, Param);

            // SqlDataReader nesnesini kapatır ve bellekten temizler.
            OkuYaz.Close();
            OkuYaz.Dispose();

            // Form üzerindeki giriş alanlarını temizler.
            TxtAd.Text = "";
            TxtSoyad.Text = "";

            // Doğum tarihi varsayılan olarak güncellenir.
            dateDogum.Value = DateTime.Now;

            // Cinsiyet ListBox'ını temizler.
            for (int i = 0; i < LstBoxCinsiyet.Items.Count; i++)
            {
                // İlgili öğe seçili mi diye kontrol et
                if (LstBoxCinsiyet.GetItemChecked(i))
                {
                    // Seçiliyse, durumunu false yap
                    LstBoxCinsiyet.SetItemChecked(i, false);
                }
            }

            // Ceza alma ve bitiş tarihi varsayılan olarak güncellenir.
            dateCezaAlma.Value = DateTime.Now;
            dateCezaBitis.Value = DateTime.Now;

            // Diğer giriş alanlarını temizler.
            TxtSuclar.Text = "";
            TxtTelefon.Text = "";

            // Kullanıcıya başarı mesajı gösterir.
            MessageBox.Show("Kayıt Başarılı!");

            // BilgiGetir ve Sorgula metodlarını çağırır.
            BilgiGetir();
            Sorgula("");
        }

        // Güncelle butonuna tıklandığında çalışan metot.
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            // Seçilen cinsiyeti belirlemek için foreach döngüsü.
            string secilenCinsiyet = "Diğer";

            foreach (object item in LstBoxCinsiyet.CheckedItems)
            {
                secilenCinsiyet = item.ToString();
            }

            // SQL sorgusu ile mahkum kaydı güncellenir.
            string Sql = "update Mahkumlar set Ad=@Ad,Soyad=@Soyad,DogumTarihi=@DogumTarihi,Cinsiyet=@Cinsiyet,CezaAlmaTarihi=@CezaAlmaTarihi,CezaBitisTarihi=@CezaBitisTarihi,SucAdi=@SucAdi,Telefon=@Telefon where MahkumID=@Id";

            // SQL sorgusunda kullanılacak parametreler tanımlanır.
            SqlParameter[] Param = new SqlParameter[]
            {
                new SqlParameter("Id", TxtMahkumId.Text),
                new SqlParameter("Ad",TxtAd.Text),
                new SqlParameter("Soyad", TxtSoyad.Text),
                new SqlParameter("DogumTarihi", dateDogum.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("Cinsiyet", secilenCinsiyet),
                new SqlParameter("CezaAlmaTarihi", dateCezaAlma.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("CezaBitisTarihi", dateCezaBitis.Value.ToString("yyyy-MM-dd")),
                new SqlParameter("SucAdi", TxtSuclar.Text),
                new SqlParameter("Telefon", TxtTelefon.Text)
            };

            // Veritabanına sorguyu gönderir ve okuma işlemini gerçekleştirir.
            SqlDataReader OkuYaz = Veritabani.OkuYaz(Sql, Param);

            // SqlDataReader nesnesini kapatır ve bellekten temizler.
            OkuYaz.Close();
            OkuYaz.Dispose();

            // Kullanıcıya güncelleme başarı mesajı gösterir.
            MessageBox.Show("Güncelleme Başarılı!");

            // Form üzerindeki giriş alanlarını temizler.
            // Yetkili kullanıcının adını TxtYetkiliAdi TextBox'ına ekler.
            TxtYetkiliAdi.Text = VeriDeposu.Veri.KullaniciAdi;
            TxtMahkumId.Text = "";

            TxtAd.Text = "";
            TxtSoyad.Text = "";

            // Doğum tarihi varsayılan olarak güncellenir.
            dateDogum.Value = DateTime.Now;

            // Cinsiyet ListBox'ını temizler.
            for (int i = 0; i < LstBoxCinsiyet.Items.Count; i++)
            {
                // İlgili öğe seçili mi diye kontrol et
                if (LstBoxCinsiyet.GetItemChecked(i))
                {
                    // Seçiliyse, durumunu false yap
                    LstBoxCinsiyet.SetItemChecked(i, false);
                }
            }

            // Ceza alma ve bitiş tarihi varsayılan olarak güncellenir.
            dateCezaAlma.Value = DateTime.Now;
            dateCezaBitis.Value = DateTime.Now;

            // Diğer giriş alanlarını temizler.
            TxtSuclar.Text = "";
            TxtTelefon.Text = "";

            // Kaydet butonunun etkinleştirilmesi.
            BtnKaydet.Enabled = true;


            // BilgiGetir ve Sorgula metodlarını çağırır.
            BilgiGetir();
            Sorgula("");
        }

        // İptal butonuna tıklandığında çalışan metot.
        private void BtnIptal_Click(object sender, EventArgs e)
        {
            // Form üzerindeki giriş alanlarını temizler.
            // Yetkili kullanıcının adını TxtYetkiliAdi TextBox'ına ekler.
            TxtYetkiliAdi.Text = VeriDeposu.Veri.KullaniciAdi;
            TxtMahkumId.Text = "";

            TxtAd.Text = "";
            TxtSoyad.Text = "";

            // Doğum tarihi varsayılan olarak güncellenir.
            dateDogum.Value = DateTime.Now;

            // Cinsiyet ListBox'ını temizler.
            for (int i = 0; i < LstBoxCinsiyet.Items.Count; i++)
            {
                // İlgili öğe seçili mi diye kontrol et
                if (LstBoxCinsiyet.GetItemChecked(i))
                {
                    // Seçiliyse, durumunu false yap
                    LstBoxCinsiyet.SetItemChecked(i, false);
                }
            }

            // Ceza alma ve bitiş tarihi varsayılan olarak güncellenir.
            dateCezaAlma.Value = DateTime.Now;
            dateCezaBitis.Value = DateTime.Now;

            // Diğer giriş alanlarını temizler.
            TxtSuclar.Text = "";
            TxtTelefon.Text = "";

            // Kaydet butonunun etkinleştirilmesi.
            BtnKaydet.Enabled = true;
        }

        // BilgiGetir butonuna tıklandığında çalışan metot.
        private void BtnBilgiGetir_Click(object sender, EventArgs e)
        {
            // Seçilen mahkumun bilgilerini getirir.
            string Sql = "select * from Mahkumlar where MahkumID=@Id";

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
                TxtMahkumId.Text = OkuYaz["MahkumID"].ToString();
                TxtYetkiliAdi.Text = OkuYaz["YetkiliKadi"].ToString();

                TxtAd.Text = OkuYaz["Ad"].ToString();
                TxtSoyad.Text = OkuYaz["Soyad"].ToString();

                // Doğum tarihini ayarlar.
                if (DateTime.TryParse(OkuYaz["DogumTarihi"].ToString(), out DateTime dogumTarihi))
                {
                    dateDogum.Value = dogumTarihi;
                }

                // Cinsiyeti ayarlar.
                string cinsiyet = OkuYaz["Cinsiyet"].ToString();
                for (int i = 0; i < LstBoxCinsiyet.Items.Count; i++)
                {
                    // İlgili cinsiyetin indeksini bul
                    if (LstBoxCinsiyet.Items[i].ToString() == cinsiyet)
                    {
                        // İlgili cinsiyeti seçili yap
                        LstBoxCinsiyet.SetItemChecked(i, true);
                    }
                    else
                    {
                        // Diğer cinsiyetleri seçili yapma
                        LstBoxCinsiyet.SetItemChecked(i, false);
                    }
                }

                // Ceza alma tarihini ayarlar.
                if (DateTime.TryParse(OkuYaz["CezaAlmaTarihi"].ToString(), out DateTime cezaAlmaTarihi))
                {
                    dateCezaAlma.Value = cezaAlmaTarihi;
                }

                // Ceza bitiş tarihini ayarlar.
                if (DateTime.TryParse(OkuYaz["CezaBitisTarihi"].ToString(), out DateTime cezaBitisTarihi))
                {
                    dateCezaBitis.Value = cezaBitisTarihi;
                }

                TxtSuclar.Text = OkuYaz["SucAdi"].ToString();
                TxtTelefon.Text = OkuYaz["Telefon"].ToString();

            }

            // SqlDataReader nesnesini kapatır ve bellekten temizler.
            OkuYaz.Close();
            OkuYaz.Dispose();

            // Kaydet butonunu devre dışı bırakır.
            BtnKaydet.Enabled = false;
        }

        // BilgiSil butonuna tıklandığında çalışan metot.
        private void BtnBilgiSil_Click(object sender, EventArgs e)
        {
            // SQL sorgusu ile seçilen kayıt silinir.
            string Sql = "delete from Mahkumlar where MahkumID=@Id";

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

        // Arama kutusunda metin değiştiğinde çalışan metot.
        private void TxtSorgu_TextChanged(object sender, EventArgs e)
        {
            // Sorgula metodunu çağırarak arama işlemini gerçekleştirir.
            Sorgula(TxtSorgu.Text);
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
                string Sql = "select * from Mahkumlar where MahkumID=@Id";

                // SQL sorgusunda kullanılacak parametreler tanımlanır.
                SqlParameter[] Param = new SqlParameter[]
                {
                    new SqlParameter("Id", row.Cells["MahkumID"].Value.ToString())
                };

                // Veritabanına sorguyu gönderir ve okuma işlemini gerçekleştirir.
                SqlDataReader OkuYaz = Veritabani.OkuYaz(Sql, Param);

                // SqlDataReader nesnesi üzerinden bir satır okunmuşsa bu blok çalışır.
                if (OkuYaz.Read())
                {
                    // Veritabanından alınan değerlerle ilgili form alanları doldurulur.
                    TxtMahkumId.Text = OkuYaz["MahkumID"].ToString();
                    TxtYetkiliAdi.Text = OkuYaz["YetkiliKadi"].ToString();

                    TxtAd.Text = OkuYaz["Ad"].ToString();
                    TxtSoyad.Text = OkuYaz["Soyad"].ToString();

                    // Doğum tarihini ayarlar.
                    if (DateTime.TryParse(OkuYaz["DogumTarihi"].ToString(), out DateTime dogumTarihi))
                    {
                        dateDogum.Value = dogumTarihi;
                    }

                    // Cinsiyeti ayarlar.
                    string cinsiyet = OkuYaz["Cinsiyet"].ToString();
                    for (int i = 0; i < LstBoxCinsiyet.Items.Count; i++)
                    {
                        // İlgili cinsiyetin indeksini bul
                        if (LstBoxCinsiyet.Items[i].ToString() == cinsiyet)
                        {
                            // İlgili cinsiyeti seçili yap
                            LstBoxCinsiyet.SetItemChecked(i, true);
                        }
                        else
                        {
                            // Diğer cinsiyetleri seçili yapma
                            LstBoxCinsiyet.SetItemChecked(i, false);
                        }
                    }

                    // Ceza alma tarihini ayarlar.
                    if (DateTime.TryParse(OkuYaz["CezaAlmaTarihi"].ToString(), out DateTime cezaAlmaTarihi))
                    {
                        dateCezaAlma.Value = cezaAlmaTarihi;
                    }

                    // Ceza bitiş tarihini ayarlar.
                    if (DateTime.TryParse(OkuYaz["CezaBitisTarihi"].ToString(), out DateTime cezaBitisTarihi))
                    {
                        dateCezaBitis.Value = cezaBitisTarihi;
                    }

                    TxtSuclar.Text = OkuYaz["SucAdi"].ToString();
                    TxtTelefon.Text = OkuYaz["Telefon"].ToString();

                }

                // SqlDataReader nesnesini kapatır ve bellekten temizler.
                OkuYaz.Close();
                OkuYaz.Dispose();

                // Kaydet butonunun devre dışı bırakılması.
                BtnKaydet.Enabled = false;
            }
        }

        // Bilgileri getirme metodunu tanımlar.
        private void BilgiGetir()
        {
            // SQL sorgusu ile MahkumId , Adı ve soyadı bilgilerini içeren kayıtlar getirilir.
            string Sql = "select MahkumID,Ad+space(1)+Soyad AdSoyad from Mahkumlar";

            // Veritabanından gelen verileri ListBox kontrolüne bind eder.
            LstBoxBilgi.DataSource = Veritabani.VeriTablosu(Sql);
            LstBoxBilgi.DisplayMember = "AdSoyad";
            LstBoxBilgi.ValueMember = "MahkumID";
        }

        // Arama yapma metodunu tanımlar.
        private void Sorgula(string Bilgi = null)
        {
            // SQL sorgusu ile tüm bilgileri üzerinde arama yapılır.
            string Sql = "select * from Mahkumlar";

            // Eğer arama için bir bilgi varsa, SQL sorgusuna WHERE koşulu eklenir.
            if (Bilgi != null)
            {
                Sql += " where YetkiliKadi like'%'+@Bilgi+'%' or " +
                    "Ad like'%'+@Bilgi+'%' or " +
                    "Soyad like'%'+@Bilgi+'%' or " +
                    "DogumTarihi like'%'+@Bilgi+'%' or " +
                    "Cinsiyet like'%'+@Bilgi+'%' or " +
                    "CezaAlmaTarihi like'%'+@Bilgi+'%' or " +
                    "CezaBitisTarihi like'%'+@Bilgi+'%' or " +
                    "SucAdi like'%'+@Bilgi+'%' or " +
                    "Telefon like'%'+@Bilgi+'%'";
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
        private void FrmSuclu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Form kapatıldığında, ana ekrana dönülmesini sağlar.
            FrmAnaEkran Ana = new FrmAnaEkran();
            Ana.Show();
            Hide();
        }


    }
}
