using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo.FluentBuilder
{
    public class CarBuilder : Vehicle.VehicleBuilder
    {
        public CarBuilder()
        {
            Vehicle.Type = "Sports Car";
        }
    }
}
