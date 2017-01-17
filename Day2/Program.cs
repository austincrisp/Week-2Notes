using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    // Class Definition
    class Dog
    {
        private int Age;
        public string Name;

        public Dog(string _Name)
        {
            Age = 0;
            Name = _Name;
        }

        public void HappyBirthday()
        {
            Age++;
        }

        public int GetAge()
        {
            return Age;
        }

        public int GetAgeDogYears()
        {
            return Age * 7;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var wilkins = new Dog("Wilkins");
            wilkins.HappyBirthday();
            var age = wilkins.GetAge();
            var ageDogYears = wilkins.GetAgeDogYears();
            Console.WriteLine(age);
        }
    }
}
