namespace _3.Singleton
{
    /// <summary>
    /// Простая реализация  (совсем не тру т.к не потокобезопасная)
    /// </summary>
    class Singleton_ver_1
    {
        private static Singleton_ver_1 instance;

        private Singleton_ver_1(){}

        public static Singleton_ver_1 Instance => instance ?? (instance = new Singleton_ver_1());
    }
}
