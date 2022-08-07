using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Entities
{
    public class Task : BaseEntity
    {
        public string Title { get; set; }

        public string  Defination { get; set; }

        public int PriortryId { get; set; }

        public DateTime EndDateTime { get; set; }
    }
}
