using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2_AxisModifiers
{
    class Program
    {
        static void Main(string[] args) // create variable "boat," name it and then give it a value "new"
        {
            Boat boaty = new Boat(3, "Boaty", 18.6);   //what constructor do we want to use?
            boaty.Move();
            boaty.BoatInfo();

            Boat boat2 = new Boat(14, "Boat 2", 30.8);
            boat2.BoatInfo();
        }
    }
}
