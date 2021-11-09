using System;

namespace ShowRoom
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] car = { "ABC123", "MAS234", "DEF123", "DOF345" };

            //Console.WriteLine(car[0]);

            Console.WriteLine("Take values from String Array :2D");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 6; j++)
                {

                    Console.Write(car[i][j]);
                }
                Console.WriteLine();
            }

            //By using For each Loop

            foreach (string a in car)
            {
                Console.WriteLine(a);
            }

            int count;
            string ch;

            do
            {
                Console.WriteLine("Enter the Vechile Reg Num:");
                ch = Console.ReadLine();
                ch = ch.ToUpper();
            
                count = ch.Length;
                // To check the length of RegNr to be searched
                if (!(count == 6))
                {

                    Console.WriteLine("Reg Nr contain 6 charaters.First 3 charaters and Last 3 digits:  ");
                }

            } while (!(count == 6));


            int ii = 0;
            int s = 0;

            do
            {
                if (ch == car[ii])
                {

                    s = ii;
                }

                ii++;

            } while (ii < car.Length);


            if (ch == car[s])

            {
                Console.WriteLine("{0} Vechile is Found: ",ch);
            }

            else
            {
                Console.WriteLine("{0} No Vechile is Found:",ch);

            }
        
            
            
            /*
            string str = "Amit$#%";
         char[] one = str.ToCharArray();
         char[] two = new char[one.Length];
         int c = 0;
         for (int i = 0; i < one.Length; i++) {
            if (!Char.IsLetterOrDigit(one[i])) {
               two[c] = one[i];
               c++;
            }
         }
         Array.Resize(ref two, c);
         Console.WriteLine("Following are the special characters:");
         foreach(var items in two) {
            Console.WriteLine(items);
         }


            */



            Console.ReadLine();
        }
    }
}
