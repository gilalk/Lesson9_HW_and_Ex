using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_HW_and_Excersizes_Challenge_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person
            {
                _firstName = "Moshe",
                _lastName = "Israel",
                _ID = 302238497
            };

            Person person2 = new Person
            {
                _firstName = "Mnachem",
                _lastName = "Israel",
                _ID = 302238497
            };

            Person person3 = new Person
            {
                _firstName = "Moshe",
                _lastName = "Israel",
                _ID = 302238423
            };

            Person idResist1 = new IdResist
            {
                _firstName = "Moshe",
                _lastName = "Israel",
                _ID = 302238657
            };

            IdResist idResist2 = new IdResist
            {
                _firstName = "Moshe",
                _lastName = "Israel",
                _ID = 302238657
            };

            Console.WriteLine(person1.ItIsTheSamePerson(person2));
            Console.WriteLine(person1.ItIsTheSamePerson(person3));
            Console.WriteLine(person2.ItIsTheSamePerson(person3));
            Console.WriteLine(person1.ItIsTheSamePerson(idResist1)); // Person's  function
            Console.WriteLine(idResist2.ItIsTheSamePerson(idResist1)); // IdResist function
        }
    }
}
