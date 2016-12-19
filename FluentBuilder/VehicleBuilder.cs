using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo.FluentBuilder
{
    public class VehicleBuilder : IVehicleBuilder
    {
        public string Type { get; private set; }
        public string Frame { get; private set; }
        public int CylinderCount { get; private set; }
        public int EngineSize { get; private set; }
        public int WheelCount { get; private set; }
        public int DoorCount { get; private set; }

        public IVehicleBuilder CreateVehicle(string type)
        {
            Type = type;
            Frame = string.Empty;
            CylinderCount = 0;
            EngineSize = 0;
            WheelCount = 0;
            DoorCount = 0;
            return this;
        }

        public IVehicleBuilder OnFrame(string frame)
        {
            Frame = frame;
            return this;
        }

        public IVehicleBuilder UseEngine(int numberOfCylinders, int engineSizeInCC)
        {
            CylinderCount = numberOfCylinders;
            EngineSize = engineSizeInCC;
            return this;
        }

        public IVehicleBuilder WithThisManyWheels(int numberOfWheels)
        {
            WheelCount = numberOfWheels;
            return this;
        }

        public IVehicleBuilder NumberOfDoors(int numberOfDoors)
        {
            DoorCount = numberOfDoors;
            return this;
        }

        public Vehicle Construct()
        {
            return this;
        }


    }
    
}
