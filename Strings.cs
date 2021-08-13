using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace BasicProgramming
{
    class Strings
    {

        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);
        const uint KEYEVENTF_KEYUP = 0x0002;
        const uint KEYEVENTF_EXTENDEDKEY = 0x0001;

        // Key up


        private int inge;
        public Strings()
        {

            CountSpacesAndWords();
            //test();
            //StringFormat();

            //var input = Console.ReadKey(true);
            while (true)
            {
                

                // Key down
                //keybd_event((byte)Convert.ToInt32("A0"), 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
                keybd_event(0xA0, 0x45, 0x0001 | 0, 0);

                Console.ReadLine();
                //Console.WriteLine(GetAscii(Console.ReadKey(true)));
                keybd_event(0xA0, 0x45, 0x0002 | 0, 0);
            }
            

        }

        int GetAscii(ConsoleKeyInfo input)
        {

            return (int)input.KeyChar;
        }

        private void CountSpacesAndWords()
        {
            string mystring = "Dette er et eksempel på en string";
            int countSpaces = mystring.Count(Char.IsWhiteSpace); // 6

            Console.WriteLine($"Der var {countSpaces} antal spaces i '{mystring}'");

        }

        public Strings(int i)
        {
            this.inge = i;
        }

        void test()
        {
            string text = @"https:\\dr.dk\livetv";
            inge = 47;
            string text2 = @$"Inges alder er {inge} og hendes 
favorithjemmeside er {text}. Dog er bt\bt\nyheder bedre";
            Console.WriteLine(text2);
            Console.ReadKey(true);
        }

        void StringFormat()
        {
            DateTime d = DateTime.Now;
            CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("en-UK");
            float f = 12.34f;
            string s1 = f.ToString();
            string s2 = f.ToString("", cultureInfo);
            string s3 = d.ToString("ddd MMMM yyy HH:mm:ss");

            string text = "Dette er en text";

            Console.WriteLine(text[1].ToString().ToUpper());

            //// Create an array of all supported standard date and time format specifiers.
            //string[] formats = {"d", "D", "f", "F", "g", "G", "m", "o", "r",
            //              "s", "t", "T", "u", "U", "Y"};
            //// Create an array of four cultures.
            //CultureInfo[] cultures = {
            //    CultureInfo.CreateSpecificCulture("dk-DK"),
            //    CultureInfo.CreateSpecificCulture("de-DE"),
            //    CultureInfo.CreateSpecificCulture("en-US"),
            //    CultureInfo.CreateSpecificCulture("es-ES"),
            //    CultureInfo.CreateSpecificCulture("fr-FR")};
            //// Define date to be displayed.
            //DateTime dateToDisplay = new DateTime(2008, 10, 31, 17, 4, 32);

            //// Iterate each standard format specifier.
            //foreach (string formatSpecifier in formats)
            //{
            //    foreach (CultureInfo culture in cultures)
            //        Console.WriteLine($"" +
            //            $"{formatSpecifier} Format Specifier " +
            //            $"{culture.Name,10} Culture " +
            //            $"{dateToDisplay.ToString(formatSpecifier, culture),40}");
            //    Console.WriteLine();


            //}
        }

        void ExampleRegularVsVerbatim()
        {
            //Regular
            string columns = "Column 1\tColumn 2\tColumn 3";
            //Output: Column 1        Column 2        Column 3

            string rows = "Row 1\r\nRow 2\r\nRow 3";
            /* Output:
              Row 1
              Row 2
              Row 3
            */

            //Verbatim
            string filePath = @"C:\Users\scoleridge\Documents\";
            //Output: C:\Users\scoleridge\Documents\

            string text = @"My pensive SARA ! thy soft cheek reclined
    Thus on mine arm, most soothing sweet it is
    To sit beside our Cot,...";
            /* Output:
            My pensive SARA ! thy soft cheek reclined
               Thus on mine arm, most soothing sweet it is
               To sit beside our Cot,...
            */

            string quote = @"Her name was ""Sara.""";
            //Output: Her name was "Sara."
        }




        void ExampleInterpolation()
        {
            var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);
            Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
            Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
            Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");
        }
        void ExampleComposite()
        {
            var pw = (firstName: "Phillis", lastName: "Wheatley", born: 1753, published: 1773);
            Console.WriteLine("{0} {1} was an African American poet born in {2}.", pw.firstName, pw.lastName, pw.born);
            Console.WriteLine("She was first published in {0} at the age of {1}.", pw.published, pw.published - pw.born);
            Console.WriteLine("She'd be over {0} years old today.", Math.Round((2018d - pw.born) / 100d) * 100d);

            // Output:
            // Phillis Wheatley was an African American poet born in 1753.
            // She was first published in 1773 at the age of 20.
            // She'd be over 300 years old today.
        }

    }
}
