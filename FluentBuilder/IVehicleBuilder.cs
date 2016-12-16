using System;
namespace FluentBuilderDemo.FluentBuilder
{
    public interface IVehicleBuilder
    {
        IVehicleBuilder CreateVehicle(string type);
        IVehicleBuilder WithDoors(int numberOfDoors);
        IVehicleBuilder WithEngine(int numberOfCylinders, int engineSizeInCC);
        IVehicleBuilder OnFrame(string frame);
        IVehicleBuilder WithWheels(int numberOfWheels);
        Vehicle Construct();
    }
}
