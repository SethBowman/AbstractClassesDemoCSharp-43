using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemoCSharp_43
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //using the abstract keyword for stubbed out methods
        //using abstract keyword means you HAVE to use the override keyword in the derived (child) classes
        public abstract void Move();

        //using virtual makes a method that already does something at creation (non stubbed out)
        //using virtual means you DO NOT have to use the ovveride keyword in the derived (child) classes, but you can optionally
        public virtual void Breathe()
        {
            Console.WriteLine("Breathing");
        }
    }
}
