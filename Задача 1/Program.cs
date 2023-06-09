using System;

class Program
{
    static void Main()
    {
        string answer;
        do
        {
            int[] array = GenerateRandomArray(4, 100, 999);
            PrintArray(array);

            int countEven = CountEvenNumbers(array);
            Console.WriteLine("Количество четных чисел: " + countEven);

            Console.WriteLine("Хотите продолжить?");
            answer = Console.ReadLine();
        } while (answer == "yes" || answer == "да");

        Console.ReadLine();
    }

    static int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] array = new int[length];
        Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(minValue, maxValue + 1);
        }
        return array;
    }

    static void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"{array[i]}, ");
        }
        Console.Write($"{array[array.Length - 1]}");
        Console.WriteLine("]");
    }

    static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }
}