using MediaRtPattern.Handler;
using MediaRtPattern.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MediaRtPattern.Controllers
{
    [Route("api/Booking")]
    [ApiController]
    public class BookingController : Controller
    {
        private readonly ISender mediatorSender;
        public BookingController(ISender sender) => mediatorSender = sender;        
                
        
        [HttpPost]
        public async Task<ActionResult> AddBooking([FromBody] Booking booking)
        {
            Booking newBooking = await mediatorSender.Send(new BookingRequest(booking));
            //return Created($"GetBookingById?id=" + newBooking.Id + "",  booking);
            return Ok(newBooking);
        }

        

    }
}
