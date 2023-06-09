using System;

class Program
{
    static void Main()
    {
        string answer;
        do
        {
            int[] array = { 1, 2, 3, 4, 5 };
            PrintArray(array);

            int[] productArray = CalculatePairProducts(array);
            PrintArray(productArray);

            Console.WriteLine("Хотите выполнить программу снова? (yes/no)");
            answer = Console.ReadLine();
        } while (answer.ToLower() == "yes" || answer.ToLower() == "да");

        if (answer.ToLower() == "no" || answer.ToLower() == "нет")
        {
            Console.WriteLine("Программа завершена.");
        }

        Console.ReadLine();
    }

    static void PrintArray(int[] array)
    {
        Console.Write("[");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.Write(array[array.Length - 1]);
        Console.WriteLine("]");
    }

    static int[] CalculatePairProducts(int[] array)
    {
        int length = array.Length;
        int[] productArray = new int[length / 2];
        int lastIndex = length - 1;

        for (int i = 0; i < length / 2; i++)
        {
            productArray[i] = array[i] * array[lastIndex - i];
        }

        return productArray;
    }
}