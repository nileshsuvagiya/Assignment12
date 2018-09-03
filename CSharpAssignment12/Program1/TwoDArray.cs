using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment12
{
    public class TwoDArray
    {
        private string[,] twoDArray = new string[3,3];
        public TwoDArray()
        {

            twoDArray[0, 0] = "ONE";
            twoDArray[0, 1] = "TWO";
            twoDArray[1, 0] = "THREE";
            twoDArray[1, 1] = "FOUR";
            twoDArray[2, 0] = "FIVE";
            twoDArray[2, 1] = "SIX";
        }

        public  void PrintTwoDArray()
        {
            Console.WriteLine("Print 2D Array");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("{0},{1}", twoDArray[i, 0], twoDArray[i, 1]);
            }
            Console.ReadLine();
        }
    }
}
