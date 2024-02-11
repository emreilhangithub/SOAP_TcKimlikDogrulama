// TCKimlikDogrulayici sınıfı, kimlik doğrulama işlemini gerçekleştiren bir aracıdır.
// Bu sınıf, IKimlikDogrulamaServisi arayüzünü kullanarak kimlik doğrulama işlemini gerçekleştirir.
// Kullanıcıdan alınan bilgileri doğrulama servisine ileterek kimlik doğrulama işlemini gerçekleştirir ve sonucu kullanıcıya bildirir.
using System;
using System.Windows.Forms;

namespace SOAP_TcKimlikDogrulama
{
    public class TCKimlikDogrulayici
    {
        private readonly IKimlikDogrulamaServisi _kimlikDogrulamaServisi;

        // Kurucu metot, kimlik doğrulama servisi nesnesini alır.
        public TCKimlikDogrulayici(IKimlikDogrulamaServisi kimlikDogrulamaServisi)
        {
            _kimlikDogrulamaServisi = kimlikDogrulamaServisi;
        }
        // Dogrula metodu, verilen bilgileri kimlik doğrulama servisine ileterek doğrulama işlemini gerçekleştirir.
        // Eğer doğrulama başarılı ise kullanıcıya bilgi mesajı gösterir, değilse hata mesajı gösterir.
        public void Dogrula(Bilgiler bilgiler)
        {
            // Bilgilerin eksiksiz ve doğru olduğunu kontrol eder.
            if (string.IsNullOrEmpty(bilgiler.Ad) || string.IsNullOrEmpty(bilgiler.Soyad) || bilgiler.DogumYili.ToString().Length < 4)
            {
                MessageBox.Show("Lütfen tüm alanları eksiksiz doldurunuz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // TC Kimlik numarasının geçerli olduğunu kontrol eder.
            if (bilgiler.TcKimlikNo.ToString().Length < 11)
            {
                MessageBox.Show("Lütfen TC Kimlik Numarasını en az 11 hane giriniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Bilgilerin doğruluğunu kimlik doğrulama servisine ileterek doğrulama işlemini gerçekleştirir.
            if (!_kimlikDogrulamaServisi.TCKimlikNoDogrula(bilgiler.TcKimlikNo, bilgiler.Ad, bilgiler.Soyad, bilgiler.DogumYili))
            {
                MessageBox.Show("TC Kimlik bilgileriniz doğrulanamadı. Lütfen bilgilerinizi kontrol ediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Doğrulama başarılı ise kullanıcıya bilgi mesajı gösterir.
            MessageBox.Show($"Sayın {bilgiler.Ad.ToUpper()} {bilgiler.Soyad.ToUpper()} {bilgiler.TcKimlikNo} numaralı TC Kimlik numaranız doğrulandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
