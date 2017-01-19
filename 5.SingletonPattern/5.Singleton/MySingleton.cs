namespace _5.Singleton
{
    public class MySingleton
    {
        //sofort initialisieren damit threadsafe
        private static MySingleton uniqueOjekt = new MySingleton();

        public static MySingleton Instance { get { return uniqueOjekt; } }

        private MySingleton() { }
    }
}