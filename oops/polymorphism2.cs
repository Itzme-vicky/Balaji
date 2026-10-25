using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    public class polymorphism2
    {
        public virtual void sound()
        {
            Console.WriteLine("Animal makes a sound");
        }
    }

    public class Dog : polymorphism2
    {
        public override void sound()
        {
            Console.WriteLine("Dog barks");
        }

        public void legs() { 
        Console.WriteLine("Dog has 4 legs");
        }
    }
}
