// KPSPublicSoapClientAdapter sınıfı, IKimlikDogrulamaServisi arayüzünü uygulayan ve TC Kimlik doğrulama hizmetini sağlayan bir adaptördür.
// Bu sınıf, KimlikDogrula servisinin sağladığı KPSPublicSoapClient'i kullanarak TC Kimlik doğrulama işlemini gerçekleştirir.
namespace SOAP_TcKimlikDogrulama
{
    public class KPSPublicSoapClientAdapter : IKimlikDogrulamaServisi
    {
        // TCKimlikNoDogrula metodu, verilen TC Kimlik numarası, ad, soyad ve doğum yılı bilgileriyle doğrulama işlemini gerçekleştirir.
        // Eğer doğrulama başarılı ise true, değilse false döndürür.
        public bool TCKimlikNoDogrula(long tcKimlikNo, string ad, string soyad, int dogumYili)
        {
            // Kimlik doğrulama servisini kullanarak TC Kimlik numarası, ad, soyad ve doğum yılı bilgileriyle doğrulama işlemini gerçekleştirir.
            using (var kimlik = new KimlikDogrula.KPSPublicSoapClient())
            {
                // Kimlik doğrulama servisinden dönen sonucu alır ve doğrudan döndürür.
                var sonuc = kimlik.TCKimlikNoDogrula(tcKimlikNo, ad, soyad, dogumYili);
                return sonuc;
            }
        }
    }
}
