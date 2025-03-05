using IBEXDATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DB;
using Common;


namespace Service
{
    public class ProjectService : IProjectService
    {
        IProjectDB _ProjectDB;

        public ProjectService(IProjectDB ProjectDB)
        {
            _ProjectDB = ProjectDB;
        }

        public async Task<Project> Add(Project project)
        {
            return await _ProjectDB.Add(project);
        }

        public async Task<Project> GetById(int id)
        {
            return await _ProjectDB.GetById(id);
        }

        public async Task<List<Project>> GetByContactorID(int id)
        {
            return await _ProjectDB.GetByContactorID(id);
        }
        

    }
}
