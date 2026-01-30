using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BusinessLogic
{
    public interface IRoomService
    {
        Task CreateAsync(string roomClass, int cost, string description, CancellationToken ct = default);
        Task DeleteAsync(int id, CancellationToken ct = default);
        Task<Room?> GetByIdAsync(int id, CancellationToken ct = default);
        Task<List<Room>> GetAllAsync(CancellationToken ct = default);
    }
}
