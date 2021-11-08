using System;
using System.Collections.Generic;
using System.Text;

namespace Grupparbete_Garaget
{
    class Moped : Vehicle
    {
        public string[] MopedHowCoolArray = { "Gangster", "Geeky", "Danger" };
        public int MopedMaxSpeed { get; set; }
        public bool MopedLegal { get; set; }
        public string MopedHowCool { get; set; }
        public Moped()
        {
            var rand = new Random();
            VehicleColor = Colors[rand.Next(0, 2)];
            VehicleWheels = 2;
            //VehicleRegNumb = rand.Next(100000, 999999);
            MopedLegal = rand.Next(0, 2) > 0;
            MopedHowCool = MopedHowCoolArray[rand.Next(0, 2)];
            MopedMaxSpeed = rand.Next(25, 120);
        }
        public override string GetInfo()
        {
            return string.Format("Available Moped: \n Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Legal: \t{3}\n How cool: \t{4}\n MaxSpeed: \t{5}km/h\n"
                    , VehicleColor, VehicleWheels, VehicleRegNumb, MopedLegal, MopedHowCool, MopedMaxSpeed);
        }
    }
}
