using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayı_tahmin_oyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rasgele = new Random();
            Console.WriteLine("Zorluk Seviyesini Yazınız. (Seçenekler:Kolay, Orta, Zor)");
            string Secenek = Console.ReadLine();
            int sınır = 1;
            int hak = 0;
            int Dogru = 0;
            if (Secenek.ToLower() == "kolay")
            {
                hak = 6;
                Console.WriteLine(Secenek + " ile oyun başlıyor Yanlış Yapma Hakınız" + hak.ToString());


                for (int i = 0; i < sınır; i++)
                {

                    Console.WriteLine("1-10 arasında bir sayı yazın");
                    string cevap = Console.ReadLine();
                    int sayı = rasgele.Next(1, 10);
                    if (cevap == sayı.ToString())
                    {
                        Dogru++;
                        Console.WriteLine("Doğru Bildiniz Doğru Sayınız:" + Dogru.ToString());
                    }
                    else if (cevap != sayı.ToString())
                    {
                        hak--;

                        Console.WriteLine("Yanlış  Bildiniz kalan hakınız:" + hak.ToString() + " Doğru Sayınız:" + Dogru.ToString()); ;
                    }
                    else
                    {
                        Console.WriteLine("1-10 arasında bir sayı yazın");
                    }
                    if (hak != 0)
                    {
                        sınır++;
                    }
                }
            }
            else if (Secenek.ToLower() == "orta")
            {
                hak = 4;
                Console.WriteLine(Secenek + " ile oyun başlıyor Yanlış Yapma Hakınız" + hak.ToString());
                for (int i = 0; i < sınır; i++)
                {

                    Console.WriteLine("1-25 arasında bir sayı yazın");
                    string cevap = Console.ReadLine();
                    int sayı = rasgele.Next(1, 25);
                    if (cevap == sayı.ToString())
                    {
                        Dogru++;
                        Console.WriteLine("Doğru Bildiniz Doğru Sayınız:" + Dogru.ToString());
                    }
                    else if (cevap != sayı.ToString())
                    {
                        hak--;

                        Console.WriteLine("Yanlış  Bildiniz kalan hakınız:" + hak.ToString() + " Doğru Sayınız:" + Dogru.ToString()); ;
                    }
                    else
                    {
                        Console.WriteLine("1-25 arasında bir sayı yazın");
                    }
                    if (hak != 0)
                    {
                        sınır++;
                    }
                }
            }
            else if (Secenek.ToLower() == "zor")
            {
                hak = 2;
                Console.WriteLine(Secenek + " ile oyun başlıyor Yanlış Yapma Hakınız" + hak.ToString());
                for (int i = 0; i < sınır; i++)
                {

                    Console.WriteLine("1-50 arasında bir sayı yazın");
                    string cevap = Console.ReadLine();
                    int sayı = rasgele.Next(1, 50);
                    if (cevap == sayı.ToString())
                    {
                        Dogru++;
                        Console.WriteLine("Doğru Bildiniz Doğru Sayınız:" + Dogru.ToString());
                    }
                    else if (cevap != sayı.ToString())
                    {
                        hak--;

                        Console.WriteLine("Yanlış  Bildiniz kalan hakınız:" + hak.ToString() + " Doğru Sayınız:" + Dogru.ToString()); ;
                    }
                    else
                    {
                        Console.WriteLine("1-50 arasında bir sayı yazın");
                    }
                    if (hak != 0)
                    {
                        sınır++;
                    }
                }
            }
            else
            {

                Console.WriteLine("Seçenekler: Kolay, Orta, Zor olmalıdır");
            }
        }
    };
}