using BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class RoomController(IRoomService roomService) : BaseController
    {
        [HttpPost("rooms")]
        public async Task<IActionResult> CreateAsync(string roomClass, int cost, string description)
        {
            await roomService.CreateAsync(roomClass, cost, description);
            return NoContent();
        }

        [HttpDelete("rooms/{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await roomService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("rooms/{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var result = await roomService.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpGet("rooms")]
        public async Task<IActionResult> GetAllAsync()
        {
            var rooms = await roomService.GetAllAsync();
            return Ok(rooms);
        }
    }
}
