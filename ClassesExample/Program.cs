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


            var llama = new Llama(3, "brown");
            //llama.Color = "Teal"; //once a property is a getter/read-only, you cannot change the value. 
            llama.Dye("Blue");
            //llama.DressUp(); //cannot call a private method!


            //var cat = new Cat();
            //cat.Color = CatColor.Tabby;
            //cat.BestFriend = bob; //bob is the chicken variable we created earlier

            //with object initializer - you can only use it at the point of creation of an object / any required fields still have to go inside the parentheses!!!:
            var cat = new Cat()
            {
                IsFeral = true,
                Color = CatColor.Tabby,
                BestFriend = bob
            };

            cat.HaveASnack();

            Console.WriteLine($"The cat is {cat.Color}.");

        }
    }

}
