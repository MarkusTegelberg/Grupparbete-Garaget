using System;
using System.Collections.Generic;
using System.Text;

namespace Grupparbete_Garaget
{
    class Car : Vehicle
    {
        public string[] CarOriginArray = { "USA", "Germany", "Japan" };
        public int CarMaxSpeed { get; set; }
        public bool CarTowbar { get; set; }
        public string CarOrigin { get; set; }
        public Car()
        {
            var rand = new Random();
            VehicleColor = Colors[rand.Next(0, 2)];
            VehicleWheels = 4;
            //VehicleRegNumb = rand.Next(100000, 999999);
            CarTowbar = rand.Next(0, 2) > 0;
            CarOrigin = CarOriginArray[rand.Next(0, 2)];
            CarMaxSpeed = rand.Next(120, 320);
        }
        public override string GetInfo() 
        {
            return string.Format("Available car: \n Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Towbar: \t{3}\n Origin: \t{4}\n MaxSpeed: \t{5}km/h\n"
                    , VehicleColor, VehicleWheels, VehicleRegNumb, CarTowbar, CarOrigin, CarMaxSpeed);
        }
    }
}
