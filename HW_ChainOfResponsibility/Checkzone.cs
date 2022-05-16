using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_ChainOfResponsibility
{
    abstract class Checkzone
    {

        protected Checkzone nextCheck;
        public bool IsFixed;
        public void NextCheck(Checkzone next)
        {
            nextCheck = next;
        }
        public abstract void CarHandle(Car car);
    }
}
