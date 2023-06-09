//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

using System;

class Program
{
    static void Main()
    {
        string answer;
        do
        {
            int[] array = GenerateRandomArray(4, -100, 100);
            PrintArray(array);

            int sumOddPositions = SumElementsAtOddPositions(array);
            Console.WriteLine("Сумма элементов на нечетных позициях: " + sumOddPositions);

            Console.WriteLine("Хотите выполнить программу снова? (yes/no)");
            answer = Console.ReadLine();
        } while (answer.ToLower() == "yes" || answer.ToLower() == "да");

        if (answer.ToLower() == "no" || answer.ToLower() == "нет")
        {
            Console.WriteLine("Программа завершена.");
        }

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
            Console.Write(array[i] + ", ");
        }
        Console.Write(array[array.Length - 1]);
        Console.WriteLine("]");
    }

    static int SumElementsAtOddPositions(int[] array)
    {
        int sum = 0;
        for (int i = 1; i < array.Length; i += 2)
        {
            sum += array[i];
        }
        return sum;
    }
}