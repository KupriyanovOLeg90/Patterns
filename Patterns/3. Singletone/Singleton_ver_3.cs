using System;

namespace _3.Singletone
{
    /// <summary>
    /// Многопоточный (Тру вариант)
    /// </summary>
    class Singleton_Ver_3
    {
        private static readonly object syncRoot = new Object();
        private static Singleton_Ver_3 instance;


        private Singleton_Ver_3() { }

        public static Singleton_Ver_3 Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        instance = new Singleton_Ver_3();
                    }
                }

                return instance; 
            }
        }
    }
}
