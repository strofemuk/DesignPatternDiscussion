using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //No pattern -- overriding constructors.
            Vehicle motorcycle1 = new Vehicle("Motorcycle", "Motorcycle frame", 2, 500, 2,0);
            Console.WriteLine(motorcycle1.ToString());

            //No pattern -- using properties.
            Vehicle motorcycle2 = new Vehicle
            {
                Type = "Motorcyle",
                Frame = "Motorcycle frame",
                NumberOfCylinders = 2,
                EngineSizeInCC = 550,
                NumberOfWheels = 2,
                Door = new Door { Count = 0 }
            };

            Console.WriteLine(motorcycle2.ToString());

            //classic builder pattern.  The director (shop) is used to conduct the building operation (builder) to produce an object (firstCar)
            Builder.IVehicleBuilder builder = new Builder.CarBuilder();
            Builder.IBuildDirector shop = new Builder.BuildDirector(builder);
            Builder.Vehicle firstCar = shop.Construct();
            Console.WriteLine(firstCar.ToString());

            //Fluent implentation.  The director is replaced with a "fluent interface"
            FluentBuilder.IVehicleBuilder secondBuilder = new FluentBuilder.Vehicle.VehicleBuilder();
            FluentBuilder.Vehicle secondCar = secondBuilder
                .BuildType("Sports Car")
                .BuildFrame("unibody")
                .BuildEngine(16, 9000)
                .BuildWheels(4)
                .BuildDoors(2)
                .Construct();
            Console.WriteLine(secondCar.ToString());

            Console.ReadKey();

            /* Questions:
             * Is the fluent interface easier to read?
             * Are there situations where we need a director?
             * Can we combine the director and the fluent interface? 
             * */

        }
    }
}
