using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton = Singleton.GetInstance();
            Singleton singleton1 = Singleton.GetInstance();

            Console.WriteLine(singleton == singleton1);
        }
    }
}
