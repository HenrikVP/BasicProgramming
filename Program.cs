using System;


namespace BasicProgramming
{
    class Program
    {
        int i = 200;
        static float f1 = 10.123456f, f2;

        static void Main(string[] args)
        {

            new Strings();
            //new Strings(32);

            //SecondProject.Program.ExampleOfMoreProjects();
            Menu();

            // Instantiates an object of the type "Loops" class
            Loops loops = new Loops();

            // Runs the methods from the instantiated class reference
            loops.ForeachMethod();

            loops.ForMethod();

            loops.WhileMethod();

            // Returns a float to the global field (f2) by running the
            // static method TwoDecimals from the "DataTypes" class
            // with (f1) as method parameter.
            f2 = DataTypes.TwoDecimals(f1);

            Console.WriteLine("Float " + f1 + " converted to 2 decimals is:" + f2);
            DataTypes.FirstMethod(null);

            // Runs a method that is part of the class
            Parsing();

            // Instantiates objectclass and runs method with
            // no reference for later use.
            new ObjectClass().MethodExample();
            int x = 10 * 200;
            // Instantiates an object "objectClass" for later use 
            ObjectClass objectClass = new ObjectClass();
            // Uses instantiated method for running "MethodExample"
            objectClass.MethodExample();
        }

        private static void Parsing()
        {
            string str = "55";
            int? result = DataTypes.TryParseMethod(str);
            if (result == null)
            {
                Console.WriteLine(str + " couldn't be int-parsed");
            }
            else
            {
                Console.WriteLine("TryParse Resultat: " + result);
            }
        }


        static void Menu()
        {

            


            string[] menuitems = {
                "Exit",
                "Datatypes",
                "Loops",
                "ObjectClass",
                "Elevish"
            };

            for (int i = 0; i < menuitems.Length; i++)
            {
                Console.WriteLine(i + " " + menuitems[i] + "\n");
            }

            var ch = Console.ReadKey().Key;
           // Console.WriteLine(" " + ch.Key);
            //Console.WriteLine("\n ch tostring " + ch.ToString() + "\n ch.key.tostring " +
            //    ch.Key.ToString() + "\n ch.keychar "  + ch.KeyChar);
            //foreach (var item in menuitems)
            //{
            //    Console.WriteLine("" + item);
            //}

            //if (ch == ConsoleKey.D1) new Elevenses().Game();

            //if (ch == ConsoleKey.D2) Console.WriteLine("Picked 1");

            //if (ch == ConsoleKey.D3) Console.WriteLine("Picked 1");

            //if (ch == ConsoleKey.D4) new Elevenses().Game();

            //switch (ch.Key)
            //{
            //    case ConsoleKey.D1:
            //        Console.WriteLine("Picked 1");
            //        break;
            //    case ConsoleKey.D2:
            //        Console.WriteLine("Picked 2");
            //        break;
            //    case ConsoleKey.D3:
            //        Console.WriteLine("Picked 3");
            //        break;
            //    default:
            //        break;
            //}

          
        }
    }
}