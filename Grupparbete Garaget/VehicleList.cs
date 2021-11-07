using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Grupparbete_Garaget
{
    /*// Collection of Vehicle objects. This class
    // implements IEnumerable so that it can be used
    // with ForEach syntax.
    public class VehicleList : IEnumerable
    {
        private Vehicle[] _vehicle;
        private Vehicle[] vehicleArray;

        public int Count() { return _vehicle.Length; }


        public VehicleList(Garage[] Varray)
        {
            _vehicle = new Garage[Varray.Length];

            for (int i = 0; i < Varray.Length; i++)
            {
                _vehicle[i] = Varray[i];
            }
        }

        public VehicleList(Vehicle[] vehicleArray)
        {
            this.vehicleArray = vehicleArray;
        }

        // Implementation for the GetEnumerator method.
        

        internal static void Add(Vehicle myCars)
        {
            throw new NotImplementedException();
        }
        public Vehicle RemoveVehicle(string UserInput)
        {
            if (UserInput.Contains("car") && VehicleList.Count > 0)
            {
                Car tmp = (Car)VehicleList[0];
                //Cash += tmp.VehicleWheels;
                Vehiclelist.RemoveAt(0);
                return tmp;
            }
            else if (UserInput.Contains("truck") && Vehiclelist.Count() > 0)
            {
                Vehicle tmp = (Truck)VehicleList[0];
                //Cash += tmp.VehicleWheels;
                VehicleList.RemoveAt(0);
                return tmp;
            }
            else if (UserInput.Contains("bus") && Vehiclelist.Count() > 0)
            {
                Vehicle tmp = (Bus)VehicleList[0];
                //Cash += tmp.VehicleWheels;
                VehicleList.RemoveAt(0);
                return tmp;
            }
            else if (UserInput.Contains("moped") && Vehiclelist.Count() > 0)
            {
                Vehicle tmp = (Moped)VehicleList[0];
                //Cash += tmp.VehicleWheels;
                VehicleList.RemoveAt(0);
                return tmp;
            }
            else if (UserInput.Contains("motorcycle") && Vehiclelist.Count() > 0)
            {
                Vehicle tmp = (Motorcycle)VehicleList[0];
                //Cash += tmp.VehicleWheels;
                VehicleList.RemoveAt(0);
                return tmp;
            }
            else if (UserInput.Contains("exit"))
            {
                GarageOpen = false;
                return null;
            }
            else
            {
                return null;
            }
        }
    }*/

    
}
