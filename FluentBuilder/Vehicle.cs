using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo.FluentBuilder
{
    /// <summary>
    /// A simple entity class to define a vehicle.
    /// </summary>
    public class Vehicle
    {
        private Vehicle() { }

        public string Type { get; set; }
        public string Frame { get; set; }
        public int NumberOfCylinders { get; set; }
        public int EngineSizeInCC { get; set; }
        public int NumberOfWheels { get; set; }
        public Door Door { get; set; }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendLine("Type: " + Type);
            toString.AppendLine("Frame: " + Frame);
            toString.AppendLine("# of cylinders: " + NumberOfCylinders);
            toString.AppendLine("Engine Size: " + EngineSizeInCC + "cc");
            toString.AppendLine("# of wheels: " + NumberOfWheels);
            toString.AppendLine("# of doors: " + Door.Count);

            return toString.ToString();
        }
        public static implicit operator Vehicle(VehicleBuilder builder)
        {
            return new FluentBuilder.Vehicle
            {
                Type = builder.Type,
                Frame = builder.Frame,
                EngineSizeInCC = builder.EngineSize,
                NumberOfCylinders = builder.CylinderCount,
                NumberOfWheels = builder.WheelCount,
                Door = new Door{ Count = builder.DoorCount}
            };
        }
    }
}
