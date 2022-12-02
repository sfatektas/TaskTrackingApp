using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Interfaces
{
    public interface IAppTaskService : IService<AppTaskCreateDto, AppTaskUpdateDto, AppTaskListDto, AppTask>
    {
    }
}
