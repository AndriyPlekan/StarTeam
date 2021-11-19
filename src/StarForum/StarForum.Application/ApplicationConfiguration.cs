﻿using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StarForum.Application.Behaviours;

namespace StarForum.Application
{
    public static class ApplicationConfiguration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            var currentAssembly = typeof(ApplicationConfiguration).Assembly;

            services.AddMediatR(currentAssembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidatorBehaviour<,>));

            services.AddFluentValidation(config => config.RegisterValidatorsFromAssembly(currentAssembly));

            return services;
        }
    }
}