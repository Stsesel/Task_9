using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                Console.WriteLine("Это мой микрокалькулятор");

                try
                {
                    Console.WriteLine("Введите первое число");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Необходимо ввести число");
                    Console.ReadLine();
                    continue;
                }



                Console.WriteLine("Выберите операцию: '+', '-', '*', '/'");
                action = Console.ReadLine();

                switch (action)
                {

                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;

                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;

                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;

                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            Console.WriteLine(firstValue / secondValue);
                        }
                        
                        break;

                    default:
                        Console.WriteLine("Ошибка! Неизвестное действие");
                        break;
                }

                Console.ReadLine();
            }

        }
    }
}
