using CleanArch.Application.Intefaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infrastructure.IoC
{
    public static class DependencyContainer
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //ApplicationCore Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infrastructure Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
