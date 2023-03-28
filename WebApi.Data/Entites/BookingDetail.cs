using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class BookingDetail
    {
        public int BookingDetailId { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public decimal Price { get; set; }
        public bool Status { get; set; }
        public int BookingForeignKey { get; set; }
        public int FieldScheduleForeignKey { get; set; }
        public int FieldForeignKey { get; set; }
        public ICollection<FeedBack> Feedbacks { get; set; }
        public Field Field { get; set; }
        public FieldSchedule FieldSchedule { get; set; }
        public Booking Booking { get; set; }
    }
}
