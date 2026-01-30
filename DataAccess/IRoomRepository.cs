using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public interface IRoomRepository
    {
        Task CreateAsync(Room room, CancellationToken ct = default);
        Task DeleteAsync(Room room, CancellationToken ct = default);
        Task<Room?> GetByIdAsync(int id, CancellationToken ct = default);
        Task<List<Room>> GetAllAsync(CancellationToken ct = default);
        Task UpdateAsync(Room room, CancellationToken ct = default);
    }
}
