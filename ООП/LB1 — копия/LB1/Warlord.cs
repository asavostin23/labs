using System;
using System.Collections.Generic;
using System.Text;

namespace LB1
{
    class Warlord
    {
        private Warlord() { }
        private static Warlord instance;
        private static readonly object locker = new object();
        public static Warlord getInstance()
        {
            lock (locker)
            {
                if (instance == null)
                    instance = new Warlord();
                return instance;
            }
        }
        public void SayHello()
        {
            Console.WriteLine("Warlord greets you");
        }
    }
}
