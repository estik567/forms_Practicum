using Forms.Common.Dto_s;
using Forms.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Forms.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IDataService<UserDto> _userService;

        public UserController(IDataService<UserDto> userService)
        {
            _userService = userService;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<List<UserDto>> Get()
        {
            return await _userService.GetAllAsync();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<UserDto> Get(int id)
        {
            return await _userService.GetByIdAsync(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<UserDto> Post([FromBody] UserDto value)
        {
            return await _userService.AddAsync(value);

        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<UserDto> Put(int id, [FromBody] UserDto value)
        {
            return await _userService.UpdateAsync(id, value);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteAsync(id);

        }
    }
}
