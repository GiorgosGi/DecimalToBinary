using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb;
            Console.Write("Enter an integer number : ");
            numb = int.Parse(Console.ReadLine());
            int quot;
            string rem = "";
            while (numb >= 1)
            {
                quot = numb / 2;
                rem += (numb % 2).ToString();
                numb = quot;
            }
            string bin = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                bin = bin + rem[i];
            }
            Console.WriteLine("The binary format for number {0} is {1}", numb, bin);
            Console.Read();
        }
    }
}
