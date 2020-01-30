using System;
using Patterns.DataReader;


namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new DataReader.DataReader();

            Console.WriteLine("Читаем из файла");
            Console.WriteLine(dataReader.GetValue(new FileDataRider(), $"{AppDomain.CurrentDomain.BaseDirectory}InfoTest.txt"));
            Console.WriteLine("................");


            Console.WriteLine("Читаем из строки");
            Console.WriteLine(dataReader.GetValue(new StringDataReader(), $"Па́ттерн (англ. pattern «образец, шаблон; форма, модель; схема, диаграмма») — схема-образ, действующая как посредствующее представление, или чувственное понятие, благодаря которому в режиме одновременности восприятия и мышления выявляются закономерности, как они существуют в природе и обществе."));
            Console.WriteLine("................");


            Console.ReadKey();
        }
    }
}
