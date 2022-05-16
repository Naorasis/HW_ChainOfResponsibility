using System;

namespace HW_ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("sozuki", true);
            Car c2 = new Car("kia", true);
            Car c3 = new Car("bmw", false);
            Car c4 = new Car("seat", true);
            Car c5 = new Car("doodge", true);
            Car c6 = new Car("nissan", false);

            Garage gar = new Garage();
            gar.Cars.Add(c1);
            gar.Cars.Add(c2);
            gar.Cars.Add(c3);
            gar.Cars.Add(c4);
            gar.Cars.Add(c5);
            gar.Cars.Add(c6);




            Checkzone firstcheck = new FirstCheck();
            Checkzone assemblies = new assembliesInspection();
            Checkzone electrical = new ElectricalSystem();
            Checkzone diagnosis = new Diagnosis();

            firstcheck.NextCheck(assemblies);
            assemblies.NextCheck(electrical);
            electrical.NextCheck(diagnosis);
            diagnosis.NextCheck(null);


            firstcheck.CarHandle(c1);
            firstcheck.CarHandle(c2);
            firstcheck.CarHandle(c3);
            firstcheck.CarHandle(c4);
            firstcheck.CarHandle(c5);
            firstcheck.CarHandle(c6);

            

           







        }
    }
}
