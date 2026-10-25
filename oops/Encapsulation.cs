using System;
using System.Collections.Generic;
using System.Text;

namespace oops
{
    public class Encapsulation
    {
        public string Name { get; set; }

        public string Address { get; set; } = string.Empty;


        public void Validate() {
            ValidateName();
            ValidateAddress();
        }

        private void ValidateName()
        {
            Console.WriteLine("Validating Name");
        }

        private void ValidateAddress()
        {
            Console.WriteLine("Validating Address");
        }


    }
}
