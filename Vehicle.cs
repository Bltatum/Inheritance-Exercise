using System;

namespace bt_inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("This vehicle goes Vrooom!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The Vehicle turned {direction}");
        }
        public virtual void Stop()
        {
            Console.WriteLine("This vehicle stopped!");
        }




        public class Tesla : Vehicle
        {
            public double BatteryKWh { get; set; }

            public void ChargeBattery()
            {
                // method definition omitted
            }
            public override void Drive()
            {
                Console.WriteLine("MEEEEEEEEEEE");
            }




        }


        public class Cessna : Vehicle
        {
            public double FuelCapacity { get; set; }

            public void RefuelTank()
            {
                // method definition omitted
            }

            public override void Drive()
            {
                Console.WriteLine("Zoooooom!");
            }
        }

        public class Zero : Vehicle // Electric motorcycle
        {
            public double BatteryKWh { get; set; }

            public void ChargeBattery()
            {
                // method definition omitted
            }
            public override void Drive()
            {
                Console.WriteLine("SHHHHHHHHHH!");
            }
        }




    }
}