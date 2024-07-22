using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Расчет_площади_фигур
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Добро пожаловать в коалиционный калькулятор228 ежжи эщкеря!");
                Console.WriteLine("Расчёт для разных фигур на выбор:");
                Console.WriteLine("1. Круг\n2. Квадрат\n3. Треугольник");
                Console.Write("Выберите фигуру: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Console.Write("Введите радиус: ");
                            double R = int.Parse(Console.ReadLine());
                            double S = Math.PI * Math.Pow(2, R);
                            Console.WriteLine("Площадь круга равна: " + S);
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Введите длину стороны квадрата: ");
                            double a = double.Parse(Console.ReadLine()); 
                            double S = a * a; 
                            Console.WriteLine("Площадь квадрата: " + S);
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Введите длину стороны: ");
                            double a = double.Parse(Console.ReadLine());
                            Console.Write("Введите длину высоты: ");
                            double h = double.Parse(Console.ReadLine());
                            double S = a * h / 2;
                            Console.WriteLine($"Площадь треугольника: {S}");
                            break;
                        }
                    default:
                        Console.WriteLine("Неизвестный выбор");
                        break;
                }
                Console.Write("Еще раз Y/N: ");
                string ans = Console.ReadLine();
                if ((ans == "N") || (ans == "n")) { break; }
            }
        }
    }
}
