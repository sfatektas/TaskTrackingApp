﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Dtos.Interfaces
{
    public interface IUpdateDto : IDto
    {
        public int Id { get; set; }
    }
}
