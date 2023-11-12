using MediaRtPattern.Model;
using MediatR;

namespace MediaRtPattern.Handler
{
    /// <summary>
    /// Booking mediart request with reponse booking record
    /// </summary>
    /// <param name="Booking"></param>
    public record BookingRequest(Booking booking) : IRequest<Booking>;
    
    
}
