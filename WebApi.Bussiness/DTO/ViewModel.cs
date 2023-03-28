using System;
using System.Collections.Generic;
using System.Text;
using WebApi.Data.Entites;

namespace WebApi.Bussiness.DTO
{
    public class ViewModel<T>
    {
        public int TotalRecord { get; set; }
        public IEnumerable<T> Items { get; set; }
    }
}
