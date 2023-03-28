using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class FieldSchedule
    {
        public int FieldScheduleID { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public decimal OriginPrice { get; set; }
        public int FieldForeignKey { get; set; }
        public Field Field { get; set; }
        public ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
