using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //string[] cities = { "Milano", "Roma", "İstanbul" };

            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            #endregion

            #region ÖrnekSınavSistemiUygulaması


            //Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            //Console.WriteLine();

            //Console.WriteLine("------------------------------------------------");

            //Console.Write("Sınıfınızda kaç öğrenci var: ");
            //int StudentCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("------------------------------------------------");

            ////öğrenci isimleri ve not ortalamalarını saklayacak diziler
            //string[] StudentNames = new string[StudentCount];
            //double[] StudentExamAvg = new double[StudentCount];

            //for (int i = 0; i < StudentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz: ");
            //    StudentNames[i] = Console.ReadLine();

            //    //Her öğrenci için 3 sınav notu girisi 

            //    double TotalExamResult = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{StudentNames[i]} İsimli öğrencinin {j + 1}. Notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        TotalExamResult += value; //Notları topluyoruz
            //    }

            //    StudentExamAvg[i] = TotalExamResult / 3;

            //}
            //Console.WriteLine();

            ////sınav ortalamarını yazdırma
            //for (int i = 0; i < StudentCount; i++)
            //{
            //    Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
            //    Console.WriteLine();

            //    Console.WriteLine($"{StudentNames[i]} isimli öğrencinin ortalaması {StudentExamAvg[i]}");

            //    //öğrencilerin geçip kalma durumları

            //    if (StudentExamAvg[i]>=50)
            //    {
            //        Console.WriteLine($"{StudentNames[i]} isimli öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{StudentNames[i]} isimli öğrenci dersten kaldı.");
            //    }

            //    Console.WriteLine();
            //}




            #endregion

            Console.Read();
        }
    }
}
