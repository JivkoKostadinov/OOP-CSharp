using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
    class Cat : Animal
    {
        public Cat(int age, string name, SexType sex)
            : base(age, name, sex)
        {

        }

        public void ProduceSound()
        {
            Console.WriteLine("Meow Meow");
        }
    }
}
