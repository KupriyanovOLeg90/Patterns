using System.IO;
using System.Text;
using Patterns.Interfaces;

namespace Patterns.DataReader
{
    class FileDataRider : IReader //Читает данные из файла
    {
        public string GetValue(string datas)
        {
            if (!File.Exists(datas))
                return string.Empty;

            using (StreamReader sw = new StreamReader(datas,Encoding.Default))
            {
                return sw.ReadToEnd();
            }
        }
    }
}
