using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment12.Program3
{
    public class Demo3
    {
        private List<int> NumList = null;

        public Demo3()
        {
            NumList = new List<int>
            {
                1,2,3,4,5,6,7,8,9,10,1,12,13,14,15,16,17,18,19,20
            };
        }
        delegate void Write3Multiplier(int i);

        private void MultiplierThree(int i)
        {

            if ((i % 3) == 0)
                {
                    Console.WriteLine("{0} is divisable by 3", i.ToString());
                }
        }
        public void PrintUsingLembda()
        {
            Console.WriteLine("Print divisable by 3 using Lembda in 1 to 20");
            NumList.ForEach(x => 
            {
                if ((x % 3) == 0)
                {
                    Console.WriteLine("{0} is divisable by 3", x.ToString());
                }
            });
        }
        public void PrintUsingDelegate()
        {
            Console.WriteLine("Print divisable by 3 using Delegate in 1 to 20");

            Write3Multiplier mulDel = this.MultiplierThree;
            NumList.ForEach(x => mulDel(x));
        }
    }
}
