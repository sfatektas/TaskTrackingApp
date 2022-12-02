using Select.TaskTrackingApp.DataAccess.Context;
using Select.TaskTrackingApp.DataAccess.Interfaces;
using Select.TaskTrackingApp.DataAccess.Repositories;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.DataAccess.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly TaskTrackingContext _context;

        public Uow(TaskTrackingContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

    }
}
