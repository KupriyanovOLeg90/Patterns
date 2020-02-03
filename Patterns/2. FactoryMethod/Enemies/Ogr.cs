namespace _2.FactoryMethod.Enemies
{
    /// <summary>
    /// Класс представляющий врага 'Огр'
    /// </summary>
    class Ogr : IEnemy
    {
        /// <summary>
        /// Боевой клич 
        /// </summary>
        public string BattleCry()
        {
            return "ЕДА ыыыыУУУУээ";
        }

        public override string ToString()
        {
            return "Огр";
        }
    }
}
