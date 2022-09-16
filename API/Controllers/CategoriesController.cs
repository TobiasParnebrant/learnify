using System.Collections.Generic;
using System.Threading.Tasks;
using Entity;
using API.Dto;
using Entity.Interfaces;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace API.Controllers
{
    public class CategoriesController : BaseController
    {
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Category> _repository;
        public CategoriesController(IGenericRepository<Category> repository, IMapper mapper)
        {
            this._repository = repository;
            this._mapper = mapper;

        }

        [HttpGet]

        public async Task<ActionResult<IReadOnlyList<CategoriesDto>>> GetCategories()
        {
            var categories = await _repository.ListAllAsync();
            return Ok(_mapper.Map<IReadOnlyList<Category>, IReadOnlyList<CategoriesDto>>(categories));
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<CategoryDto>> GetCategory(int id)
        {
            var category = await _repository.GetByIdAsync(id);

            return _mapper.Map<Category, CategoryDto>(category);
        }

    }
}