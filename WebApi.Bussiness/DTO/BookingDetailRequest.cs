using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Bussiness.DTO
{
    public class BookingDetailRequest
    {
        public int BookingId { get; set; }
        public List<CartItemViewModel> ListCart { get; set; } = new List<CartItemViewModel>();
    }
}
