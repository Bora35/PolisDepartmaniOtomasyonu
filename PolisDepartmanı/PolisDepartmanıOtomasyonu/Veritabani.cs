using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PolisDepartmanıOtomasyonu
{
    // Veritabani sınıfı, veritabanı işlemlerini gerçekleştiren yardımcı metotları içerir.
    public static class Veritabani
    {
        // Bağlantı Metodu: Veritabanına bağlantı oluşturur ve bu bağlantıyı döndürür.
        private static SqlConnection Baglanti()
        {
            // Veritabanı bağlantı dizesini alır.
            SqlConnection Baglan = new SqlConnection(ConfigurationManager.ConnectionStrings["VeritabaniBaglanti"].ToString());

            // Bağlantıyı açar.
            Baglan.Open();

            // Oluşturulan bağlantıyı döndürür.
            return Baglan;
        }

        // OkuYaz Metodu: Veritabanından veri okuma ve yazma işlemlerini gerçekleştirir.
        public static SqlDataReader OkuYaz(string Sql, SqlParameter[] Param = null)
        {
            // Bağlantıyı oluşturur.
            SqlConnection Baglan = Baglanti();

            // SqlCommand nesnesi oluşturur , SQL sorgusunu ve bağlantıyı atar.
            SqlCommand Yonet = new SqlCommand(Sql, Baglan);

            // Eğer parametreler varsa, SqlCommand nesnesine ekler.
            if (Param != null)
            {
                Yonet.Parameters.AddRange(Param);
            }

            // SqlDataReader nesnesi ile sorgudan dönen veriyi okur.
            // CommandBehavior.CloseConnection :  SqlDataReader Nesnesi kapatıldığında bağlantının otomatik olarak kapatılmasını sağlar.
            SqlDataReader OkuYaz = Yonet.ExecuteReader(CommandBehavior.CloseConnection);

            // SqlCommand nesnesini bellekten temizler.
            Yonet.Dispose();

            // OkuYaz nesnesini döndürür.
            return OkuYaz;
        }

        // VeriTablosu Metodu: Veritabanından veri çekip DataTable içerisine doldurur.
        public static DataTable VeriTablosu(string Sql, SqlParameter[] Param = null)
        {
            // DataTable nesnesi oluşturur.
            DataTable Tablo = new DataTable();

            // Bağlantıyı oluşturur.
            SqlConnection Baglan = Baglanti();

            // SqlCommand nesnesi oluşturur, SQL sorgusunu ve bağlantıyı atar.
            SqlCommand Yonet = new SqlCommand(Sql, Baglan);

            // Eğer parametreler varsa, SqlCommand nesnesine ekler.
            if (Param != null)
            {
                Yonet.Parameters.AddRange(Param);
            }

            // SqlDataAdapter nesnesi ile sorgudan dönen veriyi DataTable içine doldurur.
            SqlDataAdapter VeriAdaptoru = new SqlDataAdapter(Yonet);
            VeriAdaptoru.Fill(Tablo);

            // SqlCommand nesnesini ve parametrelerini bellekten temizler.
            Yonet.Dispose();
            Yonet.Parameters.Clear();

            // Bağlantıyı kapatır ve bellekten temizler.
            Baglan.Close();
            Baglan.Dispose();

            // DataTable nesnesini döndürür.
            return Tablo;
        }
    }
}
