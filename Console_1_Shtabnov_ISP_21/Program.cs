using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program_1
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Введите свое имя ");
                string name = Console.ReadLine();
                System.Console.WriteLine($"Привет { name}");

            }
        }
    }
}
class Program_2
{
    static void Main(string[] args)
    {
        Console.Write("Введите свое имя ");
        string name = Console.ReadLine();
        System.Console.WriteLine($"Привет { name}");

        Console.Write("Введите свою фамилию");
        string family = Console.ReadLine();
        System.Console.WriteLine($"Привет { family}");

        Console.Write("Введите свой пол");
        string age = Console.ReadLine();
        System.Console.WriteLine($"Привет { age}");

        Console.Write("Введите свое увлечение");
        string hobby = Console.ReadLine();

        System.Console.WriteLine($"Привет { family + " " + name}");
    }

}
class Program_3
{
    static void Main(string[] args)
    {
        double res5 = Math.Abs(-0.5);
        Console.WriteLine("|-0.5| = " + res5);
        Console.ReadKey();
    }
}

class Program_4
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.ReadKey();
    }
}
class Program_5
{
    static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
        Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy"));
        Console.ReadKey();
    }
}
программа для сложения двух чисел
class Program_6
{
    static void Main(string[] args)
    {
        Console.WriteLine("###Программа для сложения двух чисел###");
        Console.WriteLine("Введите первое число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        int summ = a + b;
        Console.WriteLine($"Сумма двух чисел:{summ}");
        Console.ReadKey();
    }
}