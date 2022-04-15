using System;

namespace test_6
{
    class Program
    {
        private int number;
        public int Number
        {
            get { return number; }
            set
            {
                if (value > 0)
                { number = 6; }
                else 
                { number = 0; }

            }
        }
        public override string ToString()
        {
            return $"{number}";
        }


        static void Main(string[] args)
        {

            Program test = new Program();
            test.number = -9;
            Console.WriteLine(test);
        }








    }
}
