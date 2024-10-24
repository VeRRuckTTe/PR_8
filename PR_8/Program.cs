/******************************************************************************/
/* Практическая работа №8                                                     */
/* Выполнила: Корнеева В.Е., 2-ИСП                                            */
/* Задание: Cоставить программу рассчета сложных процентов.                   */
/******************************************************************************/
using System;

namespace PR_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Title = "Практическая работа №8";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Здравствуйте!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Введите начальную сумму денежного вклада в тысячах в банк: ");
                    double m = Double.Parse(Console.ReadLine()) * 1000;
                    Console.Write("Введите процентную ставку: ");
                    double k = Double.Parse(Console.ReadLine());
                    Console.Write("Введите желаемую сумму в тысячах: ");
                    double s = Double.Parse(Console.ReadLine()) * 1000;
                    int years = 0;
                    double m1 = m;
                    if (m == 0 || k == 0 || s == 0)
                    {
                        throw new Exception("Значения не могут быть отрицательными...");
                    }
                    if (m >= s) 
                    {
                        throw new Exception("Значение начальной суммы должно быть меньше чем желаемой...");
                    }
                    while (m1 < s)
                    {
                        m1 += m1 * (k / 100); 
                        years++;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Сумма вклада превысит в размере {s} тысяч через {years} годик(-ов) "); //$ это инторполяция для того что бы списывать значения в строку
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Хотите выполнить команду еще раз? \nНажмите Y для продолжение программы, иначе любую другую кнопку для завершения!");
                    if (Console.ReadKey().Key == ConsoleKey.Y)
                    {
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Программа завершена. \tДо свидания!");
                        Console.ReadKey();
                        break;
                    }
                }
                catch (FormatException fex) // Общие исключения
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы что то не так сделали... \nОшибка: " + fex.Message);
                }
                catch (ArgumentOutOfRangeException Aex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Что-то пошло не так... \tОшибка: " + Aex.Message);
                }
                catch (Exception e) // Частные исключения
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Что-то пошло не так... \tОшибка: " + e.Message);
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}





