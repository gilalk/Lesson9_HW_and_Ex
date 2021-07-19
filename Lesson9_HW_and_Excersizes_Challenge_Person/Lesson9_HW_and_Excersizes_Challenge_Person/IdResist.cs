using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_HW_and_Excersizes_Challenge_Person
{
    class IdResist : Person
    {
        // Fields



        // Ctors



        // Abilities

        public override bool ItIsTheSamePerson(Person person)
        {
            if (person._firstName == _firstName && person._lastName == _lastName)
            {
                return true;
            }

            return false;
        }

    }
}
