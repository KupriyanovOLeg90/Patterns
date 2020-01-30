using Patterns.Interfaces;

namespace Patterns.DataReader
{
    class DataReader 
    {
        public string GetValue(IReader dataReader, string datas)
        {
            return dataReader.GetValue(datas);
        }
    }
}
