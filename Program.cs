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
            //object construction using no pattern -- overriding constructors.
            Vehicle motorcycle1 = new Vehicle("Motorcycle", "Motorcycle frame", 2, 500, 2,0);
            Console.WriteLine(motorcycle1.ToString());

            //object construction using no pattern -- using properties.
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

            //object construction using the classic builder pattern.  
            //The director (shop) is used to conduct the building operation (builder) to produce an object (firstCar)
            Builder.IVehicleBuilder builder = new Builder.CarBuilder();
            Builder.IBuildDirector shop = new Builder.BuildDirector();
            Builder.Vehicle firstCar = shop.Construct(builder);
            Console.WriteLine(firstCar.ToString());

            //let's build another one....
            Builder.IVehicleBuilder motorcycleBuilder = new Builder.MotorcycleBuilder();
            Builder.Vehicle motorcycle3 = shop.Construct(motorcycleBuilder);
            Console.WriteLine(motorcycle3.ToString());

            //object constructing using a fluent api implentation.  The director and the individual builders are replaced with a "fluent interface".
            FluentBuilder.IVehicleBuilder secondBuilder = new FluentBuilder.Vehicle.VehicleBuilder();
            FluentBuilder.Vehicle secondCar = secondBuilder
                .CreateVehicle("Sports Car")
                .OnFrame("unibody")
                .WithEngine(16, 9000)
                .WithWheels(4)
                .WithDoors(2)
                .Construct();
            Console.WriteLine(secondCar.ToString());

            //using an implicit operator conversion...
            FluentBuilder.Vehicle motorcycle4 = (FluentBuilder.Vehicle.VehicleBuilder)secondBuilder
                .CreateVehicle("Motorcycle")
                .OnFrame("motorcycle frame")
                .WithEngine(4, 250)
                .WithWheels(2)
                .WithDoors(0)                ;
            Console.WriteLine(motorcycle4.ToString());

            Console.ReadKey();

            /* Questions:
             * Is the fluent interface easier to read?
             * Are there situations where we need a director?
             * Can we combine the director and the fluent interface? 
             * */

        }
    }
}
