using System;

namespace Algorithm_Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1: Finding and printing even numbers from user input
            Console.WriteLine("Please enter a positive number:");
            int n;

            // Validating user input for a positive number
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            int[] numbers1 = new int[n];

            // Getting n positive numbers from the user
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter {i + 1}th number:");
                while (!int.TryParse(Console.ReadLine(), out numbers1[i]) || numbers1[i] <= 0)
                {
                    Console.WriteLine("Please enter a positive number!");
                    Console.Write($"Enter {i + 1}th number:");
                }
            }

            // Printing even numbers from the array
            Console.WriteLine("Even numbers entered:");
            foreach (var num in numbers1)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }

            // Question 2: Finding and printing numbers divisible by another number
            Console.WriteLine("Please enter two positive numbers:");
            Console.WriteLine("Enter the first number:");
            int n1;

            // Validating user input for the first positive number
            while (!int.TryParse(Console.ReadLine(), out n1) || n1 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            Console.WriteLine("Enter the second number:");
            int m;

            // Validating user input for the second positive number
            while (!int.TryParse(Console.ReadLine(), out m) || m <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            int[] numbers2 = new int[n1];

            // Getting n1 positive numbers from the user
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine($"Enter {i + 1}th number:");
                while (!int.TryParse(Console.ReadLine(), out numbers2[i]) || numbers2[i] <= 0)
                {
                    Console.WriteLine("Please enter a positive number!");
                    Console.WriteLine($"Enter {i + 1}th number:");
                }
            }

            // Printing numbers divisible by m from the array
            Console.WriteLine($"Numbers divisible by {m}:");
            for (int i = 0; i < n1; i++)
            {
                if (numbers2[i] % m == 0)
                {
                    Console.Write($"{numbers2[i]} ");
                }
            }

            // Question 3: Reversing and printing an array of words
            Console.WriteLine("Please enter a positive number:");
            int n2;

            // Validating user input for a positive number
            while (!int.TryParse(Console.ReadLine(), out n2) || n2 <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number:");
            }

            string?[] words = new string[n2];

            // Getting n2 words from the user
            for (int i = 0; i < n2; i++)
            {
                Console.Write($"Enter {i + 1}th word:");
                words[i] = Console.ReadLine();
            }

            // Reversing and printing the array of words
            Array.Reverse(words);
            Console.Write("Reversed words:");

            for (int i = 0; i < n2; i++)
            {
                Console.Write($"{words[i]} ");
            }

            // Question 4: Counting letters and words in a sentence
            Console.WriteLine("Please enter a sentence:");
            string? sentence = Console.ReadLine();

            // Counting letters and words in the sentence
            int letterCount = sentence.Length;
            string[] wordsInSentence = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int wordCount = wordsInSentence.Length;

            // Printing the result
            Console.WriteLine($"The sentence contains {letterCount} letters and {wordCount} words.");
        }
    }
}
