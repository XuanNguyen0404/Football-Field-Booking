using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Bussiness.DTO
{
    public class FieldGroupUpdateRequest
    {
        public int GroupFieldId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public string ImagePath { get; set; }
        public string ImageName { get; set; }
        public IFormFile Image { get; set; }

    }
}
