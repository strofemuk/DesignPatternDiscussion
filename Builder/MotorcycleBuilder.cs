using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo.Builder
{
    public class MotorcycleBuilder : Vehicle.AVehicleBuilder
    {
        public MotorcycleBuilder()
            : base()
        {
            Vehicle.Type = "Motorcycle";
        }

        public override void BuildFrame()
        {
            Vehicle.Frame = "tubular motorocycle frame";
        }

        public override void BuildEngine()
        {
            Vehicle.EngineSizeInCC = 500;
            Vehicle.NumberOfCylinders = 2;
        }

        public override void BuildWheels()
        {
            Vehicle.NumberOfWheels = 2;
        }

        public override void BuildDoors()
        {
            Vehicle.Door = new Door { Count = 0 };
        }
    }
}
