using AutoMapper;
using Select.TaskTrackingApp.Dtos.AppUserTaskDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Mapper.AutoMapper
{
    public class AppUserTaskProfile : Profile
    {
        public AppUserTaskProfile()
        {
            CreateMap<AppUserTask, AppUserTaskCreateDto>().ReverseMap();
            CreateMap<AppUserTask, AppUserTaskListDto>().ReverseMap();
            CreateMap<AppUserTask, AppUserTaskUpdateDto>().ReverseMap();
            CreateMap<AppUserTaskListDto, AppUserTaskUpdateDto>().ReverseMap();
        }
    }
}
