using System;
using _2.FactoryMethod.Factory;

namespace _2.FactoryMethod
{
    class Program
    {
        static void Main(string[] args) //
        {
            EnemiesFacroty factory = new EnemiesFacroty();

            Console.WriteLine("Вам предстоит сразится с 10 противниками:");

            for (int i = 1; i < 11; i++)
            {
                var enemy = factory.Create();
                Console.WriteLine($"{i}. {enemy} - {enemy.BattleCry()}");
            }

            Console.ReadKey();
        }

        
    }
}
