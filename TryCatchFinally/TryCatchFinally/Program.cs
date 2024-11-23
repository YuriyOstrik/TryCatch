using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            { try 
                { 
                    Console.Write("Введите число: ");
                    string input = Console.ReadLine(); 
                    int number = int.Parse(input);
                    int result = 100 / number; 
                    Console.WriteLine($"Результат: 100 / {number} = {result}"); 
                } 
             catch (DivideByZeroException ex) 
                { 
                    Console.WriteLine("Ошибка: Деление на ноль невозможно."); 
                    Console.WriteLine($"Сообщение: {ex.Message}");
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                }

             catch (FormatException ex) 
                {
                    Console.WriteLine("Ошибка: Некорректный ввод. Пожалуйста, введите числовое значение.");
                    Console.WriteLine($"Сообщение: {ex.Message}"); 
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                } 

             catch (Exception ex) 
                { 
                    Console.WriteLine("Произошла непредвиденная ошибка."); 
                    Console.WriteLine($"Сообщение: {ex.Message}"); 
                    Console.WriteLine($"Метод: {ex.TargetSite}");
                } 

             finally 
                { 
                    Console.WriteLine("Программа завершена."); 
                }
            }
        }
    }
}
