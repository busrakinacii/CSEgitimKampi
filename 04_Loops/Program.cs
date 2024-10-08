using System;
using System.Collections.Concurrent;
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
            #region For Döngüsü
            //******************************
            //int i;
            //for (i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}
            //*********************************
            //for (int i = 0;i<=20;i++)
            //{
            //    Console.WriteLine(i);
            //}
            //*******************************
            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}
            //********************************
            //Console.Write("Lütfen Bir Sayı Giriniz:");
            //int finishValue =Convert.ToInt32( Console.ReadLine());

            //for (int i =1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Orhun kitabeleri");
            //}
            //***************************************


            #endregion

            #region For Döngüsü ile Karar Yapıları
            //********************************************

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //**********************************************

            //int totalvalue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    totalvalue = totalvalue + i;
            //}
            //Console.WriteLine(totalvalue);

            //******************************************
            //1 - 20 arasındaki Çift Sayıların Toplamı
            //int totalValue = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("-------------------");
            //Console.WriteLine(totalValue);
            //*************************************
            //7 ye bölünen sayılar kaç tane 
            //int deger = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        deger++;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("------------------");
            //Console.WriteLine(deger);

            //*************************************
            //Her Saat Sonu 2 Katlanan Bakteri Sorusu

            //int bacterium = 1;
            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium = bacterium * 2;
            //    Console.WriteLine(i + ".Saat Sonunda " + bacterium + " bakteri oluştu. ");
            //}
            //*************************************



            #endregion

            #region While Döngüsü

            //While(Şart)
            //{
            //İşlemler
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}
            //******************************

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //********************************

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            //**************************************
            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden Girilen 3 Basamaklı sayının Basamakları Toplamını Hesaplayan kod
            //Console.Write("Lütfen 3 Basamaklı Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //hundreds = number / 100;
            //tens = (number % 100) / 10;

            //sum = ones + hundreds + tens;
            //Console.WriteLine("Sayının Basamak Değerlerinin Toplamı : " + sum);
            //***************************************************

            #endregion

            Console.Read();
        }
    }
}
