using System;
using HerosLib;

namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region default constructor
            #endregion
            #region Parametrized constructor
            //Hero obj1=new Hero(2, "Narco");
               // Console.WriteLine($"{obj1.id} {obj1.name}");
            /*
            Hero obj=new Hero();
            Console.WriteLine($"{obj.id} {obj.name}");
            */
            #endregion
            #region Access via Properties
            /*Console.WriteLine(obj1.Id);
            obj1.Id=3;
            Console.Write($"New Id = {obj1.Id}"); // write into a property
            */
            #endregion
            #region Accessing 1-D Arrays
            Hero obj = new Hero();
            
            Console.Write("Please enter your heros id: ");
            obj.Id=Int32.Parse(Console.ReadLine());
            Console.Write("Please enter your Superhero name: ");
            obj.Name=Console.ReadLine();
            Console.Write("Enter the first Power: ");
            obj.superPowers[0]=Console.ReadLine();
            Console.Write($"{obj.Id} {obj.Name}  {obj.superPowers[0]}");
            
            /*
            //Jagged Arrays
            obj.ja[0] = new int[2]; //  first column
            obj.ja[1] = new int[3]; // second column
            obj.ja[2] = new int[1]; // third column
            obj.ja[0][0]=10;
            obj.ja[1][2]=15;
            int[,] td = new int[2,4]; //Create a 2D Array
            Console.WriteLine($"Rank of 2D Array: {td.Rank}");
            Console.WriteLine($"Length of 2D Array: {td.Length}");

            Console.WriteLine($"Rank of Jagged Array: {obj.ja.Rank}"); // rank is the dimension of the array
            Console.WriteLine($"Length of Jagged Array: {obj.ja.Length}"); // Elements of the array

            // loop through the jagged array

            foreach (var rows in obj.ja) // looping through all rows
            {
                // looping through all columns of every row
                for(int i=0; i < rows.Length; i++)
                {
                    Console.Write($"{rows[i]} ");
                }
                Console.WriteLine();
            }
            */
            #endregion
        }
    }
}
