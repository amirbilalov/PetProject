using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class Room
    {
        public Room(string roomClass, int cost, string description)
        {
            RoomClass = roomClass;
            Cost = cost;
            Description = description;
            IsBooked = false;
        }
        public int Id { get; set; }
        public string RoomClass { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public bool IsBooked { get; set; }
    }
}
