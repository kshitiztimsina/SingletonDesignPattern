using System;

namespace SingletonDesignPattern
{
    public sealed class SignletonExample
    {
        private SignletonExample() { }
        private static SignletonExample _instance;
        private int previous;

        public static SignletonExample GetInstance()
        {
            if( _instance == null)
            {
                _instance = new SignletonExample();
            }
            return _instance;
        }
        public int AddLogic(int num)
        {
            int sum = num + previous;
            previous = sum;

            return sum;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SignletonExample single = SignletonExample.GetInstance();
            Console.WriteLine(single.AddLogic(1));
            Console.WriteLine(single.AddLogic(2));
            Console.WriteLine(single.AddLogic(4));
            Console.WriteLine(single.AddLogic(6));
            Console.WriteLine(single.AddLogic(7));

        }

    }
}
