using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Chicken
    {
        //property 
        public string Name { get; set; }

        //field
        private bool _isHungry = true;

        //default constructor - the moment you add anything to it, then it si no longer the default constructor, but a new constructor!
        //public Chicken() { } 

        //constructor
        public Chicken(string name)
        {
            Name = name;
            Console.WriteLine($"{name} got instantiated.");
        }

        //method (signature = accessibility modifier + return type + Name +({optional) parameters
        public void Peck(string typeOfFood)
        {
            if(_isHungry)
            {
                Console.WriteLine($"{Name} pecks hungrily at the {typeOfFood}.");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry.");
            }
        }


        //method overloading
        public void Peck()
        {
            Peck("Corn"); //here I am calling the original Peck method.
        }
        //now we have 2 Peck methods on the Chicken class - one that takes in a type of food and one that takes in nothing;
    }
}
