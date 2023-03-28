using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.EF;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public class BookingDetailRepository : GenericRepository<BookingDetail>, IBookingDetailRepository
    {
        public BookingDetailRepository(WebApiDbContext context) : base(context)
        {

        }
    }
}
