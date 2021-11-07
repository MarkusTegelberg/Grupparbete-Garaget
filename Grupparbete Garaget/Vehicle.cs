using System;
using System.Collections;
using System.Text;

namespace Grupparbete_Garaget
{
    public class Vehicle 
    {
        public Vehicle()
        {
            var rand = new Random();
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string regnmr = chars[rand.Next(0, chars.Length)].ToString() + chars[rand.Next(0, chars.Length)].ToString() + chars[rand.Next(0, chars.Length)].ToString() + rand.Next(0, 9) + rand.Next(0, 9) + rand.Next(0, 9);
            VehicleRegNumb = regnmr;
        }
        public string[] Colors = { "Black", "White", "Silver" };
        public int VehicleWheels { get; set; }
        public string VehicleRegNumb { get; set; }
        public string VehicleColor { get; set; }

        public virtual string GetInfo() 
        {
            return null;
        }
    }

}

