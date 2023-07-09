
//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

class Program
{
    static void Main()
    {
        int[] numbers = GenerateRandomArray(8);

        PrintArray(numbers);
    }

    static int[] GenerateRandomArray(int length)
    {
        int[] array = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            array[i] = random.Next(1, 100); // Генерируем случайное число от 1 до 100
        }

        return array;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]}, "  );
        }
    }
}