using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_HW_and_Excersizes_Challenge_Person
{
    class Person
    {
        // Fields

        public string _firstName, _lastName;
        public int _ID;

        // Ctors



        // Abilities

        public virtual bool ItIsTheSamePerson(Person person)
        {
            if (_ID == person._ID)
            {
                return true;
            }

            return false;
        }

    }
}
