using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    public class ObjectClass
    {
        private int p_i;

        public ObjectClass()
        {
            int a=0;
            for (int i = 0; i < 32; i++)
            {

            }
        }

        public ObjectClass(int i)
        {
            p_i = i;
        }
        public void MethodExample()
        {
            Console.WriteLine("This is 'i' : " + p_i);
        }
    }
}
