﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Entities
{
    public class AppUserRole : BaseEntity
    {
        public int UserId { get; set; }

        public int RoleId { get; set; }
    }
}
