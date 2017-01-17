using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var wilkins = new Dog("Wilkins");
            wilkins.HappyBirthday();
            var age = wilkins.GetAge();
            var ageDogYears = wilkins.GetAgeDogYears();
            Console.WriteLine(age);
            Console.WriteLine(ageDogYears);
            //Console.WriteLine(wilkins.name);

            var casey = new Dog("Casey");
            var spaghetti = new Dog("Spaghetti");
            spaghetti.HappyBirthday();
            var rex = new Dog("Rex");

            wilkins.AddFriend(casey);
            wilkins.AddFriend(spaghetti);
            wilkins.AddFriend(spaghetti);
            wilkins.AddFriend(rex);

            wilkins.GetDogFriends();
            wilkins.RemoveFriend(spaghetti);
            wilkins.GetDogFriends();
        }
    }
}
