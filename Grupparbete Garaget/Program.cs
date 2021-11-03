using System;

namespace Grupparbete_Garaget
{
    class Program
    {
        static void Main(string[] args)
        {
            MarkTestClass.MyMark();



            Garage myGarage = new Garage();
            /*if (UserInput == 1)
            {
                myShop.AddVehicles();

            }*/
            myGarage.AddVehicles();

            Console.WriteLine("\nWhat Vehicle do you want to extract? A Car, Truck or perhaps a Bus?\n");
            while (myGarage.GarageOpen)
            {
                myGarage.ListVehicles();
                string UserInput = Console.ReadLine().ToLower();
                Console.WriteLine();

                Vehicle VehiclePick = myGarage.RemoveVehicle(UserInput);
                if (VehiclePick != null)
                {
                    if (VehiclePick.GetType().Name == "Car")
                    {
                        Console.Clear();
                        Car tmp = (Car)VehiclePick;
                        Console.WriteLine("Drive safe!\n\n Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Towbar: \t{3}\n Origin: \t{4}\n MaxSpeed: \t{5}km/h\n " +
                            "\nWant one more vehicle? Press Enter.\nOtherwise Type \"exit\" to leave the garage!\n"
                            , VehiclePick.VehicleColor, VehiclePick.VehicleWheels, VehiclePick.VehicleRegNumb, tmp.CarTowbar, tmp.CarOrigin, tmp.CarMaxSpeed);
                        string UserAnswer = Console.ReadLine().ToLower();
                        if (UserAnswer == "exit")
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    else if (VehiclePick.GetType().Name == "Truck")
                    {
                        Console.Clear();
                        Truck tmp = (Truck)VehiclePick;
                        Console.WriteLine("Drive safe!\n\n Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Trailer: \t{3}\n MaxLoad: \t{4}ton\n Company: \t{5}\n" +
                            "\nWant one more vehicle? Press Enter.\nOtherwise Type \"exit\" to leave the garage!\n"
                            , VehiclePick.VehicleColor, VehiclePick.VehicleWheels, VehiclePick.VehicleRegNumb, tmp.TruckTrailer, tmp.TruckMaxLoad, tmp.TruckCompany);
                        string UserAnswer = Console.ReadLine().ToLower();
                        if (UserAnswer == "exit")
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    else if (VehiclePick.GetType().Name == "Bus")
                    {
                        Console.Clear();
                        Bus tmp = (Bus)VehiclePick;
                        Console.WriteLine("Drive safe!\n\n Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Schoolbus: \t{3}\n Field: \t{4}\n Capacity: \t{5}persons\n" +
                            "\nWant one more vehicle? Press Enter.\nOtherwise Type \"exit\" to leave the garage!\n"
                            , VehiclePick.VehicleColor, VehiclePick.VehicleWheels, VehiclePick.VehicleRegNumb, tmp.BusSchool, tmp.BusPurpose, tmp.BusCapacity);
                        string UserAnswer = Console.ReadLine().ToLower();
                        if (UserAnswer == "exit")
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    else if (VehiclePick.GetType().Name == "Moped")
                    {
                        Console.Clear();
                        Moped tmp = (Moped)VehiclePick;
                        Console.WriteLine("Drive safe!\n\n Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Legal: \t{3}\n How Cool: \t{4}\n Capacity: \t{5}km/h\n" +
                            "\nWant one more vehicle? Press Enter.\nOtherwise Type \"exit\" to leave the garage!\n"
                            , VehiclePick.VehicleColor, VehiclePick.VehicleWheels, VehiclePick.VehicleRegNumb, tmp.MopedLegal, tmp.MopedHowCool, tmp.MopedMaxSpeed);
                        string UserAnswer = Console.ReadLine().ToLower();
                        if (UserAnswer == "exit")
                        {
                            Console.Clear();
                            break;
                        }
                    }
                    else if (VehiclePick.GetType().Name == "Motorcycle")
                    {
                        Console.Clear();
                        Motorcycle tmp = (Motorcycle)VehiclePick;
                        Console.WriteLine("Drive safe!\n\n Color: \t{0}\n Wheels: \t{1}\n RegNumber: \t{2}\n Stickers: \t{3}\n Field: \t{4}\n MaxFuel: \t{5}liter\n" +
                            "\nWant one more vehicle? Press Enter.\nOtherwise Type \"exit\" to leave the garage!\n"
                            , VehiclePick.VehicleColor, VehiclePick.VehicleWheels, VehiclePick.VehicleRegNumb, tmp.BikeStickers, tmp.BikePurpose, tmp.BikeMaxFuel);
                        string UserAnswer = Console.ReadLine().ToLower();
                        if (UserAnswer == "exit")
                        {
                            Console.Clear();
                            break;
                        }
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("We cant find your vehicle. Want another ride? Otherwise type \"exit\" to leave the shop.");
                    string UserAnswer = Console.ReadLine().ToLower();

                    if (UserAnswer == "exit")
                    {
                        Console.Clear();
                        break;
                    }
                }
            }
            Console.WriteLine("Remeber, drive safe!");
            //Console.WriteLine("\nCash register is at :\t " + myShop.Cash + "$");
            //myGarage.AddVehicles();
            //myGarage.ListVehicles();

            Console.ReadKey();
        }
    }
}
