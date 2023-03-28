using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime CreatedAt { get; set; }
        public decimal OriginPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public bool Status { get; set; }
        public Guid UserForeignKey { get; set; }
        public User User { get; set; }
        public ICollection<BookingDiscount> BookingDiscount { get; set; }
        public ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
