using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string dvm = "d";
            while (dvm == "d")
            {
                Console.Write("İlk Değer: ");
                double deger1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Yapmak İstediğiniz İşlem: ");
                string islem = Console.ReadLine();
                Console.Write("İkici Değer: ");
                double deger2 = Convert.ToDouble(Console.ReadLine());
                if (islem == "+")
                {
                    İslemler islm = new İslemler();
                    Console.WriteLine(islm.toplama(deger1, deger2));
                }
                else if (islem == "*")
                {
                    İslemler ism = new İslemler();
                    Console.WriteLine(ism.carpma(deger1,deger2));
                }
                else if (islem == "/")
                {
                    İslemler ism = new İslemler();
                    Console.WriteLine(ism.bolme(deger1, deger2));
                }
                else
                {
                    Console.WriteLine("İslem Hatalı..");
                }
                Console.WriteLine("\nDevam Etmek İçin ' d ' Harfine Basınız..");
                dvm = Console.ReadLine();
                if(dvm != "d")
                {
                    Console.WriteLine("\nGüle Güle");
                    break;
                }
                Console.WriteLine("--------------------------------------------");
            }
        }
    }
}
