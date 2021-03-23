using AutoMapper;
using BE_4_customers.DTO;
using BE_4_customers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BE_4_customers.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<Register, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}
