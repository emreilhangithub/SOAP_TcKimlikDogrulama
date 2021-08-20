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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string title = "TC KİMLİK DOĞRULAMA SİSTEMİ";

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = title;
        }

        private void btnTcDogrula_Click(object sender, EventArgs e)
        {
            try
            {

                if
                    (
                    string.IsNullOrEmpty(txtTc.Text) || string.IsNullOrEmpty(txtAd.Text) ||
                    string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtDogumYili.Text)
                    )
                {
                    string message = "Lütfen Tüm Alanları eksiksiz doldurunuz";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if
                   (
                   txtTc.Text.Length < 11
                   )
                {
                    string message = "Lütfen Tc Kimlik Numarasını  en az 11 Hane Giriniz";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if
                   (
                   txtDogumYili.Text.Length < 4
                   )
                {
                    string message = "Lütfen Doğum Yılınızı en az 4 Hane giriniz";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Bilgiler bilgiler = new Bilgiler();

                bilgiler.TcKimlikNo = long.Parse(txtTc.Text);
                bilgiler.Ad = txtAd.Text;
                bilgiler.Soyad = txtSoyad.Text;
                bilgiler.DogumYili = Convert.ToInt32(txtDogumYili.Text);


                KimlikDogrula.KPSPublicSoapClient kimlik = new KimlikDogrula.KPSPublicSoapClient();
                var sonuc = kimlik.TCKimlikNoDogrula(bilgiler.TcKimlikNo, bilgiler.Ad, bilgiler.Soyad, bilgiler.DogumYili);
                if (sonuc)
                {
                    string message = " Sayın " + bilgiler.Ad + " " + bilgiler.Soyad + " " + bilgiler.TcKimlikNo + " " + " Numaralı Tc Kimlik Numaranız Doğrulandı";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    string message = " Tc Kimlik Bilgileriniz Doğrulanamadı Lütfen Tc Kimlik Numaranızı Kontrol Ediniz";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtAd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                  && !char.IsSeparator(e.KeyChar);
        }

        private void txtDogumYili_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
