using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo.Builder
{
    //The director of has the responsibility of conductiong the build operations.
    public class BuildDirector : IBuildDirector
    {
        public BuildDirector(IVehicleBuilder builder)
        {
            Builder = builder;
        }

        public IVehicleBuilder Builder { get; private set; }

        public Vehicle Construct()
        {
            Builder.BuildFrame();
            Builder.BuildEngine();
            Builder.BuildWheels();
            Builder.BuildDoors();

            return Builder.Vehicle;
        }
    }
}
