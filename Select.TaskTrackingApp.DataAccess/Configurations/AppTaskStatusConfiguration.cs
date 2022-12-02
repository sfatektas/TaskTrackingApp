﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.DataAccess.Configurations
{
    public class AppTaskStatusConfiguration : IEntityTypeConfiguration<AppTaskStatus>
    {
        public void Configure(EntityTypeBuilder<AppTaskStatus> builder)
        {
            builder.Property(x => x.Defination).IsRequired().HasMaxLength(50);
        }
    }
}
