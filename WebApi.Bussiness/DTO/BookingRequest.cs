using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Bussiness.DTO
{
    public class BookingRequest
    {
        public List<CartItemViewModel> ListCart { get; set; } = new List<CartItemViewModel>();
    }
}
