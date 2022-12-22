using Select.TaskTrackingApp.Common.Interfaces;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.PriortryDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Interfaces
{
    public interface IAppTaskService : IService<AppTaskCreateDto, AppTaskUpdateDto, AppTaskListDto, AppTask> , IIncludeable<AppTaskListDto>
    {
        Task<IResponse<List<PriortryListDto>>> GetPriortiries();
    }
}
