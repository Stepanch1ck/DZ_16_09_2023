using System;

namespace Tumalov_lab2
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Тумаков Лабораторная работа 2 Упражнение 2.1: приветствие по имени");
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте,{name}!");
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadKey();
            Console.WriteLine("Тумаков Лабораторная работа 2 Упражнение 2.2: деление двух чисел");
            Console.WriteLine("Введите первое число:");
            double chislo1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double chislo2 = Convert.ToDouble(Console.ReadLine());
            if (chislo2 == 0)
            {
                Console.WriteLine("Деление на ноль невозможно");
            }
            else
            {
                Console.WriteLine("Результат деления:" + chislo1 / chislo2);
            }
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadKey();
            Console.WriteLine("Тумаков Лабораторная работа 2 домашняя работа 2.1: следующая буква алфавита");
            Console.WriteLine("Введите букву:");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'z' || letter == 'я' || letter == 'Z' || letter == 'Я')
            {
                Console.WriteLine("Это последняя буква алфавита");
            }
            else
            {
                Console.WriteLine("Следующая буква алфавита:" + (char)(letter + 1));
            }
            Console.WriteLine("Нажмите Enter для продолжения");
            Console.ReadKey();
            Console.WriteLine("Тумаков Лабораторная работа 2 домашняя работа 2.2: нахождение корней квадратного уравнения");
            Console.WriteLine("Введите коэффициент a, b, c квадратного уравнения через пробел");
            string input = Console.ReadLine();
            string[] coef = input.Split(' ');
            double a = double.Parse(coef[0]);
            double b = double.Parse(coef[1]);
            double c = double.Parse(coef[2]);
            Console.WriteLine("{0}x*x+{1}x+{2}=0", a, b, c);
            double D = b * b - 4 * a * c;
            if (D > 0)
            {
                Console.WriteLine("x1=" + (-b + Math.Sqrt(D) / 2 * a));
                Console.WriteLine("x2=" + (-b - Math.Sqrt(D) / 2 * a));
            }
            else if (D == 0)
            {
                Console.WriteLine("x=" + -b / 2 * a);
            }
            else
            {
                Console.WriteLine("Нет действительных корней");
            }
            Console.WriteLine("Нажмите enter");
            Console.ReadKey();

        }
    }
}
