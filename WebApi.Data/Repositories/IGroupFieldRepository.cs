using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApi.Data.Repositories;
using WebApi.Data.Entites;

namespace WebApi.Data.Repositories
{
    public interface IGroupFieldRepository : IGenericRepository<GroupField>
    {
        Task<List<GroupField>> GetGroupFieldsByName(string name);
        Task<List<GroupField>> GetGroupFieldsByTypeField(int typeField, int pageIndex = 1, int pageSize = 10);
        Task<List<GroupField>> GetGroupFieldsById(int id);
        Task<List<GroupField>> GetAllGroupFields();
    }
}
