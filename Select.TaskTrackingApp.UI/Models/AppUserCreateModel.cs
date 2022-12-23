using Microsoft.AspNetCore.Mvc.Rendering;
using Select.TaskTrackingApp.Dtos;

namespace Select.TaskTrackingApp.UI.Models
{
    public class AppUserCreateModel : AppUserCreateDto
    {
        public SelectList DegreeSelectList { get; set; }
    }
}
