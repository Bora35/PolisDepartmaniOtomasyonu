using System;
using System.Windows.Forms;

// FrmLogin sınıfından VeriDeposu sınıfını import ediyoruz.
using static PolisDepartmanıOtomasyonu.FrmLogin;

namespace PolisDepartmanıOtomasyonu
{
    public partial class FrmAnaEkran : Form
    {
        public FrmAnaEkran()
        {
            InitializeComponent();
        }

        // Form yüklendiğinde çağrılan metod.
        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
            // Kullanıcı adını LbLYetkiliAdi üzerinde gösterir.
            LbLYetkiliAdi.Text = "Yetkili : " + VeriDeposu.Veri.KullaniciAdi;

            // Eğer kullanıcının yetkisi "true" ise Memur butonunu etkinleştirir, aksi takdirde devre dışı bırakır.
            BtnMemur.Enabled = VeriDeposu.Veri.KullaniciYetki.ToLower() == "true";

        }

        // "Suçlu" butonuna tıklandığında çağrılan metod.
        private void BtnSuclu_Click(object sender, EventArgs e)
        {
            // Suçlu formunu oluşturur ve gösterir, bu formu gizler.
            FrmSuclu Suclu = new FrmSuclu();
            Suclu.Show();
            Hide();
        }

        // "Memur" butonuna tıklandığında çağrılan metod.
        private void BtnMemur_Click(object sender, EventArgs e)
        {
            // Görevli formunu oluşturur ve gösterir, bu formu gizler.
            FrmGorevli Gorevli = new FrmGorevli();
            Gorevli.Show();
            Hide();
        }

        // "Düzenle" butonuna tıklandığında çağrılan metod.
        private void BtnDüzenle_Click(object sender, EventArgs e)
        {
            // Bilgi Düzenle formunu oluşturur ve gösterir, bu formu gizler.
            FrmBilgiDuzenle Bilgi = new FrmBilgiDuzenle();
            Bilgi.Show();
            Hide();
        }

        // Form kapatıldığında çağrılan metod.
        private void FrmAnaEkran_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Giriş ekranını oluşturur ve gösterir, bu formu gizler.
            FrmLogin Login = new FrmLogin();
            Login.Show();
            Hide();
        }
    }
}
