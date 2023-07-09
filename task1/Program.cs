//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число A:");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите степень B:");
        int B = Convert.ToInt32(Console.ReadLine());

        int result = RaiseToPower(A, B);

        Console.WriteLine("Результат: " + result);
    }

    static int RaiseToPower(int baseNumber, int exponent)
    {
        int result = 1;
        for (int i = 1; i <= exponent; i++)
        {
            result *= baseNumber;
        }
        return result;
    }
}