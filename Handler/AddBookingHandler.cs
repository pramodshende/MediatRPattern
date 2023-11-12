using MediaRtPattern.DAL;
using MediaRtPattern.Model;
using MediatR;

namespace MediaRtPattern.Handler
{
    /// <summary>
    /// Handler request with response as booking
    /// </summary>
    public class AddBookingHandler : IRequestHandler<BookingRequest, Booking>
    {
        private readonly SeedBooking _data;
        public AddBookingHandler(SeedBooking data) => _data = data;

        public async Task<Booking> Handle(BookingRequest request, CancellationToken cancellationToken)
        {
            await _data.AddBookingAsync(request.booking);
            return request.booking;
        }

        

    }
}
