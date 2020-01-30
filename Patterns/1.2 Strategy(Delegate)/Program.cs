using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.DataReader;

namespace _1._2_Strategy_Delegate_
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataReader = new DataReader();

            Console.WriteLine("Читаем из файла");
            Console.WriteLine(dataReader.GetValue(FileDataRider.GetValue, $"{AppDomain.CurrentDomain.BaseDirectory}InfoTest.txt"));
            Console.WriteLine("................");


            Console.WriteLine("Читаем из строки");
            Console.WriteLine(dataReader.GetValue(StringDataReader.GetValue, $"Па́ттерн (англ. pattern «образец, шаблон; форма, модель; схема, диаграмма») — схема-образ, действующая как посредствующее представление, или чувственное понятие, благодаря которому в режиме одновременности восприятия и мышления выявляются закономерности, как они существуют в природе и обществе."));
            Console.WriteLine("................");


            Console.ReadKey();
        }
    }
}
