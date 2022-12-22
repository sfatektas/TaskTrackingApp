using AutoMapper;
using FluentValidation;
using Select.TaskTrackingApp.Bussines.Interfaces;
using Select.TaskTrackingApp.Common.Enums;
using Select.TaskTrackingApp.Common;
using Select.TaskTrackingApp.Common.Interfaces;
using Select.TaskTrackingApp.DataAccess.Interfaces;
using Select.TaskTrackingApp.DataAccess.UnitOfWork;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.PriortryDtos;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Select.TaskTrackingApp.Bussines.Services
{
    public class AppTaskService : Service<AppTaskCreateDto,AppTaskUpdateDto,AppTaskListDto,AppTask> , IAppTaskService 
    {
        readonly IUow _uow;
        readonly IMapper _mapper;
        public AppTaskService(IUow uow, IMapper mapper, IValidator<AppTaskCreateDto> validator) : base(uow, mapper, validator)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public Task<IResponse<AppTaskListDto>> GetIncluded(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IResponse<List<AppTaskListDto>>> GetIncluded()
        {
            return new Response<List<AppTaskListDto>>(ResponseType.Success,_mapper.Map<List<AppTaskListDto>>(_uow.GetRepository<AppTask>().GetQueryable().Include(x => x.Priortry).ToList()));
        }

        public async Task<IResponse<List<PriortryListDto>>> GetPriortiries()
        {
            var data = await _uow.GetRepository<Priortry>().GetAllAsync();
            return new Response<List<PriortryListDto>>(ResponseType.Success, _mapper.Map<List<PriortryListDto>>(data));
        }
    }
}
