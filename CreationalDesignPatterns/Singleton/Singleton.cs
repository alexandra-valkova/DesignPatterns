namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton? instance;

        private Singleton() { }

        public static Singleton Instance => instance ??= new Singleton();
    }
}
