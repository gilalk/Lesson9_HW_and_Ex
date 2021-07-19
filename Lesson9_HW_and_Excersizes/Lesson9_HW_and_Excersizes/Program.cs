using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_HW_and_Excersizes
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle onlyBase = new Vehicle();
            Vehicle baseWithCar = new Car();
            Vehicle baseWithMotor = new Motorcycle();
            Car onlyCar = new Car();
            Motorcycle onlyMotor = new Motorcycle();

            onlyBase.AddWheel();
            baseWithCar.AddWheel();
            baseWithMotor.AddWheel();
            onlyCar.AddWheel();
            onlyMotor.AddWheel();

            onlyBase.OpenOrCloseRoof();
            baseWithCar.OpenOrCloseRoof();
            baseWithMotor.OpenOrCloseRoof();
            onlyCar.OpenOrCloseRoof();
            onlyMotor.OpenOrCloseRoof();
        }

    }
}
