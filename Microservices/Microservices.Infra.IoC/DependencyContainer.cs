﻿using Microservices.Domain.Core.Bus;
using Microservices.Infra.Bus;
using Microsoft.Extensions.DependencyInjection;

namespace Microservices.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
