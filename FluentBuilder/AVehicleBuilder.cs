using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo.FluentBuilder
{
    public partial class Vehicle
    {
        //The AVehicleBuilder class is insde the Vehicle to hide Vehicle's constructor.  
        public class VehicleBuilder : IVehicleBuilder
        {
            protected Vehicle Vehicle { get; set; }

            public VehicleBuilder()
            {
                Vehicle = new Vehicle();
                Vehicle.Door = new Door { Count = 0 };
            }

            public IVehicleBuilder BuildType(string type)
            {
                Vehicle.Type = type;
                return this;
            }

            public IVehicleBuilder BuildFrame(string frame)
            {
                Vehicle.Frame = frame;
                return this;
            }

            public IVehicleBuilder BuildEngine(int numberOfCylinders, int engineSizeInCC)
            {
                Vehicle.NumberOfCylinders = numberOfCylinders;
                Vehicle.EngineSizeInCC = engineSizeInCC;
                return this;
            }

            public IVehicleBuilder BuildWheels(int numberOfWheels)
            {
                Vehicle.NumberOfWheels = numberOfWheels;
                return this;
            }

            public IVehicleBuilder BuildDoors(int numberOfDoors)
            {
                Vehicle.Door = new Door { Count = numberOfDoors };
                return this;
            }

            public Vehicle Construct()
            {
                return Vehicle;
            }
        }
    }
}
