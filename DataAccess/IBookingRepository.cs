using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IBookingRepository
    {
        Task CreateBooking(Booking booking, CancellationToken ct);
        Task<Booking> GetBooking(string userName, CancellationToken ct);
    }
}
