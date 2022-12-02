using FluentValidation;
using Select.TaskTrackingApp.Dtos.AppUserTaskDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.FluentValidation.AppUserTask
{
    public class AppUserTaskCreateDtoValidator : AbstractValidator<AppUserTaskCreateDto>
    {
        public AppUserTaskCreateDtoValidator()
        {
            RuleFor(x => x.AppTaskId).NotNull();
            RuleFor(x => x.AppUserId).NotNull();
        }
    }
}
