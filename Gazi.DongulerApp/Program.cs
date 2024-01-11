using System.ComponentModel.Design;

namespace Gazi.DongulerAppSube2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("İsminizi giriniz:");
            //string isim = Console.ReadLine();
            //Console.WriteLine("Kaç kere yazılsın?");
            //int tekrar = int.Parse(Console.ReadLine());

            //for (int i = 0; i < tekrar; i++)
            //{
            //    Console.WriteLine($"{i+1}.{isim}");
            //}

            //Console.WriteLine("Başlangıç değerini giriniz:");
            //int bas = int.Parse(Console.ReadLine());
            //Console.WriteLine("Bitiş değerini giriniz:");
            //int bit = int.Parse(Console.ReadLine());
            //Console.WriteLine("Tek/Çift?");
            //string cevap = Console.ReadLine().ToLower();


            ////bas:10 bit:5
            //if (bas > bit)
            //{
            //    int temp = bas;
            //    bas = bit;
            //    bit = temp;
            //}

            //int sonuc = 0;
            //for (int i = bas; i <= bit; i++)
            //{
            //    //if (i % 2 == 0 && cevap == "çift")
            //    //{
            //    //    Console.WriteLine(i);
            //    //    sonuc += i;
            //    //}
            //    //else if (i % 2 == 1 && cevap == "tek")
            //    //{
            //    //    Console.WriteLine(i);
            //    //    sonuc += i;
            //    //}

            //    if (i % 2 == (cevap == "tek" ? 1 : 0))
            //    {
            //        Console.WriteLine(i);
            //        sonuc += i;
            //    }
            //}
            //Console.WriteLine($"Sayıların Toplamı:{sonuc}");

            //7 8 9
            //int sonuc = 0;
            //sonuc = sonuc + 7;
            //sonuc = sonuc + 8;
            //sonuc = sonuc + 9;
            //Console.WriteLine(sonuc);


            //Taban değeri giriniz:2
            //Üs değeri giriniz:3
            //İşlemin sonucu:8


            //Console.WriteLine("Taban değeri giriniz:");
            //int taban=int.Parse(Console.ReadLine());
            //Console.WriteLine("Üs değeri giriniz:");
            //int us=int.Parse(Console.ReadLine());

            //int sonuc = 1;
            //for (int i = 0; i < us; i++)
            //{
            //    sonuc = sonuc * taban;
            //}
            //Console.WriteLine(sonuc);

            //Bir sayı giriniz:5
            //Girilen sayının faktoriyeli:120

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());
            //int sonuc = 1;
            //for (int i = 2; i <= sayi; i++)
            //{
            //    sonuc *= i;
            //}
            //Console.WriteLine(sonuc);

            //Bir sayı giriniz:11
            //Girdiğiniz sayı asal

            // 2 3 4 5

            //Console.WriteLine("Bir sayı giriniz:");
            //int sayi = int.Parse(Console.ReadLine());


            //if (sayi > 2 && sayi % 2 == 0)
            //{
            //    Console.WriteLine("Asal değil");
            //}
            //else if(sayi<2)
            //{
            //    Console.WriteLine("En küçük asal sayı 2'dir.");
            //}
            //else
            //{
            //    int sayac = 0;
            //    for (int i = 2; i <= (sayi / 2); i++)
            //    {
            //        if (sayi % i == 0)
            //        {
            //            sayac++;
            //            break;
            //        }
            //    }
            //    Console.WriteLine(sayac == 0 ? "Asal" : "Asal Değildir");
            //}

            //for (; ; )
            //{
            //    Console.WriteLine("Kullanıcı adı giriniz");
            //    string user = Console.ReadLine();
            //    Console.WriteLine("Şifre giriniz:");
            //    string pass = Console.ReadLine();
            //    if (user == "admin" && pass == "123")
            //    {
            //        Console.WriteLine("Giriş başarılı!");
            //        break;
            //    }
            //}

            //Bir sayı giriniz:5
            //Devam etmek istiyor musunuz?E
            //Bir sayı giriniz:8
            //Devam etmek istiyor musunuz?E
            //Bir sayı giriniz:3
            //Devam etmek istiyor musunuz?H
            //Girdiğiniz en büyük sayı:8

            //int max = int.MinValue;
            //double toplam = 0;
            //double sayac = 0;
            //for (; ; )
            //{
            //    Console.Write("Bir sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    sayac++;
            //    toplam += sayi;
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }
            //    Console.WriteLine("Devam etmek istiyor musunuz?");
            //    string cvp = Console.ReadLine();
            //    if (cvp == "h")
            //    {
            //        break;
            //    }
            //    else if (cvp == "e")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı giriş yaptınız!");
            //    }




            //}
            //Console.WriteLine($"Girilen en büyük sayı:{max}\nSayıların Toplamı:{toplam}" +
            //    $"\nsayıların aritmetik ortalaması :{toplam/sayac}");


            //for (int i = 0; i<3; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{i}, {j}\t");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            ////}
            ///sayı isteyip boşluklu yıldız tablosu 
            //Console.WriteLine("Enter row count");//satır girişi yapınız
            //int row = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter column count");//sütun girişi yapınız
            //int column = int.Parse(Console.ReadLine()); 
            //for (int i = 0; i < row; i++)
            //{

            //    for (int j = 0; j <column; j++)
            //    {
            //        Console.Write((i + j) % 2 == 0 ? "*" : "   ");
            //    }
            //    Console.WriteLine();


            //}
            //abcd=4dcba
            //abcd?

            //bool control = false;

            //for (int a = 1; a < 10; a++)
            //{
            //    for(int b = 0; b < 10; b++)
            //    {
            //        for(int c = 0; c < 10; c++)
            //        {
            //            for(int d = 0; d < 10; d++)
            //            {
            //                if (1000 * a + 100 * b + 10 * c + d == 4 * (1000 * d + 100 * c + 10 * b + a))
            //                {
            //                    Console.WriteLine($"{a}{b}{c}{d}");
            //                    control = true;
            //                    break;
            //                }
            //                if (control == true)
            //                {
            //                    break;
            //                }
            //                if(control )
            //                {
            //                    break;  
            //                }
            //                if(control )
            //                {
            //                    break;
            //                }
            //                if (control)
            //                {
            //                    break; 
            //                }

            //            }
            //        }
            //    }
            //}

            //for(int i = 0; i<50; i++)
            //{
            //    for (int j = 0; j<50; j++)
            //    {
            //        for (int k = 0; k < 50; k++)
            //        {
            //            if(i*i+j*j==k*k)
            //                Console.WriteLine($"{i}-{j}-{k}");

            //        }
            //    }

            //}

            //Console.WriteLine("Enter starting number");
            //int start = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter end number");
            //int end = int.Parse(Console.ReadLine());
            //for (int i = start; i < end; i++)
            //{
            //    int count = 0;
            //    for (int j = 2; j <= (i / 2); j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //            break;
            //        }
            //    }

            //int count = 0;
            //while (true)
            //{
            //    Console.WriteLine("gazi");
            //        count++;



            //int max = int.MinValue;
            //double toplam = 0;
            //double sayac = 0;
            //while (true )
            //{
            //    Console.Write("Bir sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    sayac++;
            //    toplam += sayi;
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }
            //    Console.WriteLine("Devam etmek istiyor musunuz?");
            //    string cvp = Console.ReadLine();
            //    if (cvp == "h")
            //    {
            //        break;
            //    }
            //    else if (cvp == "e")
            //    {
            //        continue;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Hatalı giriş yaptınız!");
            //    }




            //}
            //Console.WriteLine($"Girilen en büyük sayı:{max}\nSayıların Toplamı:{toplam}" +
            //    $"\nsayıların aritmetik ortalaması :{toplam/sayac}");


            //int max = int.MinValue;
            //double toplam = 0;
            //double sayac = 0;
            //string cevap;
            //do
            //{
            //    Console.WriteLine("Bir sayı giriniz:");
            //    int sayi = int.Parse(Console.ReadLine());
            //    toplam += 0;
            //    sayac++;
            //    if (sayi > max)
            //    {
            //        max = sayi;
            //    }


            //    Console.WriteLine("Devam etmek istiyormusunuz:E/H ");
            //     cevap = Console.ReadLine();

            //} while (cevap=="e");
            //Console.WriteLine($"Girilen en büyük sayı:{max}\n Sayıların toplamı: {toplam}\n Sayıların aritmetik ortalaması:{toplam / sayac}");




            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Random rnd = new Random();
            //        int number = rnd.Next(33, 127);
            //        Console.Write((char)number);
            //    }
            //    Console.WriteLine();
            //}



            //int max = int.MaxValue;
            //double sayac = 0;
            //string cevap; burası yok
            //Random rnd = new Random();
            //int number = rnd.Next(1,3);
            //while (true) 
            //{ 

            //    Console.WriteLine("guess the number");  
            //    int tahmin=int.Parse(Console.ReadLine());
            //    if (tahmin == number)
            //    {
            //        Console.WriteLine("you won");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("try again");
            //    }
            //}





            //for (int i = 1; i <=3; i++)
            //{
            //    Console.WriteLine("BİR SAYI GİRİNİZ");
            //    int sayi=int.Parse(Console.ReadLine());
            //    sayac = ++;
            //    if (sayi>max)
            //    {
            //        max = sayi;      
            //    }
            //    if(sayi==number) 
            //    { 
            //        Console.WriteLine();
            //    }

            //}






            //ASCİİ

        }
    }
 }  