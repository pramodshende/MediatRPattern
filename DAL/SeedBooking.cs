using MediaRtPattern.Model;

namespace MediaRtPattern.DAL
{
    public class SeedBooking
    {
        private static List<Booking> _data;
        public SeedBooking()
        {
            _data = new()
                {
                    new Booking{Id=1, Name="A"},
                    new Booking{Id=2, Name="B"},
                    new Booking{Id=3, Name="C"},
                };
        }
    
        public async Task AddBookingAsync(Booking booking)
        {
            _data.Add(booking);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Booking>> GetBookingsAsync() 
                => await Task.FromResult(_data);

    }
}
