using AutoMapper;
using forms.Repositories.Models;
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
    public class UserService : IDataService<UserDto>
    {
        private readonly IDataRepository<User> _user;
        private readonly IMapper _mapper;

        public UserService(IDataRepository<User> user, IMapper mapper)
        {
            _user = user;
            _mapper = mapper;
        }

        public async Task<UserDto> AddAsync(UserDto entity)
        {
            return _mapper.Map<UserDto>(await _user.AddAsync(_mapper.Map<User>(entity)));

        }

        public async Task DeleteAsync(int id)
        {
            await _user.DeleteAsync(id);

        }

        public async Task<List<UserDto>> GetAllAsync()
        {
            return _mapper.Map<List<UserDto>>(await _user.GetAllAsync());

        }

        public async Task<UserDto> GetByIdAsync(int id)
        {
            var user = await _user.GetByIdAsync(id);
            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }

        public async Task<UserDto> UpdateAsync(int id, UserDto entity)
        {
            User user = _mapper.Map<User>(entity);
            user = await _user.UpdateAsync(id, user);
            return _mapper.Map<UserDto>(user);
        }
    }
}
