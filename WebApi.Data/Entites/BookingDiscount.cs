using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class BookingDiscount
    {
        public int BookingDiscountId { get; set; }
        public int BookingForeignKey { get; set; }
        public int DiscountForeignKey { get; set; }
        public Booking Booking { get; set; }
        public Discount Discount { get; set; }
        public bool Status { get; set; }
    }
    
}
