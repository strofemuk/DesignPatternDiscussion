using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo.Builder
{
    /// <summary>
    /// A simple entity class to define a vehicle.
    /// </summary>
    public partial class Vehicle
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
    }
}
