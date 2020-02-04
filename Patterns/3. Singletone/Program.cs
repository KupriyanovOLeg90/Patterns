using System;
using System.Threading;
using _3.Singletone;

namespace _3.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton_ver_1 singl1 = Singleton_ver_1.Instance;
            Singleton_ver_1 singl1_1 = Singleton_ver_1.Instance;


            Console.WriteLine($"HashCode экземпляра Singleton_ver_1:         {singl1.GetHashCode()}");
            Console.WriteLine($"HashCode другого экземпляра Singleton_ver_1: {singl1_1.GetHashCode()}");
            Console.WriteLine();


            Singleton_ver_2 singl2 = Singleton_ver_2.Instance;
            Singleton_ver_2 singl2_2 = Singleton_ver_2.Instance;

            Console.WriteLine($"HashCode экземпляра Singleton_ver_2:         {singl2.GetHashCode()}");
            Console.WriteLine($"HashCode другого экземпляра Singleton_ver_2: {singl2_2.GetHashCode()}");
            Console.WriteLine();


            Singleton_Ver_3 singl3 = Singleton_Ver_3.Instance;
            Singleton_Ver_3 singl3_3 = Singleton_Ver_3.Instance;

            Console.WriteLine($"HashCode экземпляра Singleton_ver_3:         {singl3.GetHashCode()}");
            Console.WriteLine($"HashCode другого экземпляра Singleton_ver_3: {singl3_3.GetHashCode()}");
            Console.WriteLine();

            Singleton_Ver_4 singl4 = Singleton_Ver_4.Instance;
            Singleton_Ver_4 singl4_4 = Singleton_Ver_4.Instance;

            Console.WriteLine($"HashCode экземпляра Singleton_ver_4:         {singl4.GetHashCode()}");
            Console.WriteLine($"HashCode другого экземпляра Singleton_ver_4: {singl4_4.GetHashCode()}");


            Console.ReadKey();
        }
    }
}
