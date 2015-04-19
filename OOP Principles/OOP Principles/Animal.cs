using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fauna
{
    public enum SexType
    {
        Male,
        Female
    }

    class Animal : ISound
    {
        private int age;
        private string name;
        private SexType sex;

        public int Age
        {
            get { return this.age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Age");
                }
                this.age = value;
            }
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Inavlid Name!");
                }
                this.name = value;
            }
        }

        public SexType Sex
        {
            get { return this.sex; }
            set
            {
                if (!Enum.IsDefined(typeof(SexType), value))
                {
                    throw new ArgumentException("Inavlid Sex!");
                }
                this.sex = value;
            }
        }

        public Animal(int age, string name, SexType sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public void ProduceSound()
        {
            throw new NotImplementedException();
        }

        public static double AverageAge(Animal[] animals)
        {
            return animals.Average(a => a.Age);
        }

        public override string ToString()
        {
            return String.Format("Name: {0} Age: {1} Sex: {2}", this.Name, this.Age, this.Sex);
        }
    }
}