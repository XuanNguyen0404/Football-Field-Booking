using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Bussiness.DTO
{
    public class GroupFieldCreateRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public Guid UserForeignKey { get; set; }
        public IFormFile Image { get; set; }
    }
}
