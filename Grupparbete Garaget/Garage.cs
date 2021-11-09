using System;
using System.Collections.Generic;
using System.Text;

namespace Grupparbete_Garaget
{
    public class Garage
    {
        List<Bus> BusList = new List<Bus>();
        List<Truck> TruckList = new List<Truck>();
        List<Car> CarList = new List<Car>();
        List<Motorcycle> MotorcycleList = new List<Motorcycle>();
        List<Moped> MopedList = new List<Moped>();
        //List<Vehicle> VehicleList = new List<Vehicle>();

        public bool GarageOpen { get; set; }
        //public int Cash { get; set; }

        public void AddVehicles()
        {
            GarageOpen = true;
            var rand = new Random();
            string[] Colors = { "Black", "White", "Silver" };
            string[] CarOrigin = { "USA", "Germany", "Japan" };
            string[] TruckComp = { "Maserfrakt", "DHL", "Schenker" };
            string[] BusPurp = { "School", "Commercial", "Military" };
            string[] MopedHowCool = { "Gangster", "Geeky", "Danger" };
            string[] BikePurp = { "Offroad", "Trail", "Highway" };
            //string[] RegNumb = { "ABC123", "ASD051", "HTE794" };

            for (int i = 0; i < rand.Next(1, 3); i++)
            {
                Car myCars = new Car();
                myCars.VehicleColor = Colors[rand.Next(0, 2)];
                myCars.VehicleWheels = rand.Next(3, 6);
                myCars.VehicleRegNumb = rand.Next(100000, 999999);
                myCars.CarTowbar = rand.Next(0, 2) > 0;
                myCars.CarOrigin = CarOrigin[rand.Next(0, 2)];
                myCars.CarMaxSpeed = rand.Next(120, 320);
                myCars.VehicleAmmount = rand.Next(1, 5);
                CarList.Add(myCars);
            }
            for (int i = 0; i < rand.Next(1, 3); i++)
            {
                Truck myTrucks = new Truck();
                myTrucks.VehicleColor = Colors[rand.Next(0, 2)];
                myTrucks.VehicleWheels = rand.Next(4, 12);
                myTrucks.VehicleRegNumb = rand.Next(100000, 999999);
                myTrucks.TruckTrailer = rand.Next(0, 2) > 0;
                myTrucks.TruckCompany = TruckComp[rand.Next(0, 2)];
                myTrucks.TruckMaxLoad = rand.Next(4, 20);
                myTrucks.VehicleAmmount = rand.Next(1, 3);
                TruckList.Add(myTrucks);
            }
            for (int i = 0; i < rand.Next(1, 3); i++)
            {
                Bus myBus = new Bus();
                myBus.VehicleColor = Colors[rand.Next(0, 2)];
                myBus.VehicleWheels = rand.Next(4, 8);
                myBus.VehicleRegNumb = rand.Next(100000, 999999);
                myBus.BusSchool = rand.Next(0, 2) > 0;
                myBus.BusPurpose = BusPurp[rand.Next(0, 2)];
                myBus.BusCapacity = rand.Next(8, 46);
                myBus.VehicleAmmount = rand.Next(1, 3);
                BusList.Add(myBus);
            }
            for (int i = 0; i < rand.Next(1, 3); i++)
            {
                Moped myMopeds = new Moped();
                myMopeds.VehicleColor = Colors[rand.Next(0, 2)];
                myMopeds.VehicleWheels = rand.Next(1, 4);
                myMopeds.VehicleRegNumb = rand.Next(100000, 999999);
                myMopeds.MopedLegal = rand.Next(0, 2) > 0;
                myMopeds.MopedHowCool = MopedHowCool[rand.Next(0, 2)];
                myMopeds.MopedMaxSpeed = rand.Next(25, 120);
                myMopeds.VehicleAmmount = rand.Next(1, 10);
                MopedList.Add(myMopeds);
            }
            for (int i = 0; i < rand.Next(1, 3); i++)
            {
                Motorcycle myMC = new Motorcycle();
                myMC.VehicleColor = Colors[rand.Next(0, 2)];
                myMC.VehicleWheels = rand.Next(1, 4);
                myMC.VehicleRegNumb = rand.Next(100000, 999999);
                myMC.BikeStickers = rand.Next(0, 2) > 0;
                myMC.BikePurpose = BikePurp[rand.Next(0, 2)];
                myMC.BikeMaxFuel = rand.Next(4, 16);
                myMC.VehicleAmmount = rand.Next(1, 5);
                MotorcycleList.Add(myMC);
            }
        }
        public void ListTypeOfVehicles()
        {
            foreach (Car car in CarList)
            {
                Console.WriteLine("There is {0} cars in the garage.",car.VehicleAmmount);
            }
            foreach (Truck truck in TruckList)
            {
                Console.WriteLine("There is {0} trucks in the garage.",truck.VehicleAmmount);
            }
            foreach (Bus bus in BusList)
            {
                Console.WriteLine("There is {0} bus in the garage", bus.VehicleAmmount);
            }
            foreach (Moped moped in MopedList)
            {
                Console.WriteLine("There is {0} moped in the garage", moped.VehicleAmmount);
            }
            Console.WriteLine("--------------------------\n Available Motorcycles\n ");
            foreach (Motorcycle mc in MotorcycleList)
            {
                Console.WriteLine("There is {0} Motercycle in the garage", mc.VehicleAmmount);
            }
        }

        public void ListVehicles()
        {
            //Skrivs inte ut?
            Console.WriteLine("--------------------------\n Available Cars\n");
            foreach (Car car in CarList)
            {
                Console.WriteLine(" Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Towbar: \t{3}\n Origin: \t{4}\n MaxSpeed: \t{5}km/h\n"
                    , car.VehicleColor, car.VehicleWheels, car.VehicleRegNumb, car.CarTowbar, car.CarOrigin, car.CarMaxSpeed);
            }
            Console.WriteLine("--------------------------\n Available Trucks\n");
            foreach (Truck truck in TruckList)
            {
                Console.WriteLine(" Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Trailer: \t{3}\n Company: \t{4}\n MaxLoad: \t{5}ton\n"
                    , truck.VehicleColor, truck.VehicleWheels, truck.VehicleRegNumb, truck.TruckTrailer, truck.TruckCompany, truck.TruckMaxLoad);
            }
            Console.WriteLine("--------------------------\n Available Buses\n ");
            foreach (Bus bus in BusList)
            {
                Console.WriteLine(" Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Schoolbus: \t{3}\n Field: \t{4}\n Capacity: \t{5}persons\n"
                    , bus.VehicleColor, bus.VehicleWheels, bus.VehicleRegNumb, bus.BusSchool, bus.BusPurpose, bus.BusCapacity);
            }
            Console.WriteLine("--------------------------\n Available Mopeds\n ");
            foreach (Moped moped in MopedList)
            {
                Console.WriteLine(" Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Legal: \t{3}\n How Cool: \t{4}\n MaxSpeed: \t{5}km/h\n"
                    , moped.VehicleColor, moped.VehicleWheels, moped.VehicleRegNumb, moped.MopedLegal, moped.MopedHowCool, moped.MopedMaxSpeed);
            }
            Console.WriteLine("--------------------------\n Available Motorcycles\n ");
            foreach (Motorcycle mc in MotorcycleList)
            {
                Console.WriteLine(" Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Stickers: \t{3}\n Field: \t{4}\n MaxFuel: \t{5}liter\n"
                    , mc.VehicleColor, mc.VehicleWheels, mc.VehicleRegNumb, mc.BikeStickers, mc.BikePurpose, mc.BikeMaxFuel);
            }
            Console.WriteLine("--------------------------");
        }
        public Vehicle RemoveVehicle(string UserInput)
        {
            if (UserInput.Contains("car") && CarList.Count > 0)
            {
                Car tmp = CarList[0];
                //Cash += tmp.VehicleWheels;
                CarList.RemoveAt(0);
                return tmp;
            }
            else if (UserInput.Contains("truck") && TruckList.Count > 0)
            {
                Vehicle tmp = TruckList[0];
                //Cash += tmp.VehicleWheels;
                TruckList.RemoveAt(0);
                return tmp;
            }
            else if (UserInput.Contains("bus") && BusList.Count > 0)
            {
                Vehicle tmp = BusList[0];
                //Cash += tmp.VehicleWheels;
                BusList.RemoveAt(0);
                return tmp;
            }
            else if (UserInput.Contains("moped") && MopedList.Count > 0)
            {
                Vehicle tmp = MopedList[0];
                //Cash += tmp.VehicleWheels;
                MopedList.RemoveAt(0);
                return tmp;
            }
            else if (UserInput.Contains("motorcycle") && MotorcycleList.Count > 0)
            {
                Vehicle tmp = MotorcycleList[0];
                //Cash += tmp.VehicleWheels;
                MotorcycleList.RemoveAt(0);
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

    }
}
