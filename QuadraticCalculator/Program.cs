using System;

namespace QuadraticCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор квадратных уравнений ax^2 + bx + c = 0"); 
            double a = Item("a");
            double b = Item("b");
            double c = Item("c");
            double d = Descriminant(a, b, c);
            string answer = CheckDescriminant(d, a, b);
            Console.WriteLine(answer);
            Console.ReadKey();
        }

        public static double Item(string acb)
        {
            switch (acb) {
                case "a":
                    Console.WriteLine("Введите a:");
                    double a;
                    a = Convert.ToDouble(Console.ReadLine().Replace('.',','));
                    return a;

                case "b": 
                    Console.WriteLine("Введите b:");
                    double b;
                    b = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                    return b;

                case "c":
                    Console.WriteLine("Введите c:");
                    double c;
                    c = Convert.ToDouble(Console.ReadLine().Replace('.', ','));
                    return c;

                default: return 0;
            }
        }

        public static double Descriminant(double a, double b, double c)
        {
            double d = Math.Round(((b * b) - (4 * a * c)), 2);
            return d;
        }

        public static double DescriminantEqualsZero(double a, double b) 
        {
            double x = Math.Round((-b / (2 * a)), 2);
            return x;
        }

        public static double DescriminantLargeZeroOneRoot(double a, double b, double d)
        {
            double x1 = Math.Round(((-b - Math.Sqrt(d)) / (2 * a)), 2);
            return x1;
        }

        public static double DescriminantLargeZeroTwoRoot(double a, double b, double d)
        {
            double x2 = Math.Round(((-b + Math.Sqrt(d)) / (2 * a)), 2);
            return x2;
        }

        public static string CheckDescriminant(double checkD, double a, double b)
        {
            if (checkD < 0.00)
            {
                string equationSolutionSmallerZero = "Дискриминант меньше нуля. Корней нет.";
                return equationSolutionSmallerZero;
            }
            else if (checkD == 0.00)
            {
                double x = DescriminantEqualsZero(a, b);
                string equationSolutionEqualsZero = String.Format("Дискриминант равен нулю. Корень равен {0}", x);
                return equationSolutionEqualsZero;
            }
            else if (checkD > 0.00)
            {
                double x1 = DescriminantLargeZeroOneRoot(a, b, checkD);
                double x2 = DescriminantLargeZeroTwoRoot(a, b, checkD);
                string equationSolutionLargeZero = String.Format("Дискриминант равен {0}. Первый корень равен {1}. Второй корень равен {2}", checkD, x1, x2);
                return equationSolutionLargeZero;
            }
            else { return "Ошибка"; }  
        }
    }
}
