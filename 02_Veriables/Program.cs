using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DoubleDegiskenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.OutputEncoding = Encoding.UTF8; //₺ işareti için

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double appllePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //appllePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fİyatı:" + appllePrice + "₺");
            //Console.WriteLine("---- Portakal Birim Fİyatı:" + orangePrice + "₺");
            //Console.WriteLine("---- Çilek Birim Fİyatı:" + strawberryPrice + "₺");
            //Console.WriteLine("---- Patates Birim Fİyatı:" + potatoPrice + "₺");
            //Console.WriteLine("---- Domates Birim Fİyatı:" + tomatoPrice + "₺");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double applleTotalPrice = appllePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan ürün: Elma - " + "Birim Fİyat:" + appllePrice + "- Gramaj:" + appleGram + "- Toplam Tutar: " + applleTotalPrice);
            //Console.WriteLine("Alınan ürün: Portakal - " + "Birim Fİyat:" + orangePrice + "- Gramaj:" + orangeGram + "- Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan ürün: Çilek - " + "Birim Fİyat:" + strawberryPrice + "- Gramaj:" + strawberryGram + "- Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan ürün: Patates - " + "Birim Fİyat:" + potatoPrice + "- Gramaj:" + potatoGram + "- Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan ürün: Domates - " + "Birim Fİyat:" + tomatoPrice + "- Gramaj:" + tomatoGram + "- Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = applleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + "₺");


            #endregion

            #region CharDegiskenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region KlavyedenVeriGirisleri(String)

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;


            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("İl Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-------------------");
            //Console.WriteLine("Yolcu TC Kimlik no: " + passengerIdentityNumber+ " - Yolcu: " +passengerName+" "+passengerSurname+" "+passengerDistrict+" / "+passengerCity+" / "+passengerAge);


            #endregion

            #region KlavyedenTamSayıGirisleri-ve-Dönüsümler(int)

            //int shoesPrice, computerPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;

            //int shoesCount, computerCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice+computerCount*computerPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam tutar:" + totalPrice);

            #endregion

            #region KlavyedenOndalıklıSayıİslemleri(Double)

            //double exam1, exam2, result;

            //Console.Write("1.Sınav notu: ");
            //exam1= double.Parse(Console.ReadLine());


            //Console.Write("2.Sınav notu: ");
            //exam2 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2) / 2;

            //Console.WriteLine();
            //Console.WriteLine("Sınav ortalamanız: "+result);

            #endregion

            #region KlavyedenKarakterGirisleri(Char)

            //char gender;
            //Console.Write("Cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Seçtiğiniz cinsiyet: "+ gender);

            #endregion

            Console.Read();
        }
    }
}
