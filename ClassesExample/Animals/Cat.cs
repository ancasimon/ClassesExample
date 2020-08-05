using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExample.Animals
{
    class Cat
    {
        string _color; // a field with an implicit private accessibility modifier. 

        //public string Color { get; set; } // a property with an explicitly stated public accessibility modifier;
        //previous option was for defining a color free-text; the line below shows an example of using an enum for a list of cat colors;
        public CatColor Color { get; set; } // every time you set a color, you have to choose from the CatColor options;
        public bool IsFeral { get; set; }

        public string FavoriteFood { get; set; }

        public Chicken BestFriend { get; set; }

        public void Dye(CatColor color)
        {
            Color = color;
        }

        public void HaveASnack()
        {
            Console.WriteLine($"The {Color} cat took a bite of {BestFriend.Name}. Oops");
            BestFriend.Peck($"The {Color} cat.");
        }
    }

    enum CatColor
    {
        Orange,
        Grey,
        Black, 
        Calico, 
        Tabby,
        White
    }
}
