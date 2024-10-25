using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //    Console.WriteLine("şifre doğru");
            //else
            //    Console.WriteLine("şifre yanlış");

            //string capital, country;
            //Console.Write("Başkenti giriniz:");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz:");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //    Console.WriteLine("doğru bilgi");
            //else
            //    Console.WriteLine("hatalı bilgi");

            //int sayi;
            //Console.Write("sayı giriniz:");
            //sayi = int.Parse(Console.ReadLine());
            //if (sayi == 5)
            //    Console.WriteLine("sayı doğru");
            //else
            //    Console.WriteLine("sayı yanlış");

            //int exam1, exam2, exam3, average;
            //string result="";
            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("sınavların ortalaması:" + average);

            //if (average > 0 & average <= 50)
            //    result = "Sonuç vasat";
            //if (average > 50 & average <= 70)
            //    result = "Sonuç orta";
            //if (average > 70 & average <= 84)
            //    result = "Sonuç iyi";
            //if (average > 84)
            //    result = "Sonuç çok iyi";
            //Console.WriteLine(result);

            //string city;
            //Console.Write("lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();
            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //    Console.WriteLine("şehir mevcut");
            //else
            //    Console.WriteLine("şehir mevcut değil");

            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //    Console.WriteLine("kullanıcı adı hatalı");
            //else
            //    Console.WriteLine("Hoş geldiniz");

            #endregion

            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("sayı girin: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //    Console.WriteLine("sayı çift");
            //else
            //    Console.WriteLine("sayı tek");
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Lütfen takım sembolünü girin: ");
            //team = char.Parse(Console.ReadLine());
            //if (team == 'g' | team == 'G')
            //    Console.WriteLine("galatasaray");
            //if (team == 'f' | team == 'F')
            //    Console.WriteLine("fenerbahçe");
            //if (team == 'b' | team == 'B')
            //    Console.WriteLine("beşiktaş");
            #endregion

            #region Örnek Uygulama 

            //Console.WriteLine("***** C# Eğitim Kampı Restoran *****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("-----------------------------------");

            //string menuItem;
            //Console.Write("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------Ana Yemekler------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Tavuk Çorbası");
            //    Console.WriteLine("------------Çorbalar------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margaritha");
            //    Console.WriteLine("2-Tavuklu Pizza");
            //    Console.WriteLine("3-Akdeniz Pizza");
            //    Console.WriteLine("------------Pizzalar------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Kola");
            //    Console.WriteLine("------------İçecekler------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("------------Tatlılar------------");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case

            //Console.Write("Lütfen ay giriniz: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.WriteLine("Ocak");break;
            //    case 2:Console.WriteLine("Şubat");break;
            //    case 3:Console.WriteLine("Mart");break;
            //    case 4:Console.WriteLine("Nisan");break;
            //    case 5:Console.WriteLine("Mayıs");break;
            //    case 6:Console.WriteLine("Haziran");break;
            //    case 7:Console.WriteLine("Temmuz");break;
            //    case 8:Console.WriteLine("Ağustos");break;
            //    case 9:Console.WriteLine("Eylül");break;
            //    case 10:Console.WriteLine("Ekim");break;
            //    case 11:Console.WriteLine("Kasım");break;
            //    case 12:Console.WriteLine("Aralık");break;
            //    default:Console.WriteLine("hatalı giriş");break;
            //}

            #endregion

            #region Hesap Makinesi

            int number1, number2, result;
            char symbol;
            Console.Write("birinci sayıyı giriniz: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("ikinci sayıyı giriniz: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("yapmak istediğiniz işlemi giriniz: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine("Toplam: " + result);
                    break;

                case '-':
                    result = number1 - number2;
                    Console.WriteLine("Fark: " + result);
                    break;

                case '*':
                    result = number1 * number2;
                    Console.WriteLine("Çarpım: " + result);
                    break;

                case '/':
                    result = number1 / number2;
                    Console.WriteLine("Bölüm: " + result);
                    break;
            }

            #endregion

            Console.Read();
        }
    }
}
