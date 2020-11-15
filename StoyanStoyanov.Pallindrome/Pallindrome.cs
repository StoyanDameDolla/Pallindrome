using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteMasterclass.HelloWorld
{
    public class Pallindrome
    {
        //Instantiate public/private properties to be used by constructors/methods/objects;
        //public int originalNum { get; set; }
        public int tempNum { get; set; }
        public int remainderNum { get; set; }
        //Build a pallindrome constructor for the Pallindrome class;
        public Pallindrome(int aTempNum, int aRemainderNum)
        {
            //originalNum = aOriginalNum;
            tempNum = aTempNum;
            remainderNum = aRemainderNum;

            //Instantiate original number before prompting user for input;
            int originalNum;
            //Reversed num == Const number;
            int reversedNum = 0;

            //Prompt the user for a number input;
            Console.WriteLine("\n");
            Console.WriteLine("Please, enter an integer number: ");
            originalNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //Temp number = original number;
            tempNum = originalNum;

            Console.WriteLine("==================Logic calculation=======================");
            Console.WriteLine("==================Before while loop execution=============");
            Console.WriteLine($"Original number:{originalNum}");
            Console.WriteLine($"Temporary number:{tempNum}");
            Console.WriteLine($"Reversed number:{reversedNum}");
            //Two empty carriage rows;
            Console.WriteLine("\n\n");

            Console.WriteLine("===============Starting While loop================");
            while (originalNum > 0)
            {
                remainderNum = originalNum % 10;
                Console.WriteLine($"Remainder:{remainderNum}");
                reversedNum = reversedNum * 10 + remainderNum;
                Console.WriteLine($"Reversed number:{reversedNum}");
                originalNum = originalNum / 10;
                Console.WriteLine($"Original number:{originalNum}");
                Console.WriteLine("=====Iteration complete======");
            }

            Console.WriteLine("========While loop has ender===========");
            Console.WriteLine("\n\n");

            Console.WriteLine("========Finding reversed number===========");
            Console.WriteLine($"Original number:{originalNum}");
            Console.WriteLine($"Reversed number:{reversedNum}");
            Console.WriteLine("===============================\n");

            //Conditional check for the pallindrome number;
            if (tempNum == reversedNum)
            {
                Console.WriteLine("Entered number is a pallindrome!");
            }

            else
            {
                Console.WriteLine("Entered number is not a pallindrome!");
            }

            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
