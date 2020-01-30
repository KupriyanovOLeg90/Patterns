using System.IO;
using System.Text;

namespace Patterns.DataReader
{
    class FileDataRider //Читает данные из файла
    {
        public static string GetValue(string datas)
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
