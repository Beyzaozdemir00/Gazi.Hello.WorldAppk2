namespace Gazi.DizilerApp


{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi-Array
            //int number = 10;
            //int[] numbers= new int[3];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            //numbers[3] = 40;//IndexOutOfException

            //int[] numbers = {50,20,30};

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);

            //for (int i = 0; i <numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Array.Sort(numbers);
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //Console.WriteLine("How many names do you want to sort?");
            //byte sayi = byte.Parse(Console.ReadLine());
            //string[] names = new string[sayi];
            //for (int i = 0; i <names.Length; i++) 
            //{

            //    Console.Write($"Enter {i+1}. Name: "); 
            //    names[i] = Console.ReadLine();
            //}
            //Array.Sort(names);
            //for (int i = 0;i < names.Length;i++) { 
            //Console.WriteLine($"{i+1}-{names[i]}");
            //}

            //Console.WriteLine("How many numbers do you want to sort?");
            //int sayi = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter starting number:");
            //byte baslangic = byte.Parse(Console.ReadLine());
            //Console.WriteLine("Enter end number number:");
            //int bitis = int.Parse(Console.ReadLine());
            //Random rnd = new Random();
            //int[] sayilar = new int[sayi];
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    sayilar[i] = rnd.Next(baslangic, bitis);
            //}
            //Array.Sort(sayilar);
            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}
            //Generated random numbers must be unique




            //Console.WriteLine("how many numbers do you wants?");
            //int number = int.Parse(Console.ReadLine());
            //Random rnd = new Random();
            //int number1a = rnd.Next(0,7);
            //Console.WriteLine(number1a);



            Console.WriteLine("How many numbers do you want to sort?");
            int count = int.Parse(Console.ReadLine()); // count değişkenine ata verinin sayısı sayaç
            Console.WriteLine("Enter starting number:");
            int start = int.Parse(Console.ReadLine()); // start ata
            Console.WriteLine("Enter end number:");
            int end = int.Parse(Console.ReadLine());  // end değişkeni

            Random rnd = new Random(); // rastgele sayılar oluşturmak
            HashSet<int> numbers = new HashSet<int>(); //aynı sayıyı atamaya izin vermez benzersiz sayılar

            while (numbers.Count < count) //atanan sayıda benzersiz sayı kadar döngü
            {
                int randomNumber = rnd.Next(start, end);
                numbers.Add(randomNumber);  //sayı zaten varsa eklemez
            }

            int[] numberss = numbers.ToArray();
            Array.Sort(numberss);

            for (int i = 0; i < numberss.Length; i++)
            {
                Console.WriteLine(numberss[i]);
            }




        }
    }
}
// Numbers: referans -> Heap bölgesindeki değerlerin adresini tutan yapılardır
// Index: Dizi elemanlarına ulaşmak için kullanılan sayılar. Index'ler 0'dan başlar