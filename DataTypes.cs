using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    public class DataTypes
    {
        //bool bo = true; // or false
        //Number without decimals in order of size, smallest first
        byte b = 255;
        int i = 1270;
        long l = 421341234;
        //Number with decimals in order of size, smallest first
        static float f = 12345678.123456789f;
        double d = (int)27.92d;
        decimal dec = 129031239;
        //Text
        string str = "This is a text string"; //multiple characters
        char c = 'a'; //Single character

        public static void FirstMethod(int? i)
        {
            double d = (int)27.92d;

            Console.WriteLine("double casted as int: " + d);
        }

        public static int? TryParseMethod(string str)
        {
            bool canItParseIt = int.TryParse(str, out int result);
            if (canItParseIt)
            {
                return result;
            }
            else
            {
                return null;
            }        
        }

        public static float TwoDecimals(float f)
        {
            float f2 = f * 100;
            int i = (int)f2;
            float f3 = (float)i / 100;

            return f3;


            //return ((int)f*100)/100f;
        }
    }
}
