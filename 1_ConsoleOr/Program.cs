using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1_ConsoleOr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zywDJj
            //_1Veriables();
            //_2ReadKey(string[] args)
            //_3NegatifTek();
            //_4DörtIslem();
            //_5YuzdeHesaplama();
            //_6KarZarar();
            //_7SayıOkunusu(args);
            //_8QuestiomMarkOp();
            //_9İcİceSwitch(args);
            //_10For();
            //_11ForAsalSayılar();
            //_12ForTekToplam();
            //_13PozitifCarpan();
            //_14PerfectNumber();
            //_15UcgenCizimi();
            //_16OkCizimi();
            //_17KacBasamaklı();
            //_18SayıTahmin();
            //_19RastgeleSayı();
            //_20Banknot();
            //ReferansTipler();
            //ForNot();
            Console.Read();
        }

        private static void ForNot()
        {
            //Girilen 10 notun kaç tanesi 50 ve altıdır?
            Console.WriteLine("10 Not  Giriniz");
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                int note = int.Parse(Console.ReadLine());
                if (note <= 50)
                    count++;
            }
            Console.WriteLine(count);
        }

        private static void ReferansTipler()
        {
            //Değer(Veri) Tipler ve Referans Tipler
            /*
             Değer Tipleri = Bellekte Stack te tutulur

            Referans Tipler = Heap te tutulur.Ref veya out kelimesi ile dönüştürülür.
            Ref = başlangıç değeri verilmeli
            out = başlangıç değeri verilmemeli.
             */

            int a = 10, b = 10;
            Metot(a, b);
            Console.WriteLine($"a: {a} b:{b}");

            int c = 10, d;
            Metot2(ref c, out d);
            Console.WriteLine($"c: {c} d:{d}");
        }

        private static void Metot2(ref int a, out int b)
        {
            a = 5;
            b = 5;
        }

        private static void Metot(int a, int b)
        {
            a = 5;
            b = 5;
        }

        private static void _20Banknot()
        {
            //girilen paranın banknotlara ayırınız.
            //379
            //1 adet 200
            //1 adet 100
            // 1 adet 50
            // 1 adet 20
            //1 adet 5
            //4 adet 1 
            Console.Write("Para : ");
            int para = int.Parse(Console.ReadLine());
            int adet = 0;
            while (para > 0)
            {
                if (para >= 200)
                {
                    adet = Math.DivRem(para, 200, out para);
                    Console.WriteLine($"{adet} adet 200₺");
                }
                else if (para >= 100)
                {
                    adet = Math.DivRem(para, 100, out para);
                    Console.WriteLine($"{adet} adet 100TL");
                }
                else if (para >= 50)
                {
                    adet = Math.DivRem(para, 50, out para);
                    Console.WriteLine($"{adet} adet 50₺");
                }
                else if (para >= 20)
                {
                    adet = Math.DivRem(para, 20, out para);
                    Console.WriteLine($"{adet} adet 20₺");
                }
                else if (para >= 10)
                {
                    adet = Math.DivRem(para, 10, out para);
                    Console.WriteLine($"{adet} adet 10₺");
                }
                else if (para >= 5)
                {
                    adet = Math.DivRem(para, 5, out para);
                    Console.WriteLine($"{adet} adet 5₺");
                }
                else
                {
                    Console.WriteLine($"{para} adet 1₺");
                    para = 0;
                }

            }
        }

        private static void _19RastgeleSayı()
        {
            //girilen karakter kadar rastgele kelime üreten?
            //5
            //fduaş

            Console.WriteLine("adet : ");
            int adet = int.Parse(Console.ReadLine());
            string metin = "";
            Random random = new Random();
            for (int i = 0; i < adet; i++)
            {
                metin += (char)random.Next('a', 'z');
            }
            Console.WriteLine(metin);
            Console.Read();
        }

        private static void _18SayıTahmin()
        {
            //3 hak olacak 0-10 rastgele sayı tahmin edilecek
            Random random = new Random();
            int sayi = random.Next(10);
            int tahmin, hak = 3;
            do
            {
                hak--;
                Console.WriteLine("Tahmininiz : ");
                tahmin = int.Parse(Console.ReadLine());
                if (tahmin > sayi)
                    Console.WriteLine($"daha küçük sayı giriniz.\n{hak} hakkınınız kaldı");
                else if (tahmin < sayi)
                    Console.WriteLine($"daha büyük sayı giriniz.\n{hak} hakkınınız kaldı");
                else
                {
                    Console.WriteLine($"tebrikler.{3 - hak}. hakta bildiniz");
                    break;
                }

            } while (hak > 0);
            if (hak == 0)
                Console.WriteLine($"bilemediniz.Sayı {sayi} olacak.");
        }

        private static void _17KacBasamaklı()
        {
            //Girilen sayı kaç basamaklı bul?
            Console.Write("sayı : ");
            int sayi = int.Parse(Console.ReadLine());
            int count = 0;

            //while(sayi>0)
            //{
            //    sayi /= 10;
            //    count++;
            //}
            do
            {
                sayi /= 10;
                count++;
            } while (sayi > 0);
            Console.WriteLine(count);
        }

        private static void _16OkCizimi()
        {
            Console.WriteLine("kenar : ");
            int kenar = int.Parse(Console.ReadLine());
            int ort = kenar / 2;
            if (kenar % 2 == 1)
            {
                for (int i = 0; i < ort; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < ort + 1; i++)
                {
                    for (int j = ort + 1; j > i; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < ort; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (int i = 0; i < ort; i++)
                {
                    for (int j = ort; j > i; j--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void _15UcgenCizimi()
        {
            //Üçgen çizimi
            Console.WriteLine("kenar : ");
            int kenar = int.Parse(Console.ReadLine());
            for (int i = 1; i <= kenar; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void _14PerfectNumber()
        {
            //0-100 arasındaki mükemmel sayı bulma
            decimal sum = 0, count = 0;
            for (decimal i = 1; i < 10000; i++)
            {
                for (decimal j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum += j;
                }
                if (sum == i)
                {
                    Console.WriteLine(i);
                    count++;
                }

                sum = 0;
            }
            Console.WriteLine($"adet : {count}");
        }

        private static void _13PozitifCarpan()
        {
            //Girilen sayının pozitif çarpanlarını yaz?
            Console.WriteLine("sayi : ");
            int sayi = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayi; i++)
            {
                if (sayi % i == 0)
                    Console.WriteLine(i);
            }
        }

        private static void _12ForTekToplam()
        {
            //o-100 arasındaki teklerin toplamı ve adedi,çiftlerin toplamı ve adedi
            int tektoplam = 0, tekadet = 0, cifttoplam = 0, ciftadet = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftadet++;
                    cifttoplam += i;
                }
                else
                {
                    tekadet++;
                    tektoplam += i;
                }
            }
            Console.WriteLine($"Çiftlerin Toplamı = {cifttoplam} adet = {ciftadet}");
            Console.WriteLine($"Teklerin Toplamı = {tektoplam} adet = {tekadet}");
        }

        private static void _11ForAsalSayılar()
        {
            //girilen iki sayı arasındaki asal sayıları yaz?
            Console.WriteLine("sayı1 : ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("sayı2 : ");
            int number2 = int.Parse(Console.ReadLine());
            int count = 0;

            int min = Math.Min(number1, number2);
            if (min < 0)
                min = 0;

            int max = Math.Max(number1, number2);
            if (max < 0)
                max = 0;

            for (int i = min; i <= max; i++)
            {
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 0)
                {
                    if (i > 1)
                        Console.WriteLine(i);
                }


                count = 0;
            }
        }

        private static void _10For()
        {
            //Donguler
            /*
             for(i = 0;i<n;i++)
            while(koşul)
            d0-while
            do
            {
            }
            while(kosul)
             
             */
            //Girilen metni girilen sayı kadar ekrana yazdırınız.

            Console.WriteLine("Metin : ");
            string metin = Console.ReadLine();

            Console.WriteLine("adet : ");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(metin);
            }
        }

        private static void _9İcİceSwitch(string[] args)
        {
            /*
                         Menu
                        1-dikdörtgen
                        2-Ucgen
                        3-Dongu
                        4-Cıkıs

                        1-alan
                        2-çevre
                         */
            Console.WriteLine("Menu\n1-Dikdörtgen\n2-Ucgen\n3-Dongu\n4-Cıkıs");
            Console.WriteLine("Secim : ");
            byte choice = Convert.ToByte(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    //Console.WriteLine("1-Alan\n2-Cevre");
                    //Console.WriteLine("Secim : ");
                    //choice = Convert.ToByte(Console.ReadLine());
                    choice = Menu2();
                    Console.WriteLine("x : ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("y : ");
                    int y = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine($"Alan : {x * y}");
                            break;
                        case 2:
                            Console.WriteLine($"Çevre : {2 * (x + y)}");
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim");
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("1-Alan\n2-Cevre");
                    Console.Write("Secim : ");
                    choice = Convert.ToByte(Console.ReadLine());
                    //choice =  Menu2();
                    switch (choice)
                    {
                        case 1:
                            Console.Write("yükseklik : ");
                            int h = int.Parse(Console.ReadLine());
                            Console.Write("taban : ");
                            int a = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Alan : {h * a / 2}");
                            break;
                        case 2:
                            Console.Write("a : ");
                            a = int.Parse(Console.ReadLine());
                            Console.Write("b : ");
                            int b = int.Parse(Console.ReadLine());
                            Console.Write("c : ");
                            int c = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Çevre : {a + b + c}");
                            break;
                        default:
                            Console.WriteLine("Yanlış seçim");
                            break;
                    }
                    break;
                case 3:
                    Console.Clear();
                    Main(args);
                    break;
                case 4:
                    Environment.Exit(0);//return
                    break;
                default:
                    break;
            }
        }

        private static byte Menu2()
        {
            Console.WriteLine("Menu\n1-Alan\n2-Cevre");
            Console.WriteLine("Secim : ");
            byte choice = Convert.ToByte(Console.ReadLine());
            return choice;
        }

        private static void _8QuestiomMarkOp()
        {
            Console.Write("Sayı : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(number > 0 ? "pozitif" : "negatif");
        }

        private static void _7SayıOkunusu(string[] args)
        {
            /*
             max 4 basamaklı girilen sayının okunuşunu yazdırınız ?
            ör:315
            üçyüz on beş
             */

            Console.Write("Sayı : ");
            int sayi = int.Parse(Console.ReadLine());
            //int bolum = sayi / 1000;
            //sayi = sayi % 1000;

            if (sayi == 0)
            {
                Console.WriteLine("sıfır");
            }
            else
            {
                if (sayi < 0)
                {
                    Console.Write("eksi ");
                    sayi = -sayi;
                }

                int bolum = Math.DivRem(sayi, 1000, out sayi);
                switch (bolum)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write("bin");
                        break;
                    case 2:
                        Console.Write("ikibin");
                        break;
                    case 3:
                        Console.Write("üçbin");
                        break;
                    case 4:
                        Console.Write("dörtbin");
                        break;
                    case 5:
                        Console.Write("beşbin");
                        break;
                    case 6:
                        Console.Write("altıbin");
                        break;
                    case 7:
                        Console.Write("yedibin");
                        break;
                    case 8:
                        Console.Write("sekizbin");
                        break;
                    case 9:
                        Console.Write("dokuzbin");
                        break;
                    default:
                        Console.WriteLine("max 4 basamak giriniz");
                        Main(args);
                        break;
                }

                bolum = Math.DivRem(sayi, 100, out sayi);
                switch (bolum)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write("yüz");
                        break;
                    case 2:
                        Console.Write("ikiyüz");
                        break;
                    case 3:
                        Console.Write("üçyüz");
                        break;
                    case 4:
                        Console.Write("dörtyüz");
                        break;
                    case 5:
                        Console.Write("beşyüz");
                        break;
                    case 6:
                        Console.Write("altıyüz");
                        break;
                    case 7:
                        Console.Write("yediyüz");
                        break;
                    case 8:
                        Console.Write("sekizyüz");
                        break;
                    case 9:
                        Console.Write("dokuzyüz");
                        break;

                }
                bolum = Math.DivRem(sayi, 10, out sayi);
                switch (bolum)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write("on");
                        break;
                    case 2:
                        Console.Write("yirmi");
                        break;
                    case 3:
                        Console.Write("otuz");
                        break;
                    case 4:
                        Console.Write("kırk");
                        break;
                    case 5:
                        Console.Write("elli");
                        break;
                    case 6:
                        Console.Write("altmış");
                        break;
                    case 7:
                        Console.Write("yetmiş");
                        break;
                    case 8:
                        Console.Write("seksen");
                        break;
                    case 9:
                        Console.Write("doksan");
                        break;

                }

                switch (sayi)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write("bir");
                        break;
                    case 2:
                        Console.Write("iki");
                        break;
                    case 3:
                        Console.Write("üç");
                        break;
                    case 4:
                        Console.Write("dört");
                        break;
                    case 5:
                        Console.Write("beş");
                        break;
                    case 6:
                        Console.Write("altı");
                        break;
                    case 7:
                        Console.Write("yedi");
                        break;
                    case 8:
                        Console.Write("sekiz");
                        break;
                    case 9:
                        Console.Write("dokuz");
                        break;

                }
            }
        }

        private static void _6KarZarar()
        {
            /*
             malın alış fiyatı : 100
            satış : 150
            %50 kar edildi

            kar-zarar hesabı : (satış-alış)/alış*100
             */
            Console.Write("Alış : ");
            double buy = double.Parse(Console.ReadLine());
            Console.Write("Satış : ");
            double sales = double.Parse(Console.ReadLine());
            double result = (sales - buy) / buy * 100;
            if (result > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"%{result} kar edildi");
            }

            else if (result < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"%{-result} zarar edildi");
            }

            else
                Console.WriteLine("kar ve zarar edilmemiştir");
        }

        private static void _5YuzdeHesaplama()
        {
            /*
             Yüzde hesaplama
            x: {100}
            yüzde {40} : 40
             */
            Console.Write("x : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("yüzde : ");
            double yuzde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"sonuc = {x * yuzde / 100}");
        }

        private static void _4DörtIslem()
        {
            /*Kullanıcıdan iki sayı alın
                         * x = 5
                         * y=10
                         * T = x+y
                         * F = x-y
                         * C = x*y
                         * B = x/y
                        */

            Console.Write("x : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y : ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"T : {x + y}\nF : {x - y}\nC : {x * y}\nB : {x / y}");
        }

        private static void _3NegatifTek()
        {
            //Girilen sayınının çift mi tek mi negatif mi pozitif mi 
            //-5:negatif tek
            //10:pozitif çift

            Console.Write("Sayı : ");
            int number = int.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.Write("negatif ");
                if (number % 2 == 0)
                    Console.Write("çift sayıdır.");
                else
                    Console.Write("tek sayıdır.");
            }
            else if (number > 0)
            {
                Console.Write("pozitif ");
                if (number % 2 == 0)
                    Console.Write("çift sayıdır.");
                else
                    Console.Write("tek sayıdır.");
            }
            else
                Console.WriteLine("çifttir.");
        }

        private static void _2ReadKey(string[] args)
        {
            Console.WriteLine("Menu\n1-Toplama(f2)\n2-Çıkarma(f3)\n3-Dongu(Enter)\nÇıkıs(Esc)");
            Console.WriteLine("Bir tuşa basınız");
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.F2)
                Console.WriteLine("toplama yapıldı");
            else if (cki.Key == ConsoleKey.F3)
                Console.WriteLine("Çıkarma yapıldı");
            else if (cki.Key == ConsoleKey.Enter)
                Main(args);
            else if (cki.Key == ConsoleKey.Escape)
                return;

            Console.Read();
        }

        private static void _1Veriables()
        {
            //Ctrl + R + M : Method create 
            //tekli yorum satırı
            /*
             C# Veriables(Veri Tipleri)

            Integer Veriables
            -byte : 0-255 arası veri tutar.
            -sbyte : signal(işaret) byte -128 - 127
            short/Int16 : -32.600 - 32600
            ushort : unsignal(işaretsiz) 650000
            *int/Int32 : 
            uint
            long/Int64
            ulong


            Reel(Ondalıklı) Veriables
            float: f/F
            *double : d/D getirebilir.
            *decimal : m/M

            Metinsel veriables
            char : 'x'
            *string : "    "


            Boolean Veriable
            -*bool/Boolean

            Other Veriables
            -object
            -*var

            Datetime Veriable
            -Datetime

            Console Methods
            1-Write/WriteLine : Veri yazmak için
            2-Read/Readline/ReadKey : veri almak için 
            Read: Ascii kodunu tutar.
            Readline : veriyi string tutar.
            ReadKey : ConsoleKeyInfo - hangi tuşa basıldığını tutar.

            3-Clear :Console temizler
            4-BackgroundColor : arka plan rengi
            5-ForegroundColor : yazı rengi

             */
            //Write/Line Kullanım Çeşitleri
            string name = "ibrahim", surname = "kaya";
            //1.yöntem
            Console.WriteLine("Adı : " + name + " Soyadı : " + surname);

            //2.yöntem
            Console.WriteLine("Adı : {0} Soyadı : {1}", name, surname);

            //3.yöntem
            Console.WriteLine($"Adı : {name} Soyadı : {surname}");

            //int x = Console.Read();
            //ConsoleKeyInfo cki =  Console.ReadKey();
            string s = Console.ReadLine();

            /*Dönüştürme Metotları
            1-Convert.ToVeriable : ör:Convert.ToInt32
            2-Veriable.Parse : double.Parse()
            3-ToString() : stringe dönüştürür
            */
        }
    }
}
