using IBEXDATA.Models;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Common.DTO;

namespace DB
{
    public class ContractorRepository : IContractorRepository
    {


        private readonly dbContext _dbContext;
        private readonly IMapper mapper;

        private readonly ILogger<ContractorRepository> _logger;
        public ContractorRepository(dbContext dbContext, IMapper _Mapper, ILogger<ContractorRepository> logger)
        {
            _dbContext = dbContext;
            mapper = _Mapper;
            _logger = logger;
        }

        public async Task CreateContractor(ContractorDTO contractor)
        {
            var newContractor = mapper.Map<Contractor>(contractor);
            newContractor.InsertDate = DateOnly.FromDateTime(DateTime.Now); // קביעת תאריך יצירה
            newContractor.ContractorStatus = 1;
            await _dbContext.Contractors.AddAsync(newContractor);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Contractor>> GetAllContractors()
        {
            return await _dbContext.Contractors.ToListAsync();
        }





        public async Task UpdateContractor(ContractorDTO contractor)
        {
            _logger.LogInformation("Starting UpdateContractor");

            Contractor existingContractor;
            try
            {
                existingContractor = await _dbContext.Contractors.FindAsync(contractor.ContractorId);
                _logger.LogInformation("FindAsync completed");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while finding the contractor");
                throw;
            }

            if (existingContractor != null)
            {
                _logger.LogInformation("Contractor found");

                // מיפוי ידני של השדות מאובייקט ה-DTO לאובייקט הקיים
                existingContractor.ContractorIdentity = contractor.ContractorIdentity;
                existingContractor.ContractorName = contractor.ContractorName;
                existingContractor.ManagementName = contractor.ManagementName;
                existingContractor.ManagementId = contractor.ManagementId;
                existingContractor.Address = contractor.Address;
                existingContractor.CertificateConsortium = contractor.CertificateConsortium;
                existingContractor._50form = contractor._50form;

                existingContractor.UpdateDate = DateOnly.FromDateTime(DateTime.Now); // קביעת תאריך עדכון
                await _dbContext.SaveChangesAsync();
                _logger.LogInformation("Contractor updated successfully");
            }
            else
            {
                _logger.LogWarning($"Contractor with ID {contractor.ContractorId} not found.");
                throw new KeyNotFoundException($"Contractor with ID {contractor.ContractorId} not found.");
            }
        }

    }
}

