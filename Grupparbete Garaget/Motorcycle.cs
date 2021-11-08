using System;
using System.Collections.Generic;
using System.Text;

namespace Grupparbete_Garaget
{
    class Motorcycle : Vehicle
    {
        public string[] BikePurp = { "Offroad", "Trail", "Highway" };
        public int BikeMaxFuel { get; set; }
        public bool BikeStickers { get; set; }
        public string BikePurpose { get; set; }
        public Motorcycle()
        {
            var rand = new Random();
            VehicleColor = Colors[rand.Next(0, 2)];
            VehicleWheels = 3;
            //VehicleRegNumb = rand.Next(100000, 999999);
            BikeStickers = rand.Next(0, 2) > 0;
            BikePurpose = BikePurp[rand.Next(0, 2)];
            BikeMaxFuel = rand.Next(4, 16);
        }
        public override string GetInfo()
        {
            return string.Format("Available MC: \n Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Stickers: \t{3}\n How Purpose: \t{4}\n Capacity: \t{5}liter\n"
                    , VehicleColor, VehicleWheels, VehicleRegNumb, BikeStickers, BikePurpose, BikeMaxFuel);
        }
    }
}
