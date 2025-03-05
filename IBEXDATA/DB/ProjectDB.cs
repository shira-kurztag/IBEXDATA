using IBEXDATA.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace DB
{
    public class ProjectDB : IProjectDB
    {
        private readonly dbContext _context;
        private static readonly Serilog.ILogger _logger = Log.ForContext<ProjectDB>(); // Create a logger instance

        public ProjectDB(dbContext context)
        {
            _context = context;
        }

        public async Task<Project> Add(Project project)
        {
            try
            {
                await _context.Projects.AddAsync(project);
                await _context.SaveChangesAsync();

                if (project != null)
                {
                    _logger.Information("Successfully added a new project.");
                    return project;
                }
                else
                {
                    _logger.Warning("project was not added.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error in Add method of Add in ProjectDB.");
                return null;
            }
        }

        public async Task<Project> GetById(int id)
        {
            return await _context.Projects.FirstOrDefaultAsync(p => p.ProjectId == id);
        }


        public async Task<List<Project>> GetByContactorID(int id)
        {
            return await _context.Projects
                                 .Where(p => p.ContractingCompanyId == id)
                                 .ToListAsync();
        }
    }
}
