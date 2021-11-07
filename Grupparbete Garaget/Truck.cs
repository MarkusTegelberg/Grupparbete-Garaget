using System;
using System.Collections.Generic;
using System.Text;

namespace Grupparbete_Garaget
{
    class Truck : Vehicle
    {
        public string[] TruckComp = { "Maserfrakt", "DHL", "Schenker" };
        public int TruckMaxLoad { get; set; }
        public bool TruckTrailer { get; set; }
        public string TruckCompany { get; set; }
        public Truck()
        {
            var rand = new Random();
            VehicleColor = Colors[rand.Next(0, 2)];
            VehicleWheels = 8;
            //VehicleRegNumb = rand.Next(100000, 999999);
            TruckTrailer = rand.Next(0, 2) > 0;
            TruckCompany = TruckComp[rand.Next(0, 2)];
            TruckMaxLoad = rand.Next(4, 20);
        }
        public override string GetInfo()
        {
            return string.Format("Color: \t\t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Trailer: \t{3}\n Company: \t{4}\n Maxload: \t{5}km/h\n"
                    , VehicleColor, VehicleWheels, VehicleRegNumb, TruckTrailer, TruckCompany, TruckMaxLoad);
        }
    }
}
