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
        public BuildDirector()
        {

        }


        public Vehicle Construct(IVehicleBuilder builder)
        {
            builder.BuildFrame();
            builder.BuildEngine();
            builder.BuildWheels();
            builder.BuildDoors();

            return builder.Vehicle;
        }
    }
}
