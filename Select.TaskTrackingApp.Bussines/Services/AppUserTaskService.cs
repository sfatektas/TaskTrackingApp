using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Select.TaskTrackingApp.Bussines.Interfaces;
using Select.TaskTrackingApp.Common;
using Select.TaskTrackingApp.Common.Enums;
using Select.TaskTrackingApp.Common.Interfaces;
using Select.TaskTrackingApp.DataAccess.Interfaces;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.AppUserTaskDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Services
{
    public class AppUserTaskService: Service<AppUserTaskCreateDto,AppUserTaskUpdateDto , AppUserTaskListDto, AppUserTask> ,IAppUserTaskService
    {
        readonly IMapper _mapper;
        private readonly IUow _uow;
        private readonly IAppUserService _appUserService;
        private readonly IAppTaskService _appTaskService;
        readonly IValidator<AppUserTaskCreateDto> _validator;

        public AppUserTaskService(IUow uow, IAppUserService appUserService, IAppTaskService appTaskService, IMapper mapper,IValidator<AppUserTaskCreateDto> validator):base(uow,mapper,validator)
        {
            _uow = uow;
            _appUserService = appUserService;
            _appTaskService = appTaskService;
            _mapper = mapper;
            _validator = validator;
        }
        public async Task<IResponse> CreateAppUserTask(int taskId,string userName)
        {
            var userResponse = await _appUserService.GetByFilterUser(x => x.Username == userName);
            var taskResponse = await _appTaskService.GetByIdAsync(taskId);
            await _uow.GetRepository<AppUserTask>().CreateAsync(new AppUserTask
            {
                AppTaskId = taskId,
                AppUserId = userResponse.Data.Id,
                TaskEndDate =taskResponse.Data.EndDateTime,
                TaskStatusId = (int)TaskStatusType.GorevAlındı,
            });
            await _uow.SaveChangesAsync();
            return new Response(ResponseType.Success);
        }
        public async Task<IResponse<List<AppUserTaskListDto>>> GetTasksWithUserId(int id)
        {
            //var data = await _uow.GetRepository<AppUserTask>().GetAllAsync(x => x.AppUserId == id);
            var data = _uow.GetRepository<AppUserTask>().GetQueryable();
            await data.Include(x => x.AppUser).Include(x => x.AppTask).ThenInclude(x=>x.Priortry).Include(x => x.TaskStatus).OrderByDescending(x=>x.TaskStatusId).ToListAsync();
            if (data == null)
                return new Response<List<AppUserTaskListDto>>(ResponseType.NotFound,"Veri Bulunamadı.",new List<AppUserTaskListDto>());
            return new Response<List<AppUserTaskListDto>>(ResponseType.Success, _mapper.Map<List<AppUserTaskListDto>>(data));
        }
    }
}
