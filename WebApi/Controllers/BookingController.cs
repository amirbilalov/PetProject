using BusinessLogic;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    public class BookingController(IBookingService bookingService) : BaseController
    {
        [HttpGet("booking/{userName}")]
        public async Task<IActionResult> GetBookingAsync(string userName)
        {
            var result = await bookingService.GetBooking(userName);
            if(result == null)
                return NotFound();
            return Ok(result);
        }

        [HttpPost("booking")]
        public async Task<IActionResult> CreateBookingAsync(string userName, int roomId)
        {
            if (await bookingService.CreateAsync(userName, roomId))
                return Ok();
            return BadRequest();
        }
    }
}
