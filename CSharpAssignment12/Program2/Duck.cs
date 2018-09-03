using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment12.Program2
{
    public class Duck : Animal
    {
        public Duck(string name) : base(name)
        { }

        public override void PrintAnimal()
        {
            base.PrintAnimal();
        }
    }
}
