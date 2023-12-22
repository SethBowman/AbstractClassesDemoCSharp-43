using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemoCSharp_43
{
    public class Dog : Animal
    {       

        public override void Move()
        {
            Console.WriteLine("Dog runs");
        }

        public override void Breathe()
        {
            Console.WriteLine("Dog is breathing");
        }
    }
}
