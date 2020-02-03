using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.FactoryMethod.Enemies;

namespace _2.FactoryMethod.Factory
{
    /// <summary>
    /// 
    /// Класс представляющий фабрику, которая генерирует противников
    /// 
    /// </summary>
    class EnemiesFacroty : IEnemyFactory
    {
        private static Random rnd = new Random();

        /// <summary>
        /// Типы врагов 
        /// </summary>
        private readonly List<Type> _enemies = new List<Type>()
        {
            typeof(Elf),
            typeof(Goblin),
            typeof(Ogr)
        };

        public IEnemy Create()
        {
            var typeOfEnemy = _enemies[rnd.Next(0, _enemies.Count)];

            return Activator.CreateInstance(typeOfEnemy) as IEnemy;
        }
    }
}
