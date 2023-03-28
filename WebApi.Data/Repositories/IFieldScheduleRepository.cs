using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public interface IFieldScheduleRepository : IGenericRepository<FieldSchedule>
    {
        Task<List<int>> GetScheduleAvailable(int idField, DateTime bookingDate);

        Task<List<int>> GetSchedule(int id);

        Task<int> GetFieldScheduleIdByFieldId(int id);
    }

}
