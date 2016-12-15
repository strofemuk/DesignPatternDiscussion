using System;
namespace FluentBuilderDemo.FluentBuilder
{
    public interface IVehicleBuilder
    {
        IVehicleBuilder BuildType(string type);
        IVehicleBuilder BuildDoors(int numberOfDoors);
        IVehicleBuilder BuildEngine(int numberOfCylinders, int engineSizeInCC);
        IVehicleBuilder BuildFrame(string frame);
        IVehicleBuilder BuildWheels(int numberOfWheels);
        Vehicle Construct();
    }
}
