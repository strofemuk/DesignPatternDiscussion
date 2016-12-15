using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo
{
    /// <summary>
    /// A simple entity class to define a vehicle complete with overloaded constructors.
    /// </summary>
    public class Vehicle
    {
        public Vehicle() { }

        public Vehicle(string type)
        {
            Type = type;
        }

        public Vehicle(string type, string frame)
            : this(type)
        {
            Frame = frame;
        }

        public Vehicle(string type, string frame, int numberOfCylinders)
            : this(type, frame)
        {
            NumberOfCylinders = numberOfCylinders;
        }

        public Vehicle(string type, string frame, int numberofCylinders, int engineSizeInCC)
            : this(type, frame, numberofCylinders)
        {
            EngineSizeInCC = engineSizeInCC;
        }

        public Vehicle(string type, string frame, int numberOfCylinders, int engineSizeInCC, int numberOfWheels) : this(type,frame,numberOfCylinders,engineSizeInCC)
        {
            NumberOfWheels = numberOfWheels;
        }

        public Vehicle(string type, string frame, int numberOfCylinders, int engineSizeInCC, int numberOfWheels, int numberOfDoors)
            : this(type, frame, numberOfCylinders, engineSizeInCC, numberOfWheels)
        {
            Door = new Door { Count = numberOfDoors };
        }

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
