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
            {
                if (i % 3 == 0)
                    number++;
                
                Console.WriteLine("The number is divided {0} times", number);
            }
            
        }
    }
}
/*
 The number is divided 1 times
The number is divided 1 times
The number is divided 1 times
The number is divided 2 times
The number is divided 2 times
The number is divided 2 times
The number is divided 3 times
The number is divided 3 times
The number is divided 3 times
The number is divided 4 times
The number is divided 4 times
The number is divided 4 times
The number is divided 5 times
The number is divided 5 times
The number is divided 5 times
The number is divided 6 times
The number is divided 6 times
The number is divided 6 times
The number is divided 7 times
The number is divided 7 times
The number is divided 7 times
The number is divided 8 times
The number is divided 8 times
The number is divided 8 times
The number is divided 9 times
The number is divided 9 times
The number is divided 9 times
The number is divided 10 times
The number is divided 10 times
The number is divided 10 times
The number is divided 11 times
The number is divided 11 times
The number is divided 11 times
The number is divided 12 times
The number is divided 12 times
The number is divided 12 times
The number is divided 13 times
The number is divided 13 times
The number is divided 13 times
The number is divided 14 times
The number is divided 14 times
The number is divided 14 times
The number is divided 15 times
The number is divided 15 times
The number is divided 15 times
The number is divided 16 times
The number is divided 16 times
The number is divided 16 times
The number is divided 17 times
The number is divided 17 times
The number is divided 17 times
The number is divided 18 times
The number is divided 18 times
The number is divided 18 times
The number is divided 19 times
The number is divided 19 times
The number is divided 19 times
The number is divided 20 times
The number is divided 20 times
The number is divided 20 times
The number is divided 21 times
The number is divided 21 times
The number is divided 21 times
The number is divided 22 times
The number is divided 22 times
The number is divided 22 times
The number is divided 23 times
The number is divided 23 times
The number is divided 23 times
The number is divided 24 times
The number is divided 24 times
The number is divided 24 times
The number is divided 25 times
The number is divided 25 times
The number is divided 25 times
The number is divided 26 times
The number is divided 26 times
The number is divided 26 times
The number is divided 27 times
The number is divided 27 times
The number is divided 27 times
The number is divided 28 times
The number is divided 28 times
The number is divided 28 times
The number is divided 29 times
The number is divided 29 times
The number is divided 29 times
The number is divided 30 times
The number is divided 30 times
The number is divided 30 times
The number is divided 31 times
The number is divided 31 times
The number is divided 31 times
The number is divided 32 times
The number is divided 32 times
The number is divided 32 times
The number is divided 33 times
The number is divided 33 times
The number is divided 33 times
The number is divided 34 times
Press any key to continue . . .
 * /
