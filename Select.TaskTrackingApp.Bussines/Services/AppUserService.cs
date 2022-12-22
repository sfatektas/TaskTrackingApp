using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Select.TaskTrackingApp.Bussines.Interfaces;
using Select.TaskTrackingApp.Common;
using Select.TaskTrackingApp.Common.Enums;
using Select.TaskTrackingApp.Common.Interfaces;
using Select.TaskTrackingApp.DataAccess.Context;
using Select.TaskTrackingApp.DataAccess.Interfaces;
using Select.TaskTrackingApp.DataAccess.Repositories;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.AppRoleDtos;
using Select.TaskTrackingApp.Dtos.PriortryDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Services
{
    public class AppUserService : Service<AppUserCreateDto,AppUserUpdateDto,AppUserListDto,AppUser> ,IAppUserService 
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public AppUserService(IUow uow ,IMapper mapper , IValidator<AppUserCreateDto> createvalidator) : base(uow,mapper, createvalidator)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<IResponse<AppUserListDto>> GetByFilterUser(Expression<Func<AppUser, bool>> filter)
        {
            var data = await _uow.GetRepository<AppUser>().GetByFilterAsync(filter);
            if (data != null)
            {
                var mappedData = _mapper.Map<AppUserListDto>(data);
                return new Response<AppUserListDto>(ResponseType.Success, mappedData);
            }
            return new Response<AppUserListDto>(ResponseType.NotFound, "Kullanıcı bulunamadı", new AppUserListDto());
        }

        public async Task<IResponse<List<AppUserListDto>>> GetIncluded()
        {
            var data = await _uow.GetRepository<AppUser>().GetQueryable().Include(x => x.AppUserRoles).ToListAsync();
            return new Response<List<AppUserListDto>>(ResponseType.Success,_mapper.Map<List<AppUserListDto>>(data));
        }

        public Task<IResponse<AppUserListDto>> GetIncluded(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userId)
        {
            //AppUserRoles tablosundaki userId ye eşit olan rolleri çekiyoruz.
            var roles = await _uow.GetRepository<AppRole>().GetAllAsync(x => x.AppUserRoles.Any(x => x.AppUserId == userId));
            if (roles == null)
                return new Response<List<AppRoleListDto>>(ResponseType.NotFound,"Kullanıcıya ait rol bulunamadı.",new List<AppRoleListDto>());
            var mappedData = _mapper.Map<List<AppRoleListDto>>(roles);
            return new Response<List<AppRoleListDto>>(ResponseType.Success, mappedData);
        }

    }
}
