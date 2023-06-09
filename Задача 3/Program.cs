//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


using System;

class Program
{
    static void Main()
    {
        string answer;
        do
        {
            double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 };
            PrintArray(array);

            double difference = FindDifference(array);
            Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);

            Console.WriteLine("Хотите выполнить программу снова? (yes/no)");
            answer = Console.ReadLine();
        } while (answer.ToLower() == "yes" || answer.ToLower() == "да");

        if (answer.ToLower() == "no" || answer.ToLower() == "нет")
        {
            Console.WriteLine("Программа завершена.");
        }

        Console.ReadLine();
    }

    static void PrintArray(double[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.Write(array[array.Length - 1]);
        Console.WriteLine("]");
    }

    static double FindDifference(double[] array)
    {
        double max = array[0];
        double min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }

            if (array[i] < min)
            {
                min = array[i];
            }
        }

        double difference = max - min;
        return difference;
    }
}