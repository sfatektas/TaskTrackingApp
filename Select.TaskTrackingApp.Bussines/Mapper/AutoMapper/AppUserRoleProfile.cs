using AutoMapper;
using Select.TaskTrackingApp.Dtos.AppUserRoleDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Mapper.AutoMapper
{
    public class AppUserRoleProfile : Profile
    {
        public AppUserRoleProfile()
        {
            CreateMap<AppUserRole, AppUserRoleCreateDto>().ReverseMap();
            CreateMap<AppUserRole, AppUserRoleListDto>().ReverseMap();
            CreateMap<AppUserRole, AppUserRoleUpdateDto>().ReverseMap();
        }
    }
}
