using System.Diagnostics;
using System.Globalization;
using System.Text;

namespace StructClass
{



    internal class Program
    {
        static void Main(string[] args)
        {


            foreach (CultureInfo c in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                Console.WriteLine(c.Name);
            }
        }

    }


    struct Point
    {
        public int X;
        public int Y;

        public Point()
        {
            Console.WriteLine("Constructor");
            X = 10;
            Y = 11;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Counter
    {
        private int minValue;
        private int maxValue;
        private int currentData;

        public int Data { get; }

        public Counter(int minValue, int maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public int getCurrent() { return currentData; }

        public void increment()
        {
            if (currentData + 1 <= maxValue)
                currentData++;
            else
                currentData = minValue;
        }

        public void decrement()
        {
            if (currentData - 1 >= minValue)
                currentData--;
            else
                currentData = maxValue;
        }
    }




}