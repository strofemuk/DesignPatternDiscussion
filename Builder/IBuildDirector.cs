using System;
namespace FluentBuilderDemo.Builder
{
    public interface IBuildDirector
    {
        Vehicle Construct(IVehicleBuilder builder);
    }
}
