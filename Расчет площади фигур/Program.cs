﻿using System;
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
                Console.WriteLine("Выберите фигуру:");
                Console.WriteLine("1. Круг");
                Console.WriteLine("2. Квадрат");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            Console.WriteLine("Введите радиус");
                            double R = int.Parse(Console.ReadLine());
                            double S = Math.PI * Math.Pow(2, R);
                            Console.WriteLine("Площадь круга равна: " + S);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите длину стороны квадрата: ");
                            double a= Convert.ToDouble(Console.ReadLine()); 
                            double S = a * a; 
                            Console.WriteLine("Площадь квадрата: " + S);
                            break;
                        }
                    default:
                        Console.WriteLine("Неизвестный выбор");
                        break;
                }
                Console.WriteLine("Еще раз Y/N");
                string ans = Console.ReadLine();
                if ((ans == "N") || (ans == "n")) { break; }
            }
        }
    }
}
