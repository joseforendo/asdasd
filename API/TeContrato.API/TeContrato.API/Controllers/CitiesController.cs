using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Supermarket.API.Domain.Models;
using Supermarket.API.Domain.Services;
using Supermarket.API.Extensions;
using Supermarket.API.Resources;
using Swashbuckle.AspNetCore.Annotations;

namespace Supermarket.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    [Produces("application/json")]
    public class CitiesController : ControllerBase
    {
        private readonly ICityService _cityService;
        private readonly IMapper _mapper;

        public CitiesController(ICityService cityService, IMapper mapper)
        {
            _cityService = cityService;
            _mapper = mapper;
        }
        
        [SwaggerResponse(200, "List of Categories", typeof(IEnumerable<CityResource>))]
        [HttpGet]
        [SwaggerOperation(Summary = "List all Cities")]
        [ProducesResponseType(typeof(IEnumerable<CityResource>), 200)]
        public async Task<IEnumerable<CityResource>> GetAllAsync()
        {
            var city = await _cityService.ListAsync();
            var resources = _mapper.Map<IEnumerable<City>, IEnumerable<CityResource>>(city) ;
            return resources;
        }
        
        [HttpGet("{Ccity}")]
        [SwaggerOperation(Summary = "Get a city by Id")]
        [ProducesResponseType(typeof(CityResource), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 404)]
        public async Task<IActionResult> GetAsync(int id)
        {
            var result = await _cityService.GetByIdAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var cityResource = _mapper.Map<City, CityResource>(result.Resource);
            return Ok(cityResource);
        }

        [HttpPost]
        [ProducesResponseType(typeof(CityResource), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 404)]
        [SwaggerOperation(Summary = "Create a City")]
        public async Task<IActionResult> PostAsync([FromBody] SaveCityResource resource)
        {
            
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessages());
            }

            var cities = _mapper.Map<SaveCityResource, City>(resource);
            var result = await _cityService.SaveAsync(cities);

            if (!result.Success)
                return BadRequest(result.Message);

            var cityResource = _mapper.Map<City, CityResource>(result.Resource);
            return Ok(cityResource);
        }
        
        [HttpPut("{Ccity}")]
        [SwaggerOperation(Summary = "Update a category by categoryId")]
        public async Task<IActionResult> PutAsync(int id, [FromBody] SaveCityResource resource)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState.GetErrorMessages());

            var category = _mapper.Map<SaveCityResource, City>(resource);
            var result = await _cityService.UpdateAsync(id, category);

            if (!result.Success)
                return BadRequest(result.Message);

            var categoryResource = _mapper.Map<City, CityResource>(result.Resource);

            return Ok(categoryResource);
        }
        
        [HttpDelete("{Ccity}")]
        [SwaggerOperation(Summary = "Delete a City")]
        [ProducesResponseType(typeof(CityResource), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 404)]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var result = await _cityService.DeleteAsync(id);
            if (!result.Success)
                return BadRequest(result.Message);

            var instituteResource = _mapper.Map<City, CityResource>(result.Resource);
            return Ok(instituteResource);
        }
    }
}
