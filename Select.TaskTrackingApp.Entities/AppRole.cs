﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Entities
{
    public class AppRole : BaseEntity
    {
        public string Defination { get; set; }

        public List<AppUserRole> AppUserRoles { get; set; }
    }
}
