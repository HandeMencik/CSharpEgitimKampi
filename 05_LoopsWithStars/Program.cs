using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region alt alta 10 tane * oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine("*");
            //}


            #endregion

            #region yan yana 10 tane * oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("*");
            //}


            #endregion

            #region alt alta 10 tane ve her satırda 10 tane * oluşturma

            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.Write("**********");
            //}


            #endregion

            #region Dik üçgen 

            //for (int i = 0; i <= 5; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Ters dik üçgen 

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Dik ve Ters dik üçgen

            //for (int  i = 1;  i <= 5;  i++)
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }

            //}

            //for (int k = 4; k <= 1; k--)
            //{
            //    for (int m = 1; m < k; m++)
            //    {
            //        Console.Write("*");
            //    }

            //}


            #endregion

            #region baklava dilimi

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{

            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }


            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }


            //    Console.WriteLine();

            //}

            //for (int i = n - 1; i >= 1; i--)
            //{

            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }


            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit
            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{

            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }


            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }


            //    Console.WriteLine();

            //}
            #endregion

            #region Ters Piramit

            //int n = 5;
            //for (int i = n - 1; i >= 1; i--)
            //{

            //    for (int j = 1; j <= n - i; j++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= (2 * i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }


            //    Console.WriteLine();
            //}
            #endregion
            Console.Read();
        }
    }
}
