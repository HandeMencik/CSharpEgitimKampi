using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region TemelDiziÖrnekleri

            //string[] cities = new string[2];

            //cities[0] = "Antalya";
            //cities[1] = "İstanbul";

            //Console.WriteLine(cities[0]);


            //int[] Number = new int[2];

            //Number[0] = 07;
            //Number[1] = 34;

            //Console.WriteLine(Number[1]);

            //string[] cities = { "Antalya", "İstanbul" };
            //Console.WriteLine(cities[1]);

            #endregion


            #region DizidekiTümElemanlarıListeleme

            //string[] colors = { "Siyah", "Mavi", "Kahverengi", "Pembe" };

            //for (int i = 0; i <colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}


            //int[] number = { 5, 78, 67, 82, 657 };

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i]%2==0)
            //    {
            //        Console.WriteLine(number[i]);

            //    }
            //}

            //char[] chars = { 'a', 'b', 'c', '-', '*' };
            //for (int i = 0; i < chars.Length; i++)
            //{
            //    Console.WriteLine(chars[i]);

            //}

            //int[] myArray = { 47, 25, 36, 41, 53, 67, 79, 84, 95 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i]>maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "Ali", "Ayşe", "Ahmet" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 34, 67, 23, 89 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 34, 67, 23, 89 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları
            //string[] customers = { "Ali", "Beyza", "Ayşegül" };
            //int index = Array.IndexOf(customers, "Beyza");
            //Console.WriteLine(index);

            //int[] numbers = { 56, 18, 72, 91 };
            //Console.WriteLine("--> Dizinin en büyük elemanı: "+numbers.Max() + "   --> Dizinin en küçük elemanını getir: " + numbers.Min());


            #endregion

            #region Kullanıcıdan değer alma

            //string[] cities = new string[3];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehri giriniz: ");
            //    cities[i]=Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //Console.WriteLine("Tek sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("Çift sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion
            Console.Read();
        }
    }
}
