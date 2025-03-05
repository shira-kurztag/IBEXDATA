using IBEXDATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IProjectService
    {
        Task<Project> Add(Project project);
        Task<Project> GetById(int id);
        Task<List<Project>> GetByContactorID(int id);
       
    }
}
