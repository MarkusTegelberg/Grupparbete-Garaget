using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Grupparbete_Garaget
{
    public class Garage<T> : IEnumerable where T: Vehicle
    {
        //List<Vehicle> VehicleList = new List<Vehicle>();
        Vehicle[] VehicleArray;

        public GarageEnum GetEnumerator()
        {
            return new GarageEnum(VehicleArray);
        }

        public Garage(int MaxInput)
        {
            VehicleArray = new Vehicle[0];
            max = MaxInput;
        }
        int max = 15;
        public void Add(Vehicle v)
        {
            if (VehicleArray.Length > max - 1)
            {
                Console.WriteLine("Garage full, car was thrown out");
                return;
            }
            Vehicle[] tmp = new T[VehicleArray.Length + 1];
            VehicleArray.CopyTo(tmp, 0);
            tmp[VehicleArray.Length] = v;
            VehicleArray = tmp;
        }
        public void AddVehicles()
        {
            var rand = new Random();

            for (int i = 0; i < rand.Next(1, 3); i++)
            {
                Car myCars = new Car();
                Add(myCars);
            }
            for (int i = 0; i < rand.Next(1, 3); i++)
            {
                Truck myTrucks = new Truck();                
                Add(myTrucks);
            }
            for (int i = 0; i < rand.Next(1, 3); i++)
            {
                Bus myBus = new Bus();
                Add(myBus);
            }
            for (int i = 0; i < rand.Next(1, 3); i++)
            {
                Moped myMopeds = new Moped();
                Add(myMopeds);
            }
            for (int i = 0; i < rand.Next(1, 3); i++)
            {
                Motorcycle myMC = new Motorcycle();
                Add(myMC);
            }
        }  
        public void RemoveVehicle(Vehicle v) 
        {
            for (int i = 0; i < VehicleArray.Length; i++)
            {
                if (VehicleArray[i] == v)
                {
                    List < Vehicle > RemoveVehicle = new List<Vehicle>(VehicleArray);
                    RemoveVehicle.Remove(v);
                    VehicleArray = RemoveVehicle.ToArray();
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
    }
    // When you implement IEnumerable, you must also implement IEnumerator.
    public class GarageEnum : IEnumerator
    {
        public Vehicle[] _vehicle;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;

        public GarageEnum(Vehicle[] list)
        {
            _vehicle = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _vehicle.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Vehicle Current
        {
            get
            {
                try
                {
                    return _vehicle[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
