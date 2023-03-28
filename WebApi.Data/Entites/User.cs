using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class User: IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public ICollection<GroupField> GroupFields { get; set; }
        public ICollection<Field> Fields { get; set; }
        public ICollection<FeedBack> FeedBacks { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
