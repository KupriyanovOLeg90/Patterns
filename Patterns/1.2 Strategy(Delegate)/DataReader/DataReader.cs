using System;

namespace Patterns.DataReader
{
    class DataReader 
    {
        public string GetValue(Func<string, string> funcReader, string datas)
        {
            return funcReader.Invoke(datas);
        }
    }
}
