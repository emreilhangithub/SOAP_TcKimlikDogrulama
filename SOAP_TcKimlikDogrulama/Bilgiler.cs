using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOAP_TcKimlikDogrulama
{
    /// <summary>
    /// Bilgiler sınıfı, kimlik doğrulama işlemi için kullanılacak temel bilgileri içerir.
    /// </summary>
    public class Bilgiler
    {
        /// <summary>
        /// TC Kimlik numarası özelliği. Uzun bir tamsayı türündedir.
        /// </summary>
        public long TcKimlikNo { get; set; }
        /// <summary>
        ///  Ad özelliği. Kullanıcının adını tutar.
        /// </summary>
        public string Ad { get; set; }
        /// <summary>
        /// Soyad özelliği. Kullanıcının soyadını tutar.
        /// </summary>
        public string Soyad { get; set; }
        /// <summary>
        /// DogumYili özelliği. Kullanıcının doğum yılını tutar.
        /// </summary>
        public int DogumYili { get; set; }
    }
}
