using System;

namespace bt_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SeaRay express215 = new SeaRay("Off the Glock")
            {
                MainColor = "White",
                FuelType = "Marine Grade",
                FuelCapacity = 50,
                MaximumOccupancy = 8,
                Length = 21.5
            };
            express215.Drive();
            express215.Turn("right");
            express215.Stop();
            express215.getDetails();
        }





    }

}

