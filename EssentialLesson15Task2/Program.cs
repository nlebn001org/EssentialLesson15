using EssentialLesson15Task1;
using System;
using System.Linq;

class Program
{
    //    Задание 2
    //Требуется описать структуру с именем Worker, содержащую следующие поля:
    //• фамилия и инициалы работника;
    //• название занимаемой должности;
    //• год поступления на работу.
    //Написать программу, выполняющую следующие действия:
    //• ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker (записи должны быть упорядочены по алфавиту);
    //• если значение года введено не в соответствующем формате выдает исключение;
    //• вывод на экран фамилии работника, стаж работы которого превышает введенное значение.

    static void Main(string[] args)
    {
        Worker[] workers = new Worker[5];
        string str;
        int year;

        for (int i = 0; i < workers.Length; i++)
        {
            Console.WriteLine($"Enter the lastname of {i} worker.");
            str = Console.ReadLine();
            workers[i].LastName = str;

            Console.WriteLine($"Enter the position of {i} worker.");
            str = Console.ReadLine();
            workers[i].JobTitle = str;

            Console.WriteLine($"Enter the year when {i} worker stratred to work.");
            try
            {
                str = Console.ReadLine();
                if (int.TryParse(str, out year) && year > 2000 && year < 2021)
                    workers[i].Year = year;
                else
                    throw new Exception("Wrong format exception");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        Worker[] newArr = (from worker in workers
                           where worker.Year > 2010
                           orderby worker.LastName ascending
                           select worker).ToArray();

        foreach (var item in newArr)
            Console.WriteLine(item.ToString());

    }
}

