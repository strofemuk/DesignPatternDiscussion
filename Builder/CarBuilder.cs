using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo.Builder
{
    //The builder encapsulates an algorithm for each build step.
    public class CarBuilder : Vehicle.AVehicleBuilder
    {
        public CarBuilder():base()
        {
            Vehicle.Type = "Car";
        }

        public override void BuildFrame()
        {
            Vehicle.Frame = "unibody";
        }

        public override void BuildEngine()
        {
            Vehicle.EngineSizeInCC = 2500;
            Vehicle.NumberOfCylinders = 4;
        }

        public override void BuildWheels()
        {
            Vehicle.NumberOfWheels = 4;
        }

        public override void BuildDoors()
        {
            Vehicle.Door = new Door { Count = 2 };
        }
    }
}
