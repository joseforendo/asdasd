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
    public class ControlEmployeesController : ControllerBase
    {
        private readonly IControlEmployeesService _controlemployeesService;
        private readonly IMapper _mapper;

        public ControlEmployeesController(IControlEmployeesService controlemployeesService, IMapper mapper)
        {
            _controlemployeesService = controlemployeesService;
            _mapper = mapper;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "List all Control-Employees")]
        [ProducesResponseType(typeof(IEnumerable<ControlEmployeeResource>), 200)]
        public async Task<IEnumerable<ControlEmployeeResource>> GetAllAsync()
        {
            var user = await _controlemployeesService.ListAsync();
            var resources = _mapper.Map<IEnumerable<ControlEmployees>, IEnumerable<ControlEmployeeResource>>(user);
            return resources;
        }

    }
}