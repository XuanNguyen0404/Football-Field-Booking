using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.Repositories;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public interface IFieldRepository : IGenericRepository<Field>
    {
        Task<List<Field>> GetListFieldsWithSchedule();

    }
}
