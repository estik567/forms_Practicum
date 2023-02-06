using AutoMapper;
using forms.Repositories.Entities;
using Forms.Common.Dto_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Services
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Child, ChilDto>().ReverseMap();

        }
    }
}
