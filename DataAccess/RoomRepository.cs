using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    internal class RoomRepository(AppContext context) : IRoomRepository
    {
        public async Task CreateAsync(Room room, CancellationToken ct = default)
        {
            await context.Rooms.AddAsync(room, ct);
            await context.SaveChangesAsync(ct);
        }

        public async Task DeleteAsync(Room room, CancellationToken ct = default)
        {
            context.Rooms.Remove(room);
            await context.SaveChangesAsync(ct);
        }

        public async Task<Room?> GetByIdAsync(int id, CancellationToken ct = default)
        {
            var room = await context.Rooms.FirstOrDefaultAsync(x => x.Id == id);
            return room;
        }

        public async Task<List<Room>> GetAllAsync(CancellationToken ct = default)
        {
            var rooms = await context.Rooms.ToListAsync(ct);
            return rooms;
        }

        public async Task UpdateAsync(Room room, CancellationToken ct = default)
        {
            context.Rooms.Update(room);
            await context.SaveChangesAsync(ct);
        }
    }
}
