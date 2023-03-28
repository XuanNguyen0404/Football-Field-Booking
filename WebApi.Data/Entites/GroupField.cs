using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Data.Entites
{
    public class GroupField
    {
        public int GroupFieldId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid UserForeignKey { get; set; }
        public User User { get; set; }
        public ICollection<Field> Fields { get; set; }
    }
}
