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

        //default constructor - the moment you add anythign to it, then it si no longer the default constructor, but a new constructor!
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
    }
}
