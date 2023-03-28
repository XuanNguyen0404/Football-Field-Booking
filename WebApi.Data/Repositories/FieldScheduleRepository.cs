using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.EF;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public class FieldScheduleRepository : GenericRepository<FieldSchedule>, IFieldScheduleRepository
    {

        public FieldScheduleRepository(WebApiDbContext context) : base(context)
        {

        }

        public async Task<List<int>> GetSchedule(int id)
        {
            List<int> schedule = new List<int>();

            var result = await _context.FieldSchedules
                .Where(x => x.FieldForeignKey == id)
                .FirstOrDefaultAsync();

            var start = result.TimeStart.Hour;
            var end = result.TimeEnd.Hour;

            for (int i = start; i < end; i++)
            {
                schedule.Add(i);
            }
            return schedule;
        }

        public async Task<List<int>> GetScheduleAvailable(int id, DateTime bookingDate)
        {
            List<int> schedule = await GetSchedule(id);
            List<int> tempSchedule = new List<int>();
            List<int> timeAvailable = new List<int>();

            DateTime timeStart = bookingDate.AddHours(5);
            DateTime timeEnd = bookingDate.AddHours(23);

            var query = from bd in _context.BookingDetails
                        join b in _context.Bookings on bd.BookingForeignKey equals b.BookingId
                        join fs in _context.FieldSchedules on bd.FieldScheduleForeignKey equals fs.FieldScheduleID
                        where bd.FieldForeignKey == id && (bd.TimeStart >= timeStart && bd.TimeStart <= timeEnd)
                        select new { bd.TimeStart, bd.TimeEnd};
            var listBooked = query.ToList();
            if(listBooked.Count == 0)
            {
                timeAvailable = schedule;
            }
            else
            {
                foreach(var result in listBooked)
                {
                    tempSchedule.Add(result.TimeStart.Hour);
                }
            }

            timeAvailable = schedule.Except(tempSchedule).ToList();
            return timeAvailable;
        }

        public async Task<int> GetFieldScheduleIdByFieldId(int id)
        {

            var result = await _context.FieldSchedules
                .Where(x => x.FieldForeignKey == id)
                .FirstOrDefaultAsync();

            var idSchedule = result.FieldScheduleID;
            return idSchedule;
        }
    }

}
