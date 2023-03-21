using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTasarimDeseni
{
    class UcuncuVersiyon
    {
        // singleton deseni üçüncü versiyon
        private static UcuncuVersiyon nesne;

        private UcuncuVersiyon()
        {

        }

        // nesne ilk olarak sınıf belleğe yüklendiğinde değil de o nesneyi ilk defa kullanmak istediğimizde yaratılıyor
        // lazy loading
        public static UcuncuVersiyon Nesne()
        {
            // İlgili nesneyi her istediğimizde yeni bir nesnenin yaratılmaması için;
            if (nesne == null)
            {
                // daha efektif kullanım sağlar
                nesne = new UcuncuVersiyon();
            }
            return nesne;
        }
    }
}
