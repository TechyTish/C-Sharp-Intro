using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this is a string");

            //print on new line
            string intro = "Hello my name is tish \nI love tech";
            Console.WriteLine(intro);

            //append string variable
            string intro2 = "Hello my name is tish" + "and I love tech";

            //get length of variable
            Console.WriteLine(intro2.Length);

            //use upper method
            Console.WriteLine(intro.ToUpper());

            //pass parameter to the varaiable
            Console.WriteLine(intro.Contains("love"));

            //get character via index
            Console.WriteLine(intro[4]);

            //get index via chracter(s)
            Console.WriteLine(intro.IndexOf("love"));

            //get chracter via index and how many characters
            Console.WriteLine(intro.Substring(8, 3));

            Console.ReadLine();
        }
    }
}
