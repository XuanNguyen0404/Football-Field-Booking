using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Bussiness.DTO
{
    public class CartItemViewModel
    {
        public int fieldScheduleId { get; set; }
        public string fieldName { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public DateTime BookingDate { get; set; }
        public decimal Price { get; set; }
        public int FieldForeignKey { get; set; }

    }
}
