using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public string Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int SeatCount { get; set; }
        public int BedSize { get; set; }
        public bool TowPackage { get; set; }
        public string CompanyName { get; set; }
        public string Motto { get; set; }
    }
}
