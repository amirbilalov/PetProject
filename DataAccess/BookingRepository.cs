using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    internal class BookingRepository(AppContext context) : IBookingRepository
    {
        public async Task CreateBooking(Booking booking, CancellationToken ct)
        {
            await context.Bookings.AddAsync(booking, ct);
            await context.SaveChangesAsync(ct);
        }

        public async Task<Booking?> GetBooking(string userName, CancellationToken ct)
        {
            var booking = await context.Bookings.FirstOrDefaultAsync(x => x.UserName == userName);
            return booking;
        }
    }
}
