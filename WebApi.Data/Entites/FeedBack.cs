using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class FeedBack
    {
        public int FeedBackId { get; set; }
        public int NumOfStart { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Comment { get; set; }
        public bool Status { get; set; }
        public int BookingDetailForeignKey { get; set; }
        public BookingDetail BookingDetail { get; set; }
        public Guid UserForeignKey { get; set; }
        public User User { get; set; }
    }
}
