using Select.TaskTrackingApp.Common.Interfaces;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.AppRoleDtos;
using Select.TaskTrackingApp.Dtos.DegreeDtos;
using Select.TaskTrackingApp.Dtos.PriortryDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Interfaces
{
    public interface IAppUserService : IService<AppUserCreateDto,AppUserUpdateDto,AppUserListDto,AppUser>, IIncludeable<AppUserListDto>
    {
        Task<IResponse<AppUserListDto>> GetByFilterUser(Expression<Func<AppUser, bool>> filter);
        Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userId);
        Task<IResponse<List<DegreeListDto>>> GetDegrees();
    }
}
