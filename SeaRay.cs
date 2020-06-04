using System;

namespace bt_inheritance
{
    public class SeaRay : Vehicle // Boat
    {
        public string Name { get; set; }
        public double FuelCapacity { get; set; }
        public string FuelType { get; set; }

        public double Length { get; set; }

        public SeaRay(string name)
        {
            Name = name;
        }



        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} SeaRay drives past whoooosh ");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} SeaRay turned {direction} on the Waterway. ");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} SeaRay stopped for the barge! ");
        }

        public void getDetails()
        {
            Console.WriteLine("About this Boat");
            Console.WriteLine($"This Boat Color is {MainColor}");
            Console.WriteLine($"This Boat Holds {MaximumOccupancy} people");
            Console.WriteLine($"Fuel Capacity is {FuelCapacity} gal, And Takes {FuelType} Fuel");
            Console.WriteLine($"The Length is {Length}");
        }


    }

}

