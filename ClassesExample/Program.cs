using ClassesExample.Animals;
using System;
//System is a namespace that Microsoft built in .NET 

//namespaces follow file structure - for example code about animals would go in: namespace ClassesExample.Animals
namespace ClassesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var chicken = new Chicken("Liza");
            var bob = new Chicken("Bob");

            chicken.Peck("corn");
            chicken.Peck("corn");
            chicken.Peck("corn");

            bob.Peck("watermelon");

            Console.WriteLine($"{chicken.Name} and {bob.Name} are chickens.");
        }
    }

    class Steve
    {

    }
}
