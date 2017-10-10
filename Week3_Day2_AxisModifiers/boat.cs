using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2_AxisModifiers
{
    class Boat
    {
        public int numberOfPassengers;
        private string name;
        public  double engineSize;

        public string Name
        {
            get { return name; } // could be {return this.name}
            set { name = value; } // could be {this.name = value}
        }

        public Boat()// contructor = constructs an instance =default
        {

        }
        public Boat(int numberOfPassengers, string name, double engineSize)
        {
            this.numberOfPassengers = numberOfPassengers;
            this.name = name;
            this.engineSize = engineSize;
        }

        // BELOW are methods

        public void Move() //empty, so it is not going to return anything back 
        {
            Console.WriteLine(name + " moves forward."); // method of movement
        }

        
        private double CalculateMPG()// //METHOD  can only be accessed in the BOAT class=only stuff in the class "knows" about what is inside {}
        {
            double MPG = engineSize * .7d;
            return MPG;
        }

        public void BoatInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Passengers: " + numberOfPassengers);
            Console.WriteLine("Engine size: " + engineSize);
            Console.WriteLine("MPG " + CalculateMPG());
            Console.WriteLine();
        }
    }
}
