using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumberDivideBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            var number=0;
            for (var i = 0; i < 100; i++)
            
                if (i % 3 == 0)
                    number++;
                
                Console.WriteLine("The number is divided {0} times", number);
            
            
        }
    }
}
/*
The number is divided 34 times
Press any key to continue . . .
*/

