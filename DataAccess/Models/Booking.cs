using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Booking
    {
        public Booking(string userName, int roomId)
        {
            UserName = userName;
            RoomId = roomId;
            CreatedAt = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime CreatedAt { get; set; }
        public int RoomId { get; set; }
    }
}
