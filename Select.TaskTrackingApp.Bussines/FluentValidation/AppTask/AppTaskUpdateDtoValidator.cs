using FluentValidation;
using Select.TaskTrackingApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.FluentValidation.AppTask
{
    public class AppTaskUpdateDtoValidator : AbstractValidator<AppTaskCreateDto>
    {
        public AppTaskUpdateDtoValidator()
        {
            RuleFor(x => x.Defination).NotNull();
            RuleFor(x => x.Title).NotNull();
            RuleFor(x => x.PriortryId).NotNull();
            RuleFor(x => x.EndDateTime).NotNull();
        }
    }
}
