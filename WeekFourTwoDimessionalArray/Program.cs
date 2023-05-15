
// 4.6 Using multidimensional arrays
// Write a complete program that uses a rectangular, two-dimensional array to hold rent values (as per the previous table),
// allowing the user to enter the floor and number of bedrooms, then display the rent. Once you've attempted this in Visual Studio, select Answer.

class Program
{
    static void Main()
    {

        int[,] rents = {    
            {400, 450, 510},

            {500, 560, 630},

            {625, 676, 740},

            {1000, 1250, 1600}

        };

        int floor, bedrooms;

        Console.WriteLine("Enter your floor number below: ");
        floor = Convert.ToInt32 (Console.ReadLine());

        Console.WriteLine("Enter the number of bedrooms below: ");
        bedrooms = Convert.ToInt32 (Console.ReadLine());


        Console.WriteLine("For a floor number {0} and {1} number of bedrooms, the rent is: ${2}", floor, bedrooms, rents[floor, bedrooms]);

    }
}