using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вашу фамилию:");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите желаемую оценку:");
            string b = Console.ReadLine();

            Console.WriteLine($"Поздравляю, {surname}! У вас автоматом {b} за экзамен");

        }
    }
}
