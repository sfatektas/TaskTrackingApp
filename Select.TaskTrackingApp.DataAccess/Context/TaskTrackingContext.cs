using Microsoft.EntityFrameworkCore;
using Select.TaskTrackingApp.DataAccess.Configurations;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.DataAccess.Context
{
    public class TaskTrackingContext : DbContext
    {

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<AppRole> AppRoles { get; set; }

        public DbSet<AppUserRole> AppUserRoles { get; set; }

        public DbSet<Priortry> Priortries { get; set; }

        public DbSet<AppTask> AppTasks { get; set; }

        public DbSet<AppUserTask> AppUserTasks { get; set; }

        public DbSet<Degree> Degrees { get; set; }

        public DbSet<AppTaskStatus> TaskStatuses { get; set; }

        public TaskTrackingContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppTaskConfiguration());
            modelBuilder.ApplyConfiguration(new AppTaskStatusConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserTaskConfiguration());
            modelBuilder.ApplyConfiguration(new DegreeConfiguration());
            modelBuilder.ApplyConfiguration(new PriortryConfiguration());
        }
    }
}
