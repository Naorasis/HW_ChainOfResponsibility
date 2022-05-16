using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HW_ChainOfResponsibility
{
    public  class Car
    {
        public string Modle { get; set; }
        public bool IsNeedReaper;

        public Car(string modle, bool isNeedReaper)
        {
            Modle = modle;
            IsNeedReaper = isNeedReaper;
        }

        public override string ToString()
        {
            return Modle + " " + IsNeedReaper ; 
        }
    }


}

