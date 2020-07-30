using System;

namespace QuadraticCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор квадратнох уравнений ax^2 + bx + c = 0");

            //Получаем значение для a
            Console.WriteLine("Введите a:");
            double a;
            a = Convert.ToDouble(Console.ReadLine());

            //Получаем значение b
            Console.WriteLine("Введите b:");
            double b;
            b = Convert.ToDouble(Console.ReadLine());

            //Получаем значение с
            Console.WriteLine("Введите c:");
            double c;
            c = Convert.ToDouble(Console.ReadLine());

            //Объявляем дискриминант
            double d = (b * b) - (4 * a * c);
            Console.WriteLine("Дискриминант равен {0}", d);
            Console.ReadKey();


        }
    }
}
