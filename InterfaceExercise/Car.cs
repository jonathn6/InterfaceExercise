using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public string Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int SeatCount { get; set; }
        public int TrunkSize { get; set; }
        public bool Convertable { get; set; }
        public string CompanyName { get; set; }
        public string Motto { get; set; }
    }
}
