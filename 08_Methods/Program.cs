using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Hande M");
            //    Console.WriteLine("M.Fatih A");
            //}
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);

            //}
            //Sum();

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}
            //WriteMethod("Hande");


            #endregion

            #region Geriye değer döndürmeyen parametreli metotlar
            //void WriteMethod(string CustomerName)
            //{
            //    Console.WriteLine(CustomerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: "+name+" "+surname);
            //}
            //CustomerCard("Ahmet", "Yıldırım");
            //CustomerCard("Ayşegül", "Kaya");

            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar
            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(3, 5, 9);

            #endregion

            #region Geriye değer döndüren metotlar
            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye değer döndüren string parametreli metotlar
            //string CountryCard(string Country, string Capital, string FlagColor)
            //{
            //    string cardInfo = "--> Ülke: " + Country + " --> Başkenti: " + Capital + " --> Bayrak rengi: " + FlagColor;
            //    return cardInfo;

            //}
            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x=Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y=Console.ReadLine();

            //Console.Write("Bayrak rengi giriniz: ");
            //z=Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));

            #endregion

            #region Geriye değer döndüren int parametreli metotlar
            //    int Sum(int num1, int  num2)
            //{
            //    int result =num1 + num2;
            //    return result;

            //}
            //Console.WriteLine(Sum(23,17));
            //Console.WriteLine(Sum(93,78));

            #endregion

            #region Örnek Uygulama

            //string ExamResult(string student, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student + " isimli Öğrenci sınavı geçti. || Ortalama: " + result;
            //    }
            //    else
            //    {
            //        return student + " isimli Öğrenci sınavı geçemedi. || Ortalama: " + result;
            //    }

             
            //}
            //Console.WriteLine(ExamResult("Ali", 25, 41, 80));
            //Console.WriteLine(ExamResult("Ayşe", 36, 88, 33));
            #endregion

            Console.Read();
        }
    }
}
