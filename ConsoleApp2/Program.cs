using System;

public class MainClass
{
    public static void Main()
    {
        double number1;
        double number2;
        string sign;
        char k = 'y';

        Console.WriteLine("Программа позволяет выполнять операции с двумя вещественными числами: сложение, вычитание, умножение и деление.");
        Console.WriteLine("Для успешной работы программы следуйте всем дальнейшим подсказкам.");
        Console.WriteLine();

        while (k == 'y')
        {
            try
            {
                Console.Write("Введите первое число: ");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Введите второе число: ");
                number2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Ошибка! Введено число в неверном формате. Для продолжения работы нажмите клавишу 'Enter'");
                Console.ReadLine();
                Console.Clear();
                continue;
            }

            Console.Write("Введите один из соответствующих знаков (+, -, *, /) для выполнения операции между числами " + number1 + " и " + number2 + ": ");
            sign = Console.ReadLine();
            Console.WriteLine();

            while (sign != "+" && sign != "-" && sign != "*" && sign != "/")
            {
                Console.Write("Введен неверный знак. Повторите ввод знака: ");
                sign = Console.ReadLine();
                Console.WriteLine();
            }

            if (sign == "+")
            {
                Console.WriteLine("Результат: " + number1 + " + " + number2 + " = " + (number1 + number2));
            }

            if (sign == "-")
            {
                Console.WriteLine("Результат: " + number1 + " - " + number2 + " = " + (number1 - number2));
            }

            if (sign == "*")
            {
                Console.WriteLine("Результат: " + number1 + " * " + number2 + " = " + (number1 * number2));
            }

            if (sign == "/")
            {
                if (number2 != 0)
                {
                    Console.WriteLine("Результат: " + number1 + " / " + number2 + " = " + (number1 / number2));
                }
                else
                {
                        Console.WriteLine("На ноль делить нельзя!");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Для продолжения работы с новыми числами нажмите клавишу 'Enter'");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
