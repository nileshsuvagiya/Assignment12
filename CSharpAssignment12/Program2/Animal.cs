using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment12.Program2
{
    public class Animal : IFly, ISwimm, IWalk
    {
        private string name;
        public Animal(string name)
        {
            this.name = name;
        }

        public void Fly()
        {
            Console.WriteLine("{0} - can fly", name);
        }

        public void Swimm()
        {
            Console.WriteLine("{0} - can swimm",name);

        }

        public void Walk()
        {
            Console.WriteLine("{0} - can walk", name);
        }

        public void Eat()
        {
            Console.WriteLine("{0} - can eat",name);
        }

        public virtual void PrintAnimal()
        {
            Fly();
            Swimm();
            Walk();
            Eat();
            Console.ReadLine();
        }
    }
}
