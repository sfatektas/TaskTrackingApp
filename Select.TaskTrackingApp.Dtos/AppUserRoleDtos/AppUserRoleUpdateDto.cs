using Select.TaskTrackingApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Dtos.AppUserRoleDtos
{
    public class AppUserRoleUpdateDto : IUpdateDto
    {
        public int Id { get; set; }

        public int AppUserId { get; set; }

        public int AppRoleId { get; set; }
    }
}
