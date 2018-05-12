using System;

namespace Bulldozer
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new FactoryWorker();
            worker.Count(4);
            worker.Count(5);
            worker.Count(3.5f);
        }
    }
    public class FactoryWorker
    {
        public FactoryWorker()
        {

        }
        public void Count (int number)
        {
            if (total == null)
            {
                total = 0;
            }
            total = total + Convert.ToSingle(number);
            Console.WriteLine(total.ToString());
        }

        public void Count (float number) //normally you wouldn't want to use same name, but since this is helping us handle a second TYPE its OK
        {
            total += number;
            Console.WriteLine(total.ToString());
        }

        public float total { get; set; }
    }
}
