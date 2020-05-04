using System.Collections.Generic;
using System.Threading.Tasks;
using AcarSutMarket.API.Domain.Models;

namespace AcarSutMarket.API.Domain.Repositories
{
    public interface ICategoryRepository
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}