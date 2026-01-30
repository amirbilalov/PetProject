using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    internal class RoomService(IRoomRepository roomRepository) : IRoomService
    {
        public async Task CreateAsync(string roomClass, int cost, string description, CancellationToken ct = default)
        {
            var room = new Room(roomClass, cost, description);

            await roomRepository.CreateAsync(room, ct);
        }

        public async Task DeleteAsync(int id, CancellationToken ct = default)
        {
            var room = await roomRepository.GetByIdAsync(id, ct);

            if (room != null)
                await roomRepository.DeleteAsync(room, ct);
        }

        public async Task<Room?> GetByIdAsync(int id, CancellationToken ct = default)
        {
            return await roomRepository.GetByIdAsync(id, ct);
        }

        public async Task<List<Room>> GetAllAsync(CancellationToken ct = default)
        {
            return await roomRepository.GetAllAsync(ct);
        }
    }
}
