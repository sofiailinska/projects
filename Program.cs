using System;
class program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);
        Console.WriteLine("Введіть ціле число x>1: ");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x > 1)
        {
            int sum = 0;
            while (x != 0)
            {
                sum += x % 10;
                x /= 10;
            }
            Console.WriteLine("Найменше натуральне число: " + sum);
        }
        else
        {
            Console.WriteLine("Помилка, число повинно бути x>1");
        }
        Console.ReadLine();
    }
}