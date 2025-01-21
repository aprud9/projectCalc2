using System;

public class MainClass
{
    public static void Main()
    {
        while (true)
        {
            {
                Console.WriteLine("Программа позволяет выполнять операции с двумя вещественными числами: сложение, вычитание, умножение и деление.");
                Console.WriteLine("Введите выражение в формате 50+5, 96-2, 10*2, 500/5 и т.п. Пример выражения с дробным числом: 99,9*0,1: ");

                string s = Console.ReadLine();

                // Количество символов в строке
                int countS = s.Length;

                // Переменные для чисел, знака, результата
                double number1 = 0;
                double number2 = 0;
                char sign = ' ';
                double result = 0;

                // Обработка ошибок 
                try 
                {
                    // Определяем какой знак в строке и какой он по счету.
                    for (int i = 1; i < countS; i++) // Начинаем цикл с i = 1 на случай если первое число отрицательное.
                    {
                        if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/') 
                        {
                            sign = s[i];
                            number1 = Convert.ToDouble(s.Substring(0, i)); // Определяем первое и второе число, конвертируем в тип double
                            number2 = Convert.ToDouble(s.Substring(i + 1));
                            break; // Выходим из цикла сразу после определения знака
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка! Выражение введено неверно. Для продолжения работы нажмите клавишу 'Enter'");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                // Проверка определился ли знак ранее
                if (sign == ' ')
                {
                    Console.WriteLine("Ошибка! Выражение введено неверно. Для продолжения работы нажмите клавишу 'Enter'");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }


                switch (sign)
                {
                    case '+':
                        result = number1 + number2;
                        break;
                    case '-':
                        result = number1 - number2;
                        break;
                    case '*':
                        result = number1 * number2;
                        break;
                    case '/':
                        if (number2 != 0)
                        {
                            result = number1 / number2;
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                            Console.WriteLine("Для продолжения работы с новыми числами нажмите клавишу 'Enter'");
                            Console.ReadLine();
                            Console.Clear();
                            continue;
                        }
                        break;
                }
                Console.WriteLine("Результат: " + result);
                Console.WriteLine("Для продолжения работы с новыми числами нажмите клавишу 'Enter'");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}