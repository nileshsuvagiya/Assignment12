using CSharpAssignment12.Program2;
using CSharpAssignment12.Program3;
using CSharpAssignment12.Program4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment12
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Program 1
            //new TwoDArray().PrintTwoDArray();

            //Program 2
            //Duck d = new Duck("duck");
            //d.PrintAnimal();

            //Cate c = new Cate("cate");
            //c.PrintAnimal();

            //Program 3
            //Demo3 demo3 = new Demo3();
            //demo3.PrintUsingDelegate();
            //Console.ReadLine();
            //demo3.PrintUsingLembda();
            //Console.ReadLine();


            //Program 4
            string inputEmail= "usre@MyApp.com";
            Console.WriteLine("Email to validate is " + inputEmail);
            Console.WriteLine("Is Email Valid : " + inputEmail.IsEmail());
           

            inputEmail = "usre_MyApp.com";
            Console.WriteLine("Email to validate is " + inputEmail);
            Console.WriteLine("Is Email Valid : " + inputEmail.IsEmail());
            Console.ReadLine();




        }


    }
}
