using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Llama
    {
        private int _numberOfJumps;
        private int _totalHeightOfJumps;

        public int Age { get; set; } //this is an auto-property
        //read-only property - set only in the constructor:
        //public string Color { get; }

        //public property with a private setter - can be set whenever but only by the class that owns the property:
        public string Color { get; set; }
        public bool Spits { get; set; }

        public Llama(int age, string color)
        {
            Age = age;
            Color = color;
        }

        //let's keep track of how many times a llama jumps and cumulatively add how high it jumps:
        public void Jump(int howHigh)
        {
            _numberOfJumps++;
            _totalHeightOfJumps += howHigh;
        }

        public void Dye(string color)
        {
            if (Age > 3)
            {
                Color = color;
            }
            else
            {
                DressUp("pajamas", "leopard");
            }
        }


        private void DressUp(string clothing, string style)
        {
            Console.WriteLine($"The {Color} llama is wearing {style} {clothing}.");
        }
    }
}
