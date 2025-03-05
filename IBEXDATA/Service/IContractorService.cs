using Common.DTO;

using IBEXDATA.Models;

namespace IBEXDATA.Services
{
    public interface IContractorService
    {


        Task CreateContractor(ContractorDTO contractor);
        Task<List<Contractor>> GetAllContractors();
        Task UpdateContractor(ContractorDTO contractor);
        Task<Contractor> GetAllContractorById(int Id);
    }
}
