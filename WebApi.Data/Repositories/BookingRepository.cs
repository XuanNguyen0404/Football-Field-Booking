using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.EF;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(WebApiDbContext context) : base(context)
        {

        }

        public async Task<List<Booking>> GetHistory(Guid idUser)
        {
            var result = await _context.Bookings
                .Where(x => x.UserForeignKey.Equals(idUser))
                .Include(x => x.BookingDetails).ToListAsync();
            return result;
        }
    }
}
