using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Demo_w11a_MoreBindingInheritance.Classes
{
    /*
     * public - Accessible from anywhere in the project
     * private - accessible within the current class only
     * internal - accessible within the current project by same namespace
     * protected - accessible within the current class and any class that inherits from it
     */
    public abstract class Vehicle
    {
        #region Properties
        public string Vin { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int ManufactureYear { get; set; }
        public Color Colour { get; set; }

        #endregion

        #region Constructors
        public Vehicle()
        {
          
        }
        public Vehicle(string vin, string make, string model, int year, Color colour)
        {
            Vin = vin;
            Make = make;
            Model = model;
            ManufactureYear = year;
            Colour = colour;
        }
        #endregion

        public override string ToString()
        {
            return $"{Make} {Model} ({ManufactureYear})";
        }
    }
}

