using Select.TaskTrackingApp.Common.Interfaces;
using Select.TaskTrackingApp.Dtos;
using Select.TaskTrackingApp.Dtos.Interfaces;
using Select.TaskTrackingApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Select.TaskTrackingApp.Bussines.Interfaces
{
    public interface IIncludeable<Dto> where Dto : class,IDto , new()
    {
        Task<IResponse<Dto>> GetIncluded(int id);

        Task<IResponse<List<Dto>>> GetIncluded();
    }
}
