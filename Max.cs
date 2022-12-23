using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgrorithCh20as2
{
    class Max
    {
        static void Main(string[] args)
        {
            int Numberone = 10;
            int Numbertwo = 30;
            int Numberthree = 50;
            int Max = 0;
            if (Numberone < Numbertwo)
            {
                Max = Numbertwo;
            }
            else
            {
                Max = Numberone;
            }
            if (Numberthree < Max)
            {
                Console.WriteLine("Max : "+ Max);
            }
            else
            {
                Console.WriteLine("Max : " + Numberthree);
            }
            Console.WriteLine("Press any key to the window");
            Console.ReadKey();
        }
    }
}
