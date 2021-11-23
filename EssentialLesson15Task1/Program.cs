using System;
using System.Diagnostics;

namespace EssentialLesson15Task1
{
    //    Задание
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Создайте класс Calculator.
    //В теле класса создайте четыре метода для арифметических действий: Add – сложение, Sub – вычитание, Mul – умножение, Div – деление.
    //Метод деления должен делать проверку деления на ноль, если проверка не проходит, сгенерировать исключение.
    //Пользователь вводит значения, над которыми хочет произвести операцию и выбрать саму операцию.При возникновении ошибок должны выбрасываться исключения.

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Calculator.Div(1, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

            Console.WriteLine("END");

        }
    }
}
