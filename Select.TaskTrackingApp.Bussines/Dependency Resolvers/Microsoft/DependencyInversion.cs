using AutoMapper;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Select.TaskTrackingApp.Bussines.FluentValidation.AppTask;
using Select.TaskTrackingApp.Bussines.FluentValidation.AppUser;
using Select.TaskTrackingApp.Bussines.FluentValidation.AppUserRole;
using Select.TaskTrackingApp.Bussines.FluentValidation.AppUserTask;
using Select.TaskTrackingApp.Bussines.Interfaces;
using Select.TaskTrackingApp.Bussines.Mapper.AutoMapper;
using Select.TaskTrackingApp.Bussines.Mapper.AutoMapper.AppUserMapper;
using Select.TaskTrackingApp.Bussines.Services;
using Select.TaskTrackingApp.DataAccess.Context;
using Select.TaskTrackingApp.DataAccess.Interfaces;
using Select.TaskTrackingApp.DataAccess.UnitOfWork;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.AppUserRoleDtos;
using Select.TaskTrackingApp.Dtos.AppUserTaskDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Dependency_Resolvers.Microsoft
{
    public static class DependencyInversion
    {
        public static void DependencyExtension(this IServiceCollection services)
        {
            services.AddDbContext<TaskTrackingContext>(
       options => options.UseSqlServer("server=(localdb)\\mssqllocaldb; database=TaskTrackingDb; integrated security=true;"));

            services.AddScoped<IUow, Uow>();
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AppUserProfile());
                cfg.AddProfile(new AppTaskProfile());
                cfg.AddProfile(new AppUserRoleProfile());
                cfg.AddProfile(new AppRoleProfile());
                cfg.AddProfile(new AppUserTaskProfile());
            }
            );
            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

            services.AddScoped<IValidator<AppUserCreateDto>, AppUserCreateValidator>();
            services.AddScoped<IValidator<AppUserTaskCreateDto>, AppUserTaskCreateDtoValidator>();
            services.AddScoped<IValidator<AppUserTaskUpdateDto>, AppUserTaskUpdateDtoValidator>();
            services.AddScoped<IValidator<AppTaskCreateDto>, AppTaskCreateDtoValidator>();
            services.AddScoped<IValidator<AppUserRoleCreateDto>, AppUserRoleCreateDtoValidator>();

            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IAppTaskService, AppTaskService>();
            services.AddScoped<IAppUserRoleService, AppUserRoleService>();
            services.AddScoped<IAppUserTaskService, AppUserTaskService>();

        }
    }
}
