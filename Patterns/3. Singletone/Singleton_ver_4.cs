using System;

namespace _3.Singletone
{
    /// <summary>
    /// Многопоточный (но доступен с фреймворка 4)
    /// </summary>
    class Singleton_Ver_4
    {
        private static  Lazy<Singleton_Ver_4> instance = new Lazy<Singleton_Ver_4>(() => new Singleton_Ver_4());


        private Singleton_Ver_4() { }

        public static Singleton_Ver_4 Instance
        {
            get
            {
                return instance.Value; 
            }
        }
    }
}
