namespace _2.FactoryMethod.Enemies
{
    /// <summary>
    /// Класс представляющий врага 'Эльф'
    /// </summary>
    class Goblin : IEnemy
    {
        /// <summary>
        /// Боевой клич 
        /// </summary>
        public string BattleCry()
        {
            return "Моя пришёль тебе убивать ЫЫЫЫ";
        }

        public override string ToString()
        {
            return "Гоблин обыкновенный";
        }
    }
}
