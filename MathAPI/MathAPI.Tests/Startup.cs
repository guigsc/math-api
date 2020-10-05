using MathAPI.MultipleOf;
using MathAPI.MultipleOf.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace MathAPI.Tests
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IMultipleOfEleven, MultipleOfEleven>();
        }
    }
}
