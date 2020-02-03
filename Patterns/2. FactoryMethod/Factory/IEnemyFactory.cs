using _2.FactoryMethod.Enemies;

namespace _2.FactoryMethod.Factory
{
    /// <summary>
    /// Представляет интерфейс для шаблона "Фабричный метод"
    /// Для создания врагов
    /// </summary>
    interface IEnemyFactory
    {
        /// <summary>
        /// Создает новый объект реализующий <see cref="IEnemy"/>
        /// </summary>
        /// <returns> Экземляр реализующий интерфейс <see cref="IEnemy"/></returns>
        IEnemy Create();
    } 
}
