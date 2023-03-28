using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Bussiness.DTO
{
    public class FieldUpdateRequest
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public bool Status { get; set; }
        public int GroupFieldForeinKey { get; set; }
        public IFormFile Image { get; set; }
        public Guid UserForeignKey { get; set; }

    }
}
