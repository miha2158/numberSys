using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bright_Idea_1
{
    class Program
    {
        static void ToMore(string Input, int i, int BaseBeg, int BaseEnd, char[] symbols, ref string Output)
        {
            Input.Reverse();
            int j, k, L = Input.Length;

            while (Input != string.Empty)
            {
                for (j = 1; symbols[j] != Input[i]; j++) ;


                Input = symbols[j - 1] + Input.Remove(0, 1);
                Output =S Output.Remove(0,1)


            }
        }



        static void Main(string[] args)
        {
            Console.Write("Convert number ");
            string Input = Console.ReadLine();
            Console.WriteLine();


            bool Negative = false;
            if (Input[1] == '-')
            {
                Negative = true;
                Input = Input.Remove(0, 1);
            }

            int BaseBeg, BaseEnd;

            Console.Write("From base ");
            while (!int.TryParse(Console.ReadLine(), out BaseBeg))
                Console.WriteLine("Try again");
            
            Console.WriteLine();

            Console.Write("To base ");
            while (!int.TryParse(Console.ReadLine(), out BaseEnd))
                Console.WriteLine("Try again");
            
            Console.WriteLine();

            char[] symbols = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string Output = string.Empty;

            if (BaseEnd < BaseBeg)
            {
                
            }
            else
            {
             
            }

            if (Negative)
                Output = "-" + Output;
            Console.WriteLine("Number is {0}", Output);
            
            Console.ReadKey(true);
        }
    }
}
