using AutoMapper;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.PriortryDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Mapper.AutoMapper
{
    public class AppTaskProfile : Profile
    {
        public AppTaskProfile()
        {
            CreateMap<AppTask, AppTaskListDto>().ReverseMap();
            CreateMap<AppTask, AppTaskUpdateDto>().ReverseMap();
            CreateMap<AppTask, AppTaskCreateDto>().ReverseMap();
            //AppTaskStatus
            CreateMap<AppTaskStatus, AppTaskStatusListDto>().ReverseMap();
            //Priortry
            CreateMap<Priortry, PriortryListDto>().ReverseMap();
        }
    }
}
