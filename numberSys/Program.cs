using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numberSys
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Convert number ");
            string Input = Console.ReadLine();
            Console.WriteLine();

            int BaseStart, BaseTarget;

            Console.Write("From base ");
            while (!int.TryParse(Console.ReadLine(), out BaseStart))
            {
                Console.WriteLine("Try again");
            }
            Console.WriteLine();

            Console.Write("To base ");
            while (!int.TryParse(Console.ReadLine(), out BaseTarget))
            {
                Console.WriteLine("Try again");
            }
            Console.WriteLine();


            int NInp = 0;// Convert.ToInt32(Input);
            string result = string.Empty;

            int len = Input.Length;
            int i;
            for (i = len; i <= 1; i--)
            {
                int num1;

                if (!int.TryParse(Input[i].ToString(), out num1))
                    num1 = char.ConvertToUtf32(Input[i].ToString(), 0) - char.ConvertToUtf32("A", 0) + 10;

                NInp = NInp + Convert.ToInt32(Math.Pow(10, i - 1)) * num1;
                                
            }

            /*do
            {
                string symbol;
                if (NInp % BaseTarget > 9)
                    symbol = char.ConvertFromUtf32(char.ConvertToUtf32("A", 0) + NInp % BaseTarget - 10).ToString();
                else symbol = (NInp % BaseTarget).ToString();

                result = symbol + result;
                NInp /= BaseTarget;
            }
            while (NInp > 0);*/

            Console.WriteLine("Result is {0}",NInp);

            Console.ReadKey(true);
        }
    }
}
