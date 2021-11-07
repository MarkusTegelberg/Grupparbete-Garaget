using System;
using System.Collections.Generic;
using System.Text;

namespace Grupparbete_Garaget
{
    class Bus : Vehicle
    {
        public string[] BusPurp = { "School", "Commercial", "Military" };
        public int BusCapacity { get; set; }
        public bool BusSchool { get; set; }
        public string BusPurpose { get; set; }
        public Bus()
        {
            var rand = new Random();
            VehicleColor = Colors[rand.Next(0, 2)];
            VehicleWheels = 6;
            //VehicleRegNumb = rand.Next(100000, 999999);
            BusSchool = rand.Next(0, 2) > 0;
            BusPurpose = BusPurp[rand.Next(0, 2)];
            BusCapacity = rand.Next(8, 46);
        }
        public override string GetInfo()
        {
            return string.Format("Color: \t\t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Schoolbus: \t{3}\n Purpose: \t{4}\n Capacity: \t{5}km/h\n"
                    , VehicleColor, VehicleWheels, VehicleRegNumb, BusSchool, BusPurpose, BusCapacity);
        }
    }
}
