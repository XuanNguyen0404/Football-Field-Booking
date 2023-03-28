using System;
using System.Collections.Generic;
using System.Text;

namespace WebApi.Bussiness.DTO
{
    public class GetGroupFieldPagingRequest: PagingRequestBase
    {
        public string Keyword { get; set; } = "";

        public int GroupFieldId { get; set; }
    }
}
