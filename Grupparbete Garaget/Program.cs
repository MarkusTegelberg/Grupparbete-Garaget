using System;
using System.Globalization;

//Markus Gren

namespace Grupparbete_Garaget
{
    class Program
    {
        static void Main(string[] args)
        {
            TextInfo TextInfo = CultureInfo.CurrentCulture.TextInfo;
            Console.WriteLine("Set Capacity of garage:");
            int MaxInput = Convert.ToInt32(Console.ReadLine());
            Garage<Vehicle> myGarage = new Garage<Vehicle>(MaxInput);
            myGarage.AddVehicles();
            while (true)
            {
                Console.WriteLine("Are you looking for a Vehicle? Y/N");
                string myInput = Console.ReadLine();
                //ListTypeOfVehicles(myGarage);
                //myInput = Console.ReadLine();

                //Skapa ny bil !!!!!FIXA MENY GREJ SNYGGA TILL!!!!!
                Console.WriteLine();
                Console.WriteLine("Input car specs:");
                string[] UserSpecs = new string[5];
                string[] Specs = new string[5] { "Speed  ", "Origin ", "Color  ", "Regnumber", "Wheels " };
                
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

                if (myInput.ToLower() == "y" || myInput.ToLower() == "yes")
                {
                    Console.WriteLine();
                    ListVehicle(myGarage);
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Find a vehicle in the garage by adding a parameter.");
                    Console.WriteLine("Press 1. To find with a registration number.");
                    Console.WriteLine("Press 2. To find all with colour.");
                    Console.WriteLine("Press 3. To find all with a specified number of wheels.");
                    Console.WriteLine("Press 4. To find all with a minimum number of passengers.");
                    Console.WriteLine("Press 5. To find all with cabriolet");
                    Console.WriteLine("Press 0. Exit the finding!");

                    int myInt = int.Parse(Console.ReadLine());                

                    switch (myInt)
                    {
                        case 1:
                            Console.WriteLine("Input the <registration number> of your vehicle that you are looking after");
                            Console.WriteLine("Example of how a registration number could look: abc-123");
                            Console.Write("Input reg number: ");
                            string UserInput = Console.ReadLine();
                            SearchVehicle(myGarage, UserInput, myInt);
                            //Call the search method

                            break;
                        case 2:
                            Console.WriteLine("Input the <colour> of your vehicle that you are looking after");
                            Console.WriteLine("Example on a colour: white");
                            Console.Write("Input colour: ");
                            string myColour = Console.ReadLine();
                            //Call the search method

                            break;
                        case 3:
                            Console.WriteLine("Input the amount of <wheels> your vehicle that you are looking for have");
                            Console.WriteLine("Example on how to input amount of wheels: 4");
                            Console.Write("Input wheels: ");
                            int wheelNum = int.Parse(Console.ReadLine());
                            //Call the search method

                            break;
                        case 4:
                            Console.WriteLine("Input the minimum amount of passangers that you are looking for in your vehicle");
                            Console.WriteLine("Example on how to input min amount of passangers: 4");
                            Console.Write("Input passangers: ");
                            int minNumPas = int.Parse(Console.ReadLine());
                            //Call the search method

                            break;
                        case 5:
                            Console.WriteLine("Are you looking for a car with a cabriolet Y/N?");
                            Console.Write("Input yes or no: ");
                            string cabriolet = Console.ReadLine();
                            //Call the search method

                            break;
                        default:
                            Console.WriteLine("Just add the close method, easy");
                            //Call the close method

                            break;
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("bye bye");
            Console.WriteLine("some changes");
            //sakld
            Console.WriteLine("hello");

            static void ListVehicle(Garage<Vehicle>myGarage)
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
                bool VehicleFound = false;
                foreach (Vehicle item in myGarage)
                {
                    switch (Option)
                    {
                        case 1:
                            if (item != null && item.VehicleRegNumb.ToUpper() == UserInput.ToUpper())
                            {
                                VehicleFound = true;
                                item.VehicleRegNumb = UserInput;
                                Console.Clear();
                                Console.WriteLine("The vehicle was found :");
                                Console.WriteLine(item.GetInfo());
                                Console.WriteLine();
                                Console.WriteLine("Would you like to extract this vehicle? Y/N");
                                UserInput = Console.ReadLine();

                                if (UserInput.ToUpper() == "Y")
                                {
                                    myGarage.RemoveVehicle(item);
                                    Console.WriteLine("Drive safe!");
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                        case 2:
                            //Color
                            break;
                        case 3:
                            //wheels
                            break;
                        case 4:
                            //passengers
                            break;
                        case 5:
                            //cabriolet
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
        }
    }
}
