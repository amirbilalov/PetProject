using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public interface IBookingService
    {
        Task<bool> CreateAsync(string userName, int roomId, CancellationToken ct = default);
        Task<Booking> GetBooking(string userName, CancellationToken ct = default);
    }
}
