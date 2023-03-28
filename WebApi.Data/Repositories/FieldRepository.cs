using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.EF;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public class FieldRepository : GenericRepository<Field>, IFieldRepository
    {
        public FieldRepository(WebApiDbContext context) : base(context)
        {

        }
        
        public async Task<List<Field>> GetListFieldsWithSchedule()
        {

            var result = await _context.Fields.Include(x => x.FieldSchedules)
                .ToListAsync();

            return result;
        }
    }
}
