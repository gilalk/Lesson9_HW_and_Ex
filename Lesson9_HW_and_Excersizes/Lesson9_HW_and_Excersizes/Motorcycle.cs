using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_HW_and_Excersizes
{
    class Motorcycle : Vehicle
    {
        // Fields



        // Ctors



        // Abilities

        public override void AddWheel()
        {
            if (_wheels < 2)
            {
                _wheels++;
            }
        }

        new public void OpenOrCloseRoof()
        {
            Console.WriteLine("In Motorcycle, Roof Is Always Open");
        }

    }
}
