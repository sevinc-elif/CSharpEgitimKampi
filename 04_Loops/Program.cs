﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //int i;
            //for (i = 1; i < 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}


            //for (int i = 1; i < 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i < 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("merhaba");
            //}


            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //        Console.WriteLine(i);
            //}

            //int totalValue = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}
            //Console.WriteLine(totalValue);

            //int total = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //        total += i;
            //}
            //Console.WriteLine(total);

            //int count = 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //        count++;
            //}
            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". saat sonunda: " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba döngüler");
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 3 == 0)
            //        Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}
            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            Console.Write("3 basamaklı sayı giriniz: ");
            int number = int.Parse(Console.ReadLine());
            int ones, tens, hundreds;
            int sum = 0;

            ones = number % 10;
            hundreds = number / 100;
            tens = (number % 100) / 10;
            sum = ones + tens + hundreds ;
            Console.WriteLine(ones + "-" + tens + "-" + hundreds);
            Console.WriteLine("Toplam: " + sum);
            #endregion

            Console.Read();

        }
    }
}
