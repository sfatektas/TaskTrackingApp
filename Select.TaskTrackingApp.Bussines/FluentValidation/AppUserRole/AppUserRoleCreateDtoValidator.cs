﻿using FluentValidation;
using Select.TaskTrackingApp.Dtos.AppUserRoleDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.FluentValidation.AppUserRole
{
    public class AppUserRoleCreateDtoValidator : AbstractValidator<AppUserRoleCreateDto>
    {
        public AppUserRoleCreateDtoValidator()
        {
            RuleFor(x => x.AppRoleId).NotEmpty();
            RuleFor(x => x.AppUserId).NotEmpty();
        }
    }
}
