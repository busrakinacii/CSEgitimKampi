using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region if Else
            //***********************************Örnek1
            //Console.Write("Lütfen Şifreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifreniz DOĞRU:)");
            //}
            //else
            //{
            //    Console.WriteLine("Şifreniz YANLIŞ:(");
            //}
            //***********************************Örnek2

            //string capital, country;
            //Console.Write("Başkenti Giriniz:");
            //capital=Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz:");
            //country=Console.ReadLine();

            //if(capital=="ankara" & country=="türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Bilgi :(");
            //}
            //***********************************Örnek3

            //int number;
            //Console.Write("Sayıyı Giriniz:");
            //number = int.Parse(Console.ReadLine());
            //if (number == 0)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else { Console.WriteLine("Sayı Yanlış"); }

            //***********************************Örnek4

            //int exam1, exam2, exam3, average;
            //string result = "HATA!";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuç Çok iyi";
            //}
            //Console.WriteLine(result);

            //***********************************Örnek5

            //string city;
            //Console.WriteLine("Şehir Giriniz:");
            //city = Console.ReadLine();

            //if(city=="ankara"| city=="adana" | city=="bursa"| city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut :)");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil. :(");
            //}
            //***********************************Örnek6

            //Console.WriteLine("Lütfen Kullanıcı Adını Giriniz:");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Bu Kullanıcı Adı Hatalıdır.!");
            //}
            //else { Console.WriteLine("Hoş Geldiniz :)"); }
            #endregion

            #region Mod İşlemleri
            //********************************Örnek1

            //int number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //********************************Örnek2

            //Console.Write("Lütfen 1.Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1.Sayının 2.Sayıya Bölümünden Kalan: " + result);


            //********************************Örnek3

            //Console.Write("Lütfen Sayı Giriniz:");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı Çifttir.");
            //}
            //else { Console.WriteLine("Sayı Tektir."); }
            #endregion

            #region Char Değişkenler ile Karar Yapıları
            //char team;
            //Console.Write("Bir Takım Sembolü Seçiniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("GalataSaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("FenerBahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("BeşikTaş");
            //}
            //else
            //{
            //    Console.WriteLine(team + " - Dikkat Yanlış Karakter Girdiniz.");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğirim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();

            //string menuItem;
            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi:");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ANA YEMEKLER-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Faulye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------ANA YEMEKLER-----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ÇORBALAR-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-EzoGelin Çorba");
            //    Console.WriteLine("------------ÇORBALAR-----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------PİZZALAR-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz");
            //    Console.WriteLine("2-Margaritha");
            //    Console.WriteLine("2-Tavuklu Pizza");
            //    Console.WriteLine("------------PİZZALAR-----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İÇECEKLER-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("------------İÇECEKLER-----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------TATLILAR-----------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Triliçe");
            //    Console.WriteLine("2-KazanDibi");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("------------TATLILAR-----------");
            //    Console.WriteLine();
            //}
            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("OCAK"); break;
            //        case 2: Console.WriteLine("ŞUBAT");break;
            //        case 3: Console.WriteLine("MART");break;
            //        case 4: Console.WriteLine("NİSAN");break;
            //        case 5: Console.WriteLine("MAYIS");break;
            //        case 6: Console.WriteLine("HAZİRAN");break;
            //        case 7: Console.WriteLine("TEMMUZ");break;
            //        case 8: Console.WriteLine("AĞUSTOS");break;
            //        case 9: Console.WriteLine("EYLÜL");break;
            //        case 10: Console.WriteLine("EKİM");break;
            //        case 11: Console.WriteLine("KASIM");break;
            //        case 12: Console.WriteLine("ARALIK");break;
            //    default:
            //        Console.WriteLine("Hatalı Veri Girişi");break;




            #endregion

            #region Switch Case Hesap Makinesı Uygulaması

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı Giriniz:");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sayıyı Giriniz:");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Yapmak istediğiniz İşlemi Giriniz:");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{

            //    case '+':
            //        result = number1 + number2; 
            //        Console.WriteLine("Toplama İşlemi Sonucu: "+ result); break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Çıkartma İşlemi Sonucu: " + result); ; break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölme İşlemi Sonucu: " + result); break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpma İşlemi Sonucu: " + result); break;
            //    default:
            //        Console.WriteLine("HATA!!!"); break;


            //}

            #endregion

            Console.Read();
        }
    }
}
