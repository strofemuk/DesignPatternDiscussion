using System;
namespace FluentBuilderDemo.Builder
{
    public interface IVehicleBuilder
    {
        void CreateVehicle();
        void BuildDoors();
        void BuildEngine();
        void BuildFrame();
        void BuildWheels();
        Vehicle Vehicle { get; }
    }
}
