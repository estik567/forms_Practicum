using AutoMapper;
using forms.Repositories.Entities;
using forms.Repositories.Interfaces;
using Forms.Common.Dto_s;
using Forms.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Services.Services
{
    public class ChildService : IDataService<ChilDto>
    {
        private readonly IDataRepository<Child> _child;
        private readonly IMapper _mapper;

        public ChildService(IDataRepository<Child> child, IMapper mapper)
        {
            _child = child;
            _mapper = mapper;
        }

        public async Task<ChilDto> AddAsync(ChilDto entity)
        {
            return _mapper.Map<ChilDto>(await _child.AddAsync(_mapper.Map<Child>(entity)));

        }

        public async Task DeleteAsync(int id)
        {
            await _child.DeleteAsync(id);
        }

        public async Task<List<ChilDto>> GetAllAsync()
        {
            return _mapper.Map<List<ChilDto>>(await _child.GetAllAsync());

        }

        public async Task<ChilDto> GetByIdAsync(int id)
        {
            var child = await _child.GetByIdAsync(id);
            var childDto = _mapper.Map<ChilDto>(child);
            return childDto;
        }

        public async Task<ChilDto> UpdateAsync(int id, ChilDto entity)
        {
            Child child = _mapper.Map<Child>(entity);
            child = await _child.UpdateAsync(id, child);
            return _mapper.Map<ChilDto>(child);
        }
    }
}
