using System.Collections.Generic;
using System.Threading.Tasks;
using AcarSutMarket.API.Domain.Models;

namespace AcarSutMarket.API.Domain.Services
{
    public interface ICategoryService
    {
         Task<IEnumerable<Category>> ListAsync();
    }
}