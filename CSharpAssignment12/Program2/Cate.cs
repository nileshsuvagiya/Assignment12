using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment12.Program2
{
    public class Cate : Animal
    {
        public Cate(string name) : base(name)
        { }

        public override void PrintAnimal()
        {
            Walk();
            Eat();
            Console.ReadLine();
        }
    }
}
