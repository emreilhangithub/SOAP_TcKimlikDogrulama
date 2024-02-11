using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOAP_TcKimlikDogrulama
{
    public partial class FrmTcDorulamaSistemi : Form
    {
        // Başlık için sabit bir değer oluşturuyoruz.
        private readonly string _title = "TC KİMLİK DOĞRULAMA SİSTEMİ";

        // Kimlik doğrulayıcı nesnesi tanımlıyoruz.
        private readonly TCKimlikDogrulayici _dogrulayici;

        public FrmTcDorulamaSistemi()
        {
            InitializeComponent();

            // TCKimlikDogrulayici sınıfını kullanarak bir nesne oluşturuyoruz.
            // Bu nesne, kimlik doğrulama işlemlerini gerçekleştirecek.
            _dogrulayici = new TCKimlikDogrulayici(new KPSPublicSoapClientAdapter());
            
            // Form başlığını ayarlıyoruz.
            this.Text = _title;
        }

        private void FrmTcDorulamaSistemi_Load(object sender, EventArgs e)
        {
            // Başlık ayarını form yüklenirken de yapabiliriz, burada gerek yok.
            // this.Text = title;
        }

        // TC Kimlik doğrulama butonuna tıklandığında gerçekleşen olay.
        private void btnTcDogrula_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanıcının girdiği bilgileri bir Bilgiler nesnesine atıyoruz.
                var bilgiler = new Bilgiler
                {
                    TcKimlikNo = long.Parse(txtTc.Text),
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text,
                    DogumYili = int.Parse(txtDogumYili.Text)
                };

                //// TCKimlikDogrulayici sınıfı üzerinden bilgileri doğrulama işlemi için çağırıyoruz.
                _dogrulayici.Dogrula(bilgiler);
            }

            catch (Exception hata)
            {
                // Herhangi bir hata oluştuğunda kullanıcıya hata mesajını gösteriyoruz.
                MessageBox.Show(hata.ToString());
            }
        }

        // Sadece sayı girişine izin veren bir olay.
        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        // Sadece harf  girişine izin veren bir olay.
        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);

            e.KeyChar = Char.ToUpper(e.KeyChar); //BÜYÜK HARFE ÇEVİRDİK OTAMATİK
        }
        // Sadece harf  girişine izin veren bir olay.
        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                  && !char.IsSeparator(e.KeyChar);

            e.KeyChar = Char.ToUpper(e.KeyChar);//BÜYÜK HARFE ÇEVİRDİK OTAMATİK
        }
        // Sadece sayı  girişine izin veren bir olay.
        private void txtDogumYili_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
