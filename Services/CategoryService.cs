using System.Collections.Generic;
using System.Threading.Tasks;
using AcarSutMarket.API.Domain.Models;
using AcarSutMarket.API.Domain.Repositories;
using AcarSutMarket.API.Domain.Services;

namespace AcarSutMarket.API.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            this._categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        { 
            return await _categoryRepository.ListAsync();
        }
    }
}