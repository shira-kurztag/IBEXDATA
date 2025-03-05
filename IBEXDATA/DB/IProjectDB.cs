using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using IBEXDATA.Models;

namespace DB
{
    public interface IProjectDB
    {
       Task<Project> Add(Project project);
        Task<Project> GetById(int id);
        Task<List<Project>> GetByContactorID(int id);
    }
}
