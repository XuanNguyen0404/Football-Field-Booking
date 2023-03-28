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
    public class GroupFieldRepository : GenericRepository<GroupField>, IGroupFieldRepository
    {
        public GroupFieldRepository(WebApiDbContext context) : base(context)
        {

        }

        public async Task<List<GroupField>> GetGroupFieldsById(int id)
        {

            var result = await _context.GroupFields
                .Where(x => x.GroupFieldId == id)
                .Include(x => x.Fields)
                .ThenInclude(x => x.FieldSchedules)
                .ToListAsync();

            return result;
        }

        public async Task<List<GroupField>> GetAllGroupFields()
        {
            var result = await _context.GroupFields.Include(x => x.Fields)
                .ThenInclude(x => x.FieldSchedules)
                .ToListAsync();

            return result;
        }

        public async Task<List<GroupField>> GetGroupFieldsByName(string name)
        {
            var result = await _context.GroupFields.OrderBy(x => x.Name)
                .Where(x => x.Name.Contains(name)).Include(x => x.Fields)
                .ThenInclude(x => x.FieldSchedules)
                .ToListAsync();

            return result;
        }

        public async Task<List<GroupField>> GetGroupFieldsByTypeField(int typeField, int pageIndex = 1, int pageSize = 10)
        {
            var result = await _context.GroupFields.Include(x => x.Fields.Where(x => x.TypeField == typeField))
                .ThenInclude(x => x.FieldSchedules)
                .Skip((pageIndex - 1) * pageSize).Take(pageSize)
                .ToListAsync();
            //List<GroupField> listGroupField = new List<GroupField>();
            //var query = from gf in _context.GroupFields
            //            join f in _context.Fields on gf.GroupFieldId equals f.GroupFieldForeinKey
            //            where f.TypeField == typeField
            //            select new { gf };

            //var list = query.ToList();
            //foreach(var a in list)
            //{
            //    GroupField g = new GroupField();
            //    g.GroupFieldId = a.gf.GroupFieldId;
            //    g.Name = a.gf.Name;
            //    g.Address = a.gf.Address;
            //    g.Description = a.gf.Description;
            //    g.Status = a.gf.Status;
            //    g.ImagePath = a.gf.ImagePath;
            //    g.ImageName = a.gf.ImageName;
            //    g.CreatedAt = a.gf.CreatedAt;
            //    g.UserForeignKey = a.gf.UserForeignKey;

            //    listGroupField.Add(g);
            //}
            List<GroupField> newList = new List<GroupField>();
            foreach (var a in result)
            {
                if (a.Fields.Count > 0)
                {
                    newList.Add(a);
                }
            }
            return newList;
        }

    }
}
