using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo.Builder
{
    public partial class Vehicle
    {
        //The AVehicleBuilder class is insde the Vehicle to hide Vehicle's constructor.  
        public abstract class AVehicleBuilder : IVehicleBuilder
        {
            public Vehicle Vehicle { get; protected set; }

            protected AVehicleBuilder()
            {
                Vehicle = new Vehicle();
            }

            public abstract void CreateVehicle();
            public abstract void BuildFrame();
            public abstract void BuildEngine();
            public abstract void BuildWheels();
            public abstract void BuildDoors();
        }
    }
}
