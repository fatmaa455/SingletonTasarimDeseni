using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTasarimDeseni
{
    class BirinciVersiyon
    {
        // singleton deseni birinci versiyon

        // SingletonTasarimDeseni sınıfı belleğe yüklendiği anda statik olan SingletonTasarimDeseni nesnesi yaratılacaktır
        // early loading
        private static BirinciVersiyon nesne = new BirinciVersiyon();

        // yapıcı metod parametresiz olmalı
        // private ya da protected olmalı
        private BirinciVersiyon()
        {

        }


        // sadece get kullanıldığı için bir kez yaratılan nesne harici bir kaynak tarafından hiçbir şekilde değiştirilemez
        public static BirinciVersiyon Nesne
        {
            get
            {
                return nesne;
            }
        }
    }
}
