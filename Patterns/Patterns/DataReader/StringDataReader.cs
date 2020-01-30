using Patterns.Interfaces;

namespace Patterns.DataReader
{
    class StringDataReader : IReader
    {
        public string GetValue(string datas)
        {
            return datas; //Тут можно добавить любую логику на корректировку строки
        }
    }
}
