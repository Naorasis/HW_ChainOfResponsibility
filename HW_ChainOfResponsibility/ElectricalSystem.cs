using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ChainOfResponsibility
{
    internal class ElectricalSystem : Checkzone
    {
        public override void CarHandle(Car car)
        {
            Random random = new Random();
            int testpoint = random.Next(1, 11);
            if (testpoint >= 6)
            {
                Console.WriteLine($"{car.Modle} You passed the Electrical test , You are going to the next test");
                if (nextCheck != null)
                    nextCheck.CarHandle(car);
                else
                    Console.WriteLine("The tset is over");
                car.IsNeedReaper = true;

            }
            else
            {
                Console.WriteLine($"{ car.Modle} we got the problem and fixd it");
                car.IsNeedReaper = false;

            }
        }
    }
}
