# SOAP_TcKimlikDogrulama

## Proje Tanıtımı 

*Bu proje, Türkiye Cumhuriyeti Kimlik Numarası (TC Kimlik No) doğrulama işlemlerini gerçekleştiren bir sistemdir.*

# Proje İçeriği #

1) Proje, bir C# Windows Forms uygulamasıdır.
Amacı, kullanıcının TC Kimlik numarası doğrulamasını yapmaktır.

2)Temel Bileşenler:

- Bilgiler: Kullanıcının TC Kimlik bilgilerini içeren model sınıfı.
- IKimlikDogrulamaServisi: TC Kimlik doğrulama servisiyle etkileşim için bir arayüz (interface).
- KPSPublicSoapClientAdapter: Gerçek bir SOAP istemcisiyle iletişim kurarak TC Kimlik doğrulama servisine istek yapacak adaptör sınıfı.
- TCKimlikDogrulayici: IKimlikDogrulamaServisi arayüzünü kullanarak TC Kimlik doğrulamasını gerçekleştirecek yardımcı sınıf.
- FrmTcDorulamaSistemi: Windows Forms uygulamasının ana formu.

3)Yapılanlar:

- Bilgiler model sınıfı: Kullanıcının TC Kimlik bilgilerini temsil eder.
- IKimlikDogrulamaServisi interface: TC Kimlik doğrulama servisiyle etkileşim için bir arayüz belirlendi.
- KPSPublicSoapClientAdapter sınıfı: Gerçek bir SOAP istemcisiyle iletişim kurmak için IKimlikDogrulamaServisi arayüzünü uygulayan bir adaptör sınıf oluşturuldu.
- TCKimlikDogrulayici sınıfı: IKimlikDogrulamaServisi arayüzünü kullanarak TC Kimlik doğrulamasını gerçekleştiren bir yardımcı sınıf oluşturuldu.
- FrmTcDorulamaSistemi formu: Kullanıcı arayüzü ve kullanıcının girdiği bilgileri işleyen form oluşturuldu.

4)Nerede İstek Atıyoruz:

- FrmTcDorulamaSistemi formunda, kullanıcının girdiği bilgileri TCKimlikDogrulayici sınıfına gönderiyoruz.
- TCKimlikDogrulayici sınıfı, bu bilgileri IKimlikDogrulamaServisi arayüzü kullanarak doğrulama işlemi için KPSPublicSoapClientAdapter sınıfına iletiyor.
- KPSPublicSoapClientAdapter sınıfı, gerçek bir SOAP istemcisiyle iletişim kurarak TC Kimlik doğrulama hizmetine istek yapar ve sonucu döndürür.
- Sonuç TCKimlikDogrulayici sınıfı aracılığıyla FrmTcDorulamaSistemi formuna iletilir ve kullanıcıya bildirilir.

Bu şekilde, kullanıcının girdiği TC Kimlik bilgilerini doğrulamak için bir sistem oluşturduk. Bu sistem, SOAP protokolünü kullanan bir hizmeti entegre ederek TC Kimlik doğrulama işlemlerini gerçekleştiriyor.

![Anasayfa](https://github.com/emreilhangithub/SOAP_TcKimlikDogrulama/blob/master/images/Anasayfa.png)

```.NET``` ```C#``` ```SOAP```  ```WindowsForm``` ```Software``` ```Computer``` ```Programmer```