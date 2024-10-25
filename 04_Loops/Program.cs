using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ForDöngüsü

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("FH");
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int FinishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < FinishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region ForDöngüsüİleKararYapıları

            //for (int i = 1; i<=100; i++)
            //{
            //    if (i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}
            //int TotalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        TotalValue += i;
            //        Console.WriteLine(i);

            //        //TotalValue++;

            //    }
            //}
            //Console.WriteLine("---> "+TotalValue);
            #endregion

            #region WhileDöngüsü

            //while(şart)
            //{
            //    işlemler
            //}                //islem sağlandığı müddetce anlamındadır

            //int i = 1;

            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <=10)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;
            //while (i >= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);



            #endregion

            #region ÖrnekSınavSorusu

            //Console.Write("3 Basamaklı bir sayı giriniz: ");
            //int Number = int.Parse(Console.ReadLine());

            //int ones, tens, hundred, sum;

            //hundred = Number / 100;
            //tens = (Number / 10) % 10;
            //ones = Number % 10;

            //sum = hundred + tens + ones;

            //Console.Write("Basamakların toplamı: "+sum);
          
            #endregion
            Console.Read();
        }
    }
}
