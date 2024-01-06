using System;

namespace Algorithm_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            Console.WriteLine("Please enter a positive number:");
            int n;

            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            int[] numbers1 = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter {i + 1}th number:");
                while (!int.TryParse(Console.ReadLine(), out numbers1[i]) || numbers1[i] <= 0)
                {
                    Console.WriteLine("Please enter a positive number!");
                    Console.Write($"Enter {i + 1}th number:");
                }
            }

            Console.WriteLine("Even numbers entered:");
            foreach (var num in numbers1)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }

            // Question 2
            Console.WriteLine("Please enter two positive numbers:");
            Console.WriteLine("Enter the first number:");
            int n1;

            while (!int.TryParse(Console.ReadLine(), out n1) || n1 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            Console.WriteLine("Enter the second number:");
            int m;

            while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            int[] numbers2 = new int[n1];

            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine($"Enter {i + 1}th number:");
                while (!int.TryParse(Console.ReadLine(), out numbers2[i]) || numbers2[i] <= 0)
                {
                    Console.WriteLine("Please enter a positive number!");
                    Console.WriteLine($"Enter {i + 1}th number:");
                }
            }

            Console.WriteLine($"Numbers divisible by {m}:");
            for (int i = 0; i < n1; i++)
            {
                if (numbers2[i] % m == 0)
                {
                    Console.Write($"{numbers2[i]} ");
                }
            }

            // Question 3
            Console.WriteLine("Please enter a positive number:");
            int n2;

            while (!int.TryParse(Console.ReadLine(), out n2) || n2 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            string?[] words = new string[n2];

            for (int i = 0; i < n2; i++)
            {
                Console.Write($"Enter {i + 1}th word:");
                words[i] = Console.ReadLine();
            }

            Array.Reverse(words);
            Console.Write("Reversed words:");

            for (int i = 0; i < n2; i++)
            {
                Console.Write($"{words[i]} ");
            }

            // Question 4
            Console.WriteLine("Please enter a sentence:");
            string? sentence = Console.ReadLine();

            int letterCount = sentence.Length;
            string[] wordsInSentence = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int wordCount = wordsInSentence.Length;

            Console.WriteLine($"The sentence contains {letterCount} letters and {wordCount} words.");
        }
    }
}
