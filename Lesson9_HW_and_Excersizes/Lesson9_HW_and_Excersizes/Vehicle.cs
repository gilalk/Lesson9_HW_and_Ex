using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_HW_and_Excersizes
{
    class Vehicle
    {
        // Fields

        public int _wheels;
        public string _color;
        public bool _roofIsOpen;

        // Ctors



        // Abilities

        public virtual void AddWheel()
        {
            if (_wheels < 4)
            {
                _wheels++;
            }
            Console.WriteLine(_wheels);
        }

        public void OpenOrCloseRoof()
        {
            if (_roofIsOpen)
            {
                _roofIsOpen = false;
            }
            else
            {
                _roofIsOpen = true;
            }
        }

    }
}
