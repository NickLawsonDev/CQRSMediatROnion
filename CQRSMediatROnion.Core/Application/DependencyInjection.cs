using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CQRSMediatROnion.Core.Application;

public static class DependencyInjection {
    public static void AddServices(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
    }
}