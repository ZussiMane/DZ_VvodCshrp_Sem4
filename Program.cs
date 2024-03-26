﻿// Задача 1: Напишите программу, которая бесконечно запрашивает 
// целые числа с консоли. Программа завершается при вводе символа ‘q’ 
// или при вводе числа, сумма цифр которого чётная.

class Program
{
    static void Main()
    {
        while (true) // Бесконечный цикл
        {
            Console.Write("Введите число или 'q' для выхода: ");
            string input = Console.ReadLine(); // Чтение строки ввода пользователя

            if (input == "q") // Проверка на ввод 'q' для выхода
            {
                break;
            }

            if (int.TryParse(input, out int number)) // Проверка, является ли ввод числом(преобзазование строки в число "number")
            {
                int sum = 0;
                while (number > 0) // Вычисление суммы цифр числа
                {
                    sum += number % 10; // Добавление последней цифры к сумме
                    number /= 10; // Удаление последней цифры из числа
                }

                if (sum % 2 == 0) // Проверка, является ли сумма цифр четной
                {
                    Console.WriteLine("Сумма цифр данного числа является четной!");
                    break;
                }
            }
            else // Если ввод не является числом и не 'q', повторить запрос
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q'.");
            }
        }
    }
}