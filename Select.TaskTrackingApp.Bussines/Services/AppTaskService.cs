using AutoMapper;
using FluentValidation;
using Select.TaskTrackingApp.Bussines.Interfaces;
using Select.TaskTrackingApp.DataAccess.Interfaces;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Services
{
    public class AppTaskService : Service<AppTaskCreateDto,AppTaskUpdateDto,AppTaskListDto,AppTask> , IAppTaskService
    {
        public AppTaskService(IUow uow, IMapper mapper, IValidator<AppTaskCreateDto> validator) : base(uow, mapper, validator)
        {


        }

    }
}
