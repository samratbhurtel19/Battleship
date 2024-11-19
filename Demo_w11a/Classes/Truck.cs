using Demo_w11a_MoreBindingInheritance.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_w11a.Classes
{
    public class Truck : Vehicle
    {
        List<Truck> trucks = new List<Truck>();
        public string EngineSize { get; set; }
        public int NumAxles { get; set; }
        public int TowingCapacity { get; set; }


        public Truck()
        {
        }
        public Truck (string vin, string make, string model, int year, string engineSize, int numAxles, int towingCapacity)
            : base()
        {
            EngineSize = engineSize;
            NumAxles = numAxles;
            TowingCapacity = towingCapacity;
        }
    }
}
