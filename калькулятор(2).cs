﻿using System;

class Calculator
{
    static void Main(string[] args)
    {
        bool continueCalculating = true;

        while (continueCalculating)
        {
            Console.WriteLine("Введите первое число:");
            bool isFirstNumberValid = double.TryParse(Console.ReadLine(), out double number1);
            if (!isFirstNumberValid)
            {
                Console.WriteLine("Преобразование завершилось неудачно. Введите корректное число.");
                continue;
            }

            Console.WriteLine("Введите второе число (или оставьте пустым для операций без второго числа):");
            string secondInput = Console.ReadLine();
            bool isSecondNumberValid = double.TryParse(secondInput, out double number2);

            if (!isSecondNumberValid && !string.IsNullOrEmpty(secondInput))
            {
                Console.WriteLine("Преобразование завершилось неудачно. Введите корректное число.");
                continue;
            }

            Console.WriteLine("Выберите операцию (+, -, *, /, ^, sqrt, max, min):");
            string operation = Console.ReadLine();

            double result;

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine($"Результат: {result}");
                    break;

                case "-":
                    result = number1 - number2;
                    Console.WriteLine($"Результат: {result}");
                    break;

                case "*":
                    result = number1 * number2;
                    Console.WriteLine($"Результат: {result}");
                    break;

                case "/":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                        Console.WriteLine($"Результат: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Деление на ноль.");
                    }
                    break;

                case "^":
                    result = Math.Pow(number1, number2);
                    Console.WriteLine($"Результат: {result}");
                    break;

                case "sqrt":
                    if (number1 >= 0)
                    {
                        result = Math.Sqrt(number1);
                        Console.WriteLine($"Квадратный корень числа {number1}: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: Нельзя извлечь квадратный корень из отрицательного числа.");
                    }
                    break;

                case "max":
                    result = Math.Max(number1, number2);
                    Console.WriteLine($"Максимум: {result}");
                    break;

                case "min":
                    result = Math.Min(number1, number2);
                    Console.WriteLine($"Минимум: {result}");
                    break;

                default:
                    Console.WriteLine("Неизвестная операция.");
                    break;
            }

            Console.WriteLine("Хотите продолжить? (да/нет):");
            string userResponse = Console.ReadLine().ToLower();
            if (userResponse != "да")
            {
                continueCalculating = false;
            }
        }

        Console.WriteLine("Спасибо за использование калькулятора!");
    }
}
