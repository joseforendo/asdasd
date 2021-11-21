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
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "List all Users")]
        [ProducesResponseType(typeof(IEnumerable<UserResource>), 200)]
        public async Task<IEnumerable<UserResource>> GetAllAsync()
        {
            var user = await _userService.ListAsync();
            var resources = _mapper.Map<IEnumerable<User>, IEnumerable<UserResource>>(user);
            return resources;
        }
        
        [HttpGet("{Cuser}")]
        [SwaggerOperation(Summary = "Get a user by Id")]
        [ProducesResponseType(typeof(UserResource), 200)]
        [ProducesResponseType(typeof(BadRequestResult), 404)]
        public async Task<IActionResult> GetAsync(int id)
        {
            var result = await _userService.GetByIdAsync(id);

            if (!result.Success)
                return BadRequest(result.Message);

            var userResource = _mapper.Map<User, UserResource>(result.Resource);
            return Ok(userResource);
        }
    }
}
