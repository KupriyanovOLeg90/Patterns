namespace _2.FactoryMethod.Enemies
{
    /// <summary>
    /// Класс представляющий врага 'Эльф'
    /// </summary>
    class Elf : IEnemy
    {
        /// <summary>
        /// Боевой клич 
        /// </summary>
        public string BattleCry()
        {
            return "Умри призренный";
        }

        public override string ToString()
        {
            return "Светлый эльф";
        }
    }
}
