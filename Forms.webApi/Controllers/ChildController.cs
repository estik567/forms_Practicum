using Forms.Common.Dto_s;
using Forms.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Forms.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChildController : ControllerBase
    {
        private readonly IDataService<ChilDto> _childService;

        public ChildController(IDataService<ChilDto> childService)
        {
            _childService = childService;
        }

        // GET: api/<ChildController>
        [HttpGet]
        public async Task<List<ChilDto>> Get()
        {
            return await _childService.GetAllAsync();
        }

        // GET api/<ChildController>/5
        [HttpGet("{id}")]
        public async Task<ChilDto> Get(int id)
        {
            return await _childService.GetByIdAsync(id);

        }

        // POST api/<ChildController>
        [HttpPost]
        public async Task<ChilDto> Post([FromBody] ChilDto value)
        {
            return await _childService.AddAsync(value);

        }

        // PUT api/<ChildController>/5
        [HttpPut("{id}")]
        public async Task<ChilDto> Put(int id, [FromBody] ChilDto value)
        {
            return await _childService.UpdateAsync(id, value);

        }

        // DELETE api/<ChildController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _childService.DeleteAsync(id);
        }
    }
}
