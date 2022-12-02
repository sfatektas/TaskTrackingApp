using FluentValidation;
using Select.TaskTrackingApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.FluentValidation.AppTask
{
    class AppTaskCreateDtoValidator : AbstractValidator<AppTaskCreateDto>
    {
        public AppTaskCreateDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.Defination).NotEmpty();
            RuleFor(x => x.PriortryId).NotEmpty();
            RuleFor(x => x.EndDateTime).NotEmpty();
        }
    }
}
