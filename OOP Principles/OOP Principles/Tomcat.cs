using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
    class Tomcat : Cat
    {
        public Tomcat(int age, string name, SexType sex)
            : base(age, name, sex)
        {
            if (sex != SexType.Male)
            {
                throw new ArgumentException("Tomcats can only be male");
            }
        }

        public void ProduceSound()
        {
            Console.WriteLine("Masculine Meow Meow");
        }
    }
}