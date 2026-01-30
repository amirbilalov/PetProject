using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public static class Extensions
    {
        public static IServiceCollection AddBusinessLogic(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRoomService, RoomService>();
            serviceCollection.AddScoped<IBookingService, BookingService>();
            return serviceCollection;
        }
    }
}
