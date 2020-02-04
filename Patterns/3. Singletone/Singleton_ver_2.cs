namespace _3.Singletone
{
    /// <summary>
    /// Статическая инициализация (потокобезопасная но если нужно получать экзепляр не первом вызове класса а именно когда обращаемся к Instance не пойдет)
    /// </summary>
    class Singleton_ver_2
    {
        private Singleton_ver_2() { }

        public static Singleton_ver_2 Instance { get; } = new Singleton_ver_2();
    }
}
