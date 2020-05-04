using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AcarSutMarket.API.Domain.Models;
using AcarSutMarket.API.Domain.Services;


namespace AcarSutMarket.API.Controllers
{
    public class CategoriesController
    {
        [Route("/api/[controller]")]
        public class CategoriesController : Controller
        {
            private readonly ICategoryService _categoryService;
        
        public CategoriesControllers(ICategoryService categoryService)
        {
            _categoryService = categoryService;   
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
        }
    }
}