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
            public Vehicle Vehicle { get; protected set; }

            public IVehicleBuilder CreateVehicle(string type)
            {
                Vehicle = new FluentBuilder.Vehicle();
                Vehicle.Type = type;
                return this;
            }

            public IVehicleBuilder OnFrame(string frame)
            {
                Vehicle.Frame = frame;
                return this;
            }

            public IVehicleBuilder WithEngine(int numberOfCylinders, int engineSizeInCC)
            {
                Vehicle.NumberOfCylinders = numberOfCylinders;
                Vehicle.EngineSizeInCC = engineSizeInCC;
                return this;
            }

            public IVehicleBuilder WithWheels(int numberOfWheels)
            {
                Vehicle.NumberOfWheels = numberOfWheels;
                return this;
            }

            public IVehicleBuilder WithDoors(int numberOfDoors)
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
