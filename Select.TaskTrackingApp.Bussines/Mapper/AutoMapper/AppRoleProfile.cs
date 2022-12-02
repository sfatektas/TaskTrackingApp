﻿using AutoMapper;
using Select.TaskTrackingApp.Dtos.AppRoleDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Mapper.AutoMapper
{
    public class AppRoleProfile : Profile
    {
        public AppRoleProfile()
        {
            CreateMap<AppRole, AppRoleCreateDto>().ReverseMap();
            CreateMap<AppRole, AppRoleListDto>().ReverseMap();
            CreateMap<AppRole, AppRoleUpdateDto>().ReverseMap();
        }
    }
}
