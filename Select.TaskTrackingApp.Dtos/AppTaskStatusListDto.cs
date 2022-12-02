using Select.TaskTrackingApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Dtos
{
    public class AppTaskStatusListDto : IListDto
    {
        public int Id { get ; set ; }

        public string Defination { get; set; }
    }
}
