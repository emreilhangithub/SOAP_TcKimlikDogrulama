// IKimlikDogrulamaServisi, TC Kimlik doğrulama işlemi için kullanılacak metodları içeren bir arayüzdür.
// Bu arayüz, TC Kimlik numarası, ad, soyad ve doğum yılı bilgilerini alarak doğrulama işlemini gerçekleştiren bir metodu tanımlar.
namespace SOAP_TcKimlikDogrulama
{
    public interface IKimlikDogrulamaServisi
    {
        // TCKimlikNoDogrula metodu, verilen TC Kimlik numarası, ad, soyad ve doğum yılı bilgileriyle doğrulama işlemini gerçekleştirir.
        // Eğer doğrulama başarılı ise true, değilse false döndürür.
        bool TCKimlikNoDogrula(long tcKimlikNo, string ad, string soyad, int dogumYili);
    }
}