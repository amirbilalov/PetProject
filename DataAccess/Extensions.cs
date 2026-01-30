using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public static class Extensions
    {
        public static IServiceCollection AddDataAccess(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection.AddScoped<IRoomRepository, RoomRepository>();
            serviceCollection.AddScoped<IBookingRepository, BookingRepository>();

            var stringConnection = configuration.GetConnectionString("PostgreStringConnection");

            serviceCollection.AddDbContext<AppContext>(x =>
            {
                x.UseNpgsql(stringConnection);
            });

            return serviceCollection;
        }
    }
}
