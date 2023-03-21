using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonTasarimDeseni
{
    class DorduncuVersiyon
    {
        // singleton deseni dördüncü versiyon
        private static DorduncuVersiyon nesne;

        // eğer çok kanallı(multi-thread) bir uygulama geliştiriyorsanız farklı kanalların aynı  nesneyi tekrar yaratması olasıdır
        // bunu engellemek için;
        public static Object kilit = new Object();

        private DorduncuVersiyon()
        {

        }

        public static DorduncuVersiyon Nesne()
        {
            if (nesne == null)
            {
                // eğer nesne ilk defa yaratılacaksa yani daha önceden nesne null değere sahipse lock anahtar sözcüğü ile işaretlenen blok kitlenerek 
                // başka kanalların bu bloğa erişmesi engellenir
                lock (kilit)
                {
                    // kilitleme işlemi bittiğinde nesne  yaratılmış olacağı için, kilidin kalkmasını bekleyen diğer kanal lock bloğuna girmiş olsa bile
                    // bu bloktaki ikinci if kontrolü nesnenin yeniden oluşturulmasını engeller
                    if (nesne == null)
                    {
                        nesne = new DorduncuVersiyon();
                    }
                }
            }
            return nesne;
        }
    }
}
