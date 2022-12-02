using Select.TaskTrackingApp.Common.Interfaces;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.AppUserRoleDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Interfaces
{
    public interface IAppUserRoleService : IService<AppUserRoleCreateDto, AppUserRoleUpdateDto, AppUserRoleListDto, AppUserRole>
    {
        //Task<IResponse<List<AppUserRoleListDto>>> GetUserRoles(int userid);
    }
}
