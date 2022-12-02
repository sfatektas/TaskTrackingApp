﻿using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.DataAccess.Interfaces
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;

        Task SaveChangesAsync();
    }
}
