using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    public class Polymorphism
    {

        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public string add(string a, string b)
        {
            return (a +" " + b);
        }

    }
}
