using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTasarimDeseni
{
    class IkinciVersiyon
    {
        // singleton deseni ikinci versiyon
        // birinci versiyondan tek farkı get yerine metot ile nesnenin döndürülmesi
        private static IkinciVersiyon nesne = new IkinciVersiyon();

        private IkinciVersiyon()
        {

        }

        public static IkinciVersiyon Nesne()
        {
            return nesne;
        }
    }
}
