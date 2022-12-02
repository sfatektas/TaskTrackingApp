using AutoMapper;
using FluentValidation;
using Select.TaskTrackingApp.Bussines.Interfaces;
using Select.TaskTrackingApp.Common;
using Select.TaskTrackingApp.Common.Enums;
using Select.TaskTrackingApp.Common.Interfaces;
using Select.TaskTrackingApp.DataAccess.Interfaces;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.AppUserRoleDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Services
{
    public class AppUserRoleService : Service<AppUserRoleCreateDto, AppUserRoleUpdateDto, AppUserRoleListDto, AppUserRole>, IAppUserRoleService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public AppUserRoleService(IUow uow , IMapper mapper, IValidator<AppUserRoleCreateDto> createvalidator) : base(uow,mapper,createvalidator)
        {
            _uow = uow;
        }
        //public async Task<IResponse<List<AppUserRoleListDto>>> GetUserRoles(int userid)
        //{
        //    var data = await _uow.GetRepository<AppUserRole>().GetAllAsync(x => x.AppUserId == userid);
        //    if (data != null)
        //    {
        //        var mappedData = _mapper.Map<List<AppUserRoleListDto>>(data);
        //        return new Response<List<AppUserRoleListDto>>(ResponseType.Success, mappedData);
        //    }
        //    return new Response<List<AppUserRoleListDto>>(ResponseType.NotFound, "Kullanıcının Rolü bulunamdı", new List<AppUserRoleListDto>());
        //}
    }
}
