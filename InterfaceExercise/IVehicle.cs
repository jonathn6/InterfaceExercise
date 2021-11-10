using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public string Year { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public int SeatCount { get; set; }

    }
}
