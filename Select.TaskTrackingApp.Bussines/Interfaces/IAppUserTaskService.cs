using Select.TaskTrackingApp.Common.Interfaces;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.AppUserTaskDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Interfaces
{
    public interface IAppUserTaskService : IService<AppUserTaskCreateDto,AppUserTaskUpdateDto,AppUserTaskListDto,AppUserTask>, IIncludeable<AppUserTaskListDto>
    {
        Task<IResponse> CreateAppUserTask(int taskId, string userName);
        Task<IResponse<List<AppUserTaskListDto>>> GetTasksWithUserId(int id);
    }
}
