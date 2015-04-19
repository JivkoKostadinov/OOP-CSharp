using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
    class Kitten : Cat
    {
        public Kitten(int age, string name, SexType sex)
            : base(age, name, sex)
        {
            if (sex != SexType.Female)
            {
                throw new ArgumentException("Kittens can only be female");
            }
        }

        public void ProduceSound()
        {
            Console.WriteLine("Feminine Meow Meow");
        }
    }
}
