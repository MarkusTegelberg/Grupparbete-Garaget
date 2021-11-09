using System;
using System.Globalization;

namespace Grupparbete_Garaget
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TextInfo TextInfo = CultureInfo.CurrentCulture.TextInfo;
                Console.WriteLine("Set Capacity of garage:");
                int MaxInput = Convert.ToInt32(Console.ReadLine());
                Garage<Vehicle> myGarage = new Garage<Vehicle>(MaxInput);

                myGarage.AddVehicles();
                bool Leave = false;
                while (Leave == false)
                {
                    Console.WriteLine("Do you want to Extract or park your vehicle? E/P");
                    string myInput = Console.ReadLine();

                    if (myInput.ToLower() == "e" || myInput.ToLower() == "extract")
                    {
                        Console.WriteLine();
                        Console.WriteLine("----------------------------------------------------");
                        Console.WriteLine("Find a vehicle in the garage by adding a parameter.");
                        Console.WriteLine("Press 1. To find and extract with a registration number.");
                        Console.WriteLine("Press 2. To find all with colour.");
                        Console.WriteLine("Press 3. To find all with a specified number of wheels.");
                        Console.WriteLine("Press 4. To find all with a specific vehicle type");
                        Console.WriteLine("Press 5. To show amount of each vehicle type");
                        Console.WriteLine("Press 6. Show all vehicles");
                        Console.WriteLine("Press 0. Exit the finding!");

                        int myInt = int.Parse(Console.ReadLine());
                        if (myInt != 1)
                        {
                            Console.Clear();
                        }
                        switch (myInt)
                        {
                            case 1:
                                Console.WriteLine("Input the <registration number> of your vehicle that you are looking after");
                                Console.WriteLine("Example of how a registration number could look: ABC123");
                                Console.Write("Input reg number: ");
                                string UserInput = Console.ReadLine();
                                SearchVehicle(myGarage, UserInput, myInt);
                                //Call the search method
                                break;

                            case 2:
                                Console.WriteLine("Input the <colour> of your vehicle that you are looking after");
                                Console.WriteLine("Example on a colour: white");
                                Console.Write("Input colour: ");
                                UserInput = Console.ReadLine();
                                Console.Clear();
                                SearchVehicle(myGarage, UserInput, myInt);
                                //Call the search method
                                break;

                            case 3:
                                Console.WriteLine("Input the amount of <wheels> your vehicle that you are looking for have");
                                Console.WriteLine("Example on how to input amount of wheels: 4");
                                Console.Write("Input wheels: ");
                                UserInput = Console.ReadLine();
                                SearchVehicle(myGarage, UserInput, myInt);
                                //Call the search method
                                break;

                            case 4:
                                Console.WriteLine("Input the vehicle type that you are looking after");
                                Console.WriteLine("Example on a type: car");
                                Console.Write("Input vehicle: ");
                                UserInput = Console.ReadLine();
                                SearchVehicle(myGarage, UserInput, myInt);
                                //Call the search method
                                break;

                            case 5:
                                ListTypeOfVehicles(myGarage);
                                break;

                            case 6:
                                ListVehicle(myGarage);
                                break;

                            default:
                                Leave = true;
                                Console.WriteLine("Thank you come again!");
                                //Call the close method
                                break;
                        }
                    }
                    else if (myInput.ToLower() == "p" || myInput.ToLower() == "park")
                    {
                        Console.WriteLine("What type of vehicle do you want to park?");
                        string UserInput = Console.ReadLine().ToLower();
                        string[] UserSpecs = new string[5];
                        string[] Specs = new string[5];
                        switch (UserInput)
                        {
                            case "car":
                                Console.WriteLine();
                                Console.WriteLine("Input car specs:");
                                UserSpecs = new string[5];
                                Specs = new string[5] { "MaxSpeed  ", "Origin ", "Color  ", "Regnumber", "Wheels " };
                                for (int i = 0; i < UserSpecs.Length; i++)
                                {
                                    Console.Write(Specs[i] + " :\t");
                                    UserSpecs[i] = Console.ReadLine();
                                }
                                Car newCar = new Car();
                                newCar.CarMaxSpeed = Convert.ToInt32(UserSpecs[0]);
                                newCar.CarOrigin = TextInfo.ToTitleCase(UserSpecs[1]);
                                newCar.CarTowbar = true;
                                newCar.VehicleColor = TextInfo.ToTitleCase(UserSpecs[2]);
                                newCar.VehicleRegNumb = UserSpecs[3].ToUpper();
                                newCar.VehicleWheels = Convert.ToInt32(UserSpecs[4]);
                                myGarage.Add(newCar);
                                break;

                            case "truck":
                                Console.WriteLine();
                                Console.WriteLine("Input truck specs:");
                                UserSpecs = new string[5];
                                Specs = new string[5] { "Wheels  ", "Color ", "Company  ", "Regnumber", "MaxLoad " };
                                for (int i = 0; i < UserSpecs.Length; i++)
                                {
                                    Console.Write(Specs[i] + " :\t");
                                    UserSpecs[i] = Console.ReadLine();
                                }
                                Truck newTruck = new Truck();
                                newTruck.VehicleWheels = Convert.ToInt32(UserSpecs[0]);
                                newTruck.VehicleColor = TextInfo.ToTitleCase(UserSpecs[1]);
                                newTruck.TruckTrailer = true;
                                newTruck.TruckCompany = TextInfo.ToTitleCase(UserSpecs[2]);
                                newTruck.VehicleRegNumb = UserSpecs[3].ToUpper();
                                newTruck.TruckMaxLoad = Convert.ToInt32(UserSpecs[4]);
                                myGarage.Add(newTruck);
                                break;
                            case "bus":
                                Console.WriteLine();
                                Console.WriteLine("Input bus specs:");
                                UserSpecs = new string[5];
                                Specs = new string[5] { "Wheels  ", "Color ", "Purpose  ", "Regnumber", "Capacity " };
                                for (int i = 0; i < UserSpecs.Length; i++)
                                {
                                    Console.Write(Specs[i] + " :\t");
                                    UserSpecs[i] = Console.ReadLine();
                                }
                                Bus newBus = new Bus();
                                newBus.VehicleWheels = Convert.ToInt32(UserSpecs[0]);
                                newBus.VehicleColor = TextInfo.ToTitleCase(UserSpecs[1]);
                                newBus.BusSchool = true;
                                newBus.BusPurpose = TextInfo.ToTitleCase(UserSpecs[2]);
                                newBus.VehicleRegNumb = UserSpecs[3].ToUpper();
                                newBus.BusCapacity = Convert.ToInt32(UserSpecs[4]);
                                myGarage.Add(newBus);
                                break;
                            case "moped":
                                Console.WriteLine();
                                Console.WriteLine("Input moped specs:");
                                UserSpecs = new string[5];
                                Specs = new string[5] { "Wheels  ", "Color ", "HowCool  ", "Regnumber", "MaxSpeed" };
                                for (int i = 0; i < UserSpecs.Length; i++)
                                {
                                    Console.Write(Specs[i] + " :\t");
                                    UserSpecs[i] = Console.ReadLine();
                                }
                                Moped newmoped = new Moped();
                                newmoped.VehicleWheels = Convert.ToInt32(UserSpecs[0]);
                                newmoped.VehicleColor = TextInfo.ToTitleCase(UserSpecs[1]);
                                newmoped.MopedLegal = true;
                                newmoped.MopedHowCool = TextInfo.ToTitleCase(UserSpecs[2]);
                                newmoped.VehicleRegNumb = UserSpecs[3].ToUpper();
                                newmoped.MopedMaxSpeed = Convert.ToInt32(UserSpecs[4]);
                                myGarage.Add(newmoped);
                                break;
                            case "motorcycle":
                                Console.WriteLine();
                                Console.WriteLine("Input motorcycle specs:");
                                UserSpecs = new string[5];
                                Specs = new string[5] { "Wheels  ", "Color ", "Purpose  ", "Regnumber", "MaxFuel" };
                                for (int i = 0; i < UserSpecs.Length; i++)
                                {
                                    Console.Write(Specs[i] + " :\t");
                                    UserSpecs[i] = Console.ReadLine();
                                }
                                Motorcycle newmotorcycle = new Motorcycle();
                                newmotorcycle.VehicleWheels = Convert.ToInt32(UserSpecs[0]);
                                newmotorcycle.VehicleColor = TextInfo.ToTitleCase(UserSpecs[1]);
                                newmotorcycle.BikeStickers = true;
                                newmotorcycle.BikePurpose = TextInfo.ToTitleCase(UserSpecs[2]);
                                newmotorcycle.VehicleRegNumb = UserSpecs[3].ToUpper();
                                newmotorcycle.BikeMaxFuel = Convert.ToInt32(UserSpecs[4]);
                                myGarage.Add(newmotorcycle);
                                break;
                            default:
                                Console.WriteLine("We dont accept that type of vehicle.");
                                break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                static void ListVehicle(Garage<Vehicle> myGarage)
                {
                    foreach (Vehicle item in myGarage)
                    {
                        Console.WriteLine(item.GetInfo());
                    }
                }
                static void ListTypeOfVehicles(Garage<Vehicle> myGarage)
                {
                    Console.WriteLine("Vehicles in garage");
                    int Cars = 0;
                    int Trucks = 0;
                    int Buses = 0;
                    int Mopeds = 0;
                    int Motorcycles = 0;
                    foreach (Vehicle item in myGarage)
                    {
                        switch (item.GetType().Name)
                        {
                            case "Car":
                                Cars += 1;
                                break;
                            case "Truck":
                                Trucks += 1;
                                break;
                            case "Bus":
                                Buses += 1;
                                break;
                            case "Moped":
                                Mopeds += 1;
                                break;
                            case "Motorcycle":
                                Motorcycles += 1;
                                break;
                            default:
                                break;
                        }
                    }
                    Console.WriteLine("Number of Cars :\t" + Cars);
                    Console.WriteLine("Number of Trucks :\t" + Trucks);
                    Console.WriteLine("Number of Buses :\t" + Buses);
                    Console.WriteLine("Number of Mopeds :\t" + Mopeds);
                    Console.WriteLine("Number of Motorcycles :\t" + Motorcycles);
                }
                static void SearchVehicle(Garage<Vehicle> myGarage, string UserInput, int Option)
                {
                    //Garage<Vehicle> tmpGarage = new Garage<Vehicle>(100);
                    bool VehicleFound = false;
                    foreach (Vehicle item in myGarage)
                    {
                        switch (Option)
                        {
                            case 1:
                                if (item != null && item.VehicleRegNumb.ToUpper() == UserInput.ToUpper())
                                {
                                    VehicleFound = true;
                                    ExtractVehicle(myGarage, item);
                                }
                                break;
                            case 2:
                                if (item != null && item.VehicleColor.ToUpper() == UserInput.ToUpper())
                                {
                                    VehicleFound = true;
                                    Console.WriteLine(item.GetInfo());
                                    //tmpGarage.Add(item);
                                    continue;
                                }
                                //Color
                                break;
                            case 3:
                                if (item != null && item.VehicleWheels == Convert.ToInt32(UserInput))
                                {
                                    VehicleFound = true;
                                    Console.WriteLine(item.GetInfo());
                                    //tmpGarage.Add(item);
                                    continue;
                                }
                                //wheels
                                break;
                            case 4:
                                if (item != null && item.GetType().Name.ToUpper() == UserInput.ToUpper())
                                {
                                    VehicleFound = true;
                                    Console.WriteLine(item.GetInfo());
                                    //tmpGarage.Add(item);
                                    continue;
                                }
                                //vehicle type
                                break;

                            default:
                                break;
                        }

                    }
                    if (VehicleFound == false)
                    {
                        Console.WriteLine("The vehicle was not found!");
                    }
                }
                static void ExtractVehicle(Garage<Vehicle> myGarage, Vehicle item)
                {
                    Console.Clear();
                    Console.WriteLine("The vehicle was found :");
                    Console.WriteLine(item.GetInfo());
                    Console.WriteLine();
                    Console.WriteLine("Would you like to extract this vehicle? Y/N");
                    string UserInput = Console.ReadLine();
                    if (UserInput.ToUpper() == "Y")
                    {
                        myGarage.RemoveVehicle(item);
                        Console.WriteLine("Drive safe!");
                        Console.WriteLine();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong.");
            }
        }
    }
}