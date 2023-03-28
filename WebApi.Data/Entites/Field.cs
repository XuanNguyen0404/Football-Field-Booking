using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class Field
    {
        public int FieldId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int TypeField { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsHot { get; set; }
        public int TopHot { get; set; }
        public int GroupFieldForeinKey { get; set; }
        public GroupField GroupField { get; set; }
        public Guid UserForeignKey { get; set; }
        public User User { get; set; }
        public ICollection<FieldSchedule> FieldSchedules { get; set; }
        public ICollection<BookingDetail> BookingDetails { get; set; }
    }
}
