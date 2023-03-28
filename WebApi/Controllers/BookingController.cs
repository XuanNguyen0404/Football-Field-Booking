using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApi.Bussiness.DTO;
using WebApi.Bussiness.IServices;
using WebApi.Data.Entites;
using WebApi.Data.Repositories;
using WebApi.Controllers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class BookingController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public BookingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // POST api/<OrderController>
        [HttpPost("checkout/booking")]
        public async Task<IActionResult> Checkout([FromBody]BookingRequest bookingRequest)
        {
            List<CartItemViewModel> listCart = bookingRequest.ListCart;
            int percentDiscount = 0;
            decimal totalPrice = 0;
            decimal priceDiscount = 0;
            decimal finalPrice = 0;
            var booking = new Booking();
            string id = null;
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                IEnumerable<Claim> claims = identity.Claims;

                var userIdClaim = claims
                    .Where(x => x.Type == ClaimTypes.NameIdentifier)
                    .FirstOrDefault();
                id = userIdClaim.Value;
            }
            Guid idUser = Guid.Parse(id);

            if (listCart != null)
            {
                foreach (CartItemViewModel item in listCart)
                {
                    totalPrice = totalPrice + item.Price;
                }
                if (percentDiscount != 0)
                {
                    priceDiscount = (totalPrice * percentDiscount) / 100;
                    finalPrice = totalPrice - priceDiscount;

                    booking.CreatedAt = DateTime.Now;
                    booking.OriginPrice = totalPrice;
                    booking.TotalPrice = finalPrice;
                    booking.Status = true;
                    booking.UserForeignKey = idUser;

                }
                else
                {
                    booking.CreatedAt = DateTime.Now;
                    booking.OriginPrice = totalPrice;
                    booking.TotalPrice = totalPrice;
                    booking.Status = true;
                    booking.UserForeignKey = idUser;
                }
            }
            await _unitOfWork.Booking.Add(booking);
            int status =  _unitOfWork.Complete();
            if (status > 0)
            {
                return Ok(booking.BookingId);
            }
            return BadRequest();
        }

        [HttpGet("{idUser}")]
        public async Task<IActionResult> GetHistory(Guid idUser)
        {
            List<Booking> list = await _unitOfWork.Booking.GetHistory(idUser);
            if(list != null)
            {
                return Ok(list);
            }
            return BadRequest();
        }




    }
}
