namespace Algotirma_soruları;

class Program
{
    static void Main(string[] args)
    /*Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.*/
    {
        Console.WriteLine("Lütfen Pozitif bir sayı girin:");
        int n;
        

        while (!int.TryParse(Console.ReadLine(), out n ) || n <= 0)
        {

            Console.WriteLine("Hatalı giriş.Lütfen pozitif bir sayı giriniz");
            Console.Write("Lütfen pozitif bir sayı girin.");
        }

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
           Console.Write($"Lütfen {i+1} :::sayıyı girin:");
           while(!int.TryParse(Console.ReadLine(), out numbers[i]) || numbers[i] <=0)
           {
           Console.WriteLine("Lütfen pozitif bir sayı giriniz !");
           Console.Write($"Lütfen {i+1} sayı giriniz");

           }
        
        }


        Console.WriteLine("Girilen çift sayılar");
        foreach (var num in numbers)
        {
            if ( num % 2 == 0)
            {
               Console.WriteLine(num);
            }
        }

/*Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.*/
       Console.WriteLine("Lütfen iki adet pozitif sayı giriniz:");
       Console.WriteLine("Lütfen 1.Sayıyı Giriniz.");
       int n1;
       while(!int.TryParse(Console.ReadLine(), out n1 ) || n1 <=0 )
       {
        Console.WriteLine("Pozitif bir sayı girmediniz,Lütfen pozitif bir sayı giriniz:");
        Console.Write("Lütfen pozitif bir sayı giriniz");
       }


       Console.WriteLine("Lütfen 2.sayıyı Giriniz:");
       int m;
       while(!int.TryParse(Console.ReadLine(),out m ) || m <=0 )
       {
       Console.WriteLine("Pozitif bir sayı girmediniz,Lütfen pozitif bir sayı giriniz:");
       Console.Write("Lütfen Pozitif bir sayı giriniz");
       }



       int[] numbers = new int[n1];

       for (int i = 0; i < n1; i++)
       {
        Console.WriteLine($"Lütfen {i+1}. sayıyı giriniz:");
        while(!int.TryParse(Console.ReadLine(), out numbers[i] ) || numbers[i] <=0 )
        {
        Console.WriteLine("Pozitif sayı girmediniz lütfen,pozitif sayı giriniz:");
        Console.Write($"Lütfen {i+1} adet pozitif sayı giriniz:");
        }

       }

       
     for (int i = 0; i < n1; i++)
     {
        if (numbers[i]  % m == 0)
      {
        Console.Write($"{numbers[i]} ");
      }
      
     }
     
/* Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.*/
     Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
     int n2;
     while(!int.TryParse(Console.ReadLine(),out n2) || n2 <=0 )
     {
      Console.WriteLine("Pozitif bir sayı girmediniz!");
      Console.WriteLine("Lütfen pozitif bir sayı giriniz:");
     }


     string?[] word = new string[n2];
    

     for (int i = 0; i < n2; i++)
     {
      Console.Write($"Lütfen {n2+0} kelime giriniz:");
      word[i] = Console.ReadLine();
     }
     
     Array.Reverse(word);
     Console.Write("Girmiş olduğunuz kelimeler:");

     for (int i = 0; i < n2; i++)
     {
      Console.WriteLine(word[i]+" ");
     }




/* Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın. */
     Console.WriteLine("Lütfen bir cümle giriniz:");
        string ?cumle = Console.ReadLine();

        // Harf sayısını hesapla
        int harfSayisi = cumle.Length;

        // Kelime sayısını hesapla
        string[] kelimeler = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int kelimeSayisi = kelimeler.Length;

        // Sonuçları ekrana yazdır
        Console.WriteLine($"Girilen cümlede {harfSayisi} harf ve {kelimeSayisi} kelime bulunmaktadır.");

 
   }


   




   
   }
