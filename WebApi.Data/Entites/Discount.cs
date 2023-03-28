using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public String DiscountCode { get; set; }
        public int Percent { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
        public ICollection<BookingDiscount> BookingDiscount { get; set; }

    }
}
