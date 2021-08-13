using System;

namespace BasicProgramming
{
    public class Loops
    {
        public void WhileMethod()
        {

            // "Do while" runs the code atleast once
            // while "while" checks condition first.
            int i = 0, j = 0;
            while (i < 0)
            {
                Console.WriteLine("While: " + i);
                i++;
            }

            do
            {
                Console.WriteLine("DoWhile: " + j);
                j++;
            }
            while (j < 0);
        }

        public void ForMethod()
        {
            int i1 = 1;
            int j1 = ++i1;
            Console.WriteLine("j1: " + j1 + "i1: " + i1);

            int i2 = 1;
            int j2 = i2++;
            Console.WriteLine("j2: " + j2 + "i2: " + i2);

            int length = 10;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("For Loop #" + i);
            }
        }

        public void ForeachMethod()
        {           
            string[] noContentArray = new string[10];
            int c = 0;
            foreach (var item in noContentArray)
            {
                c++;
                Console.WriteLine("Counting places : " + c);
            }

            string[] animals = { "svin", "lus", "abekat" };
            foreach (var animal in animals)
            {
                Console.WriteLine("All the animals are good..."+animal);
            }

            Console.WriteLine("But the " + animals[1]+" is my favorite");
        }

    }
}

