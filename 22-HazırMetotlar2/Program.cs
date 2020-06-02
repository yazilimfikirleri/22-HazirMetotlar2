using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_HazırMetotlar2
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# programlama dilinde matematiksel işlemleri daha hızlı ve kolay bir şekilde hesaplayabilmek için Math kütüphanesi içerisinde bulunan hazır metotlar kullanarak bir takım işlemler gerçekleştirilebilir.
            /*
             Örneğin bir sayının;
                 -karesini,
                 -karekökünü,
                 -üssünü,
                 -mutlak değerini
                 ve bir çok işlemi yapılabilir.
              */

            Console.WriteLine("Sayı girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int mutlakDeger = Math.Abs(sayi);//Bir sayının mutlak değerini tutar.
            double cos = Math.Cos(sayi);//Sayının kosinüsünü tutar.
            double sin = Math.Sin(sayi);//Sayının sinüsünü tutar.
            double ussu = Math.Pow(sayi, 2);//x üzeri y yi hesaplar.
            double kareKok = Math.Sqrt(sayi);//x in karekökünü bulur.

            Console.WriteLine("Girilen sayının mutlak değeri: " + mutlakDeger);
            Console.WriteLine("Girilen sayının kosinüsü: " + cos);
            Console.WriteLine("Girilen sayının sinüsü: " + sin);
            Console.WriteLine("Girilen sayının üssü: " + ussu);
            Console.WriteLine("Girilen sayının karekökü: " + kareKok);

            Console.Read();

        }
    }
}
