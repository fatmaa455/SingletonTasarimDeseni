using System;

namespace SingletonTasarimDeseni
{
    class Program
    {
        static void Main(string[] args)
        {
            // nesnenin birinci versiyon ile oluşturulması
            BirinciVersiyon n = BirinciVersiyon.Nesne;

            // nesnenin ikinci versiyon ile oluşturulması
            IkinciVersiyon n2 = IkinciVersiyon.Nesne();

            // nesnenin üçüncü versiyon ile oluşturulması
            UcuncuVersiyon n3 = UcuncuVersiyon.Nesne();

            // nesnenin dördüncü versiyon ile oluşturulması
            DorduncuVersiyon n4 = DorduncuVersiyon.Nesne();
        }
    }
}
