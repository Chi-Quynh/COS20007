using System.Security.Cryptography;
using System.Xml.Linq;

namespace Program
{
    public class Counter
    {
        private int _count;
        private string _name;

        public Counter(string name)
        {
            _count = 0;
            _name = name;
        }  
        
        public void Increment() 
        {
        _count++;
        }
        public void Reset() 
        {
        _count = 0;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int Ticks
        {
            get => _count;
        }

    }

    public class MainClass
    {
        private static void PrintCounters(Counter[] counter) 
        {
            foreach(var i in counter)
            {
                Console.WriteLine("{0} is {1}",i.Name,i.Ticks);
            }
        }

        public static void Main(string[] args) 
        {

            Counter[] myCounters = new Counter[3];
            myCounters[0]= new Counter("Counter 1");
            myCounters[1]= new Counter("Counter 2");
            myCounters[2] = myCounters[0];

            for (int i =0; i < 10;i++)
            {
                myCounters[0].Increment();
            }

            for (int i = 0; i < 15; i++)
            {
                myCounters[1].Increment();
            }
            PrintCounters(myCounters);
            myCounters[2].Reset();
            PrintCounters(myCounters);
        }

    }
}
 
