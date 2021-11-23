using EssentialLesson15Task1;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EssentialLesson15Task3
{

    //    Задание 3
    //Используя Visual Studio, создайте проект по шаблону Console Application.
    //Требуется описать структуру с именем Price, содержащую следующие поля:
    //• название товара;
    //• название магазина, в котором продается товар;
    //• стоимость товара в гривнах.
    //Написать программу, выполняющую следующие действия:
    //• ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price (записи должны быть упорядочены в алфавитном порядке по названиям магазинов);
    //• вывод на экран информации о товарах, продающихся в магазине, название которого введено с клавиатуры(если такого магазина нет, вывести исключение).

    class Program
    {
        static void Main(string[] args)
        {
            Price[] prices = new Price[2];
            string str;
            int price;

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine($"Enter a name of the Product.");
                str = Console.ReadLine();
                prices[i].Product = str;

                Console.WriteLine($"Enter a name of the Shop.");
                str = Console.ReadLine();
                prices[i].Shop = str;

                Console.WriteLine($"Enter a Price of the product.");
                try
                {
                    str = Console.ReadLine();
                    if (int.TryParse(str, out price))
                        prices[i].PriceUAH = price;
                    else
                        throw new Exception("Wrong format exception");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }


            while (true)
            {
                Console.WriteLine("Enter the name of a shop");

                try
                {
                    str = Console.ReadLine();

                    IEnumerable<Price> selected = from element in prices where element.Shop == str select element;

                    if (selected.Count() > 0)
                        selected.ToList().ForEach(p => Console.WriteLine(p.ToString()));
                    else
                        throw new Exception("Shop is not at the list Exception");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
