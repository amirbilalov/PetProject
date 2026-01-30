using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    internal class BookingService(IBookingRepository bookingRepository, IRoomRepository roomRepository) : IBookingService
    {
        public async Task<bool> CreateAsync(string userName, int roomId, CancellationToken ct = default)
        {
            var roomSelected = await roomRepository.GetByIdAsync(roomId, ct);

            if(roomSelected.IsBooked)
            {
                return false;
            }
            roomSelected.IsBooked = true;

            var booking = new Booking(userName, roomId);
            await bookingRepository.CreateBooking(booking, ct);
            await roomRepository.UpdateAsync(roomSelected);
            return true;
        }

        public async Task<Booking?> GetBooking(string userName, CancellationToken ct = default)
        {
            var booking = await bookingRepository.GetBooking(userName, ct);
            return booking;
        }
    }
}
