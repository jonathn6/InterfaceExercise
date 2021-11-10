using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var car1 = new Car();
            car1.CompanyName = "General Motors";
            car1.Motto = "company motto";
            car1.Year = "2000";
            car1.Make = "Chevy";
            car1.Model = "Corvette";
            car1.SeatCount = 2;
            car1.Convertable = true;
            car1.TrunkSize = 0;

            var truck1 = new Truck();
            truck1.CompanyName = "General Motors";
            truck1.Motto = "company motto";
            truck1.Year = "2000";
            truck1.Make = "Chevy";
            truck1.Model = "Silverado";
            truck1.SeatCount = 4;
            truck1.BedSize = 100;
            truck1.TowPackage = true;

            var suv1 = new SUV();
            suv1.CompanyName = "General Motors";
            suv1.Motto = "company motto";
            suv1.Year = "2000";
            suv1.Make = "Chevy";
            suv1.Model = "Taho";
            suv1.SeatCount = 4;
            suv1.CargoSize = 100;
            suv1.NumberOfUSPPorts = 4;

            var vehicles = new List<IVehicle>();
            vehicles.Add(car1);
            vehicles.Add(truck1);
            vehicles.Add(suv1);

            foreach (var veh in vehicles)
            {
                if (veh is Car) {
                    var tempCar = new Car();
                    tempCar = (Car)veh;
                    Console.WriteLine($"{tempCar.CompanyName}'s motto is {tempCar.Motto}");
                    Console.WriteLine($"They make the {tempCar.Year} {tempCar.Make} {tempCar.Model} with {tempCar.SeatCount} seats and {tempCar.TrunkSize} trunk space");
                    if (tempCar.Convertable)
                    {
                        Console.WriteLine("This car is perfect for anyone who loves a convertible!");
                    } else
                    {
                        Console.WriteLine("This car is not a convertible");
                    }
                } else
                {
                    if (veh is Truck)
                    {
                        var tempTruck = new Truck();
                        tempTruck = (Truck)veh;
                        Console.WriteLine($"{tempTruck.CompanyName}'s motto is {tempTruck.Motto}");
                        Console.WriteLine($"They make the {tempTruck.Year} {tempTruck.Make} {tempTruck.Model} with {tempTruck.SeatCount} seats and {tempTruck.BedSize} bed size.");
                        if (tempTruck.TowPackage)
                        {
                            Console.WriteLine("This model comes with a tow package");
                        } else
                        {
                            Console.WriteLine("This model does not come with a tow package");
                        }
                    } else
                    {
                        var tempSUV = new SUV();
                        tempSUV = (SUV)veh;
                        Console.WriteLine($"{tempSUV.CompanyName}'s motto is {tempSUV.Motto}");
                        Console.WriteLine($"They make the {tempSUV.Year} {tempSUV.Make} {tempSUV.Model} with {tempSUV.SeatCount} seats and {tempSUV.CargoSize} cargo space.");
                        Console.WriteLine($"This model is available with {tempSUV.NumberOfUSPPorts} USB ports.");
                    }
                }
            }
            
        }
    }
}
