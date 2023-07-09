// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числ

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = DigitSum(number);

        Console.WriteLine("Сумма цифр числа: " + sum);
    }

    static int DigitSum(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }
        return sum;
    }
}
