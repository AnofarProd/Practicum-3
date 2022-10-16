using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /// <summary>
            /// Задание 1 - Проверка числа на чётное либо нет.
            /// </summary>
            /// <param name="args"></param>

            Console.WriteLine("Задание 1 - Проверка числа на чётное либо нет\n");
            Console.WriteLine("Результат проверки выводится в формате: (Число N является чётным) или (Число N не является чётным)\n");
            Console.WriteLine("Введите целое число:\n");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"\nЧисло {number} является чётным.");
            }
            else
            {
                Console.WriteLine($"\nЧисло {number} не является чётным.");
            }
            Console.ReadKey();
            Console.Clear();

            /// <summary>
            /// Задание 2 - Реализация алгоритма подсчета карт в игре "21".
            /// </summary>
            /// <param name="args"></param>

            Console.WriteLine("Задание 2 - Игра в 21. \n");
            Console.WriteLine("Необходимо ввести количество карт в руке и их номинал.\n");
            Console.WriteLine("Введите количество карт в руке: \n");
            int quantityCards = int.Parse(Console.ReadLine());
            int valueCards = 0;
            int valueCard = 0;

            for (int i = 1; i <= quantityCards; i++)
            {
                Console.WriteLine($"\nВведите номинал карты номер {i}:");
                string value = Console.ReadLine();

                switch (value)
                {
                    case "2":
                        valueCard = 2; break;

                    case "3":
                        valueCard = 3; break;

                    case "4":
                        valueCard = 4; break;

                    case "5":
                        valueCard = 5; break;

                    case "6":
                        valueCard = 6; break;

                    case "7":
                        valueCard = 7; break;

                    case "8":
                        valueCard = 8; break;

                    case "9":
                        valueCard = 9; break;

                    case "10":
                        valueCard = 10; break;

                    case "J":
                        valueCard = 10; break;

                    case "Q":
                        valueCard = 10; break;

                    case "K":
                        valueCard = 10; break;

                    case "T":
                        valueCard = 10; break;
                }// Присвоение очков введенной карте

                valueCards += valueCard;// Суммирование полученного номинала карты в общий пул к количеству карт.

            }
            Console.Clear();
            Console.WriteLine($"\nСумма карт в вашей руке: {valueCards}");
            Console.ReadKey();
            Console.Clear();

            /// <summary>
            /// Задание 3 - Проверка простого числа.
            /// </summary>
            /// <param name="args"></param>

            Console.WriteLine("Задание 3 - Проверка простого числа.\n");
            Console.WriteLine("Введите число для проверки: ");
            number = int.Parse(Console.ReadLine());

            bool resultApp = true;
            int p = 2;
            while (p <= number - 1 )
            {
                if (number % p == 0)
                {
                    resultApp = false;
                    break;
                }
                p++;
            }
            if (resultApp)
            {
                Console.WriteLine($"Число {number} является простым числом");
            }
            else 
            {
                Console.WriteLine($"Число {number} не является простым числом");
            }

            /// <summary>
            /// Задание 4 - Наименьший элемент в последовательности.
            /// </summary>
            /// <param name="args"></param>

        }
    }
}

